using EGP_PAINEL.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGP_PAINEL.Formularios
{
    public partial class form_cadastro_camara : Form
    {
        int index = 0;
        class_cadastro_camara cadastro_Camara;
        bool primeira_inicializacao = false;
        string caminho_imagem = "";

        bool sendo_alterado = false;
       // bool alterou_imagem = false;
        bool criando_um_novo = false;

        public form_cadastro_camara()
        {
            InitializeComponent();
        }       

        private void form_cadastro_camara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)            
                this.Close();
            
        }        

        private void form_cadastro_camara_Load(object sender, EventArgs e)
        {
            cadastro_Camara = new class_cadastro_camara();

            if (cadastro_Camara.PreencheGrid("exec usp_camara 'c'") != null)
            {
                dataGrid_camaras.DataSource = cadastro_Camara.PreencheGrid("exec usp_camara 'c'").Tables[0];
                AjustaGrid();
                OrganizaColunasGrid();
                ConfiguraPictureBox();
            }

            DesativaTextos();
            AjustaGrid();
            AjustaCorLinhasGrid();
            ed_consulta.Focus();
        }
          
        private void AjustaCorLinhasGrid()
        {
            int cor = 0;

            for (int i = 0; i < dataGrid_camaras.Rows.Count; i++)
            {
                if (cor == 0)
                {
                    cor = 1;
                    dataGrid_camaras.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                }
                else if (cor == 1)
                {
                    cor = 0;
                    dataGrid_camaras.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(187, 238, 255);
                }
            }
        }

        private void ed_consulta_KeyUp(object sender, KeyEventArgs e)
        {
          
            string cmd = "select c.SERIAL_CAMARA [Serial]," +
                                "c.NOME[Nome], " +
                                "c.CNPJ[CNPJ], " +
                                "c.EMAIL[Email], " +
                                "c.TELEFONE[Telefone], " +
                                "c.CELULAR[Celular], " +
                                "c.IMAGEM[Imagem], " +
                                "c.FK_ENDERECO," +
                                "e.BAIRRO [Bairro], " +
                                "e.CEP [Cep], " +
                                "e.CIDADE [Cidades], " +
                                "e.NUMERO [Número], " +
                                "e.RUA [Rua] " +
                                "from CAMARA c, ENDERECO e " +
                                "where c.FK_ENDERECO = e.ID_ENDERECO " +
                                "and (e.RUA + e.CIDADE + e.CEP + " +
                                                         "e.BAIRRO + " +
                                                         "c.NOME + " +
                                                         "c.CNPJ + " +
                                                         "c.EMAIL + " +
                                                         "c.TELEFONE + " +
                                                         "c.CELULAR) like '%" + ed_consulta.Text.Replace(" ", "%") + "%'";

            dataGrid_camaras.DataSource = cadastro_Camara.PreencheGrid(cmd).Tables[0];
            dataGrid_camaras.RowHeadersVisible = false;
            //AjustaGrid();

            AjustaCorLinhasGrid();
            OrganizaColunasGrid();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            // http://www.andrealveslima.com.br/blog/index.php/2015/02/05/salvando-imagens-no-banco-de-dados-utilizando-c/

            // retira as marcaras
            string cnpj = Regex.Replace(msk_cnpj.Text, "[^0-9]","");
            string numero = Regex.Replace(msk_numero.Text,"[^0-9]", "");
            string cep = Regex.Replace(msk_cep.Text, "[^0-9]", "");
            string telefone = Regex.Replace(msk_telefone.Text, "[^0-9]", "");

            ed_nome.Tag = "Nome";
            msk_cep.Tag = "CEP";
            msk_cnpj.Tag = "CNPJ";
            msk_numero.Tag = "Número";
            msk_telefone.Tag = "Telefone";
            ed_rua.Tag = "Rua";
            ed_email.Tag = "Email";
            ed_cidade.Tag = "Cidade";
            ed_bairro.Tag = "Bairro";


            if (sendo_alterado)
            {
                if (VerificaCampos())
                {
                    if (cnpj.Length < 14)
                    {
                        MessageBox.Show("O CNPJ precisa ter 14 digitos.", "Antenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        msk_cnpj.Focus();
                    }
                    else if (cep.Length < 8)
                    {
                        MessageBox.Show("O CEP precisa ter 8 digitos.", "Antenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        msk_cep.Focus();
                    }
                    else
                    {
                        if (cadastro_Camara.Update(dataGrid_camaras.CurrentRow.Cells["Serial"].Value.ToString(),
                                              ed_nome.Text,
                                              cnpj,
                                              ed_email.Text,
                                              telefone,
                                              "",
                                              ConverteFotoParaByteArray(),
                                              cep,
                                              ed_rua.Text,
                                              numero,
                                              ed_bairro.Text,
                                              ed_cidade.Text)) // insere no banco, se der certo retorna true
                        {
                            sendo_alterado = false;

                            MessageBox.Show(cadastro_Camara.Mensagem_Retorno, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            tab_Camara.SelectedTab = tabPage_camaras;

                            int linha_anterior = dataGrid_camaras.CurrentRow.Index;
                            dataGrid_camaras.DataSource = cadastro_Camara.PreencheGrid("exec usp_camara 'c'").Tables[0];

                            OrganizaColunasGrid();
                            AjustaCorLinhasGrid();

                            // seleciona a linha que estava sendo editada
                            dataGrid_camaras.CurrentCell = dataGrid_camaras[2, linha_anterior];

                            DesativaTextos();
                            PreencheCampos(dataGrid_camaras.CurrentRow.Index);
                        }
                        else
                        {
                            ed_nome.Focus();
                            MessageBox.Show(cadastro_Camara.Mensagem_Retorno, "Algo deu errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (criando_um_novo)               
            {
                if (VerificaCampos())
                {
                    if (cnpj.Length < 14)
                    {
                        MessageBox.Show("O CNPJ precisa ter 14 digitos.", "Antenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        msk_cnpj.Focus();
                    }
                    else if (cep.Length < 8)
                    {
                        MessageBox.Show("O CEP precisa ter 8 digitos.", "Antenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        msk_cep.Focus();
                    }
                    else
                    {
                        if (cadastro_Camara.Insert(ed_nome.Text,
                                              cnpj,
                                              ed_email.Text,
                                              telefone,
                                              "",
                                              ConverteFotoParaByteArray(),
                                              cep,
                                              ed_rua.Text,
                                              numero,
                                              ed_bairro.Text,
                                              ed_cidade.Text)) // insere no banco, se der certo retorna true
                        {
                            criando_um_novo = false;
                            MessageBox.Show(cadastro_Camara.Mensagem_Retorno, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            tab_Camara.SelectedTab = tabPage_camaras;

                            dataGrid_camaras.DataSource = cadastro_Camara.PreencheGrid("exec usp_camara 'c'").Tables[0];


                            OrganizaColunasGrid();
                            AjustaCorLinhasGrid();
                            SelecionarLinhaNoGrid(cadastro_Camara.Serial_camara);
                            DesativaTextos();
                            PreencheCampos(index); // index é atribuido no metodo SelecionarLinhaNoGrid(conteudoDaLinha)
                        }
                        else
                        {
                            ed_nome.Focus();
                            MessageBox.Show(cadastro_Camara.Mensagem_Retorno, "Algo deu errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }


                          
        }

        private bool VerificaCampos()
        {
            TextBox text;
            MaskedTextBox masked;
            bool retorno = true; // se retornar true é porque não tem campos vazios  

            // é como se dicesse assim: estou procurando todos os que estão vazios com o tabindex = 0, depois = 1, depois = 2
            // para que as mensagens de alerta apareçam na ordem

            for (int i = 0; i < tabPage_edicao.Controls.Count; i++)
            {
                foreach (Control item in tabPage_edicao.Controls)
                {
                    if (item is TextBox)
                    {
                        text = item as TextBox;

                        if (item.TabIndex == i)
                        {
                            if (string.IsNullOrEmpty(text.Text))
                            {
                                MessageBox.Show("O campo " + text.Tag + " não pode ficar vazio." +
                                               "", "Campo " + text.Tag + " vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                retorno = false;
                                text.Focus();
                                break;
                            }
                        }
                    }
                    else if (item is MaskedTextBox)
                    {
                        masked = item as MaskedTextBox;

                        string texto = Regex.Replace(masked.Text, "[^0-9]", "");

                        if (item.TabIndex == i)
                        {
                            if (string.IsNullOrEmpty(texto))
                            {
                                MessageBox.Show("O campo " + masked.Tag + " não pode ficar vazio." +
                                               "", "Campo " + masked.Tag + " vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                retorno = false;
                                masked.Focus();
                                break;
                            }
                        }                        
                    }                              
                }
                if (!retorno)                
                    break;
                
            }
            // se retorno ainda for verdadeiro significa que os campos estão preenchidos até agora
            if (retorno)
            {
                for (int i = 2; i < groupBox_endereco.Controls.Count; i++)
                {
                    foreach (Control item in groupBox_endereco.Controls)
                    {
                        if (item is TextBox)
                        {
                            text = item as TextBox;

                            if (item.TabIndex == i)
                            {
                                if (string.IsNullOrEmpty(text.Text))
                                {
                                    MessageBox.Show("O campo " + text.Tag + " não pode ficar vazio." +
                                                   "", "Campo " + text.Tag + " vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    retorno = false;
                                    text.Focus();
                                    break;
                                }
                            }
                        }
                        else if (item is MaskedTextBox)
                        {
                            masked = item as MaskedTextBox;

                            string texto = Regex.Replace(masked.Text, "[^0-9]", "");

                            if (item.TabIndex == i)
                            {
                                if (string.IsNullOrEmpty(texto))
                                {
                                    MessageBox.Show("O campo " + masked.Tag + " não pode ficar vazio." +
                                                   "", "Campo " + masked.Tag + " vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    retorno = false;
                                    masked.Focus();
                                    break;
                                }
                            }
                        }
                    }
                    if (!retorno)                    
                        break;
                    
                }
            }
            return retorno;
        }

        private void SelecionarLinhaNoGrid(string linha)
        {
            // recebe o valor da celula no datagrid para posicionar a seleção nesta célula

            for (int i = 0; i < dataGrid_camaras.Rows.Count; i++)
            {
                if (dataGrid_camaras.Rows[i].Cells[0].Value.ToString() == linha)
                {
                    dataGrid_camaras.CurrentCell = dataGrid_camaras[2, i]; // desta forma ele altera o CurrentRows propriedade                    
                    index = dataGrid_camaras.Rows[i].Index;
                    break;
                }
            }
        }

        private void dataGrid_camaras_SelectionChanged(object sender, EventArgs e)
        {
            // quando o usuário organiza o grid por ordem, ele fica null por um instante

            if (dataGrid_camaras.CurrentRow != null)
            {
                // só irá preencher os campos depois que o form for totalmente inicializado
                if (primeira_inicializacao == true) 
                {
                    PreencheCampos(dataGrid_camaras.CurrentRow.Index);                                                                                      
                }
            }
        }        

        private void PreencheCampos(int linha)
        {
            ed_nome.Text = dataGrid_camaras.Rows[linha].Cells["Nome"].Value.ToString();
            msk_cnpj.Text = dataGrid_camaras.Rows[linha].Cells["CNPJ"].Value.ToString();
            msk_cep.Text = dataGrid_camaras.Rows[linha].Cells["Cep"].Value.ToString();
            msk_numero.Text = dataGrid_camaras.Rows[linha].Cells["Número"].Value.ToString();
            msk_telefone.Text = dataGrid_camaras.Rows[linha].Cells["Telefone"].Value.ToString();
            ed_bairro.Text = dataGrid_camaras.Rows[linha].Cells["Bairro"].Value.ToString();
            ed_cidade.Text = dataGrid_camaras.Rows[linha].Cells["Cidades"].Value.ToString();
            ed_email.Text = dataGrid_camaras.Rows[linha].Cells["Email"].Value.ToString();
            ed_rua.Text = dataGrid_camaras.Rows[linha].Cells["Rua"].Value.ToString();

            if (string.IsNullOrEmpty(dataGrid_camaras.Rows[linha].Cells["Imagem"].Value.ToString()))
            {
                pcb_imagem.Image = null;
            }
            else
            {
                try
                {
                    byte[] imagem = new byte[0];
                    imagem = (byte[])dataGrid_camaras.Rows[linha].Cells["Imagem"].Value;

                    MemoryStream memory = new MemoryStream(imagem);
                    pcb_imagem.Image = Image.FromStream(memory);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao carregar imagem. " + e.Message,"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }   
        }

        private void form_cadastro_camara_Shown_1(object sender, EventArgs e)
        {
            primeira_inicializacao = true;
            ed_consulta.Focus();
        }

        private void form_cadastro_camara_FormClosed(object sender, FormClosedEventArgs e)
        {
            primeira_inicializacao = false;
        }

        private void ed_consulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("'"))
                e.Handled = true;
        }

        private void bt_nova_Click(object sender, EventArgs e)
        {
            criando_um_novo = true;
            tab_Camara.SelectedTab = tabPage_edicao;
            AtivaTextos();
            LimpaCampos();
            ed_nome.Focus();
        }

        private void ConfiguraPictureBox()
        {
            pcb_imagem.SizeMode = PictureBoxSizeMode.Zoom;
        }
               

        private void AjustaGrid()
        {
            // permite que altere a altura do cabeçalho
            dataGrid_camaras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // ESTA PROPRIEDADE PERMITE ALTERAR OS ESTILOS PARA O CABEÇALHO
            dataGrid_camaras.EnableHeadersVisualStyles = false;
          
            // pripriedades para o cabeçalho
            dataGrid_camaras.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_camaras.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(169, 169, 169);
            dataGrid_camaras.ColumnHeadersDefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            dataGrid_camaras.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(227, 241, 241);
            dataGrid_camaras.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(169, 169, 169);

            // ajusta a altura do cabeçalho automaticamente
            dataGrid_camaras.AutoResizeColumnHeadersHeight(); 

            dataGrid_camaras.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGrid_camaras.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(112, 140, 237);

            // configurações para todas as células

            // cor da letra quando selecionada
            dataGrid_camaras.DefaultCellStyle.SelectionForeColor = Color.Black;

            // cor de fundo da celula quando selecionada
            dataGrid_camaras.DefaultCellStyle.SelectionBackColor = Color.FromArgb(112, 140, 237);
            dataGrid_camaras.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;         

            dataGrid_camaras.DefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);

            // indica que o usuário não vai poder editar linhas
            dataGrid_camaras.ReadOnly = true; 

            //controles do grid completo
            dataGrid_camaras.BorderStyle = BorderStyle.Fixed3D;
            dataGrid_camaras.BackgroundColor = Color.FromArgb(240, 240, 240);
            dataGrid_camaras.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // estilo da borda do cabeçalho
            dataGrid_camaras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; 
            dataGrid_camaras.ColumnHeadersVisible = true;

            // quando clicar, seleciona a linha inteira
            dataGrid_camaras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // o usuário não poderá selecionar muitas linhas
            dataGrid_camaras.MultiSelect = false;

            // retira a primeira coluna 
            dataGrid_camaras.RowHeadersVisible = false;             
        }

        private void OrganizaColunasGrid()
        {
            dataGrid_camaras.Columns["Serial"].Visible = false;
            dataGrid_camaras.Columns["FK_ENDERECO"].Visible = false;
            dataGrid_camaras.Columns["Imagem"].Visible = false;
            dataGrid_camaras.Columns["Bairro"].Visible = false;
            dataGrid_camaras.Columns["Cep"].Visible = false;
            dataGrid_camaras.Columns["Cidades"].Visible = false;
            dataGrid_camaras.Columns["Número"].Visible = false;
            dataGrid_camaras.Columns["Rua"].Visible = false;

            dataGrid_camaras.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_camaras.Columns["CNPJ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_camaras.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_camaras.Columns["Telefone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_camaras.Columns["Celular"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void LimpaCampos()
        {
            ed_bairro.Clear();
            ed_cidade.Clear();
            ed_email.Clear();
            ed_nome.Clear();
            ed_rua.Clear();
            msk_cep.Clear();
            msk_cnpj.Clear();
            msk_numero.Clear();
            msk_telefone.Clear();

            pcb_imagem.Image = null;
        }

        private void DesativaTextos()
        {
            ed_bairro.Enabled = false;
            ed_cidade.Enabled = false;
            ed_email.Enabled = false;
            ed_nome.Enabled = false;
            ed_rua.Enabled = false;
            msk_cep.Enabled = false;
            msk_cnpj.Enabled = false;
            msk_numero.Enabled = false;
            msk_telefone.Enabled = false;

            bt_salvar.Visible = false;
            bt_excluir_foto.Visible = false;
            bt_cancelar.Visible = false;
        }

        private void AtivaTextos()
        {
            ed_bairro.Enabled = true;
            ed_cidade.Enabled = true;
            ed_email.Enabled = true;
            ed_nome.Enabled = true;
            ed_rua.Enabled = true;
            msk_cep.Enabled = true;
            msk_cnpj.Enabled = true;
            msk_numero.Enabled = true;
            msk_telefone.Enabled = true;

            bt_salvar.Visible = true;
            bt_excluir_foto.Visible = true;
            bt_cancelar.Visible = true;
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            DesativaTextos();
            if (dataGrid_camaras.CurrentRow is null)
            {
                if (dataGrid_camaras.Rows.Count > 0)
                {
                    dataGrid_camaras.CurrentCell = dataGrid_camaras[2, 0];
                    PreencheCampos(dataGrid_camaras.CurrentRow.Index);
                }
            }
            else
            {
                PreencheCampos(dataGrid_camaras.CurrentRow.Index);
            }
            
            //alterou_imagem = false;
            sendo_alterado = false;
            criando_um_novo = false;
            tab_Camara.SelectedTab = tabPage_camaras;
        }

        private byte[] ConverteFotoParaByteArray()
        {
            // fonte
            // https://docs.microsoft.com/pt-br/troubleshoot/dotnet/csharp/copy-image-database-picturebox


            if (pcb_imagem.Image is null)            
                return null;            
            else
            {
                try
                {
                    if (string.IsNullOrEmpty(caminho_imagem)) // verifica o caminho da imagem
                    {
                        return (byte[])dataGrid_camaras.CurrentRow.Cells["Imagem"].Value; // retorna a mesma que está no banco
                    }
                    else
                    {
                        using (FileStream arquivo = new FileStream(caminho_imagem, FileMode.Open, FileAccess.Read))
                        {
                            byte[] matriz = new byte[arquivo.Length];

                            arquivo.Read(matriz, 0, matriz.Length);

                            caminho_imagem = "";
                            return matriz;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Problemas ao salvar imagem. " + e.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }                
            }                     
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            if (dataGrid_camaras.CurrentRow is null)
            {
                MessageBox.Show("selecione um cadastro a ser alterado.","Ops!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sendo_alterado = true;
                tab_Camara.SelectedTab = tabPage_edicao;
                AtivaTextos();
                ed_nome.Focus();
            }          

        }

        private void pcb_imagem_DoubleClick(object sender, EventArgs e)
        {
            if (sendo_alterado || criando_um_novo)
            {
                using (OpenFileDialog open = new OpenFileDialog())
                {
                    pcb_imagem.SizeMode = PictureBoxSizeMode.Zoom;

                    open.InitialDirectory = "C:\\";

                    //estudar
                    open.Filter = "Tipos |*.png;*.jpg;*.bmp;*.jpeg";

                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        caminho_imagem = open.FileName;
                        pcb_imagem.ImageLocation = open.FileName;
                        //alterou_imagem = true;
                    }
                }
            }
            
        }

        private void bt_excluir_foto_Click(object sender, EventArgs e)
        {
            if (!(pcb_imagem.Image is null))
            {
                //alterou_imagem = true;
                pcb_imagem.Image = null;
            }
        }

        private void ed_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("'"))
            {
                e.Handled = true;
            }
        }

        private void tab_Camara_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage_camaras && sendo_alterado)
                e.Cancel = true;
            else if (e.TabPage == tabPage_camaras && criando_um_novo)
                e.Cancel = true;                        
        }

        //private void MostraImagem(int linha)
        //{
        //    //byte[] byImagem = (byte[])dataGrid_camaras.Rows[linha].Cells["Imagem"].Value;


        //    //MemoryStream memory = new MemoryStream(byImagem);

        //    //pcb_imagem.Image = Image.FromStream(memory);

        //    //memory.Dispose();

        //    //Image img = Image.FromStream(new MemoryStream(byImagem));



        //    //img.Save(response)

        //    //using (var strean = new MemoryStream((byte[])dataGrid_camaras.Rows[linha].Cells["Imagem"].Value))
        //    //{

        //        //pcb_imagem.Image = Bitmap.FromStream(strean);
        //        //pcb_imagem.Image = System.Drawing.Image.FromStream(strean);
        //        //pcb_imagem.Image. FromStream(strean);
        //    //}
        //}

    }
}
