using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EGP_PAINEL.Classes;
using EGP_PAINEL.Formularios;
using EGP_Tela_Inicial_04_02.Classes;
using EGP_Tela_Inicial_04_02.Formulario_login_inicial;
using EGP_Tela_Inicial_04_02.Formularios;
using MZControls;
using FontAwesome.Sharp;
using System.Drawing.Drawing2D;
using System.Windows.Media;

namespace EGP_Tela_Inicial_04_02
{
    public partial class Form_principal : Form
    {
        int left_panel;
        PictureBox mostra_menu_lateral;
        PictureBox opc_menu_rapido;
        Panel border_left_button;

        class_verifica_acessos acessos;
        List<string> nomes = new List<string>();
        List<IconButton> lista_botoes_menu_lateral_esquerdo = new List<IconButton>();
        List<Label> lista_labels_opcoes_menu_lateral_esquerdo = new List<Label>();

        DateTime data;

        Label lbl_painel_operador;
        Label lbl_cab_hora;

        IconPictureBox btn_close_form;
        IconPictureBox btn_minimize_form;
        IconPictureBox btn_maximize_form;
        IconButton botao_lat_esquerda;
        IconButton botao_ativo_esquerda;
        IconPictureBox seta_baixo;

        string[] nomes_menu;


        List<string> itens_menu_opcoes_0_nomes = new List<string>();
        List<string> itens_menu_opcoes_1_nomes = new List<string>();
        List<string> itens_menu_opcoes_2_nomes = new List<string>();
        List<string> itens_menu_opcoes_3_nomes = new List<string>();
        List<string> itens_menu_opcoes_4_nomes = new List<string>();
        List<string> itens_menu_opcoes_5_nomes = new List<string>();
        List<string> itens_menu_opcoes_6_nomes = new List<string>();


        public Form_principal()
        {         
            InitializeComponent();
            this.Opacity = 0;
            panel_cab_1.MouseDown += Panel_cab_1_MouseDown;
            border_left_button = new Panel();
            seta_baixo = new IconPictureBox();  

            border_left_button.Size = new Size(5, 55);
            border_left_button.BackColor = System.Drawing.Color.FromArgb(0, 88, 255);

            seta_baixo.Size = new Size(20, 20);
            seta_baixo.IconChar = IconChar.ChevronDown;
            seta_baixo.SizeMode = PictureBoxSizeMode.CenterImage;
            seta_baixo.IconColor = System.Drawing.Color.FromArgb(0, 88, 255);
            seta_baixo.IconSize = 22;
            seta_baixo.BackColor = System.Drawing.Color.FromArgb(222,232,248);

            mzSombraPanel_lateral_esquerda.Controls.Add(border_left_button);
            mzSombraPanel_lateral_esquerda.Controls.Add(seta_baixo);

            border_left_button.Visible = false;
            seta_baixo.Visible = false;
        }

        // ESTUDAR A QUESTÃO DOS MDI INTERFACE DE MULTIPLAS TELAS


        private void Form_principal_Load(object sender, EventArgs e)
        {
            acessos = new class_verifica_acessos(Class_gerencia_login.ID_Usuario);

            DesenhaTelaInicial();
            mostra_menu_lateral = new PictureBox();
            mostra_menu_lateral.Height = 30;
            mostra_menu_lateral.Width = 30;

            mostra_menu_lateral.BorderStyle = BorderStyle.None;

            this.Controls.Add(mostra_menu_lateral);

            mostra_menu_lateral.Location = new Point(this.Width - mostra_menu_lateral.Width - 15, this.Height - panel_menu_lateral.Height);
            mostra_menu_lateral.Visible = false;

            mostra_menu_lateral.Click += Mostra_menu_lateral_Click;
            mostra_menu_lateral.MouseEnter += Mostra_menu_lateral_MouseEnter;
            mostra_menu_lateral.MouseLeave += Mostra_menu_lateral_MouseLeave;
            toolTip1.SetToolTip(mostra_menu_lateral, "Clique para abrir o menu lateral");

            mostra_menu_lateral.Image = Image.FromFile("exibir_ao_publico_esquerda.png");
            mostra_menu_lateral.SizeMode = PictureBoxSizeMode.StretchImage;
            timer_hora.Start();

            this.Opacity = 1;
        }

        private void Mostra_menu_lateral_MouseLeave(object sender, EventArgs e)
        {
            mostra_menu_lateral.BorderStyle = BorderStyle.None;
        }

        private void Mostra_menu_lateral_MouseEnter(object sender, EventArgs e)
        {
            mostra_menu_lateral.BorderStyle = BorderStyle.FixedSingle;
        }

        // permite mudar a posição do form através do panel bar e sem a barra nativa do form

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Panel_cab_1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // torna a imagem de fundo opaca
        public Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                                                  ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height,
                                   GraphicsUnit.Pixel, attributes);
            }
            return bmp;

            // fonte
            //https://stackoverflow.com/questions/23114282/are-we-able-to-set-opacity-of-the-background-image-of-a-panel
            //https://www.codeproject.com/Tips/201129/Change-Opacity-of-Image-in-C
        }
               
        void DesenhaTelaInicial()
        {
            // configurações da janela principal

            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(1000, 500);
            this.BackgroundImage = SetImageOpacity(Image.FromFile(@"imagens\fundo_camara.png"), 0.25F);
            this.BackgroundImageLayout = ImageLayout.Center;
           
            lbl_painel_operador = new Label();
            lbl_cab_hora = new Label();
            btn_minimize_form = new IconPictureBox();
            btn_maximize_form = new IconPictureBox();
            btn_close_form= new IconPictureBox();

            // cabeçalho, logos etc

            panel_cab_1.Height = 50;
            panel_cab_1.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            panel_cab_1.AutoScroll = false;


            // painel do operador
            lbl_painel_operador.Text = "Painel do Operador";
            lbl_painel_operador.AutoSize = true;

            panel_cab_1.Controls.Add(lbl_painel_operador);

            lbl_painel_operador.Font = new Font(System.Drawing.FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            lbl_painel_operador.ForeColor = System.Drawing.Color.FromArgb(0, 120, 111);
            lbl_painel_operador.Location = new Point(15, (panel_cab_1.Height / 2) - (lbl_painel_operador.Height / 2));

            // usuario
            lbl_usuario.AutoSize = true;
            lbl_usuario.Text = "Usuário:";
            lbl_usuario.Font = new Font(System.Drawing.FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(0, 120, 111);
           

            lbl_nome_usuario.AutoSize = true;

            #region Adiciona abreviaturas no nome da pessoa
            lbl_nome_usuario.Text = "";

            string[] palavras_nome = Class_gerencia_login.Nome_Usuario.Split(' ');
            string abreviaturas = "";

            if (palavras_nome.Length >= 3)
            {
                for (int i = 0; i < palavras_nome.Length; i++)
                {
                    if (i + 1 == palavras_nome.Length - 1)
                        lbl_nome_usuario.Text += palavras_nome[0] + " " + abreviaturas + palavras_nome[palavras_nome.Length - 1];
                    else
                    {
                        if (string.IsNullOrWhiteSpace(lbl_nome_usuario.Text))
                            abreviaturas += palavras_nome[i + 1][0].ToString() + ". ";
                    }
                }
            }
            else
                lbl_nome_usuario.Text = Class_gerencia_login.Nome_Usuario;
            #endregion

            lbl_nome_usuario.Font = new Font(System.Drawing.FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            lbl_nome_usuario.ForeColor = System.Drawing.Color.FromArgb(46, 84, 123);

            panel_cab_usuario.Left = lbl_painel_operador.Width + lbl_painel_operador.Left + 30;
            panel_cab_usuario.Width = lbl_usuario.Width + lbl_nome_usuario.Width + 20;
            panel_cab_usuario.Height = panel_cab_1.Height;
            panel_cab_usuario.Location = new Point(panel_cab_usuario.Left, 0);

            lbl_usuario.Left = (panel_cab_usuario.Width / 2) - ((lbl_usuario.Width + lbl_nome_usuario.Width) / 2);
            lbl_usuario.Location = new Point(lbl_usuario.Left, (panel_cab_usuario.Height / 2) - (lbl_usuario.Height / 2));

            lbl_nome_usuario.Left = lbl_usuario.Left + lbl_usuario.Width;
            lbl_nome_usuario.Top = lbl_usuario.Top;

            // logo
            pictureBox_logo.Width = 240;
            pictureBox_logo.Height = panel_cab_1.Height;
            pictureBox_logo.Left = (panel_cab_1.Width / 2) - (pictureBox_logo.Width / 2);
            pictureBox_logo.Location = new Point(pictureBox_logo.Left, 0);
            pictureBox_logo.Anchor = AnchorStyles.None;


            // nome da cidade da camara
            lbl_nome_cidade.AutoSize = true;
            
            data = DateTime.Now;
            
            lbl_nome_cidade.Text = "Ji-Paraná - RO " + String.Format("{0: dd}", data).Trim() + "/" + String.Format("{0: MM}", data).Trim() + "/" + String.Format("{0: yyyy}", data).Trim();
            lbl_nome_cidade.Font = new Font(System.Drawing.FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            lbl_nome_cidade.ForeColor = System.Drawing.Color.FromArgb(0, 120, 111);

            panel_cab_camara.Width = lbl_nome_cidade.Width + 25;
            panel_cab_camara.Height = panel_cab_1.Height;
           
            lbl_nome_cidade.Left = (panel_cab_camara.Width / 2) - (lbl_nome_cidade.Width / 2);
            lbl_nome_cidade.Location = new Point(lbl_nome_cidade.Left, (panel_cab_camara.Height / 2) - (lbl_nome_cidade.Height / 2));


            // hora
            lbl_cab_hora.Text = String.Format("{0: HH}",data).Trim() + ":" + String.Format("{0: mm}",data).Trim();
            lbl_cab_hora.AutoSize = true;

            panel_cab_1.Controls.Add(lbl_cab_hora);

            lbl_cab_hora.Font = new Font(System.Drawing.FontFamily.GenericSansSerif, 15, FontStyle.Regular);
            lbl_cab_hora.ForeColor = System.Drawing.Color.FromArgb(0, 120, 111);
            lbl_cab_hora.Location = new Point((panel_cab_1.Width - lbl_cab_hora.Width) - 15, (panel_cab_1.Height / 2) - (lbl_cab_hora.Height / 2));
            lbl_cab_hora.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // posição nome da cidade da camara
            panel_cab_camara.Left = panel_cab_1.Width - lbl_cab_hora.Width - panel_cab_camara.Width - 35;
            panel_cab_camara.Location = new Point(panel_cab_camara.Left, 0);


            // logo da camara no panel menu
            pictureBox_logo_camara.BackgroundImage = Image.FromFile(@"imagens\logo_camara.png");
            pictureBox_logo_camara.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_logo_camara.Width = 168;

            // desativa os componentes da versão anterior

            pictureBox_div_1.Visible = false;
            pictureBox_div_2.Visible = false;
            pictureBox_div_3.Visible = false;
            pictureBox_div_4.Visible = false;
            pictureBox_div_5.Visible = false;
            pictureBox_div_6.Visible = false;
            pictureBox_icone_suporte.Visible = false;
            panel_cab_suporte.Visible = false;
            panel_cab_notificacoes.Visible = false;
            panel_cab_versao.Visible = false;

            #region CONFIGURAÇÕES DA VERSÃO ANTERIOR
            //int largura_divisorias = 10;

            //pictureBox_div_1.Height = panel_cab_1.Height;
            //pictureBox_div_1.Left = pictureBox_logo.Left + pictureBox_logo.Width;
            //pictureBox_div_1.Width = largura_divisorias;
            //pictureBox_div_1.Location = new Point(pictureBox_div_1.Left, 0);

            //panel_cab_versao.Height = panel_cab_1.Height;
            //panel_cab_versao.Width = 90;
            //panel_cab_versao.Left = pictureBox_div_1.Left + pictureBox_div_1.Width;
            //panel_cab_versao.Location = new Point(panel_cab_versao.Left, 0);

            //FontFamily fontFamily = new FontFamily("Gotham");
            //lbl_versao.Text = "V 1.00";
            //lbl_versao.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            //lbl_versao.ForeColor = Color.FromArgb(46, 84, 123);
            //lbl_versao.AutoSize = true;
            //lbl_versao.Left = (panel_cab_versao.Width / 2) - (lbl_versao.Width / 2);
            //lbl_versao.Top = (panel_cab_versao.Height / 2) - (lbl_versao.Height / 2);

            //pictureBox_div_2.Height = panel_cab_1.Height;
            //pictureBox_div_2.Left = panel_cab_versao.Left + panel_cab_versao.Width + 6;
            //pictureBox_div_2.Width = largura_divisorias;
            //pictureBox_div_2.Location = new Point(pictureBox_div_2.Left, 0);


            //pictureBox_div_3.Left = panel_cab_camara.Left + panel_cab_camara.Width;
            //pictureBox_div_3.Height = panel_cab_1.Height;
            //pictureBox_div_3.Width = largura_divisorias;
            //pictureBox_div_3.Location = new Point(pictureBox_div_3.Left + 6, 0);


            //pictureBox_div_4.Left = panel_cab_usuario.Left + panel_cab_usuario.Width + 6;
            //pictureBox_div_4.Width = largura_divisorias;
            //pictureBox_div_4.Height = panel_cab_1.Height;
            //pictureBox_div_4.Location = new Point(pictureBox_div_4.Left, 0);

            //panel_cab_notificacoes.Left = pictureBox_div_4.Left + pictureBox_div_4.Width;
            //panel_cab_notificacoes.Height = panel_cab_1.Height;
            //panel_cab_notificacoes.Width = 180;
            //panel_cab_notificacoes.Location = new Point(panel_cab_notificacoes.Left, 0);

            //int espaco = 20;
            //pictureBox_cab_notificacao_1.Width = 25;
            //pictureBox_cab_notificacao_1.Left = ((panel_cab_notificacoes.Width / 2) - ((pictureBox_cab_notificacao_1.Width + espaco) * 3) / 2) + 3;
            //pictureBox_cab_notificacao_1.Height = 35;
            //pictureBox_cab_notificacao_1.Top = (panel_cab_notificacoes.Height / 2) - (pictureBox_cab_notificacao_1.Height / 2);

            //pictureBox_cab_notificacao_2.Width = pictureBox_cab_notificacao_1.Width;
            //pictureBox_cab_notificacao_2.Left = pictureBox_cab_notificacao_1.Left + pictureBox_cab_notificacao_1.Width + espaco;
            //pictureBox_cab_notificacao_2.Height = pictureBox_cab_notificacao_1.Height;
            //pictureBox_cab_notificacao_2.Top = pictureBox_cab_notificacao_1.Top;

            //pictureBox_cab_notificacao_3.Width = pictureBox_cab_notificacao_2.Width;
            //pictureBox_cab_notificacao_3.Left = pictureBox_cab_notificacao_2.Left + pictureBox_cab_notificacao_2.Width + espaco;
            //pictureBox_cab_notificacao_3.Height = pictureBox_cab_notificacao_2.Height;
            //pictureBox_cab_notificacao_3.Top = pictureBox_cab_notificacao_2.Top;

            //pictureBox_div_5.Left = panel_cab_notificacoes.Left + panel_cab_notificacoes.Width;
            //pictureBox_div_5.Width = largura_divisorias;
            //pictureBox_div_5.Height = panel_cab_1.Height;
            //pictureBox_div_5.Location = new Point(pictureBox_div_5.Left, 0);

            //lbl_suporte.Text = "Suporte:";
            //lbl_suporte.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            //lbl_suporte.ForeColor = Color.FromArgb(46, 84, 123);

            //lbl_telefone_suporte.Text = "(69) 3536.9000";
            //lbl_telefone_suporte.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            //lbl_telefone_suporte.ForeColor = Color.FromArgb(46, 84, 123);

            //panel_cab_suporte.Left = pictureBox_div_5.Left + pictureBox_div_5.Width + 13;
            //panel_cab_suporte.Height = panel_cab_1.Height;
            //panel_cab_suporte.Location = new Point(panel_cab_suporte.Left, 0);

            //pictureBox_icone_suporte.Width = 20;

            //panel_cab_suporte.Width = lbl_suporte.Width + lbl_telefone_suporte.Width + pictureBox_icone_suporte.Width + 10;

            //pictureBox_icone_suporte.Left = (panel_cab_suporte.Width / 2) - ((lbl_suporte.Width + lbl_telefone_suporte.Width + pictureBox_icone_suporte.Width) / 2);
            //pictureBox_icone_suporte.Height = pictureBox_icone_suporte.Width;
            //pictureBox_icone_suporte.Location = new Point(pictureBox_icone_suporte.Left, (panel_cab_suporte.Height / 2) - (pictureBox_icone_suporte.Height / 2));
            //pictureBox_icone_suporte.BorderStyle = BorderStyle.None;

            //lbl_suporte.Left = pictureBox_icone_suporte.Left + pictureBox_icone_suporte.Width;
            //lbl_suporte.Location = new Point(lbl_suporte.Left, (panel_cab_suporte.Height / 2) - (lbl_suporte.Height / 2));

            //lbl_telefone_suporte.Left = lbl_suporte.Left + lbl_suporte.Width;
            //lbl_telefone_suporte.Location = new Point(lbl_telefone_suporte.Left, lbl_suporte.Top);

            //pictureBox_div_6.Left = panel_cab_suporte.Left + panel_cab_suporte.Width + 15;
            //pictureBox_div_6.Height = panel_cab_1.Height;
            //pictureBox_div_6.Width = largura_divisorias;
            //pictureBox_div_6.Location = new Point(pictureBox_div_6.Left, 0);

            // barras coloridas

            //int barras_altura = 7;

            //panel_cab_2.BackColor = Color.FromArgb(243, 130, 34);
            //panel_cab_2.Height = barras_altura;

            //panel_cab_3.BackColor = Color.FromArgb(28, 82, 116);
            //panel_cab_3.Height = barras_altura;


            //panel_roda_1.Height = barras_altura;
            //panel_roda_1.BackColor = Color.FromArgb(250, 254, 253);

            //panel_roda_2.Height = barras_altura;
            //panel_roda_2.BackColor = Color.FromArgb(0, 87, 133);

            //panel_roda_3.Height = barras_altura;
            //panel_roda_3.BackColor = Color.FromArgb(243, 129, 33);

            //panel_menu_inferior.Height = 53;
            //panel_menu_inferior.AutoScroll = true;
            //panel_menu_inferior.BackColor = Color.FromArgb(234, 244, 253);
            #endregion

            panel_roda_1.Visible = false;
            panel_roda_2.Visible = false;
            panel_roda_3.Visible = false;

            panel_cab_2.Visible = false;
            panel_cab_3.Visible = false;

            #region CONFIGURAÇÃO DA INFORMAÇÃO DO ULTIMO BACKUP

            // CONFIGURAÇÃO DA INFORMAÇÃO DO ULTIMO BACKUP

            //panel_ultimo_backup.Height = panel_menu_inferior.Height;
            //panel_ultimo_backup.Width = 300;
            //panel_ultimo_backup.Left = panel_menu_inferior.Width - panel_ultimo_backup.Width;
            //panel_ultimo_backup.Top = 0;
            //panel_ultimo_backup.BackColor = Color.FromArgb(234, 244, 253);
            //panel_ultimo_backup.BorderStyle = BorderStyle.None;

            //lbl_ultimo_backup.Text = "Último Backup realizado";
            //lbl_ultimo_backup.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);
            //lbl_ultimo_backup.AutoSize = true;
            //lbl_ultimo_backup.ForeColor = Color.FromArgb(143, 143, 146);

            //pictureBox_backup.Height = panel_ultimo_backup.Height - 17;
            //pictureBox_backup.Width = pictureBox_backup.Height;
            //pictureBox_backup.BorderStyle = BorderStyle.None;
            //pictureBox_backup.Left = (panel_ultimo_backup.Width / 2) - ((lbl_ultimo_backup.Width + pictureBox_backup.Width) / 2);
            //pictureBox_backup.Top = (panel_ultimo_backup.Height / 2) - (pictureBox_backup.Height / 2);
            //pictureBox_backup.SizeMode = PictureBoxSizeMode.StretchImage;

            //lbl_data_backup.Text = "08.02.2021";
            //lbl_data_backup.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold);
            //lbl_data_backup.AutoSize = true;
            //lbl_data_backup.ForeColor = Color.FromArgb(143,143,146);

            //lbl_dia.Text = "Dia ";
            //lbl_dia.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);
            //lbl_dia.AutoSize = true;
            //lbl_dia.ForeColor = Color.FromArgb(143, 143, 146);

            //lbl_ultimo_backup.Left = pictureBox_backup.Left + pictureBox_backup.Width + 10;
            //lbl_ultimo_backup.Top = (panel_ultimo_backup.Height / 2) - ((lbl_ultimo_backup.Height + lbl_dia.Height) / 2);

            //lbl_dia.Left = (lbl_ultimo_backup.Left + (lbl_ultimo_backup.Width / 2)) - ((lbl_dia.Width + lbl_data_backup.Width) / 2);
            //lbl_dia.Top = lbl_ultimo_backup.Top + lbl_ultimo_backup.Height;

            //lbl_data_backup.Left = lbl_dia.Left + lbl_dia.Width;
            //lbl_data_backup.Top = lbl_dia.Top;

            // menu lateral direita 
            #endregion


            panel_exibir_ao_publico.Height = 38;
            panel_exibir_ao_publico.BackColor = System.Drawing.Color.FromArgb(239, 239, 239);

            lbl_exibir_ao_publico.Text = "EXIBIR AO PÚBLICO";
            lbl_exibir_ao_publico.Font = new Font(System.Drawing.FontFamily.GenericSansSerif, 8, FontStyle.Bold);
            lbl_exibir_ao_publico.ForeColor = System.Drawing.Color.FromArgb(46, 84, 123);

            pictureBox_exibir_ao_publico.Width = 18;
            pictureBox_exibir_ao_publico.Height = 18;
            pictureBox_exibir_ao_publico.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_exibir_ao_publico.BorderStyle = BorderStyle.None;

            //panel_menu_lateral.Height = panel_menu_inferior.Top - (panel_cab_3.Top + panel_cab_3.Height);

            panel_menu_lateral.Height = this.Height - panel_cab_1.Height - 120;
            panel_menu_lateral.Width = lbl_exibir_ao_publico.Width + pictureBox_exibir_ao_publico.Width + 55;
            panel_menu_lateral.Left = this.Width - panel_menu_lateral.Width;
            panel_menu_lateral.Location = new Point(panel_menu_lateral.Left, this.Height - panel_menu_lateral.Height);
            panel_menu_lateral.BackColor = System.Drawing.Color.FromArgb(234, 244, 253);
            panel_menu_lateral.BorderStyle = BorderStyle.FixedSingle;
            panel_menu_lateral.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;

            pictureBox_exibir_ao_publico.Left = (panel_menu_lateral.Width / 2) - ((lbl_exibir_ao_publico.Width + pictureBox_exibir_ao_publico.Width) / 2);
            pictureBox_exibir_ao_publico.Location = new Point(pictureBox_exibir_ao_publico.Left, (panel_exibir_ao_publico.Height / 2) - (pictureBox_exibir_ao_publico.Height / 2));

            lbl_exibir_ao_publico.Left = pictureBox_exibir_ao_publico.Left + pictureBox_exibir_ao_publico.Width;
            lbl_exibir_ao_publico.Location = new Point(lbl_exibir_ao_publico.Left, (panel_exibir_ao_publico.Height / 2) - (lbl_exibir_ao_publico.Height / 2));

            AdicionandoItensMenuLateral(panel_menu_lateral);


            // barra de menu rápido superior

            mzSombraPanel_menu_superior.TipoDeSombra = MZSombraPanel.ShadowsPanel.Desplasada;
            mzSombraPanel_menu_superior.Dock = DockStyle.None;
            mzSombraPanel_menu_superior.Width = this.Width - 25;
            mzSombraPanel_menu_superior.Height = 89;
            mzSombraPanel_menu_superior.Location = new Point(8, panel_cab_1.Height);
            mzSombraPanel_menu_superior.BackColor = System.Drawing.Color.FromArgb(247, 247, 247);
            mzSombraPanel_menu_superior.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            

            // menu suspenso da versão anterior
            menuStrip_principal.Left = 0;
            menuStrip_principal.Height = 50;
            menuStrip_principal.Width = this.Width;
            menuStrip_principal.Location = new Point(menuStrip_principal.Left, 180);
            menuStrip_principal.BackColor = System.Drawing.Color.FromArgb(234, 244, 253);
            menuStrip_principal.Renderer = new MyRenderer();


            // configurando mzSombraPanel lateral esquerda
            //mzSombraPanel_lateral_esquerda.TipoDeSombra = MZSombraPanel.ShadowsPanel.Desplasada;
            mzSombraPanel_lateral_esquerda.Width = 218;
            mzSombraPanel_lateral_esquerda.Height = 470;
            mzSombraPanel_lateral_esquerda.BackColor = System.Drawing.Color.FromArgb(247, 247, 247);
            mzSombraPanel_lateral_esquerda.Location = new Point(8, mzSombraPanel_menu_superior.Top + mzSombraPanel_menu_superior.Height + 10);
            ArredondaCantos(mzSombraPanel_lateral_esquerda);
            mzSombraPanel_lateral_esquerda.Anchor = AnchorStyles.Top | AnchorStyles.Left;


            // adiciona os menus rápidos
            AdicionaMenusRapidos();

            // adiciona menus laterais gerais
            AdicionaMenuLateralEsquerda();


            // lista de menus antiga
            AdicionaMenus();



            // botão minimizar
            btn_minimize_form.IconChar = IconChar.WindowMinimize;
            btn_minimize_form.BackgroundImageLayout = ImageLayout.Center;
            btn_minimize_form.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_minimize_form.Width = 30;
            btn_minimize_form.Height = 30;
            btn_minimize_form.IconFont = IconFont.Solid;
            btn_minimize_form.Padding = new Padding(0, 0, 0, 8);
            btn_minimize_form.IconColor = System.Drawing.Color.FromArgb(46, 84, 123);
            this.Controls.Add(btn_minimize_form);
            btn_minimize_form.Location = new Point(15, this.Height - btn_minimize_form.Height - (btn_minimize_form.Height / 2));
            btn_minimize_form.BringToFront();
            btn_minimize_form.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            btn_minimize_form.Click += Btn_minimize_form_Click;

            // botão maximizar
            btn_maximize_form.IconChar = IconChar.WindowMaximize;
            btn_maximize_form.BackgroundImageLayout = ImageLayout.Center;
            btn_maximize_form.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_maximize_form.Width = 30;
            btn_maximize_form.Height = 30;
            btn_maximize_form.IconFont = IconFont.Solid;
            btn_maximize_form.IconColor = System.Drawing.Color.FromArgb(46, 84, 123);
            this.Controls.Add(btn_maximize_form);
            btn_maximize_form.Location = new Point(btn_minimize_form.Left + btn_minimize_form.Width + 5, this.Height - btn_maximize_form.Height - (btn_maximize_form.Height / 2));
            btn_maximize_form.BringToFront();
            btn_maximize_form.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            btn_maximize_form.Click += Btn_maximize_form_Click;

            // botão fechar
            btn_close_form.IconChar = IconChar.WindowClose;
            btn_close_form.BackgroundImageLayout = ImageLayout.Center;
            btn_close_form.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_close_form.Width = 30;
            btn_close_form.Height = 30;
            btn_close_form.IconFont = IconFont.Solid;
            btn_close_form.IconColor = System.Drawing.Color.FromArgb(46, 84, 123);
            this.Controls.Add(btn_close_form);
            btn_close_form.Location = new Point(btn_maximize_form.Left + btn_maximize_form.Width + 5, this.Height - btn_close_form.Height - (btn_close_form.Height / 2));
            btn_close_form.BringToFront();
            btn_close_form.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            btn_close_form.Click += Btn_close_form_Click;
        }

        void AdicionaMenuLateralEsquerda()
        {
            lista_botoes_menu_lateral_esquerdo.Add(CriaBotaoLateralEsquerda(" Cadastros", 0, 0, IconChar.Home));
            lista_botoes_menu_lateral_esquerdo.Add(CriaBotaoLateralEsquerda(" Registros", 1, 1, IconChar.ChartSimple));
            lista_botoes_menu_lateral_esquerdo.Add(CriaBotaoLateralEsquerda(" Acessar", 2, 2, IconChar.Envelope));
            lista_botoes_menu_lateral_esquerdo.Add(CriaBotaoLateralEsquerda(" Exibir no Painel", 3, 3, IconChar.FileLines));
            lista_botoes_menu_lateral_esquerdo.Add(CriaBotaoLateralEsquerda(" Configurações", 4, 4, IconChar.Gear));
            lista_botoes_menu_lateral_esquerdo.Add(CriaBotaoLateralEsquerda(" Relatórios", 5, 5, IconChar.Clipboard));
            lista_botoes_menu_lateral_esquerdo.Add(CriaBotaoLateralEsquerda(" Ajuda", 6, 6, IconChar.CircleQuestion));
            lista_botoes_menu_lateral_esquerdo.Add(CriaBotaoLateralEsquerda(" Sair", 7, 7, IconChar.CircleLeft));

        }

        IconButton CriaBotaoLateralEsquerda(string text, int ordemBotao, int qt_button, IconChar icone)
        {
            botao_lat_esquerda = new IconButton();


            botao_lat_esquerda.BackColor = System.Drawing.Color.Transparent;
            botao_lat_esquerda.Height = 55;
            botao_lat_esquerda.Width = 190;
            botao_lat_esquerda.Text = text;
            mzSombraPanel_lateral_esquerda.Controls.Add(botao_lat_esquerda);
            botao_lat_esquerda.Tag = ordemBotao;
            botao_lat_esquerda.Location = new Point(5, 18 + (botao_lat_esquerda.Height * qt_button ));
            botao_lat_esquerda.FlatStyle = FlatStyle.Flat;
            botao_lat_esquerda.FlatAppearance.BorderSize = 0;
            botao_lat_esquerda.Font = new Font(System.Drawing.FontFamily.GenericSansSerif, 11, FontStyle.Regular);
            botao_lat_esquerda.IconChar = icone;
            botao_lat_esquerda.IconColor = System.Drawing.Color.FromArgb(0, 120, 111);
            botao_lat_esquerda.ForeColor = System.Drawing.Color.FromArgb(0, 120, 111);
            botao_lat_esquerda.TextImageRelation = TextImageRelation.ImageBeforeText;
            botao_lat_esquerda.IconSize = 28;
            botao_lat_esquerda.TextAlign = ContentAlignment.MiddleLeft;
            botao_lat_esquerda.ImageAlign = ContentAlignment.MiddleLeft;
            botao_lat_esquerda.Padding = new Padding(10,0,0,0);

            botao_lat_esquerda.Click += Botao_lat_esquerda_Click;

            botao_lat_esquerda.BackgroundImage = null; 
            
            return botao_lat_esquerda;
        }

       

        void DesativaBotaoEsquerda()
        {
            if (botao_ativo_esquerda != null)
            {
                botao_ativo_esquerda.BackgroundImage = null;
                botao_ativo_esquerda.ForeColor = System.Drawing.Color.FromArgb(0, 120, 111);
                botao_ativo_esquerda.IconColor = System.Drawing.Color.FromArgb(0, 120, 111);                
            }            
        }

        private void Botao_lat_esquerda_Click(object sender, EventArgs e)
        {
            DesativaBotaoEsquerda();

            IconButton botao = sender as IconButton;

            botao.BackgroundImage = Image.FromFile(@"imagens\botao_menu_lateral_esquerdo.png");
            botao.BackgroundImageLayout = ImageLayout.Stretch;
            botao.ForeColor = System.Drawing.Color.FromArgb(0, 88, 255);
            botao.IconColor = System.Drawing.Color.FromArgb(0, 88, 255);

            botao_ativo_esquerda = botao;

            seta_baixo.Location = new Point(botao.Width - seta_baixo.Width, botao.Location.Y + ((botao.Height / 2) - (seta_baixo.Height / 2)));
            seta_baixo.Visible = true;

            border_left_button.Location = new Point(5, botao.Location.Y);
            border_left_button.Visible = true;

            RemoveBotoesOpcoesMenuLateralEsquerdo();
            CriaBotoesOpcoesMenuLateralEsquerdo(botao);
        }

        void RemoveBotoesOpcoesMenuLateralEsquerdo()
        {
            if (lista_labels_opcoes_menu_lateral_esquerdo.Count != 0)
            {
                foreach (Label item in lista_labels_opcoes_menu_lateral_esquerdo)
                {
                    mzSombraPanel_lateral_esquerda.Controls.Remove(item);
                    item.Dispose();
                }
                lista_labels_opcoes_menu_lateral_esquerdo.Clear();
            }            
        }

        void CriaBotoesOpcoesMenuLateralEsquerdo(IconButton botaoSender)
        {

            lista_labels_opcoes_menu_lateral_esquerdo.Add(CrialabelOpcao("Entidade", botaoSender, 0));
            lista_labels_opcoes_menu_lateral_esquerdo.Add(CrialabelOpcao("Legislatura", botaoSender, 1));
            lista_labels_opcoes_menu_lateral_esquerdo.Add(CrialabelOpcao("Pessoas", botaoSender, 2));

            RerganizaAlturaBotoes(botaoSender, 69);
        }

        Label CrialabelOpcao(string nome, IconButton iconButton, int qtOpcoes)
        {
            Label opcao = new Label();

            opcao.Text = nome;
            opcao.ForeColor = System.Drawing.Color.FromArgb(0, 120, 111);
            opcao.Font = new Font(System.Drawing.FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            opcao.AutoSize = false;
            opcao.Width = botao_lat_esquerda.Width;
            opcao.Height = 23;
            opcao.BackColor = System.Drawing.Color.Transparent;
            opcao.TextAlign = ContentAlignment.MiddleLeft;
            opcao.Padding = new Padding(50, 0, 0, 0);

            mzSombraPanel_lateral_esquerda.Controls.Add(opcao);

            opcao.Location = new Point(5, iconButton.Location.Y + iconButton.Height + (23 * qtOpcoes));
            opcao.BringToFront();

            return opcao;
        }
        void RerganizaAlturaBotoes(IconButton botaoSender, int heightLabls)
        {
            //ajustar altura apenas dos botões que tem a ordem maior que a ordem do botão atual

            int ordem_button_atual = (int)botaoSender.Tag;
            int controler = 0;

            if (ordem_button_atual != 0)
            {
                lista_botoes_menu_lateral_esquerdo[ordem_button_atual].BackgroundImage = null;
                lista_botoes_menu_lateral_esquerdo[ordem_button_atual].ForeColor = System.Drawing.Color.FromArgb(0, 120, 111);
                lista_botoes_menu_lateral_esquerdo[ordem_button_atual].IconColor = System.Drawing.Color.FromArgb(0, 120, 111);

                lista_botoes_menu_lateral_esquerdo[ordem_button_atual].Location = new Point(5, lista_botoes_menu_lateral_esquerdo[ordem_button_atual - 1].Location.Y + lista_botoes_menu_lateral_esquerdo[ordem_button_atual - 1].Height);

            }


            for (int i = ordem_button_atual + 1; i < lista_botoes_menu_lateral_esquerdo.Count; i++)
            {
                if(controler == 0)
                {
                    lista_botoes_menu_lateral_esquerdo[i].Location = new Point(5, lista_botoes_menu_lateral_esquerdo[i - 1].Location.Y + lista_botoes_menu_lateral_esquerdo[i - 1].Height + heightLabls);
                    controler++;
                }
                else
                {
                    lista_botoes_menu_lateral_esquerdo[i].Location = new Point(5, lista_botoes_menu_lateral_esquerdo[i - 1].Location.Y + lista_botoes_menu_lateral_esquerdo[i - 1].Height);
                }

                // botao anterior .Y + o heigth dele, + o total da lista suspensa que foi gerada
            }
            
        } 




        // 03/02/2023
        void AdicionaMenusRapidos()
        {
            string menus_rapidos = acessos.RetornaMenusRapidos();

            if (!string.IsNullOrEmpty(menus_rapidos))
            {
                string[] menu_rapido = menus_rapidos.Split('\n');
                string nome_imagem = "";
                string nome_substring = "";
                int espaco_entre_categorias = 0;
                int cont_categoria = 1;
                 
                //Entidade;entidade;CADASTRO
                nome_substring = menu_rapido[0].Substring(menu_rapido[0].IndexOf(";") + 1);

                //entidade;CADASTRO
                string categoria_anterior = nome_substring.Substring(nome_substring.IndexOf(";") + 1);
                //CADASTRO

                for (int i = 0; i < menu_rapido.Length - 1; i++)
                {

                    opc_menu_rapido = new PictureBox();
                    opc_menu_rapido.Height = 67;
                    opc_menu_rapido.Width = 67;
                    opc_menu_rapido.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    opc_menu_rapido.BackColor = System.Drawing.Color.Transparent;

                    nome_substring = menu_rapido[i].Substring(menu_rapido[i].IndexOf(";") + 1);
                    nome_imagem = nome_substring.Substring(0, nome_substring.IndexOf(";"));

                    opc_menu_rapido.Image = Image.FromFile(@"imagens\iconesSuperiores\" + nome_imagem + ".png");
                    opc_menu_rapido.SizeMode = PictureBoxSizeMode.Zoom;
                    opc_menu_rapido.Tag = menu_rapido[i].Substring(0, menu_rapido[i].IndexOf(";"));
                    opc_menu_rapido.Click += Opc_menu_rapido_Click;
                    opc_menu_rapido.MouseMove += Opc_menu_rapido_MouseMove;
                    opc_menu_rapido.MouseLeave += Opc_menu_rapido_MouseLeave;

                    mzSombraPanel_menu_superior.Controls.Add(opc_menu_rapido);

                    // compara a categoria anterior com a atual
                    nome_substring = menu_rapido[i].Substring(menu_rapido[i].IndexOf(";") + 1);
                    if (categoria_anterior == nome_substring.Substring(nome_substring.IndexOf(";") + 1))
                    {
                        opc_menu_rapido.Location = new Point((pictureBox_logo_camara.Left + pictureBox_logo_camara.Width) + (67 * i) + espaco_entre_categorias, 7);                            
                    }
                    else
                    {
                        opc_menu_rapido.Location = new Point((pictureBox_logo_camara.Left + pictureBox_logo_camara.Width) + (67 * i) + (37 * cont_categoria), 7);
                        
                        espaco_entre_categorias = 37 * cont_categoria;
                        cont_categoria++;
                    }
                                        

                    toolTip1.IsBalloon = false;
                    toolTip1.ToolTipIcon = ToolTipIcon.Info;
                    toolTip1.ToolTipTitle = "Menu";
                    toolTip1.SetToolTip(opc_menu_rapido, menu_rapido[i].Substring(0, menu_rapido[i].IndexOf(";")));

                    nome_substring = menu_rapido[i].Substring(menu_rapido[i].IndexOf(";") + 1);
                    categoria_anterior = nome_substring.Substring(nome_substring.IndexOf(";") + 1);

                }
            } 
                   
        }

        private void Opc_menu_rapido_MouseLeave(object sender, EventArgs e)
        {
            PictureBox botao = sender as PictureBox;

            if (botao.Tag.ToString().ToUpper() == "ENTIDADE")
            {
                botao.Image = Image.FromFile(@"imagens\iconesSuperiores\entidade.png");
            }
        }

        private void Opc_menu_rapido_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox botao = sender as PictureBox;

            if(botao.Tag.ToString().ToUpper() == "ENTIDADE")
            {
                botao.Image = Image.FromFile(@"imagens\iconesSuperiores\entidade_2.png");
            }
        }

        private void Opc_menu_rapido_Click(object sender, EventArgs e)
        {
            PictureBox botao = sender as PictureBox;
            MessageBox.Show(botao.Tag.ToString());
        }

        private void Btn_close_form_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_maximize_form_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Btn_minimize_form_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void AdicionaMenus()
        {
            nomes = acessos.Nomes_menu_principal();

            nomes_menu = new string[acessos.Quantidae_nomes_menu];

            for (int i = 0; i < acessos.Quantidae_nomes_menu; i++)
            {
                nomes_menu[i] = nomes[i];
            }
         
            menu_opcoes_0.Tag = 0;
            menu_opcoes_1.Tag = 1;
            menu_opcoes_2.Tag = 2;
            menu_opcoes_3.Tag = 3;
            menu_opcoes_4.Tag = 4;
            menu_opcoes_5.Tag = 5;
            menu_opcoes_6.Tag = 6;

            ConfiguraMenu(nomes_menu[0], menu_opcoes_0);
            ConfiguraMenu(nomes_menu[1], menu_opcoes_1);
            ConfiguraMenu(nomes_menu[2], menu_opcoes_2);
            ConfiguraMenu(nomes_menu[3], menu_opcoes_3);
            ConfiguraMenu(nomes_menu[4], menu_opcoes_4);
            ConfiguraMenu(nomes_menu[5], menu_opcoes_5);
            ConfiguraMenu(nomes_menu[6], menu_opcoes_6);

            #region Imagens_itens_menu_configuração
            // itens menu CONFIGURAÇÃO

            // icones da lista suspensa                      

            //Image[] itens_configuracao_images = new Image[8] {  Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\meu_cadastro.ico"),
            //                                                    Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\trocar_senha.ico"),
            //                                                    Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\abrir_chamado.ico"),
            //                                                    Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\novidades.ico"),
            //                                                    Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\mesa_diretora_sair.ico"),
            //                                                    Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\vereadores.ico"),
            //                                                    Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\backup.ico"),
            //                                                    Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\mesa_diretora_sair.ico")};

            #endregion
                             
            string[] array_lista = acessos.RetornaListaSuspensa().Split('\n');

            int contador = 0;

            try
            {
                while (contador < array_lista.Length)
                {
                    if (array_lista[contador].StartsWith("0")) // irá criar uma lista dos itens que estão na posição 0
                        itens_menu_opcoes_0_nomes.Add(array_lista[contador].Substring(array_lista[contador].IndexOf('_') + 1, array_lista[contador].Length - 2));
                    else if (array_lista[contador].StartsWith("1"))
                        itens_menu_opcoes_1_nomes.Add(array_lista[contador].Substring(array_lista[contador].IndexOf('_') + 1, array_lista[contador].Length - 2));
                    else if (array_lista[contador].StartsWith("2"))
                        itens_menu_opcoes_2_nomes.Add(array_lista[contador].Substring(array_lista[contador].IndexOf('_') + 1, array_lista[contador].Length - 2));
                    else if (array_lista[contador].StartsWith("3"))
                        itens_menu_opcoes_3_nomes.Add(array_lista[contador].Substring(array_lista[contador].IndexOf('_') + 1, array_lista[contador].Length - 2));
                    else if (array_lista[contador].StartsWith("4"))
                        itens_menu_opcoes_4_nomes.Add(array_lista[contador].Substring(array_lista[contador].IndexOf('_') + 1, array_lista[contador].Length - 2));
                    else if (array_lista[contador].StartsWith("5"))
                        itens_menu_opcoes_5_nomes.Add(array_lista[contador].Substring(array_lista[contador].IndexOf('_') + 1, array_lista[contador].Length - 2));
                    else if (array_lista[contador].StartsWith("6"))
                        itens_menu_opcoes_6_nomes.Add(array_lista[contador].Substring(array_lista[contador].IndexOf('_') + 1, array_lista[contador].Length - 2));

                    contador++;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Deu ruim " + erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                       

            itens_menu_opcoes_0_nomes.Sort();
            itens_menu_opcoes_1_nomes.Sort();
            itens_menu_opcoes_2_nomes.Sort();
            itens_menu_opcoes_3_nomes.Sort();
            itens_menu_opcoes_4_nomes.Sort();
            itens_menu_opcoes_5_nomes.Sort();
            itens_menu_opcoes_6_nomes.Sort();

            AddItensSuspensosMenu(menu_opcoes_0, itens_menu_opcoes_0_nomes, null);
            AddItensSuspensosMenu(menu_opcoes_1, itens_menu_opcoes_1_nomes, null);
            AddItensSuspensosMenu(menu_opcoes_2, itens_menu_opcoes_2_nomes, null);
            AddItensSuspensosMenu(menu_opcoes_3, itens_menu_opcoes_3_nomes, null);
            AddItensSuspensosMenu(menu_opcoes_4, itens_menu_opcoes_4_nomes, null);
            AddItensSuspensosMenu(menu_opcoes_5, itens_menu_opcoes_5_nomes, null);
            AddItensSuspensosMenu(menu_opcoes_6, itens_menu_opcoes_6_nomes, null);


            left_panel = this.Width - panel_menu_lateral.Width;

            // foi retirado devido à alteração
            //AdicionaBotoesRodape(panel_menu_inferior);     
        }


        void AddItensSuspensosMenu(ToolStripMenuItem menu, List<string> nomes, Image[] imagens)
        {
            List<ToolStripSeparator> separadores = new List<ToolStripSeparator>();
            List<ToolStripMenuItem> itens = new List<ToolStripMenuItem>();

            System.Drawing.FontFamily fontFamily = new System.Drawing.FontFamily("calibri");

            for (int i = 0; i < nomes.Count; i++)
            {
                separadores.Add(new ToolStripSeparator());
                itens.Add(new ToolStripMenuItem(nomes[i].Substring(nomes[i].IndexOf("_"), nomes[i].Length - 1).Replace("_",""), null, new EventHandler(Itens_menu_click)));

                itens[i].Tag = nomes_menu[(int)menu.Tag].ToString() + "_" + itens[i].ToString();
                itens[i].Font = new Font(fontFamily, 9, FontStyle.Regular);
                itens[i].AutoSize = false;
                itens[i].Width = menu.Width;
                itens[i].Height = 20;
                itens[i].TextAlign = ContentAlignment.MiddleCenter;

                menu.DropDownItems.Add(itens[i]);

                if (!(i == nomes.Count - 1))                
                    menu.DropDownItems.Add(separadores[i]);               
                
            }

            ((ToolStripDropDownMenu)(menu.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(menu.DropDown)).ShowCheckMargin = false;
            ((ToolStripDropDownMenu)(menu.DropDown)).AutoSize = false;
            ((ToolStripDropDownMenu)(menu.DropDown)).Width = menu.Width;
        }

        void Itens_menu_click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;

            if (menu.Tag.ToString().StartsWith(nomes_menu[0]))                  // CADASTRO
            {

                // entidade
                if (menu.Tag.ToString().ToUpper().Contains("ENTIDADE"))
                {
                    form_cadastro_camara form_Cadastro_Camara = new form_cadastro_camara();
                    form_Cadastro_Camara.ShowDialog();
                }
                // legislatura
                else if (menu.Tag.ToString().ToUpper().Contains("LEGISLATURA"))
                {

                }
                // pessoas
                else if (menu.Tag.ToString().ToUpper().Contains("PESSOAS"))
                {
                    form_cadastro_participante form_Cadastro_Participante = new form_cadastro_participante();
                    form_Cadastro_Participante.ShowDialog();
                }
            }
            else if (menu.Tag.ToString().StartsWith(nomes_menu[1]))             // REGISTRO
            {
                
            }
            else if (menu.Tag.ToString().StartsWith(nomes_menu[2]))             // ACESSOS
            {
                if (menu.Tag.ToString().ToUpper().Contains("ACESSOS"))
                {
                    form_acessos form_Acessos = new form_acessos();
                    form_Acessos.ShowDialog();
                }
            }
            else if (menu.Tag.ToString().StartsWith(nomes_menu[3]))             // EXIBIR AO PUBLICO
            {

            }
            else if (menu.Tag.ToString().StartsWith(nomes_menu[4]))             // CONFIGURAÇÕES
            {

            }
            else if (menu.Tag.ToString().StartsWith(nomes_menu[5]))             // RELATÓRIO
            {

            }
            else if (menu.Tag.ToString().StartsWith(nomes_menu[6]))             // AJUDA
            {
                if (menu.Tag.ToString().ToUpper().Contains("SAIR"))
                {
                    this.Close();
                }
            }
        }

        private void ConfiguraMenu(string nomeMenu, ToolStripMenuItem menu)
        {
            menu.AutoSize = false;
            menu.Text = nomeMenu;
            menu.Width = 150;
            menu.Height = 49;
            menu.ForeColor = System.Drawing.Color.FromArgb(47, 47, 47);
            
            System.Drawing.FontFamily fontFamily = new System.Drawing.FontFamily("calibri");
            menu.Font = new Font(fontFamily, 10, FontStyle.Bold);
        }

        #region AdicionaBotoesRodape(Panel panel_rodape)
        //void AdicionaBotoesRodape(Panel panel_rodape)
        //{
        //    // 19 BOTÕES

        //    List<Button> botoes = new List<Button>();
        //    List<Image> images_rodape = new List<Image>();

        //    images_rodape.Add(Image.FromFile("planeta_32.ico"));
        //    images_rodape.Add(Image.FromFile("porta_32.ico"));
        //    images_rodape.Add(Image.FromFile("calentdario_rodape_32.ico"));
        //    images_rodape.Add(Image.FromFile("notas_32.ico"));
        //    images_rodape.Add(Image.FromFile("leitura_32.ico"));
        //    images_rodape.Add(Image.FromFile("pasta_32.ico"));
        //    images_rodape.Add(Image.FromFile("manutencao_32.ico"));
        //    images_rodape.Add(Image.FromFile("quadrado_bola_cubo.ico"));
        //    images_rodape.Add(Image.FromFile("escrever_32.ico"));
        //    images_rodape.Add(Image.FromFile("livro_a_b.ico"));
        //    images_rodape.Add(Image.FromFile("documento_32.ico"));
        //    images_rodape.Add(Image.FromFile("microfone_32.ico"));
        //    images_rodape.Add(Image.FromFile("monitor_32.ico"));
        //    images_rodape.Add(Image.FromFile("porta_2_32.ico"));
        //    images_rodape.Add(Image.FromFile("hexagono_32.ico"));
        //    images_rodape.Add(Image.FromFile("mouse_32.ico"));
        //    images_rodape.Add(Image.FromFile("botao_32.ico"));
        //    images_rodape.Add(Image.FromFile("telemarketing_32.ico"));
        //    images_rodape.Add(Image.FromFile("internet_explorer_32.ico"));

        //    int esquerda_botao = 70;

        //    for (int i = 0; i < 19; i++)
        //    {
        //        botoes.Add(new Button());

        //        botoes[i].FlatStyle = FlatStyle.Standard;
        //        botoes[i].Height = panel_rodape.Height - 7;
        //        botoes[i].Width = botoes[i].Height;
        //        botoes[i].BackColor = Color.White;
        //        botoes[i].BackgroundImageLayout = ImageLayout.Center;
        //        botoes[i].Image = images_rodape[i];

        //        panel_rodape.Controls.Add(botoes[i]);

        //        botoes[i].Left = esquerda_botao;
        //        botoes[i].Location = new Point(botoes[i].Left, (panel_rodape.Height / 2) - (botoes[i].Height / 2));

        //        if (i == 5 || i == 14)                
        //            esquerda_botao += botoes[i].Width + 15;                
        //        else                
        //            esquerda_botao += botoes[i].Width;               
        //    }
        //}
        #endregion


        void AdicionandoItensMenuLateral(Panel panel_lateral)
        {           
            List<Panel> panels = new List<Panel>();
            List<string> nomes_menus_lateral = new List<string>();

            //List<Button> botoes = new List<Button>();
            //List<Label> lbl_tela_de = new List<Label>();

            List<Image> images = new List<Image>();
            List<string> nomes_imagens = new List<string>();

            #region Alteração
            //List<string> nomes_botoes = new List<string>();
            //List<Label> lbl_nomes = new List<Label>();

            //nomes_botoes.Add("PAUTA DO DIA");           // 0
            //nomes_botoes.Add("ATA");                    // 1
            //nomes_botoes.Add("PALAVRA LIVRE");          // 2
            //nomes_botoes.Add("DISCUSSÃO");              // 3
            //nomes_botoes.Add("VOTAÇÃO");                // 4
            //nomes_botoes.Add("MENSAGENS");              // 5
            #endregion 

            nomes_menus_lateral = acessos.RetornaMenusLaterais();
            nomes_menus_lateral.Sort();

            for (int i = 0; i < nomes_menus_lateral.Count ; i++)
            {
                string nome = nomes_menus_lateral[i].ToString();
                nomes_imagens.Add(nome.Substring(nome.IndexOf('_') + 1, nome.Length - 2));

                images.Add(Image.FromFile(@"imagens\" + nomes_imagens[i] + ".jpg"));
            }


            int topo = panel_exibir_ao_publico.Top + panel_exibir_ao_publico.Height + 10;

            for (int i = 0; i < nomes_menus_lateral.Count; i++)
            {
                panels.Add(new Panel());                              
               
                panels[i].Height = 85;
                panels[i].Width = 95;
                panels[i].BackColor = System.Drawing.Color.FromArgb(215, 231, 246);
                panels[i].BorderStyle = BorderStyle.None;
                panels[i].BackgroundImage = images[i];
                panels[i].BackgroundImageLayout = ImageLayout.Stretch;
                panels[i].Click += Panels_menu_lateral_Click1;
                panels[i].Tag = nomes_imagens[i];

                #region ALTERAÇÃO
                //botoes.Add(new Button());
                //lbl_tela_de.Add(new Label());

                //lbl_nomes.Add(new Label());

                //botoes[i].Height = 45;
                //botoes[i].Width = 45;
                //botoes[i].BackColor = Color.White;
                //botoes[i].FlatStyle = FlatStyle.Standard;
                //botoes[i].BackgroundImage = images[i];
                //botoes[i].BackgroundImageLayout = ImageLayout.Center;
                //botoes[i].Tag = i;
                //botoes[i].Click += Form_principal_Click;

                //lbl_tela_de[i].Text = "Tela de";
                //lbl_tela_de[i].Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular);

                //panels[i].Controls.Add(botoes[i]);

                //botoes[i].Left = (panels[i].Width / 2) - (botoes[i].Width / 2);
                //botoes[i].Location = new Point(botoes[i].Left, 4);

                //panels[i].Controls.Add(lbl_tela_de[i]);

                //lbl_tela_de[i].AutoSize = true;
                //lbl_tela_de[i].Left = (panels[i].Width / 2) - (lbl_tela_de[i].Width / 2);
                //lbl_tela_de[i].Location = new Point(lbl_tela_de[i].Left, botoes[i].Top + botoes[i].Height);
                //lbl_tela_de[i].BackColor = Color.Transparent;

                //panels[i].Controls.Add(lbl_nomes[i]);

                //lbl_nomes[i].Text = nomes_botoes[i];
                //lbl_nomes[i].AutoSize = true;
                //lbl_nomes[i].Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular);
                //lbl_nomes[i].Left = (panels[i].Width / 2) - (lbl_nomes[i].Width / 2);
                //lbl_nomes[i].Location = new Point(lbl_nomes[i].Left, lbl_tela_de[i].Top + lbl_tela_de[i].Height);

                #endregion

                panel_lateral.Controls.Add(panels[i]);

                panels[i].Left = (panel_lateral.Width / 2) - (panels[i].Width / 2);
                

                panels[i].Location = new Point(panels[i].Left, topo);

                int resto = ((panel_menu_lateral.Height - (panel_exibir_ao_publico.Top + panel_exibir_ao_publico.Height)) + 10) - (panels[i].Height * 6);
                int espaco = resto / 8;

                if (espaco < 0)                
                    espaco = 10;
                
                topo += panels[i].Height + espaco;         
            }
        }

        private void Panels_menu_lateral_Click1(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;

            if (panel.Tag.ToString().ToUpper() == "DISCUSSAO")
            {
                Form_discusao form_ = new Form_discusao();
                form_.ShowDialog();
            }
        }

        //este código impede o usuário de redimensionar o formulário
        //protected override void WndProc(ref Message m)
        //{
        //    try
        //    {
        //        switch (m.Msg)
        //        {
        //            case 0x0112: // Esse é o codigo de uma mensagem referente a barra de titulo do formulario
        //                int command = m.WParam.ToInt32() & 0xfff0;
        //                // 0xF010 eh o codigo do comando "Restore"
        //                // 0xF120 eh o Duplo Clique da Barra
        //                if ((new int[] { 0xF010, 0xF120 }).Contains(command))
        //                {
        //                    // Se for executado qq um desses casos ignorar o comando (nao passar para o windows) ao menos q o form esteje minimizado.. ai continua...
        //                    if (this.WindowState != FormWindowState.Minimized) return;
        //                }
        //                break;
        //        }
        //        base.WndProc(ref m);
        //    }
        //    catch (Exception exe)
        //    {
        //        MessageBox.Show("[Metodo WndProc(ref Message m)] " + exe.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void Form_principal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }       

        private void pictureBox_exibir_ao_publico_Click(object sender, EventArgs e)
        {
            for (int i = left_panel; i <= this.Width; i++)
            {
                panel_menu_lateral.Left = i;
            }
            mostra_menu_lateral.BringToFront();
            mostra_menu_lateral.Visible = true;
        }

        private void Mostra_menu_lateral_Click(object sender, EventArgs e)
        {
            mostra_menu_lateral.Visible = false;

            for (int i = this.Width; i >= left_panel; i--)
            {
                panel_menu_lateral.Left = i;
            }                       
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override System.Drawing.Color MenuItemSelected
            {
                get { return System.Drawing.Color.FromArgb(234, 244, 253); }
            }
            public override System.Drawing.Color MenuItemSelectedGradientBegin
            {
                get { return System.Drawing.Color.FromArgb(234, 244, 253); }
            }
            public override System.Drawing.Color MenuItemSelectedGradientEnd
            {
                get { return System.Drawing.Color.FromArgb(234, 244, 253); }
            }
        }

        private void timer_hora_Tick(object sender, EventArgs e)
        {
            data = DateTime.Now;
            lbl_cab_hora.Text = String.Format("{0: HH}", data).Trim() + ":" + String.Format("{0: mm}", data).Trim();
            lbl_nome_cidade.Text = "JI-PARANÁ - RO " + String.Format("{0: dd}", data).Trim() + "/" + String.Format("{0: MM}", data).Trim() + "/" + String.Format("{0: yyyy}", data).Trim();
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

    }
}
