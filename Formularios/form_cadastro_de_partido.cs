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

namespace EGP_PAINEL.Formularios
{
    public partial class form_cadastro_de_partido : Form
    {
        public form_cadastro_de_partido()
        {
            InitializeComponent();
        }

        private void Cadastro_de_partido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {

                pictureBox_partido.SizeMode = PictureBoxSizeMode.StretchImage;

                open.InitialDirectory = "C:\\";

                //estudar
                open.Filter = "Tipos |*.png;*.jpg;*.bmp;*.jpeg";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_partido.ImageLocation = open.FileName;
                }
            }
        }

        private void form_cadastro_de_partido_Load(object sender, EventArgs e)
        {
            if (Partido.Chamou_cad_participante)
            {
                groupBox_pergunta_presidente.Visible = true;
                lbl_presidente.Top = 244;
                comboBox_nome_presidente.Top = 262;
                Partido.Chamou_cad_participante = false;
                bt_bandeira.Top = 311;
                bt_bandeira.Left = 12;
                bt_salvar.Left = 578;
                bt_salvar.Top = 311;
            }
            else
            {
                groupBox_pergunta_presidente.Visible = false;
                lbl_presidente.Top = 189;
                comboBox_nome_presidente.Top = 207;
                bt_bandeira.Top = 257;
                bt_bandeira.Left = 298;
                bt_salvar.Left = 578;
                bt_salvar.Top = 257;
            }
        }

        private void rad_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_sim.Checked)
            {
                comboBox_nome_presidente.Enabled = false;
            }
            else
            {
                comboBox_nome_presidente.Enabled = true;
            }
        }
    }
}
