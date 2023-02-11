using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGP_Tela_Inicial_04_02.Formulario_login_inicial
{
    public partial class Form_login_inicial : Form
    {
        string texto_padrao_ed_codigo = "Digite seu código";
        string texto_padrao_ed_usuario = "Digite seu nome ou e-mail";
        string texto_padrao_ed_senha = "Digite sua senha de até 8 dígitos";

        public Form_login_inicial()
        {
            InitializeComponent();
        }

        private void Form_login_inicial_Load(object sender, EventArgs e)
        {
            //int eds_altura = 25;

            //ed_codigo.Height = eds_altura;
            //ed_codigo.Width = (this.Width / 3) - 130;
            //ed_codigo.Left = (this.Width / 2) - ((ed_codigo.Width / 2) + 2);
            //ed_codigo.Location = new Point(ed_codigo.Left, (this.Height / 2) - 56);
            ed_codigo.Text = texto_padrao_ed_codigo;
            //ed_codigo.ForeColor = Color.FromArgb(160, 156, 153);

            //ed_usuario.Height = eds_altura;
            //ed_usuario.Width = ed_codigo.Width;
            //ed_usuario.Left = ed_codigo.Left;
            //ed_usuario.Location = new Point(ed_usuario.Left, ed_codigo.Location.Y + ed_codigo.Height + 63);
            ed_usuario.Text = texto_padrao_ed_usuario;
            //ed_usuario.ForeColor = Color.FromArgb(160, 156, 153);

            //ed_senha.Height = eds_altura;
            //ed_senha.Width = ed_codigo.Width;
            //ed_senha.Left = ed_codigo.Left;
            //ed_senha.Location = new Point(ed_senha.Left, ed_usuario.Location.Y + ed_usuario.Height + 61);
            ed_senha.Text = texto_padrao_ed_senha;
            //ed_senha.ForeColor = Color.FromArgb(160, 156, 153);

            //int bts_largura = 107;
            //int bts_altura = 42;

            //pictureBox_bt_acessar.Width = bts_largura;
            //pictureBox_bt_acessar.Left = ((this.Width / 2) - pictureBox_bt_acessar.Width) - 6;
            //pictureBox_bt_acessar.Height = bts_altura;
            //pictureBox_bt_acessar.Location = new Point(pictureBox_bt_acessar.Left, ed_senha.Location.Y + ed_senha.Height + 39);

            //pictureBox_bt_sair.Height = bts_altura;
            //pictureBox_bt_sair.Width = bts_largura;
            //pictureBox_bt_sair.Left = (this.Width / 2) + 9;
            //pictureBox_bt_sair.Location = new Point(pictureBox_bt_sair.Left, pictureBox_bt_acessar.Top);


            this.Focus();
        }

        private void ed_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        e.Handled = true;
                        ed_usuario.Focus();
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void ed_codigo_Enter(object sender, EventArgs e)
        {
            if (ed_codigo.Text == texto_padrao_ed_codigo)
            {
                ed_codigo.Clear();
                ed_codigo.ForeColor = Color.Black;
            }
        }

        private void ed_codigo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ed_codigo.Text))
            {
                ed_codigo.Text = texto_padrao_ed_codigo;
                ed_codigo.ForeColor = Color.FromArgb(160, 156, 153);
            }
        }

        private void ed_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("'"))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                ed_senha.Focus();
            }
            else
            if (string.IsNullOrWhiteSpace(Convert.ToString(e.KeyChar)))
            {
                e.Handled = true;
            }
            else
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                ed_usuario.Focus();
            }
        }

        private void ed_usuario_Enter(object sender, EventArgs e)
        {
            if (ed_usuario.Text == texto_padrao_ed_usuario)
            {
                ed_usuario.Clear();
                ed_usuario.ForeColor = Color.Black;
            }
        }

        private void ed_usuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ed_usuario.Text))
            {
                ed_usuario.Text = texto_padrao_ed_usuario;
                ed_usuario.ForeColor = Color.FromArgb(160, 156, 153);
            }
        }

        private void ed_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                ed_codigo.Focus();
            }
            else if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void ed_senha_Enter(object sender, EventArgs e)
        {
            if (ed_senha.Text == texto_padrao_ed_senha)
            {
                ed_senha.Clear();
                ed_senha.PasswordChar = '*';
                ed_senha.ForeColor = Color.Black;
            }
        }

        private void ed_senha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ed_senha.Text))
            {
                ed_senha.ForeColor = Color.FromArgb(160, 156, 153);
                ed_senha.PasswordChar = '\u0000';
                ed_senha.Text = texto_padrao_ed_senha;
            }
        }

        private void pictureBox_bt_acessar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            Class_gerencia_login _Login = new Class_gerencia_login(int.TryParse(ed_codigo.Text, out codigo) ? codigo : 0, ed_usuario.Text, ed_senha.Text);

            if (_Login.ValidarUsuario())            
                this.Close();
                                  
        }

        private void pictureBox_bt_sair_Click(object sender, EventArgs e)
        {
            Class_gerencia_login.Status = 0;
            this.Close();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);              

        private void Form_login_inicial_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
