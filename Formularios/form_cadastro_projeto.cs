using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EGP_PAINEL.Classes;
using System.Resources;
using System.IO;
using System.Collections;


// ARQUIVOS DE RECURSOS 
// https://docs.microsoft.com/pt-br/dotnet/framework/resources/working-with-resx-files-programmatically

namespace EGP_PAINEL.Formularios
{
    public partial class form_cadastro_projeto : Form
    {

        string arquivo = @".\Cad_Projeto.resx";
        int quantidade = 0;
        Cad_projeto projeto;
        public form_cadastro_projeto()
        {
            InitializeComponent();
        }

        private void form_cadastro_projeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void form_cadastro_projeto_Load(object sender, EventArgs e)
        {
            ToolTip tool_sigla  = new ToolTip();
            ToolTip tool_tipo = new ToolTip();


            tool_sigla.ToolTipIcon = ToolTipIcon.Info;
            tool_sigla.ToolTipTitle = "Sigla";
            tool_sigla.IsBalloon = true;
            tool_sigla.ShowAlways = true;
            tool_sigla.AutoPopDelay = 3300;
            tool_sigla.InitialDelay = 50;
            //tool_sigla.ReshowDelay = 200;

            tool_tipo.ToolTipIcon = ToolTipIcon.Info;
            tool_tipo.ToolTipTitle = "Tipo";
            tool_tipo.IsBalloon = true;
            tool_tipo.ShowAlways = true;
            tool_tipo.AutoPopDelay = 3300;
            tool_tipo.InitialDelay = 50;
            //tool_tipo.ReshowDelay = 200;

            tool_sigla.SetToolTip(this.txt_sigla, "Exemplo: 'PL' - Projeto de Lei");
            tool_tipo.SetToolTip(this.txt_tipo, "Exemplo: 'Projeto de Lei'");
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            
            projeto = new Cad_projeto(txt_sigla.Text,
                                                  txt_tipo.Text,
                                                  combo_autor.Text,
                                                  txt_ementa.Text,
                                                  txt_indexacao.Text);


            if (File.Exists(Directory.GetCurrentDirectory() + arquivo))
            {
                using (ResXResourceReader ler = new ResXResourceReader(arquivo))
                {                    
                    foreach (DictionaryEntry item in ler)
                    {
                        quantidade += 1;
                    }
                }

                try
                {
                    using (ResXResourceWriter resx = new ResXResourceWriter(arquivo))
                    {
                        resx.AddResource("p " + quantidade, projeto);
                    }

                    GravouCadastro();

                        MessageBox.Show("Salvo!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Algo de errado não está certo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                CriaArquivoResx(0);
            }
        }

        private void GravouCadastro()
        {
            using (ResXResourceWriter resx = new ResXResourceWriter(@".\Recursos.resx"))
            {
                resx.AddResource("GravouProjeto", "true");
            }
        }

        private void CriaArquivoResx(int quantidade)
        {
            try
            {
                using (ResXResourceWriter resx = new ResXResourceWriter(arquivo))
                {
                    resx.AddResource("p " + quantidade, projeto);
                }
                GravouCadastro();

                MessageBox.Show("Salvo!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo de errado não está certo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
