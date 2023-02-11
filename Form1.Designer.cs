namespace EGP_Tela_Inicial_04_02
{
    partial class Form_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_principal));
            this.panel_cab_1 = new System.Windows.Forms.Panel();
            this.panel_cab_usuario = new System.Windows.Forms.Panel();
            this.lbl_nome_usuario = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.panel_cab_camara = new System.Windows.Forms.Panel();
            this.lbl_nome_cidade = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_menu_lateral = new System.Windows.Forms.Panel();
            this.iconPictureBox_exibir_ao_publico = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_exibir_no_painel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer_hora = new System.Windows.Forms.Timer(this.components);
            this.mzSombraPanel_menu_superior = new MZControls.MZSombraPanel();
            this.pictureBox_logo_camara = new System.Windows.Forms.PictureBox();
            this.mzSombraPanel_lateral_esquerda = new System.Windows.Forms.Panel();
            this.panel_cab_1.SuspendLayout();
            this.panel_cab_usuario.SuspendLayout();
            this.panel_cab_camara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_menu_lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_exibir_ao_publico)).BeginInit();
            this.mzSombraPanel_menu_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo_camara)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cab_1
            // 
            this.panel_cab_1.AutoScroll = true;
            this.panel_cab_1.Controls.Add(this.panel_cab_usuario);
            this.panel_cab_1.Controls.Add(this.panel_cab_camara);
            this.panel_cab_1.Controls.Add(this.pictureBox_logo);
            this.panel_cab_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cab_1.Location = new System.Drawing.Point(0, 0);
            this.panel_cab_1.Name = "panel_cab_1";
            this.panel_cab_1.Size = new System.Drawing.Size(870, 64);
            this.panel_cab_1.TabIndex = 0;
            // 
            // panel_cab_usuario
            // 
            this.panel_cab_usuario.Controls.Add(this.lbl_nome_usuario);
            this.panel_cab_usuario.Controls.Add(this.lbl_usuario);
            this.panel_cab_usuario.Location = new System.Drawing.Point(0, 0);
            this.panel_cab_usuario.Name = "panel_cab_usuario";
            this.panel_cab_usuario.Size = new System.Drawing.Size(227, 64);
            this.panel_cab_usuario.TabIndex = 6;
            this.panel_cab_usuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover_tela_cabecalho_MouseDown);
            // 
            // lbl_nome_usuario
            // 
            this.lbl_nome_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nome_usuario.AutoSize = true;
            this.lbl_nome_usuario.Location = new System.Drawing.Point(62, 26);
            this.lbl_nome_usuario.Name = "lbl_nome_usuario";
            this.lbl_nome_usuario.Size = new System.Drawing.Size(95, 13);
            this.lbl_nome_usuario.TabIndex = 2;
            this.lbl_nome_usuario.Text = "Evandro de Souza";
            this.lbl_nome_usuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover_tela_cabecalho_MouseDown);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(20, 26);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(46, 13);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "Usuário:";
            this.lbl_usuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover_tela_cabecalho_MouseDown);
            // 
            // panel_cab_camara
            // 
            this.panel_cab_camara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_cab_camara.Controls.Add(this.lbl_nome_cidade);
            this.panel_cab_camara.Location = new System.Drawing.Point(617, 0);
            this.panel_cab_camara.Name = "panel_cab_camara";
            this.panel_cab_camara.Size = new System.Drawing.Size(250, 64);
            this.panel_cab_camara.TabIndex = 4;
            this.panel_cab_camara.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover_tela_cabecalho_MouseDown);
            // 
            // lbl_nome_cidade
            // 
            this.lbl_nome_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nome_cidade.Location = new System.Drawing.Point(30, 23);
            this.lbl_nome_cidade.Name = "lbl_nome_cidade";
            this.lbl_nome_cidade.Size = new System.Drawing.Size(189, 13);
            this.lbl_nome_cidade.TabIndex = 1;
            this.lbl_nome_cidade.Text = "CÂMARA MUNICIPAL DE JI-PARANÁ";
            this.lbl_nome_cidade.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover_tela_cabecalho_MouseDown);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(369, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(165, 64);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            this.pictureBox_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover_tela_cabecalho_MouseDown);
            // 
            // panel_menu_lateral
            // 
            this.panel_menu_lateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_menu_lateral.AutoScroll = true;
            this.panel_menu_lateral.Controls.Add(this.iconPictureBox_exibir_ao_publico);
            this.panel_menu_lateral.Controls.Add(this.lbl_exibir_no_painel);
            this.panel_menu_lateral.Location = new System.Drawing.Point(700, 195);
            this.panel_menu_lateral.Margin = new System.Windows.Forms.Padding(0);
            this.panel_menu_lateral.Name = "panel_menu_lateral";
            this.panel_menu_lateral.Size = new System.Drawing.Size(158, 278);
            this.panel_menu_lateral.TabIndex = 8;
            // 
            // iconPictureBox_exibir_ao_publico
            // 
            this.iconPictureBox_exibir_ao_publico.BackColor = System.Drawing.Color.White;
            this.iconPictureBox_exibir_ao_publico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox_exibir_ao_publico.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconPictureBox_exibir_ao_publico.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox_exibir_ao_publico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_exibir_ao_publico.IconSize = 38;
            this.iconPictureBox_exibir_ao_publico.Location = new System.Drawing.Point(7, 12);
            this.iconPictureBox_exibir_ao_publico.Name = "iconPictureBox_exibir_ao_publico";
            this.iconPictureBox_exibir_ao_publico.Size = new System.Drawing.Size(47, 38);
            this.iconPictureBox_exibir_ao_publico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox_exibir_ao_publico.TabIndex = 2;
            this.iconPictureBox_exibir_ao_publico.TabStop = false;
            this.iconPictureBox_exibir_ao_publico.Click += new System.EventHandler(this.pictureBox_exibir_ao_publico_Click);
            // 
            // lbl_exibir_no_painel
            // 
            this.lbl_exibir_no_painel.AutoSize = true;
            this.lbl_exibir_no_painel.Location = new System.Drawing.Point(57, 22);
            this.lbl_exibir_no_painel.Name = "lbl_exibir_no_painel";
            this.lbl_exibir_no_painel.Size = new System.Drawing.Size(79, 13);
            this.lbl_exibir_no_painel.TabIndex = 1;
            this.lbl_exibir_no_painel.Text = "Exibir no Painel";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Menu";
            // 
            // timer_hora
            // 
            this.timer_hora.Interval = 1000;
            this.timer_hora.Tick += new System.EventHandler(this.timer_hora_Tick);
            // 
            // mzSombraPanel_menu_superior
            // 
            this.mzSombraPanel_menu_superior.AddControl = null;
            this.mzSombraPanel_menu_superior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mzSombraPanel_menu_superior.Controls.Add(this.pictureBox_logo_camara);
            this.mzSombraPanel_menu_superior.Location = new System.Drawing.Point(0, 70);
            this.mzSombraPanel_menu_superior.Name = "mzSombraPanel_menu_superior";
            this.mzSombraPanel_menu_superior.Padding = new System.Windows.Forms.Padding(10);
            this.mzSombraPanel_menu_superior.Size = new System.Drawing.Size(867, 89);
            this.mzSombraPanel_menu_superior.TabIndex = 9;
            this.mzSombraPanel_menu_superior.TipoDeSombra = MZControls.MZSombraPanel.ShadowsPanel.Central;
            // 
            // pictureBox_logo_camara
            // 
            this.pictureBox_logo_camara.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo_camara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_logo_camara.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_logo_camara.Location = new System.Drawing.Point(10, 10);
            this.pictureBox_logo_camara.Name = "pictureBox_logo_camara";
            this.pictureBox_logo_camara.Size = new System.Drawing.Size(205, 69);
            this.pictureBox_logo_camara.TabIndex = 8;
            this.pictureBox_logo_camara.TabStop = false;
            // 
            // mzSombraPanel_lateral_esquerda
            // 
            this.mzSombraPanel_lateral_esquerda.Location = new System.Drawing.Point(12, 165);
            this.mzSombraPanel_lateral_esquerda.Name = "mzSombraPanel_lateral_esquerda";
            this.mzSombraPanel_lateral_esquerda.Size = new System.Drawing.Size(188, 308);
            this.mzSombraPanel_lateral_esquerda.TabIndex = 13;
            this.mzSombraPanel_lateral_esquerda.SizeChanged += new System.EventHandler(this.mzSombraPanel_lateral_esquerda_SizeChanged_1);
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 495);
            this.Controls.Add(this.mzSombraPanel_lateral_esquerda);
            this.Controls.Add(this.mzSombraPanel_menu_superior);
            this.Controls.Add(this.panel_menu_lateral);
            this.Controls.Add(this.panel_cab_1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_principal";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form_principal_Load);
            this.panel_cab_1.ResumeLayout(false);
            this.panel_cab_usuario.ResumeLayout(false);
            this.panel_cab_usuario.PerformLayout();
            this.panel_cab_camara.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_menu_lateral.ResumeLayout(false);
            this.panel_menu_lateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_exibir_ao_publico)).EndInit();
            this.mzSombraPanel_menu_superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo_camara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cab_1;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panel_cab_usuario;
        private System.Windows.Forms.Panel panel_cab_camara;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_nome_cidade;
        private System.Windows.Forms.Label lbl_nome_usuario;
        private System.Windows.Forms.Panel panel_menu_lateral;
        private System.Windows.Forms.Label lbl_exibir_no_painel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer_hora;
        private MZControls.MZSombraPanel mzSombraPanel_menu_superior;
        private System.Windows.Forms.PictureBox pictureBox_logo_camara;
        private System.Windows.Forms.Panel mzSombraPanel_lateral_esquerda;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_exibir_ao_publico;
    }
}

