using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EGP_PAINEL.Classes;
using System.IO;

namespace EGP_PAINEL.Formularios
{
    public partial class form_cadastro_funcoes : Form
    {
        class_cadastro_funcoes cadastro_funcoes;
        Label alteracao = new Label();

        DataGridViewImageColumn iconcolumn;


        bool alterar = false;
        bool novo = false;
        int index = 0;

        public form_cadastro_funcoes()
        {
            InitializeComponent();
            cadastro_funcoes = new class_cadastro_funcoes();
        }

        private void Cadastro_funcoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {

            //https://docs.microsoft.com/pt-br/dotnet/framework/data/adonet/connection-string-syntax

            // validar as informações


            ed_nome.Tag = "Nome";
            ed_descricao.Tag = "Descricao";

            if (VerificaTextBox())  // verifica os campos vazios
            {

                if (alterar) // verifica se clicou para alterar
                {
                    alterar = false;

                    if (cadastro_funcoes.Update(ed_nome.Text, ed_descricao.Text, "null", alterando_id))  // altera o cadastro e retorna true se deu certo
                    {
                        alterando_id = 0;
                        int pos_atual = dataGrid_funcao.CurrentRow.Index; // guarda a posição atual do grid

                        //MessageBox.Show(cadastro_funcoes.Mensagem_Retorno, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabControl_funcao.SelectedTab = tabPage_funcao;
                        dataGrid_funcao.DataSource = cadastro_funcoes.PreencheGrid("exec usp_funcao 'c'").Tables[0];


                        // retira a especificação de qual a função está sendo alterada
                        tabPage_nova.Controls.Remove(alteracao);
                        ed_nome.Location = new Point(6, 37);
                        lbl_nome_funcao.Location = new Point(3, 17);
                        alterar = false;
                        DesativaTextos();


                        AjustaGrid();

                        // seleciona a linha do grid que estava selecionada antes da alteração
                        dataGrid_funcao.CurrentCell = dataGrid_funcao[0, pos_atual];

                        ed_nome.Text = dataGrid_funcao.Rows[pos_atual].Cells[1].Value.ToString();
                        ed_descricao.Text = dataGrid_funcao.Rows[pos_atual].Cells[2].Value.ToString();
                    }
                    else
                    {
                        ed_nome.Focus();
                        MessageBox.Show(cadastro_funcoes.Mensagem_Retorno, "Algo deu errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else    // verifica se clicou para inserir um novo

                if (novo)
                {
                    novo = false;

                    if (cadastro_funcoes.Insert(ed_nome.Text, ed_descricao.Text)) // insere no banco, se der certo retorna true
                    {
                        try
                        {
                            DesativaTextos();

                           // MessageBox.Show(cadastro_funcoes.Mensagem_Retorno, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tabControl_funcao.SelectedTab = tabPage_funcao;
                            dataGrid_funcao.DataSource = cadastro_funcoes.PreencheGrid("exec usp_funcao 'c'").Tables[0];

                            AjustaGrid();

                            SelecionarLinhaNoGrid(cadastro_funcoes.ID); // seleciona a linha com base no conteudo da coluna id

                            ed_nome.Text = dataGrid_funcao.Rows[index].Cells[1].Value.ToString();
                            ed_descricao.Text = dataGrid_funcao.Rows[index].Cells[2].Value.ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } 
                    }
                    else
                    {
                        ed_nome.Focus();
                        MessageBox.Show(cadastro_funcoes.Mensagem_Retorno, "Algo deu errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                  
            }                         
        }

        private void SelecionarLinhaNoGrid(int linha)
        {
            for (int i = 0; i < dataGrid_funcao.Rows.Count ; i++)
            {
                if (Convert.ToInt32(dataGrid_funcao.Rows[i].Cells["CÓDIGO"].Value.ToString()) == linha)
                {
                    dataGrid_funcao.CurrentCell = dataGrid_funcao[dataGrid_funcao.Rows[i].Cells["CÓDIGO"].ColumnIndex, i]; // desta forma ele altera o CurrentRows propriedade                    
                    index = dataGrid_funcao.Rows[i].Index;
                    break;
                }
            }
        }
        
        private bool VerificaTextBox()
        {
            bool retorno = true;

            foreach (Control item in tabPage_nova.Controls)
            {
                if (item is TextBox)
                {
                    TextBox text = item as TextBox;

                    if (string.IsNullOrWhiteSpace(text.Text))
                    {
                        MessageBox.Show("É necessário preencher o campo \"" + text.Tag.ToString() + "\"", "Faltam informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        retorno = false;
                        text.Focus();
                        break;
                    }
                }   
            }
            return retorno;
        }


        private void bt_novo_Click(object sender, EventArgs e)
        {
            tabControl_funcao.SelectedTab = tabPage_nova;
            ed_nome.Clear();
            ed_descricao.Clear();            
            AtivaTextos();
            novo = true;

            ed_nome.Focus();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {            

            if (alterar)
            {
                tabPage_nova.Controls.Remove(alteracao);

                ed_nome.Location = new Point(6, 37);
                lbl_nome_funcao.Location = new Point(3, 17);
                alterar = false;
                tabControl_funcao.SelectedTab = tabPage_funcao;
                DesativaTextos();
            }
            else if (novo)
            {
                novo = false;
                DesativaTextos();
            }

            tabControl_funcao.SelectedTab = tabPage_funcao;

            if (!(dataGrid_funcao.CurrentRow is null))
            {
                ed_nome.Text = dataGrid_funcao.CurrentRow.Cells[1].Value.ToString();
                ed_descricao.Text = dataGrid_funcao.CurrentRow.Cells[2].Value.ToString();
            } // caso seja nulo, ele nega que é nulo então o fluxo de código sai fora
            
        }

        private void form_cadastro_funcoes_Load(object sender, EventArgs e)
        {
            dataGrid_funcao.DataSource = cadastro_funcoes.PreencheGrid("exec usp_funcao 'c'").Tables[0];
            dataGrid_funcao.RowHeadersVisible = false; // retira o cabeçalho das linhas

            iconcolumn = new DataGridViewImageColumn();
            iconcolumn.Image = Image.FromFile("seta_colunas_grid_3.jpg");
            iconcolumn.Name = "teste";
            iconcolumn.HeaderText = "";
            iconcolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            AjustaGrid();

            //ed_consulta.Focus();

            DesativaTextos();

            panel_lupa.Left = ed_consulta.Left + ed_consulta.Width;

            ed_consulta.Text = "Pesquise";
            ed_consulta.ForeColor = Color.FromArgb(161,162,162);
            ed_consulta.TextAlign = HorizontalAlignment.Center;            
        }

        private void DesativaTextos()
        {
            ed_nome.Enabled = false;
            ed_descricao.Enabled = false;

            bt_cancelar.Visible = false;
            bt_salvar.Visible = false;
        }

        private void AtivaTextos()
        {
            ed_nome.Enabled = true;
            ed_descricao.Enabled = true;

            bt_cancelar.Visible = true;
            bt_salvar.Visible = true;
        }       

        private void ed_consulta_KeyUp(object sender, KeyEventArgs e)
        {
            ed_consulta.Text = ed_consulta.Text.Replace("'", "");
            string cmd = "select upper( f.ID_FUNCAO ) [Código], " +
                                " upper( f.NOME ) [Nome], " +
				                " upper ( f.DESCRICAO ) [Descrição], " +
				                "f.SERIAL_CAMARA[Serial da Câmara] from funcao f " +
                                "where (CONVERT(VARCHAR(100), ID_FUNCAO, 103) + NOME + DESCRICAO) like '%" + ed_consulta.Text + "%'";
                        
            dataGrid_funcao.DataSource = cadastro_funcoes.PreencheGrid(cmd).Tables[0];
            dataGrid_funcao.RowHeadersVisible = false;
            AjustaGrid();
        }

        private void ed_consulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("'"))            
                e.Handled = true;
            
        }

        private void ed_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("'"))            
                e.Handled = true;
            
        }

        private void dataGrid_funcao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGrid_funcao_SelectionChanged(object sender, EventArgs e)
        {
            // implementar aqui
            // https://social.msdn.microsoft.com/Forums/pt-BR/2b228da1-c8de-4a2e-8639-54e17f5d9cc2/clicar-no-datagrid-e-pegar-a-linha-selecionada?forum=vscsharppt#:~:text=Dentro%20desse%20evento%2C%20voc%C3%AA%20pode,linhas%20ao%20mesmo%20tempo...

            // quando o usuário organiza o grid por ordem, ele fica null por um instante

            if (dataGrid_funcao.CurrentRow != null)
            {
                ed_nome.Text = dataGrid_funcao.CurrentRow.Cells[1].Value.ToString();
                ed_descricao.Text = dataGrid_funcao.CurrentRow.Cells[2].Value.ToString();
            }            
        }

        private void tabControl_funcao_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 0 && alterar)
                e.Cancel = true;
            else if (e.TabPageIndex == 0 && novo)
                e.Cancel = true;
        }

        private void form_cadastro_funcoes_Shown(object sender, EventArgs e)
        {
            //ed_consulta.Focus();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if (dataGrid_funcao.CurrentRow is null)
            {
                MessageBox.Show("Nenhuma função selecionada.","Ops",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(dataGrid_funcao.CurrentRow.Cells["CÓDIGO"].Value);

                DialogResult result = MessageBox.Show("Excluir permanentemente a função n° " + id, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (cadastro_funcoes.Delete(id))
                    {
                        dataGrid_funcao.DataSource = cadastro_funcoes.PreencheGrid("exec usp_funcao 'c'").Tables[0];
                        dataGrid_funcao.RowHeadersVisible = false;
                        AjustaGrid();
                        //MessageBox.Show(cadastro_funcoes.Mensagem_Retorno, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Não é possível excluir pois os seguintes nomes estão exercendo esta função: " + cadastro_funcoes.Mensagem_Retorno, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }          
        }
        int alterando_id = 0;

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            if (dataGrid_funcao.CurrentRow is null)
            {
                MessageBox.Show("Nenhuma função selecionada.","Ops!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ed_nome.Text = dataGrid_funcao.CurrentRow.Cells["NOME"].Value.ToString();
                ed_descricao.Text = dataGrid_funcao.CurrentRow.Cells["DESCRIÇÃO"].Value.ToString();

                this.alterando_id = Convert.ToInt32(dataGrid_funcao.CurrentRow.Cells["CÓDIGO"].Value.ToString());

                alteracao.Text = "Alterando função \"" + ed_nome.Text + "\" ID = " + alterando_id;
                alteracao.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
                alteracao.ForeColor = Color.Red;
                alteracao.Location = new Point(3, 10);
                alteracao.AutoSize = true;

                tabPage_nova.Controls.Add(alteracao);

                lbl_nome_funcao.Location = new Point(3, 35);
                ed_nome.Location = new Point(6, 55);

                AtivaTextos();

                tabControl_funcao.SelectedTab = tabPage_nova;
                alterar = true;
            }            
        }
                        
        
        private void AjustaCorLinhasGrid()
        {
            // int cor = 0;
            FontFamily fontFamily = new FontFamily("calibri");

            for (int i = 0; i < dataGrid_funcao.Rows.Count; i++)
            {
                dataGrid_funcao.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 254);
                dataGrid_funcao.Rows[i].Height = 32;
                dataGrid_funcao.Rows[i].DefaultCellStyle.Font = new Font(fontFamily, 12, FontStyle.Regular);
                dataGrid_funcao.Rows[i].DefaultCellStyle.ForeColor = Color.FromArgb(110, 102, 100);
            }

            //if (cor == 0)
            //{
            //    cor = 1;

            //}
            //else if (cor == 1)
            //{
            //    cor = 0;
            //    dataGrid_funcao.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 254);
            //    dataGrid_funcao.Rows[i].Height = 35;
            //}
        }

        private void dataGrid_funcao_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AjustaCorLinhasGrid();
        }

        private void ed_descricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("'"))
                e.Handled = true;
        }

        private void AjustaGrid()
        {
            // permite que altere a altura do cabeçalho
            dataGrid_funcao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            //dataGrid_funcao.ColumnHeadersHeight = 17; // altura do cabeçalho

            dataGrid_funcao.EnableHeadersVisualStyles = false;
            //              |
            //              +--- ESTA PROPRIEDADE PERMITE ALTERAR OS ESTILOS PARA O CABEÇALHO

            // pripriedades para o cabeçalho
            dataGrid_funcao.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;    
            dataGrid_funcao.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(48, 75, 109);
            dataGrid_funcao.ColumnHeadersDefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);         
            dataGrid_funcao.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(251, 250, 246);
            dataGrid_funcao.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(169, 169, 169);          
            //dataGrid_funcao.AutoResizeColumnHeadersHeight(); // ajusta a altura do cabeçalho automaticamente
            dataGrid_funcao.ColumnHeadersHeight = 43; // ajusta altura da linha do cabeçalho

            dataGrid_funcao.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGrid_funcao.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(112, 140, 237);

            // mudar de cor quando seleciona a linha / texto
            dataGrid_funcao.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 65);
            dataGrid_funcao.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 254);


            // configurações para todas as células
            dataGrid_funcao.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            //modos de redicionamente para as colunas
            //dataGrid_funcao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGrid_funcao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                       

            AjustaCorLinhasGrid();
            
            dataGrid_funcao.ReadOnly = true; // indica que o usuário não vai poder editar linhas

            //controles do grid completo

            dataGrid_funcao.BorderStyle = BorderStyle.Fixed3D;
            dataGrid_funcao.BackgroundColor = Color.FromArgb(255, 255, 254);
            dataGrid_funcao.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGrid_funcao.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; // estilo da borda do cabeçalho
            dataGrid_funcao.ColumnHeadersVisible = true;
            dataGrid_funcao.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // quando clicar, seleciona a linha inteira
            dataGrid_funcao.MultiSelect = false; // o usuário não poderá selecionar muitas linhas
            dataGrid_funcao.RowHeadersVisible = false; // retira a primeira coluna 
                                                       //dataGrid_funcao.RowHeadersWidth = 15;

            //Icon icon = new Icon(this.GetType(), "seta_colunas_grid.ico");


            dataGrid_funcao.Columns["Serial da Câmara"].Visible = false;

            if (!(dataGrid_funcao.Columns[iconcolumn.Name] is null))
            {
                dataGrid_funcao.Columns.Remove(iconcolumn);

                iconcolumn = new DataGridViewImageColumn();
                iconcolumn.Image = Image.FromFile("seta_colunas_grid_3.jpg");
                iconcolumn.Name = "teste";
                iconcolumn.HeaderText = "";
                iconcolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGrid_funcao.Columns.Insert(0, iconcolumn);
                dataGrid_funcao.Columns[0].Width = 40;
                dataGrid_funcao.Columns[0].Resizable = DataGridViewTriState.False;
            }
            else
            {
                dataGrid_funcao.Columns.Insert(0, iconcolumn);
                dataGrid_funcao.Columns[0].Width = 40;
                dataGrid_funcao.Columns[0].Resizable = DataGridViewTriState.False;
            }

            dataGrid_funcao.Columns["CÓDIGO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_funcao.Columns["NOME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_funcao.Columns["DESCRIÇÃO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            //dataGrid_funcao.rowheaders
        }
        private void ed_consulta_Enter(object sender, EventArgs e)
        {
            if (ed_consulta.Text == "Pesquise")
            {
                ed_consulta.Clear();
                ed_consulta.TextAlign = HorizontalAlignment.Left;
                ed_consulta.ForeColor = Color.Black;
                ed_consulta.CharacterCasing = CharacterCasing.Upper;                
            }
        }

        private void ed_consulta_Validating(object sender, CancelEventArgs e)
        {         
            if (string.IsNullOrWhiteSpace(ed_consulta.Text))
            {                
                ed_consulta.CharacterCasing = CharacterCasing.Normal;
                ed_consulta.TextAlign = HorizontalAlignment.Center;
                ed_consulta.Text = "Pesquise";
                ed_consulta.ForeColor = Color.FromArgb(161, 162, 162);
            }
        }

        private void ed_consulta_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}

