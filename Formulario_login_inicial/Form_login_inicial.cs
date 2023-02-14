using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGP_Tela_Inicial_04_02.Formulario_login_inicial
{
    public partial class Form_login_inicial : Form
    {
        string texto_padrao_ed_usuario = "Digite seu nome ou e-mail";
        string texto_padrao_ed_senha = "Digite sua senha de até 8 dígitos";

        public Form_login_inicial()
        {
            InitializeComponent();
        }

        private void Form_login_inicial_Load(object sender, EventArgs e)
        {            
            ed_usuario.Text = texto_padrao_ed_usuario;           
            ed_senha.Text = texto_padrao_ed_senha;

            this.Opacity = 0;
            ArredondaCantos(panel_center);

            EstilizaTelaLogin();

            this.Opacity = 1;
            this.Focus();
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
            if (!char.IsDigit(e.KeyChar))
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
            Class_gerencia_login _Login = new Class_gerencia_login(ed_usuario.Text, ed_senha.Text);

            if (_Login.ValidarUsuario())            
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

        private void ArredondaCantos(Control control)
        {
            using (GraphicsPath forma = new GraphicsPath())
            {
                forma.AddRectangle(new Rectangle(1, 1, control.Width, control.Height));
                forma.AddRectangle(new Rectangle(1, 1, 10, 10));
                forma.AddPie(1, 1, 20, 20, 180, 90);
                forma.AddRectangle(new Rectangle(control.Width - 12, 1, 12, 13));
                forma.AddPie(control.Width - 24, 1, 24, 26, 270, 90);
                forma.AddRectangle(new Rectangle(1, control.Height - 10, 10, 10));
                forma.AddPie(1, control.Height - 20, 20, 20, 90, 90);
                forma.AddRectangle(new Rectangle(control.Width - 12, control.Height - 13, 13, 13));
                forma.AddPie(control.Width - 24, control.Height - 26, 24, 26, 0, 90);
                forma.SetMarkers();

                control.Region = new Region(forma);
            }

            //https://pt.stackoverflow.com/questions/528084/%C3%89-poss%C3%ADvel-fazer-bordas-arredondadas-no-combobox-do-windows-forms-c
        }

        void EstilizaTelaLogin()
        {
            panel_center.Size = new Size(400, 500);
            panel_center.Location = new Point((this.Width / 2) - (panel_center.Width / 2), (this.Height / 2) - (panel_center.Height / 2) - 20);
            panel_center.Anchor = AnchorStyles.None;

            this.MinimumSize = new Size(480, 600);

        }
    }
}
