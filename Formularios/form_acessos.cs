using EGP_Tela_Inicial_04_02.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGP_Tela_Inicial_04_02.Formularios
{
    public partial class form_acessos : Form
    {
        class_form_acessos class_acessos;
        DataGridViewImageColumn coluna_imagem_usuarios;
        DataGridViewImageColumn coluna_imagem_acessos;

        bool mostrou_form_primeira_vez = false;
        string acessos = "";
        int linhas_alteradas = 0;

        public form_acessos()
        {
            InitializeComponent();
        }

        private void form_acessos_Load(object sender, EventArgs e)
        {
            AjustaFormulario();
            class_acessos = new class_form_acessos();

            dataGrid_acessos.ColumnCount = 4;

            dataGrid_acessos.Columns[0].Name = "id_acessos";
            dataGrid_acessos.Columns[1].Name = "fk_menu_itens_suspensos";
            dataGrid_acessos.Columns[2].Name = "fk_id_pessoa";

            dataGrid_acessos.Columns[0].Visible = false;
            dataGrid_acessos.Columns[1].Visible = false;
            dataGrid_acessos.Columns[2].Visible = false;

            dataGrid_acessos.Columns[3].Name = "ROTINA";
            dataGrid_acessos.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "ACESSO", Visible = true });
            dataGrid_acessos.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "ALTERAR", Visible = true });
            dataGrid_acessos.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "NOVO", Visible = true });
                     
            coluna_imagem_usuarios = new DataGridViewImageColumn();
            coluna_imagem_usuarios.Image = Image.FromFile("seta_colunas_grid_3.jpg");
            coluna_imagem_usuarios.Name = "coluna_seta_usuarios";
            coluna_imagem_usuarios.HeaderText = "";
            coluna_imagem_usuarios.ImageLayout = DataGridViewImageCellLayout.Stretch;

            coluna_imagem_acessos = new DataGridViewImageColumn();
            coluna_imagem_acessos.Image = Image.FromFile("seta_colunas_grid_3.jpg");
            coluna_imagem_acessos.Name = "coluna_seta_acessos";
            coluna_imagem_acessos.HeaderText = "";
            coluna_imagem_acessos.ImageLayout = DataGridViewImageCellLayout.Stretch;

            PreencheGrid();
            PreencheGrid_acessos();

            AjustaGrid(dataGrid_usuarios, coluna_imagem_usuarios);
            Ajusta_largura_colunas_usuarios();
            AjustaGrid(dataGrid_acessos, coluna_imagem_acessos);
            Ajusta_largura_colunas_acessos();
        }

        void AjustaGrid(DataGridView dataGridView, DataGridViewImageColumn newColumn)
        {
            try
            {
                // permite que altere a altura do cabeçalho
                dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

                // ESTA PROPRIEDADE PERMITE ALTERAR OS ESTILOS PARA O CABEÇALHO
                dataGridView.EnableHeadersVisualStyles = false;

                // pripriedades para o cabeçalho
                dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(48, 75, 109);
                dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(251, 250, 246);
                dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(169, 169, 169);
                // ajusta altura da linha do cabeçalho
                dataGridView.ColumnHeadersHeight = 43;

                dataGridView.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
                dataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(112, 140, 237);

                // mudar de cor quando seleciona a linha / texto
                dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 65);
                dataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 254);

                FontFamily fontFamily = new FontFamily("calibri");
                // Coloca a cor de fundo nas linhas
                dataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 254);
                dataGridView.RowsDefaultCellStyle.Font = new Font(fontFamily, 12, FontStyle.Regular);
                dataGridView.RowsDefaultCellStyle.ForeColor = Color.FromArgb(110, 102, 100);

                // configurações para todas as células

                // alinha o conteudo dentro da célula
                dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                // deixa que eu escolha a autura de cada linha, ao invés de ficar por padrão
                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                // indica que o usuário não vai poder editar linhas
                dataGridView.ReadOnly = false;


                //controles do grid completo
                dataGridView.BorderStyle = BorderStyle.Fixed3D;
                dataGridView.BackgroundColor = Color.FromArgb(255, 255, 254);
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                // estilo da borda do cabeçalho
                dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                dataGridView.ColumnHeadersVisible = true;

                // quando clicar, seleciona a linha inteira
                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // o usuário não poderá selecionar muitas linhas
                dataGridView.MultiSelect = false;

                // retira a primeira coluna 
                dataGridView.RowHeadersVisible = false;
                               
                // retira a ultima linha adicionada automaticamente, é utilizada para adicionar novas linhas
                dataGridView.AllowUserToAddRows = false;

                // não deixa o usuário deletar as linhas do grid
                dataGridView.AllowUserToDeleteRows = false;

              
                string coluna_nome = newColumn.Name;
                // insere a primeira coluna com a imagem
                if (!(dataGridView.Columns[newColumn.Name] is null))
                {
                    // se a primeira coluna existir, então deleta e coloca outra

                    dataGridView.Columns.Remove(newColumn.Name);

                    newColumn = new DataGridViewImageColumn();
                    newColumn.Image = Image.FromFile("seta_colunas_grid_3.jpg");
                    newColumn.Name = coluna_nome;
                    newColumn.HeaderText = "";
                    newColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                    dataGridView.Columns.Insert(0, newColumn);
                    dataGridView.Columns[0].Width = 40;
                    dataGridView.Columns[0].Resizable = DataGridViewTriState.False;
                }
                else
                {
                    dataGridView.Columns.Insert(0, newColumn);
                    dataGridView.Columns[0].Width = 40;
                    dataGridView.Columns[0].Resizable = DataGridViewTriState.False;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AjustaAlturaLinhasGrid(dataGridView);
        }

        void Ajusta_largura_colunas_usuarios()
        {
            // largura das colunas
            dataGrid_usuarios.Columns ["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_usuarios.Columns ["NOME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_usuarios.Columns ["LOGIN"].Width = 250;
            dataGrid_usuarios.Columns ["CPF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void Ajusta_largura_colunas_acessos()
        {
            int largura = (dataGrid_acessos.Width - dataGrid_acessos.Columns["coluna_seta_acessos"].Width) / 4;

            dataGrid_acessos.Columns["ROTINA"].Width = largura;
            dataGrid_acessos.Columns["ACESSO"].Width = largura;
            dataGrid_acessos.Columns["ALTERAR"].Width = largura;
            dataGrid_acessos.Columns["NOVO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void PreencheGrid_acessos()
        {
            //https://social.msdn.microsoft.com/Forums/pt-BR/ecfd6c9c-f4bb-458d-9a7c-0048809fe783/adicionar-registro-no-banco-pelo-datagridview-marcado-com-chekbox?forum=vscsharppt

            string[] acessos_usuario = class_acessos.RetornaPermissoesUsuario( Convert.ToInt32(dataGrid_usuarios.CurrentRow.Cells["ID"].Value.ToString())).Split('\n');
                    
            string[] itens;

            //id_usuario                0
            //id_menu_itens_suspensos   1
            //id_acessos                2
            //posicao_menu              3
            //nome_item                 4
            //acesso                    5
            //alterar                   6
            //novo                      7
            //nome_menu                 8
            bool acesso, alterar, novo, existe_a_coluna;

            int id_usuario;
            int id_menu_itens_suspensos;
            int id_acessos;


            existe_a_coluna = false;
            string nome_coluna_imagem = dataGrid_acessos.Columns[0].Name;
            if (nome_coluna_imagem == coluna_imagem_acessos.Name)
            {
                existe_a_coluna = true;
            }
          
            for (int i = 0; i < acessos_usuario.Length - 1; i++)
            {
                itens = acessos_usuario[i].Split('_');

                id_usuario =                Convert.ToInt32(itens[0]);
                id_menu_itens_suspensos =   Convert.ToInt32(itens[1]);
                id_acessos =                Convert.ToInt32(itens[2]);
                acesso =                    Convert.ToInt32(itens[5]) == 1 ? true : false;
                alterar =                   Convert.ToInt32(itens[6]) == 1 ? true : false;
                novo =                      Convert.ToInt32(itens[7]) == 1 ? true : false;

                // coluna 0 = "id_acessos";
                // coluna 1 = "fk_menu_itens_suspensos";
                // coluna 2 = "fk_id_pessoa";

                if (existe_a_coluna)
                    dataGrid_acessos.Rows.Add(Image.FromFile("seta_colunas_grid_3.jpg"), 
                                                                id_acessos, 
                                                                id_menu_itens_suspensos, 
                                                                id_usuario, 
                                                                itens[4], 
                                                                acesso, 
                                                                alterar, 
                                                                novo);
                else
                    dataGrid_acessos.Rows.Add(id_acessos, id_menu_itens_suspensos, id_usuario, itens[4], acesso, alterar, novo);
            }        
        }

        private void AjustaAlturaLinhasGrid(DataGridView dataGrid)
        {
            for (int i = 0; i < dataGrid.Rows.Count; i++)
                dataGrid.Rows[i].Height = 32;
        }

        void AjustaFormulario()
        {

            tabControl.Location = new Point(0, 0);
            tabControl.Height = 460;
            tabControl.Width = this.Width - 15;

            dataGrid_usuarios.Location = new Point(0, 0);
            dataGrid_usuarios.Width = tabPage_usuarios.Width;
            dataGrid_usuarios.Height = 367;

            ed_consulta.Location = new Point(0, dataGrid_usuarios.Top + dataGrid_usuarios.Height + 13);
            ed_consulta.Width = 436;
            ed_consulta.Height = 35;

            bt_acessos.Width = 120;
            bt_acessos.Height = ed_consulta.Height;
            bt_acessos.Location = new Point((dataGrid_usuarios.Left + dataGrid_usuarios.Width) - bt_acessos.Width, ed_consulta.Top);
        }

        void PreencheGrid()
        {
            dataGrid_usuarios.DataSource = class_acessos.RetornaUsuarios().Tables[0];
        }

        private void dataGrid_usuarios_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AjustaAlturaLinhasGrid(dataGrid_usuarios);
        }

        private void dataGrid_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            // regula para que o grid seja carregado apenas quando o usuário mudar a seleção do usuário
            if (mostrou_form_primeira_vez) 
            {
                if (dataGrid_usuarios.CurrentRow != null)
                {
                    dataGrid_acessos.Rows.Clear();
                    PreencheGrid_acessos();
                    AjustaAlturaLinhasGrid(dataGrid_acessos);
                }
            }            
        }

        private void form_acessos_Shown(object sender, EventArgs e)
        {
            mostrou_form_primeira_vez = true;
        }

        private void form_acessos_FormClosed(object sender, FormClosedEventArgs e)
        {
            mostrou_form_primeira_vez = false;
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGrid_acessos.Rows.Count; i++)
            {
                int id_acessos =                Convert.ToInt32(dataGrid_acessos["id_acessos", i].Value);
                int fk_menu_itens_suspensos =   Convert.ToInt32(dataGrid_acessos["fk_menu_itens_suspensos", i].Value);
                int fk_id_pessoa =              Convert.ToInt32(dataGrid_acessos["fk_id_pessoa", i].Value);
                int acesso =                    Convert.ToBoolean(dataGrid_acessos["Acesso", i].Value) ? 1 : 0;
                int alterar =                   Convert.ToBoolean(dataGrid_acessos["Alterar", i].Value) ? 1 : 0;
                int novo =                      Convert.ToBoolean(dataGrid_acessos["Novo", i].Value) ? 1 : 0;

                acessos += "id_acessos_"                + id_acessos + 
                           "_fk_menu_itens_suspensos_"  + fk_menu_itens_suspensos + 
                           "_id_usuario_"               + fk_id_pessoa + 
                           "_acesso_"                   + acesso + 
                           "_alterar_"                  + alterar + 
                           "_novo_"                     + novo + "\n";

                linhas_alteradas++;
            }
        }
    }
}
