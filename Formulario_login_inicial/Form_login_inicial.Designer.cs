namespace EGP_Tela_Inicial_04_02.Formulario_login_inicial
{
    partial class Form_login_inicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login_inicial));
            this.ed_usuario = new System.Windows.Forms.TextBox();
            this.ed_senha = new System.Windows.Forms.TextBox();
            this.panel_center = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.iconPictureBox_logo = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox_bt_acessar = new FontAwesome.Sharp.IconButton();
            this.checkBox_lembrar = new System.Windows.Forms.CheckBox();
            this.lbl_esqueceu_senha = new System.Windows.Forms.Label();
            this.lbl_voltar = new System.Windows.Forms.Label();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ed_usuario
            // 
            this.ed_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ed_usuario.Font = new System.Drawing.Font("Montserrat", 12F);
            this.ed_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ed_usuario.Location = new System.Drawing.Point(41, 173);
            this.ed_usuario.MaxLength = 100;
            this.ed_usuario.Name = "ed_usuario";
            this.ed_usuario.Size = new System.Drawing.Size(275, 27);
            this.ed_usuario.TabIndex = 20;
            this.ed_usuario.Enter += new System.EventHandler(this.ed_usuario_Enter);
            this.ed_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_usuario_KeyPress);
            this.ed_usuario.Leave += new System.EventHandler(this.ed_usuario_Leave);
            // 
            // ed_senha
            // 
            this.ed_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ed_senha.Font = new System.Drawing.Font("Montserrat", 12F);
            this.ed_senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ed_senha.Location = new System.Drawing.Point(41, 218);
            this.ed_senha.MaxLength = 8;
            this.ed_senha.Name = "ed_senha";
            this.ed_senha.Size = new System.Drawing.Size(275, 27);
            this.ed_senha.TabIndex = 21;
            this.ed_senha.Enter += new System.EventHandler(this.ed_senha_Enter);
            this.ed_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_senha_KeyPress);
            this.ed_senha.Leave += new System.EventHandler(this.ed_senha_Leave);
            // 
            // panel_center
            // 
            this.panel_center.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_center.BackColor = System.Drawing.Color.White;
            this.panel_center.Controls.Add(this.lbl_voltar);
            this.panel_center.Controls.Add(this.lbl_esqueceu_senha);
            this.panel_center.Controls.Add(this.checkBox_lembrar);
            this.panel_center.Controls.Add(this.lbl_usuario);
            this.panel_center.Controls.Add(this.iconPictureBox_logo);
            this.panel_center.Controls.Add(this.ed_senha);
            this.panel_center.Controls.Add(this.ed_usuario);
            this.panel_center.Controls.Add(this.pictureBox_bt_acessar);
            this.panel_center.Location = new System.Drawing.Point(258, 33);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(400, 500);
            this.panel_center.TabIndex = 27;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(38, 145);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuario.TabIndex = 28;
            this.lbl_usuario.Text = "Usuário";
            // 
            // iconPictureBox_logo
            // 
            this.iconPictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_logo.BackgroundImage = global::EGP_Tela_Inicial_04_02.Properties.Resources.logo_1;
            this.iconPictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox_logo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox_logo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox_logo.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox_logo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_logo.IconSize = 67;
            this.iconPictureBox_logo.Location = new System.Drawing.Point(77, 49);
            this.iconPictureBox_logo.Name = "iconPictureBox_logo";
            this.iconPictureBox_logo.Size = new System.Drawing.Size(239, 67);
            this.iconPictureBox_logo.TabIndex = 27;
            this.iconPictureBox_logo.TabStop = false;
            // 
            // pictureBox_bt_acessar
            // 
            this.pictureBox_bt_acessar.BackColor = System.Drawing.Color.Tan;
            this.pictureBox_bt_acessar.FlatAppearance.BorderSize = 0;
            this.pictureBox_bt_acessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pictureBox_bt_acessar.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox_bt_acessar.ForeColor = System.Drawing.Color.White;
            this.pictureBox_bt_acessar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pictureBox_bt_acessar.IconColor = System.Drawing.Color.Black;
            this.pictureBox_bt_acessar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pictureBox_bt_acessar.Location = new System.Drawing.Point(41, 287);
            this.pictureBox_bt_acessar.Name = "pictureBox_bt_acessar";
            this.pictureBox_bt_acessar.Size = new System.Drawing.Size(102, 39);
            this.pictureBox_bt_acessar.TabIndex = 25;
            this.pictureBox_bt_acessar.Text = "Entrar";
            this.pictureBox_bt_acessar.UseVisualStyleBackColor = false;
            this.pictureBox_bt_acessar.Click += new System.EventHandler(this.pictureBox_bt_acessar_Click);
            // 
            // checkBox_lembrar
            // 
            this.checkBox_lembrar.AutoSize = true;
            this.checkBox_lembrar.Location = new System.Drawing.Point(235, 299);
            this.checkBox_lembrar.Name = "checkBox_lembrar";
            this.checkBox_lembrar.Size = new System.Drawing.Size(81, 17);
            this.checkBox_lembrar.TabIndex = 29;
            this.checkBox_lembrar.Text = "Lembrar-me";
            this.checkBox_lembrar.UseVisualStyleBackColor = true;
            // 
            // lbl_esqueceu_senha
            // 
            this.lbl_esqueceu_senha.AutoSize = true;
            this.lbl_esqueceu_senha.Location = new System.Drawing.Point(130, 363);
            this.lbl_esqueceu_senha.Name = "lbl_esqueceu_senha";
            this.lbl_esqueceu_senha.Size = new System.Drawing.Size(113, 13);
            this.lbl_esqueceu_senha.TabIndex = 30;
            this.lbl_esqueceu_senha.Text = "Esqueceu sua senha?";
            // 
            // lbl_voltar
            // 
            this.lbl_voltar.AutoSize = true;
            this.lbl_voltar.Location = new System.Drawing.Point(130, 386);
            this.lbl_voltar.Name = "lbl_voltar";
            this.lbl_voltar.Size = new System.Drawing.Size(107, 13);
            this.lbl_voltar.TabIndex = 31;
            this.lbl_voltar.Text = "Voltar para executiva";
            // 
            // Form_login_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(894, 570);
            this.Controls.Add(this.panel_center);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_login_inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login EG-Painel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_login_inicial_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_login_inicial_MouseDown);
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox ed_usuario;
        private System.Windows.Forms.TextBox ed_senha;
        private FontAwesome.Sharp.IconButton pictureBox_bt_acessar;
        private System.Windows.Forms.Panel panel_center;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_logo;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_voltar;
        private System.Windows.Forms.Label lbl_esqueceu_senha;
        private System.Windows.Forms.CheckBox checkBox_lembrar;
    }
}