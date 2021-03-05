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
        DataGridViewImageColumn coluna_imagem;

        public form_acessos()
        {
            InitializeComponent();
        }

        private void form_acessos_Load(object sender, EventArgs e)
        {
            AjustaFormulario();
            class_acessos = new class_form_acessos();
            PreencheGrid();

            coluna_imagem = new DataGridViewImageColumn();
            coluna_imagem.Image = Image.FromFile("seta_colunas_grid_3.jpg");
            coluna_imagem.Name = "teste";
            coluna_imagem.HeaderText = "";
            coluna_imagem.ImageLayout = DataGridViewImageCellLayout.Stretch;

            AjustaGrid();
        }

        void AjustaGrid()
        {
            try
            {
                // permite que altere a altura do cabeçalho
                dataGrid_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

                // ESTA PROPRIEDADE PERMITE ALTERAR OS ESTILOS PARA O CABEÇALHO
                dataGrid_usuarios.EnableHeadersVisualStyles = false;

                // pripriedades para o cabeçalho
                dataGrid_usuarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid_usuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(48, 75, 109);
                dataGrid_usuarios.ColumnHeadersDefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                dataGrid_usuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(251, 250, 246);
                dataGrid_usuarios.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(169, 169, 169);
                // ajusta altura da linha do cabeçalho
                dataGrid_usuarios.ColumnHeadersHeight = 43;

                dataGrid_usuarios.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
                dataGrid_usuarios.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(112, 140, 237);

                // mudar de cor quando seleciona a linha / texto
                dataGrid_usuarios.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 65);
                dataGrid_usuarios.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 254);

                FontFamily fontFamily = new FontFamily("calibri");
                // Coloca a cor de fundo nas linhas
                dataGrid_usuarios.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 254);
                dataGrid_usuarios.RowsDefaultCellStyle.Font = new Font(fontFamily, 12, FontStyle.Regular);
                dataGrid_usuarios.RowsDefaultCellStyle.ForeColor = Color.FromArgb(110, 102, 100);

                // configurações para todas as células

                // alinha o conteudo dentro da célula
                dataGrid_usuarios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                // deixa que eu escolha a autura de cada linha, ao invés de ficar por padrão
                dataGrid_usuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                // indica que o usuário não vai poder editar linhas
                dataGrid_usuarios.ReadOnly = false;


                //controles do grid completo
                dataGrid_usuarios.BorderStyle = BorderStyle.Fixed3D;
                dataGrid_usuarios.BackgroundColor = Color.FromArgb(255, 255, 254);
                dataGrid_usuarios.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                // estilo da borda do cabeçalho
                dataGrid_usuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; 
                dataGrid_usuarios.ColumnHeadersVisible = true;

                // quando clicar, seleciona a linha inteira
                dataGrid_usuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // o usuário não poderá selecionar muitas linhas
                dataGrid_usuarios.MultiSelect = false;

                // retira a primeira coluna 
                dataGrid_usuarios.RowHeadersVisible = false;

                // largura das colunas

                dataGrid_usuarios.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGrid_usuarios.Columns["NOME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGrid_usuarios.Columns["LOGIN"].Width = 250;
                dataGrid_usuarios.Columns["CPF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // retira a ultima linha adicionada automaticamente, é utilizada para adicionar novas linhas
                dataGrid_usuarios.AllowUserToAddRows = false;

                // não deixa o usuário deletar as linhas do grid
                dataGrid_usuarios.AllowUserToDeleteRows = false;

                // insere a primeira coluna com a imagem
                if (!(dataGrid_usuarios.Columns[coluna_imagem.Name] is null))
                {
                    // se a primeira coluna existir, então deleta e coloca outra

                    dataGrid_usuarios.Columns.Remove(coluna_imagem.Name);

                    coluna_imagem = new DataGridViewImageColumn();
                    coluna_imagem.Image = Image.FromFile("seta_colunas_grid_3.jpg");
                    coluna_imagem.Name = "teste";
                    coluna_imagem.HeaderText = "";
                    coluna_imagem.ImageLayout = DataGridViewImageCellLayout.Stretch;

                    dataGrid_usuarios.Columns.Insert(0, coluna_imagem);
                    dataGrid_usuarios.Columns[0].Width = 40;
                    dataGrid_usuarios.Columns[0].Resizable = DataGridViewTriState.False;
                }
                else
                {
                    dataGrid_usuarios.Columns.Insert(0, coluna_imagem);
                    dataGrid_usuarios.Columns[0].Width = 40;
                    dataGrid_usuarios.Columns[0].Resizable = DataGridViewTriState.False;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AjustaAlturaLinhasGrid(dataGrid_usuarios);
        }

        void PreencheGrid_acessos()
        {
            // https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.datagridboolcolumn?view=netframework-4.8

            DataGridBoolColumn data = new DataGridBoolColumn();


            //dataGrid_acessos.Columns.Add(data);
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
    }
}
