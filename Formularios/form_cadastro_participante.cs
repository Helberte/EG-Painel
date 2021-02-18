using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EGP_PAINEL.Classes;

namespace EGP_PAINEL.Formularios
{
    public partial class form_cadastro_participante : Form
    {
        form_cadastro_participante frm_cad_participante;
        bool mouse_na_foto = false;


        public form_cadastro_participante()
        {
            InitializeComponent();
            frm_cad_participante = this;
        }

        private void form_cadastro_participante_Load(object sender, EventArgs e)
        {
            
        }

        private void form_cadastro_participante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                frm_cad_participante.Close();
            }            
        }              

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (ed_Nome.Text.Trim() != "")
            {
                ed_Login.Text = ed_Nome.Text.Substring(0, (ed_Nome.Text.IndexOf(" ") == -1) ? 0 : ed_Nome.Text.IndexOf(" "));                       
            }            
        }

        private void btFoto_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox_foto_MouseEnter(object sender, EventArgs e)
        {
            mouse_na_foto = true;          
        }

        private void pictureBox_foto_MouseLeave(object sender, EventArgs e)
        {
            mouse_na_foto = false;
        }

        private void form_cadastro_participante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (mouse_na_foto)
                {
                    pictureBox_foto.Image = null;
                }
            }
        }
        private void btConcluido_Click(object sender, EventArgs e)
        {
            // se retornar falso é porque tem campos sem serem preenchidos

            bool retorno = AnalisaControles(groupBox_info_pessoais);

            if (retorno)
            {
                retorno = AnalisaControles(groupBox_atribuicoes);
                if (retorno)
                {
                    retorno = AnalisaControles(groupBox_endereco);

                    if (retorno)
                    {
                        retorno = AnalisaControles(groupBox_movel);
                    }
                }                
            }
            if (retorno)
            {
                MessageBox.Show("Concluído");
            }                 
        }
        private bool AnalisaControles(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox)
                {                   
                    if (item.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Faltam informações.", "Faltam dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                else if (item is ComboBox)
                {
                    if(item.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Faltam informações.", "Faltam dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                else if (item is MaskedTextBox) 
                {
                    string maskara = Regex.Replace(item.Text, "[^0-9]", ""); // retira a mascara

                    if (maskara.Trim() == string.Empty)
                    {
                        MessageBox.Show("Faltam informações.", "Faltam dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }                    
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_cadastro_funcoes cad_funcoes = new form_cadastro_funcoes();

            cad_funcoes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_cadastro_de_partido cad_partido = new form_cadastro_de_partido();

            Partido.Chamou_cad_participante = true;

            cad_partido.ShowDialog();
        }

        private void pictureBox_foto_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {

                pictureBox_foto.SizeMode = PictureBoxSizeMode.StretchImage;

                open.InitialDirectory = "C:\\";

                //estudar
                open.Filter = "Tipos |*.png;*.jpg;*.bmp;*.jpeg";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_foto.ImageLocation = open.FileName;
                }
            }
        }
    }
}
