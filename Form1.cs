using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EGP_PAINEL.Classes;
using EGP_PAINEL.Formularios;
using EGP_Tela_Inicial_04_02.Formulario_login_inicial;

namespace EGP_Tela_Inicial_04_02
{
    public partial class Form_principal : Form
    {
        int left_panel;
        PictureBox mostra_menu_lateral;

        string[] nomes_menu;



        string[] itens_configuracao_nomes;
       


        public Form_principal()
        {         
            InitializeComponent();            
        }
        // ESTUDAR A QUESTÃO DOS MDI INTERFACE DE MULTIPLAS TELAS


        private void Form_principal_Load(object sender, EventArgs e)
        {
           
            DesenhaTelaInicial();
            mostra_menu_lateral = new PictureBox();
            mostra_menu_lateral.Height = 30;
            mostra_menu_lateral.Width = 30;

            mostra_menu_lateral.BorderStyle = BorderStyle.None;

            this.Controls.Add(mostra_menu_lateral);

            mostra_menu_lateral.Location = new Point(panel_cab_3.Width - mostra_menu_lateral.Width, (panel_cab_3.Height + panel_cab_3.Top) + ((menuStrip_principal.Height / 2) - (mostra_menu_lateral.Height / 2)));
            mostra_menu_lateral.Visible = false;

            mostra_menu_lateral.Click += Mostra_menu_lateral_Click;
            mostra_menu_lateral.MouseEnter += Mostra_menu_lateral_MouseEnter;
            mostra_menu_lateral.MouseLeave += Mostra_menu_lateral_MouseLeave;
            toolTip1.SetToolTip(mostra_menu_lateral, "Clique para abrir o menu lateral");

            mostra_menu_lateral.Image = Image.FromFile("exibir_ao_publico_esquerda.png");
            mostra_menu_lateral.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Mostra_menu_lateral_MouseLeave(object sender, EventArgs e)
        {
            mostra_menu_lateral.BorderStyle = BorderStyle.None;
        }

        private void Mostra_menu_lateral_MouseEnter(object sender, EventArgs e)
        {
            mostra_menu_lateral.BorderStyle = BorderStyle.FixedSingle;
        }

        void DesenhaTelaInicial()
        {
            this.BackColor = Color.FromArgb(250, 254, 255);

            // cabeçalho, logos etc

            panel_cab_1.Height = 58;
            panel_cab_1.BackColor = Color.FromArgb(253, 254, 255);

            pictureBox_logo.Width = 240;
            pictureBox_logo.Height = panel_cab_1.Height;
            pictureBox_logo.Left = 0;
            pictureBox_logo.Location = new Point(0, 0);

            int largura_divisorias = 10;

            pictureBox_div_1.Height = panel_cab_1.Height;
            pictureBox_div_1.Left = pictureBox_logo.Left + pictureBox_logo.Width;
            pictureBox_div_1.Width = largura_divisorias;
            pictureBox_div_1.Location = new Point(pictureBox_div_1.Left, 0);

            pictureBox_versao.Height = panel_cab_1.Height;
            pictureBox_versao.Width = 70;
            pictureBox_versao.Left = pictureBox_div_1.Left + pictureBox_div_1.Width + 10;
            pictureBox_versao.Location = new Point(pictureBox_versao.Left, 0);

            pictureBox_div_2.Height = panel_cab_1.Height;
            pictureBox_div_2.Left = pictureBox_versao.Left + pictureBox_versao.Width + 13;
            pictureBox_div_2.Width = largura_divisorias;
            pictureBox_div_2.Location = new Point(pictureBox_div_2.Left + 6, 0);

            lbl_nome_camara.AutoSize = true;
            lbl_nome_camara.Text = "CÂMARA MUNICIPAL DE JI-PARANÁ";
            lbl_nome_camara.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            lbl_nome_camara.ForeColor = Color.FromArgb(46, 84, 123);

            panel_cab_camara.Width = lbl_nome_camara.Width + 25;
            panel_cab_camara.Height = panel_cab_1.Height;
            panel_cab_camara.Left = pictureBox_div_2.Left + pictureBox_div_2.Width;
            panel_cab_camara.Location = new Point(panel_cab_camara.Left, 0);

            lbl_nome_camara.Left = (panel_cab_camara.Width / 2) - (lbl_nome_camara.Width / 2);
            lbl_nome_camara.Location = new Point(lbl_nome_camara.Left, (panel_cab_camara.Height / 2) - (lbl_nome_camara.Height / 2));

            pictureBox_div_3.Left = panel_cab_camara.Left + panel_cab_camara.Width;
            pictureBox_div_3.Height = panel_cab_1.Height;
            pictureBox_div_3.Width = largura_divisorias;
            pictureBox_div_3.Location = new Point(pictureBox_div_3.Left + 6, 0);

            lbl_usuario.AutoSize = true;
            lbl_usuario.Text = "Usuário:";
            lbl_usuario.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            lbl_usuario.ForeColor = Color.FromArgb(46, 84, 123);

            lbl_nome_usuario.AutoSize = true;
            lbl_nome_usuario.Text = "Evando de Souza";
            lbl_nome_usuario.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            lbl_nome_usuario.ForeColor = Color.FromArgb(46, 84, 123);

            panel_cab_usuario.Left = pictureBox_div_3.Left + pictureBox_div_3.Width;
            panel_cab_usuario.Width = lbl_usuario.Width + lbl_nome_usuario.Width + 20;
            panel_cab_usuario.Height = panel_cab_1.Height;
            panel_cab_usuario.Location = new Point(panel_cab_usuario.Left, 0);

            lbl_usuario.Left = (panel_cab_usuario.Width / 2) - ((lbl_usuario.Width + lbl_nome_usuario.Width) / 2);
            lbl_usuario.Location = new Point(lbl_usuario.Left, (panel_cab_usuario.Height / 2) - (lbl_usuario.Height / 2));

            lbl_nome_usuario.Left = lbl_usuario.Left + lbl_usuario.Width;
            lbl_nome_usuario.Top = lbl_usuario.Top;

            pictureBox_div_4.Left = panel_cab_usuario.Left + panel_cab_usuario.Width + 6;
            pictureBox_div_4.Width = largura_divisorias;
            pictureBox_div_4.Height = panel_cab_1.Height;
            pictureBox_div_4.Location = new Point(pictureBox_div_4.Left, 0);

            panel_cab_notificacoes.Left = pictureBox_div_4.Left + pictureBox_div_4.Width;
            panel_cab_notificacoes.Height = panel_cab_1.Height;
            panel_cab_notificacoes.Width = 180;
            panel_cab_notificacoes.Location = new Point(panel_cab_notificacoes.Left, 0);

            pictureBox_div_5.Left = panel_cab_notificacoes.Left + panel_cab_notificacoes.Width;
            pictureBox_div_5.Width = largura_divisorias;
            pictureBox_div_5.Height = panel_cab_1.Height;
            pictureBox_div_5.Location = new Point(pictureBox_div_5.Left, 0);

            lbl_suporte.Text = "Suporte:";
            lbl_suporte.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            lbl_suporte.ForeColor = Color.FromArgb(46, 84, 123);

            lbl_telefone_suporte.Text = "(69) 3536.9000";
            lbl_telefone_suporte.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            lbl_telefone_suporte.ForeColor = Color.FromArgb(46, 84, 123);

            panel_cab_suporte.Left = pictureBox_div_5.Left + pictureBox_div_5.Width + 13;
            panel_cab_suporte.Height = panel_cab_1.Height;
            panel_cab_suporte.Location = new Point(panel_cab_suporte.Left, 0);

            pictureBox_icone_suporte.Width = 20;

            panel_cab_suporte.Width = lbl_suporte.Width + lbl_telefone_suporte.Width + pictureBox_icone_suporte.Width + 10;

            pictureBox_icone_suporte.Left = (panel_cab_suporte.Width / 2) - ((lbl_suporte.Width + lbl_telefone_suporte.Width + pictureBox_icone_suporte.Width) / 2);
            pictureBox_icone_suporte.Height = pictureBox_icone_suporte.Width;
            pictureBox_icone_suporte.Location = new Point(pictureBox_icone_suporte.Left, (panel_cab_suporte.Height / 2) - (pictureBox_icone_suporte.Height / 2));
            pictureBox_icone_suporte.BorderStyle = BorderStyle.None;

            lbl_suporte.Left = pictureBox_icone_suporte.Left + pictureBox_icone_suporte.Width;
            lbl_suporte.Location = new Point(lbl_suporte.Left, (panel_cab_suporte.Height / 2) - (lbl_suporte.Height / 2));

            lbl_telefone_suporte.Left = lbl_suporte.Left + lbl_suporte.Width;
            lbl_telefone_suporte.Location = new Point(lbl_telefone_suporte.Left, lbl_suporte.Top);

            pictureBox_div_6.Left = panel_cab_suporte.Left + panel_cab_suporte.Width + 15;
            pictureBox_div_6.Height = panel_cab_1.Height;
            pictureBox_div_6.Width = largura_divisorias;
            pictureBox_div_6.Location = new Point(pictureBox_div_6.Left, 0);

            // barras coloridas

            int barras_altura = 7;

            panel_cab_2.BackColor = Color.FromArgb(243, 130, 34);
            panel_cab_2.Height = barras_altura;

            panel_cab_3.BackColor = Color.FromArgb(28, 82, 116);
            panel_cab_3.Height = barras_altura;


            panel_roda_1.Height = barras_altura;
            panel_roda_1.BackColor = Color.FromArgb(250, 254, 253);

            panel_roda_2.Height = barras_altura;
            panel_roda_2.BackColor = Color.FromArgb(0, 87, 133);

            panel_roda_3.Height = barras_altura;
            panel_roda_3.BackColor = Color.FromArgb(243, 129, 33);

            panel_menu_inferior.Height = 53;
            panel_menu_inferior.AutoScroll = true;
            panel_menu_inferior.BackColor = Color.FromArgb(234, 244, 253);

            // CONFIGURAÇÃO DA INFORMAÇÃO DO ULTIMO BACKUP

            panel_ultimo_backup.Height = panel_menu_inferior.Height;
            panel_ultimo_backup.Width = 300;
            panel_ultimo_backup.Left = panel_menu_inferior.Width - panel_ultimo_backup.Width;
            panel_ultimo_backup.Top = 0;
            panel_ultimo_backup.BackColor = Color.FromArgb(234, 244, 253);
            panel_ultimo_backup.BorderStyle = BorderStyle.None;

            lbl_ultimo_backup.Text = "Último Backup realizado";
            lbl_ultimo_backup.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);
            lbl_ultimo_backup.AutoSize = true;
            lbl_ultimo_backup.ForeColor = Color.FromArgb(143, 143, 146);

            pictureBox_backup.Height = panel_ultimo_backup.Height - 17;
            pictureBox_backup.Width = pictureBox_backup.Height;
            pictureBox_backup.BorderStyle = BorderStyle.None;
            pictureBox_backup.Left = (panel_ultimo_backup.Width / 2) - ((lbl_ultimo_backup.Width + pictureBox_backup.Width) / 2);
            pictureBox_backup.Top = (panel_ultimo_backup.Height / 2) - (pictureBox_backup.Height / 2);
            pictureBox_backup.SizeMode = PictureBoxSizeMode.StretchImage;

            lbl_data_backup.Text = "08.02.2021";
            lbl_data_backup.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold);
            lbl_data_backup.AutoSize = true;
            lbl_data_backup.ForeColor = Color.FromArgb(143,143,146);

            lbl_dia.Text = "Dia ";
            lbl_dia.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);
            lbl_dia.AutoSize = true;
            lbl_dia.ForeColor = Color.FromArgb(143, 143, 146);

            lbl_ultimo_backup.Left = pictureBox_backup.Left + pictureBox_backup.Width + 10;
            lbl_ultimo_backup.Top = (panel_ultimo_backup.Height / 2) - ((lbl_ultimo_backup.Height + lbl_dia.Height) / 2);

            lbl_dia.Left = (lbl_ultimo_backup.Left + (lbl_ultimo_backup.Width / 2)) - ((lbl_dia.Width + lbl_data_backup.Width) / 2);
            lbl_dia.Top = lbl_ultimo_backup.Top + lbl_ultimo_backup.Height;

            lbl_data_backup.Left = lbl_dia.Left + lbl_dia.Width;
            lbl_data_backup.Top = lbl_dia.Top;

            // menu lateral direita 


            panel_exibir_ao_publico.Height = 38;
            panel_exibir_ao_publico.BackColor = Color.FromArgb(239, 239, 239);

            lbl_exibir_ao_publico.Text = "EXIBIR AO PÚBLICO";
            lbl_exibir_ao_publico.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
            lbl_exibir_ao_publico.ForeColor = Color.FromArgb(46, 84, 123);

            pictureBox_exibir_ao_publico.Width = 18;
            pictureBox_exibir_ao_publico.Height = 18;
            pictureBox_exibir_ao_publico.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_exibir_ao_publico.BorderStyle = BorderStyle.None;

            panel_menu_lateral.Height = panel_menu_inferior.Top - (panel_cab_3.Top + panel_cab_3.Height);
            panel_menu_lateral.Width = lbl_exibir_ao_publico.Width + pictureBox_exibir_ao_publico.Width + 55;
            panel_menu_lateral.Left = panel_cab_3.Width - panel_menu_lateral.Width;
            panel_menu_lateral.Location = new Point(panel_menu_lateral.Left, panel_cab_3.Top + panel_cab_3.Height);
            panel_menu_lateral.BackColor = Color.FromArgb(234, 244, 253);
            panel_menu_lateral.BorderStyle = BorderStyle.FixedSingle;

            pictureBox_exibir_ao_publico.Left = (panel_menu_lateral.Width / 2) - ((lbl_exibir_ao_publico.Width + pictureBox_exibir_ao_publico.Width) / 2);
            pictureBox_exibir_ao_publico.Location = new Point(pictureBox_exibir_ao_publico.Left, (panel_exibir_ao_publico.Height / 2) - (pictureBox_exibir_ao_publico.Height / 2));

            lbl_exibir_ao_publico.Left = pictureBox_exibir_ao_publico.Left + pictureBox_exibir_ao_publico.Width;
            lbl_exibir_ao_publico.Location = new Point(lbl_exibir_ao_publico.Left, (panel_exibir_ao_publico.Height / 2) - (lbl_exibir_ao_publico.Height / 2));

            // menu

            menuStrip_principal.Left = 0;
            menuStrip_principal.Height = 50;
            menuStrip_principal.Width = panel_cab_3.Width;
            menuStrip_principal.Location = new Point(menuStrip_principal.Left, panel_cab_3.Top + panel_cab_3.Height);
            menuStrip_principal.BackColor = Color.FromArgb(234, 244, 253);

            // cadastro 1          

            nomes_menu = new string[7] { "CADASTRO 1", "CADASTRO 2", "CADASTRO 3", "CADASTRO 4", "CADASTRO 5", "CONFIGURAÇÃO", "AJUDA" };

            menu_cadastro_1.Tag      = 0;
            menu_cadastro_2.Tag      = 1;
            menu_cadastro_3.Tag      = 2;
            menu_cadastro_4.Tag      = 3;
            menu_cadastro_5.Tag      = 4;
            menu_configuracoes_6.Tag = 5;
            menu_ajuda_7.Tag         = 6;

            ConfiguraMenu(nomes_menu[0], menu_cadastro_1);
            ConfiguraMenu(nomes_menu[1], menu_cadastro_2);
            ConfiguraMenu(nomes_menu[2], menu_cadastro_3);
            ConfiguraMenu(nomes_menu[3], menu_cadastro_4);
            ConfiguraMenu(nomes_menu[4], menu_cadastro_5);
            ConfiguraMenu(nomes_menu[5], menu_configuracoes_6);
            ConfiguraMenu(nomes_menu[6], menu_ajuda_7);

            // itens menu CONFIGURAÇÃO

            // icones da lista suspensa
            

            //Image image_cad = Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\meu_cadastro.ico");
            //Image image_senha = Image.FromFile(Directory.GetCurrentDirectory() +  @"\Icones\trocar_senha.ico");
            //Image image_abrir_chamado = Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\abrir_chamado.ico");
            //Image image_novidades = Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\novidades.ico");
            //Image image_mesa_diretora = Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\mesa_diretora_sair.ico");
            //Image image_vereadores = Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\vereadores.ico");
            //Image image_backup = Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\backup.ico");
            //Image image_sair = Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\mesa_diretora_sair.ico");

            // Imagens do menu Configurações_6

            Image[] itens_configuracao_images = new Image[8] {  Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\meu_cadastro.ico"),
                                                                Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\trocar_senha.ico"),
                                                                Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\abrir_chamado.ico"),
                                                                Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\novidades.ico"),
                                                                Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\mesa_diretora_sair.ico"),
                                                                Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\vereadores.ico"),
                                                                Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\backup.ico"),
                                                                Image.FromFile(Directory.GetCurrentDirectory() + @"\Icones\mesa_diretora_sair.ico")};

            itens_configuracao_nomes = new string[8] {  "Meu cadastro",
                                                        "Trocar senha",
                                                        "Abrir chamado",
                                                        "Novidades",
                                                        "Mesa diretora",
                                                        "Vereadores",
                                                        "Backup",
                                                        "Sair"};

            AddItensSuspensosMenu(menu_configuracoes_6, itens_configuracao_nomes, itens_configuracao_images);

            //ToolStripSeparator linha_separadora_1 = new ToolStripSeparator();
            //ToolStripSeparator linha_separadora_2 = new ToolStripSeparator();
            //ToolStripSeparator linha_separadora_3 = new ToolStripSeparator();
            //ToolStripSeparator linha_separadora_4 = new ToolStripSeparator();
            //ToolStripSeparator linha_separadora_5 = new ToolStripSeparator();
            //ToolStripSeparator linha_separadora_6 = new ToolStripSeparator();
            //ToolStripSeparator linha_separadora_7 = new ToolStripSeparator();         

            //ToolStripMenuItem item_meu_cadastro = new ToolStripMenuItem("Meu cadastro", image_cad, new EventHandler(item_meu_cadastro_click));
            //ToolStripMenuItem item_trocar_senha = new ToolStripMenuItem("Trocar senha", image_senha, new EventHandler(item_trocar_senha_click));
            //ToolStripMenuItem item_abrir_chamado = new ToolStripMenuItem("Abrir chamado", image_abrir_chamado, new EventHandler(item_abrir_chamado_click));
            //ToolStripMenuItem item_novidaes = new ToolStripMenuItem("Novidades", image_novidades, new EventHandler(item_novidaes_click));
            //ToolStripMenuItem item_mesa_diretora = new ToolStripMenuItem("Mesa Diretora", image_mesa_diretora, new EventHandler(item_mesa_diretora_click));
            //ToolStripMenuItem item_vereadores = new ToolStripMenuItem("Vereadores", image_vereadores, new EventHandler(item_vereadores_click));
            //ToolStripMenuItem item_backup = new ToolStripMenuItem("Backup", image_backup, new EventHandler(item_backup_click));
            //ToolStripMenuItem item_sair = new ToolStripMenuItem("Sair", image_sair, new EventHandler(item_sair_click));

            //((ToolStripDropDownMenu)(menu_configuracoes_6.DropDown)).ShowImageMargin = true;
            //((ToolStripDropDownMenu)(menu_configuracoes_6.DropDown)).ShowCheckMargin = false;

            //menu_configuracoes_6.DropDownItems.Add(item_meu_cadastro);
            //menu_configuracoes_6.DropDownItems.Add(linha_separadora_1);
            //menu_configuracoes_6.DropDownItems.Add(item_trocar_senha);
            //menu_configuracoes_6.DropDownItems.Add(linha_separadora_2);
            //menu_configuracoes_6.DropDownItems.Add(item_abrir_chamado);
            //menu_configuracoes_6.DropDownItems.Add(linha_separadora_3);
            //menu_configuracoes_6.DropDownItems.Add(item_novidaes);
            //menu_configuracoes_6.DropDownItems.Add(linha_separadora_4);
            //menu_configuracoes_6.DropDownItems.Add(item_mesa_diretora);
            //menu_configuracoes_6.DropDownItems.Add(linha_separadora_5);
            //menu_configuracoes_6.DropDownItems.Add(item_vereadores);
            //menu_configuracoes_6.DropDownItems.Add(linha_separadora_6);
            //menu_configuracoes_6.DropDownItems.Add(item_backup);
            //menu_configuracoes_6.DropDownItems.Add(linha_separadora_7);
            //menu_configuracoes_6.DropDownItems.Add(item_sair);

            left_panel = panel_cab_3.Width - panel_menu_lateral.Width;

            AdicionandoItensMenuLateral(panel_menu_lateral);
            AdicionaBotoesRodape(panel_menu_inferior);
                      
        }

        void AddItensSuspensosMenu(ToolStripMenuItem menu, string [] nomes, Image[] imagens)
        {
            List<ToolStripSeparator> separadores = new List<ToolStripSeparator>();
            List<ToolStripMenuItem> itens = new List<ToolStripMenuItem>();

            for (int i = 0; i < nomes.Length; i++)
            {
                separadores.Add(new ToolStripSeparator());
                itens.Add(new ToolStripMenuItem(nomes[i], imagens[i], new EventHandler(Itens_menu_click)));

                itens[i].Tag = nomes_menu[(int)menu.Tag].ToString() + "_" + nomes[i];

                menu.DropDownItems.Add(itens[i]);
                menu.DropDownItems.Add(separadores[i]);
            }

            ((ToolStripDropDownMenu)(menu.DropDown)).ShowImageMargin = true;
            ((ToolStripDropDownMenu)(menu.DropDown)).ShowCheckMargin = false;
        }

        void Itens_menu_click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;

            if (menu.Tag.ToString().StartsWith(nomes_menu[0]))
            {
               
            }
            else if (menu.Tag.ToString().StartsWith(nomes_menu[1]))
            {

            }
            else if (menu.Tag.ToString().StartsWith(nomes_menu[2]))
            {

            }
            else if (menu.Tag.ToString().StartsWith(nomes_menu[3]))
            {

            }
            else if (menu.Tag.ToString().StartsWith(nomes_menu[4]))
            {

            }
            else if (menu.Tag.ToString().StartsWith(nomes_menu[5]))
            {
                if (menu.Tag.ToString().Contains(itens_configuracao_nomes[0]))
                {
                    form_cadastro_participante form_Cadastro_Participante = new form_cadastro_participante();
                    form_Cadastro_Participante.ShowDialog();
                }
            }
            else if (menu.Tag.ToString().StartsWith(nomes_menu[6]))
            {

            }
        }


        private void ConfiguraMenu(string nomeMenu, ToolStripMenuItem menu)
        {
            menu.AutoSize = false;
            menu.Text = nomeMenu;
            menu.Width = 150;
            menu.ForeColor = Color.FromArgb(55, 62, 70);
            menu.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);
        }

        void AdicionaBotoesRodape(Panel panel_rodape)
        {
            // 19 BOTÕES
            
            List<Button> botoes = new List<Button>();
            List<Image> images_rodape = new List<Image>();

            images_rodape.Add(Image.FromFile("planeta_32.ico"));
            images_rodape.Add(Image.FromFile("porta_32.ico"));
            images_rodape.Add(Image.FromFile("calentdario_rodape_32.ico"));
            images_rodape.Add(Image.FromFile("notas_32.ico"));
            images_rodape.Add(Image.FromFile("leitura_32.ico"));
            images_rodape.Add(Image.FromFile("pasta_32.ico"));
            images_rodape.Add(Image.FromFile("manutencao_32.ico"));
            images_rodape.Add(Image.FromFile("quadrado_bola_cubo.ico"));
            images_rodape.Add(Image.FromFile("escrever_32.ico"));
            images_rodape.Add(Image.FromFile("livro_a_b.ico"));
            images_rodape.Add(Image.FromFile("documento_32.ico"));
            images_rodape.Add(Image.FromFile("microfone_32.ico"));
            images_rodape.Add(Image.FromFile("monitor_32.ico"));
            images_rodape.Add(Image.FromFile("porta_2_32.ico"));
            images_rodape.Add(Image.FromFile("hexagono_32.ico"));
            images_rodape.Add(Image.FromFile("mouse_32.ico"));
            images_rodape.Add(Image.FromFile("botao_32.ico"));
            images_rodape.Add(Image.FromFile("telemarketing_32.ico"));
            images_rodape.Add(Image.FromFile("internet_explorer_32.ico"));

            int esquerda_botao = 70;

            for (int i = 0; i < 19; i++)
            {
                botoes.Add(new Button());

                botoes[i].FlatStyle = FlatStyle.Standard;
                botoes[i].Height = panel_rodape.Height - 7;
                botoes[i].Width = botoes[i].Height;
                botoes[i].BackColor = Color.White;
                botoes[i].BackgroundImageLayout = ImageLayout.Center;
                botoes[i].Image = images_rodape[i];

                panel_rodape.Controls.Add(botoes[i]);

                botoes[i].Left = esquerda_botao;
                botoes[i].Location = new Point(botoes[i].Left, (panel_rodape.Height / 2) - (botoes[i].Height / 2));

                if (i == 5 || i == 14)                
                    esquerda_botao += botoes[i].Width + 15;                
                else                
                    esquerda_botao += botoes[i].Width;               
            }
        }

        void AdicionandoItensMenuLateral(Panel panel_lateral)
        {
            List<Panel> panels = new List<Panel>();
            List<Button> botoes = new List<Button>();
            List<Label> lbl_tela_de = new List<Label>();
            List<Image> images = new List<Image>();

            List<string> nomes_botoes = new List<string>();
            List<Label> lbl_nomes = new List<Label>();

            nomes_botoes.Add("PAUTA DO DIA");           // 0
            nomes_botoes.Add("ATA");                    // 1
            nomes_botoes.Add("PALAVRA LIVRE");          // 2
            nomes_botoes.Add("DISCUSSÃO");              // 3
            nomes_botoes.Add("VOTAÇÃO");                // 4
            nomes_botoes.Add("MENSAGENS");              // 5

            images.Add(Image.FromFile("calendario_32.ico"));
            images.Add(Image.FromFile("ata_32.ico"));
            images.Add(Image.FromFile("palavra_livre_32.ico"));
            images.Add(Image.FromFile("discussao_32.ico"));
            images.Add(Image.FromFile("votacao_32.ico"));
            images.Add(Image.FromFile("mensagens_32.ico"));

            int topo = panel_exibir_ao_publico.Top + panel_exibir_ao_publico.Height + 10;

            for (int i = 0; i < 6; i++)
            {
                panels.Add(new Panel());
                botoes.Add(new Button());
                lbl_tela_de.Add(new Label());

                lbl_nomes.Add(new Label());
               
                panels[i].Height = 75;
                panels[i].Width = 95;
                panels[i].BackColor = Color.FromArgb(215, 231, 246);
                panels[i].BorderStyle = BorderStyle.None;

                botoes[i].Height = 45;
                botoes[i].Width = 45;
                botoes[i].BackColor = Color.White;
                botoes[i].FlatStyle = FlatStyle.Standard;
                botoes[i].BackgroundImage = images[i];
                botoes[i].BackgroundImageLayout = ImageLayout.Center;
                botoes[i].Tag = i;
                botoes[i].Click += Form_principal_Click;

                lbl_tela_de[i].Text = "Tela de";
                lbl_tela_de[i].Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular);

                panels[i].Controls.Add(botoes[i]);
               
                botoes[i].Left = (panels[i].Width / 2) - (botoes[i].Width / 2);
                botoes[i].Location = new Point(botoes[i].Left, 4);

                panels[i].Controls.Add(lbl_tela_de[i]);

                lbl_tela_de[i].AutoSize = true;
                lbl_tela_de[i].Left = (panels[i].Width / 2) - (lbl_tela_de[i].Width / 2);
                lbl_tela_de[i].Location = new Point(lbl_tela_de[i].Left, botoes[i].Top + botoes[i].Height);
                lbl_tela_de[i].BackColor = Color.Transparent;

                panels[i].Controls.Add(lbl_nomes[i]);

                lbl_nomes[i].Text = nomes_botoes[i];
                lbl_nomes[i].AutoSize = true;
                lbl_nomes[i].Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular);
                lbl_nomes[i].Left = (panels[i].Width / 2) - (lbl_nomes[i].Width / 2);
                lbl_nomes[i].Location = new Point(lbl_nomes[i].Left, lbl_tela_de[i].Top + lbl_tela_de[i].Height);

                panel_lateral.Controls.Add(panels[i]);

                panels[i].Left = (panel_lateral.Width / 2) - (panels[i].Width / 2);

                panels[i].Location = new Point(panels[i].Left, topo);

                topo += panels[i].Height + 7;
            }
        }

        private void Form_principal_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;

            if ((int)botao.Tag == 3)
            {
                Form_discusao form_ = new Form_discusao();
                form_.ShowDialog();
            }            
        }

        void item_sair_click(object sender, EventArgs e)
        {
            this.Close();
        }

        void item_backup_click(object sender, EventArgs e)
        {

        }

        void item_vereadores_click(object sender, EventArgs e)
        {

        }

        void item_mesa_diretora_click(object sender, EventArgs e)
        {

        }

        void item_novidaes_click(object sender, EventArgs e)
        {

        }

        void item_abrir_chamado_click(object sender, EventArgs e)
        {
             
        }

        void item_meu_cadastro_click(object sender, EventArgs e)
        {
            form_cadastro_participante form_Cadastro_Participante = new form_cadastro_participante();
            form_Cadastro_Participante.ShowDialog();
        }

        void item_trocar_senha_click(object sender, EventArgs e)
        { 

        }             
       
        // este código impede o usuário de redimensionar o formulário
        protected override void WndProc(ref Message m) 
        {
            switch (m.Msg)
            {
                case 0x0112: // Esse é o codigo de uma mensagem referente a barra de titulo do formulario
                    int command = m.WParam.ToInt32() & 0xfff0;
                    // 0xF010 eh o codigo do comando "Restore"
                    // 0xF120 eh o Duplo Clique da Barra
                    if ((new int[] { 0xF010, 0xF120 }).Contains(command))
                    {
                        // Se for executado qq um desses casos ignorar o comando (nao passar para o windows) ao menos q o form esteje minimizado.. ai continua...
                        if (this.WindowState != FormWindowState.Minimized) return;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void Form_principal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }       

        private void pictureBox_exibir_ao_publico_Click(object sender, EventArgs e)
        {
            for (int i = left_panel; i <= panel_cab_3.Width; i++)
            {
                panel_menu_lateral.Left = i;
            }
            mostra_menu_lateral.BringToFront();
            mostra_menu_lateral.Visible = true;
        }

        private void Mostra_menu_lateral_Click(object sender, EventArgs e)
        {
            mostra_menu_lateral.Visible = false;

            for (int i = panel_cab_3.Width; i >= left_panel; i--)
            {
                panel_menu_lateral.Left = i;
            }                       
        }
    }
}
