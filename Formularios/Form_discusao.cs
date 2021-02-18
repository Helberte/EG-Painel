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
using System.Collections;

namespace EGP_PAINEL.Formularios
{
    public partial class Form_discusao : Form
    {
        List<Cad_projeto> projetos = new List<Cad_projeto>();

        public Form_discusao()
        {
            InitializeComponent();
        }

        private void Form_discusao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form_discusao_Activated(object sender, EventArgs e)
        {            

            //using (ResXResourceReader reader = new ResXResourceReader(@".\Cad_Projeto.resx"))
            //{
            //    foreach (DictionaryEntry item in reader)
            //    {
            //        if (((string) item.Key).StartsWith("p"))
            //        {
            //            projetos.Add((Cad_projeto)item.Value);
            //        }
            //    }
            //}

            //groupBox_Informacoes_pj.Text = projetos[Discusao_votacao.Tag].Tipo;
            //lbl_autor.Text = projetos[Discusao_votacao.Tag].Autor;
            //lbl_emenda.Text = projetos[Discusao_votacao.Tag].Ementa;
            //lbl_indexacao.Text = projetos[Discusao_votacao.Tag].Indexacao;
        }
    }
}
