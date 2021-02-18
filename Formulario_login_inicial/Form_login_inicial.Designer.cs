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
            this.pictureBox_bt_acessar = new System.Windows.Forms.PictureBox();
            this.pictureBox_bt_sair = new System.Windows.Forms.PictureBox();
            this.ed_senha = new System.Windows.Forms.TextBox();
            this.ed_usuario = new System.Windows.Forms.TextBox();
            this.ed_codigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bt_acessar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bt_sair)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_bt_acessar
            // 
            this.pictureBox_bt_acessar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_bt_acessar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_bt_acessar.Location = new System.Drawing.Point(357, 367);
            this.pictureBox_bt_acessar.Name = "pictureBox_bt_acessar";
            this.pictureBox_bt_acessar.Size = new System.Drawing.Size(70, 30);
            this.pictureBox_bt_acessar.TabIndex = 12;
            this.pictureBox_bt_acessar.TabStop = false;
            this.pictureBox_bt_acessar.Click += new System.EventHandler(this.pictureBox_bt_acessar_Click);
            // 
            // pictureBox_bt_sair
            // 
            this.pictureBox_bt_sair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_bt_sair.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_bt_sair.Location = new System.Drawing.Point(433, 367);
            this.pictureBox_bt_sair.Name = "pictureBox_bt_sair";
            this.pictureBox_bt_sair.Size = new System.Drawing.Size(72, 30);
            this.pictureBox_bt_sair.TabIndex = 11;
            this.pictureBox_bt_sair.TabStop = false;
            this.pictureBox_bt_sair.Click += new System.EventHandler(this.pictureBox_bt_sair_Click);
            // 
            // ed_senha
            // 
            this.ed_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ed_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ed_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ed_senha.Location = new System.Drawing.Point(332, 324);
            this.ed_senha.MaxLength = 8;
            this.ed_senha.Multiline = true;
            this.ed_senha.Name = "ed_senha";
            this.ed_senha.Size = new System.Drawing.Size(201, 20);
            this.ed_senha.TabIndex = 10;
            this.ed_senha.Enter += new System.EventHandler(this.ed_senha_Enter);
            this.ed_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_senha_KeyPress);
            this.ed_senha.Leave += new System.EventHandler(this.ed_senha_Leave);
            // 
            // ed_usuario
            // 
            this.ed_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ed_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ed_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_usuario.Location = new System.Drawing.Point(332, 268);
            this.ed_usuario.MaxLength = 100;
            this.ed_usuario.Multiline = true;
            this.ed_usuario.Name = "ed_usuario";
            this.ed_usuario.Size = new System.Drawing.Size(201, 20);
            this.ed_usuario.TabIndex = 9;
            this.ed_usuario.Enter += new System.EventHandler(this.ed_usuario_Enter);
            this.ed_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_usuario_KeyPress);
            this.ed_usuario.Leave += new System.EventHandler(this.ed_usuario_Leave);
            // 
            // ed_codigo
            // 
            this.ed_codigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ed_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ed_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_codigo.Location = new System.Drawing.Point(332, 211);
            this.ed_codigo.MaxLength = 100;
            this.ed_codigo.Multiline = true;
            this.ed_codigo.Name = "ed_codigo";
            this.ed_codigo.Size = new System.Drawing.Size(201, 20);
            this.ed_codigo.TabIndex = 8;
            this.ed_codigo.Enter += new System.EventHandler(this.ed_codigo_Enter);
            this.ed_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_codigo_KeyPress);
            this.ed_codigo.Leave += new System.EventHandler(this.ed_codigo_Leave);
            // 
            // Form_login_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EGP_Tela_Inicial_04_02.Properties.Resources._500;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 501);
            this.Controls.Add(this.pictureBox_bt_acessar);
            this.Controls.Add(this.pictureBox_bt_sair);
            this.Controls.Add(this.ed_senha);
            this.Controls.Add(this.ed_usuario);
            this.Controls.Add(this.ed_codigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_login_inicial";
            this.Text = "Form_login_inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_login_inicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bt_acessar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bt_sair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_bt_acessar;
        private System.Windows.Forms.PictureBox pictureBox_bt_sair;
        private System.Windows.Forms.TextBox ed_senha;
        private System.Windows.Forms.TextBox ed_usuario;
        private System.Windows.Forms.TextBox ed_codigo;
    }
}