using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;
using System.Reflection;

namespace Configurador_EGP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ed_IP.Focus();
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            int vazio = 0;
            foreach (Control item in this.Controls)
            {               
                if (item is TextBox)
                {
                    TextBox text = item as TextBox;

                    if (string.IsNullOrWhiteSpace(text.Text))
                    {
                        vazio = 1;
                        text.Focus();
                        MessageBox.Show("Existem campos vazios", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }               
            }

            if (vazio == 0)
            {
                CriaGravaArquivo();
            }            
        }

        private void CriaGravaArquivo()
        {
            try
            {
                using (ResXResourceWriter writer = new ResXResourceWriter(@".\Conection.resx"))
                {
                    writer.AddResource("Ip", ed_IP.Text);
                    writer.AddResource("Usuario", ed_Usuario.Text);
                    writer.AddResource("Senha", ed_senha.Text);

                    MessageBox.Show("Gravou!", "Deu!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu algo errado: " + e.ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)            
                this.Close();
            
        }
    }
}
