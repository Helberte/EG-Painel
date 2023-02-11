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
            this.ed_codigo = new System.Windows.Forms.TextBox();
            this.ed_usuario = new System.Windows.Forms.TextBox();
            this.ed_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_bt_acessar = new FontAwesome.Sharp.IconButton();
            this.pictureBox_bt_sair = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // ed_codigo
            // 
            this.ed_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ed_codigo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ed_codigo.Location = new System.Drawing.Point(61, 89);
            this.ed_codigo.MaxLength = 100;
            this.ed_codigo.Name = "ed_codigo";
            this.ed_codigo.Size = new System.Drawing.Size(275, 27);
            this.ed_codigo.TabIndex = 19;
            this.ed_codigo.Enter += new System.EventHandler(this.ed_codigo_Enter);
            this.ed_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_codigo_KeyPress);
            this.ed_codigo.Leave += new System.EventHandler(this.ed_codigo_Leave);
            // 
            // ed_usuario
            // 
            this.ed_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ed_usuario.Font = new System.Drawing.Font("Montserrat", 12F);
            this.ed_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ed_usuario.Location = new System.Drawing.Point(61, 150);
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
            this.ed_senha.Location = new System.Drawing.Point(61, 210);
            this.ed_senha.MaxLength = 8;
            this.ed_senha.Name = "ed_senha";
            this.ed_senha.Size = new System.Drawing.Size(275, 27);
            this.ed_senha.TabIndex = 21;
            this.ed_senha.Enter += new System.EventHandler(this.ed_senha_Enter);
            this.ed_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_senha_KeyPress);
            this.ed_senha.Leave += new System.EventHandler(this.ed_senha_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(111)))));
            this.label1.Location = new System.Drawing.Point(93, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Acesse com a sua conta";
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
            this.pictureBox_bt_acessar.Location = new System.Drawing.Point(61, 281);
            this.pictureBox_bt_acessar.Name = "pictureBox_bt_acessar";
            this.pictureBox_bt_acessar.Size = new System.Drawing.Size(275, 39);
            this.pictureBox_bt_acessar.TabIndex = 25;
            this.pictureBox_bt_acessar.Text = "Entrar";
            this.pictureBox_bt_acessar.UseVisualStyleBackColor = false;
            this.pictureBox_bt_acessar.Click += new System.EventHandler(this.pictureBox_bt_acessar_Click);
            // 
            // pictureBox_bt_sair
            // 
            this.pictureBox_bt_sair.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox_bt_sair.FlatAppearance.BorderSize = 0;
            this.pictureBox_bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pictureBox_bt_sair.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox_bt_sair.ForeColor = System.Drawing.Color.White;
            this.pictureBox_bt_sair.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pictureBox_bt_sair.IconColor = System.Drawing.Color.Black;
            this.pictureBox_bt_sair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pictureBox_bt_sair.Location = new System.Drawing.Point(61, 344);
            this.pictureBox_bt_sair.Name = "pictureBox_bt_sair";
            this.pictureBox_bt_sair.Size = new System.Drawing.Size(275, 38);
            this.pictureBox_bt_sair.TabIndex = 26;
            this.pictureBox_bt_sair.Text = "Sair";
            this.pictureBox_bt_sair.UseVisualStyleBackColor = false;
            this.pictureBox_bt_sair.Click += new System.EventHandler(this.pictureBox_bt_sair_Click);
            // 
            // Form_login_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(400, 419);
            this.Controls.Add(this.pictureBox_bt_sair);
            this.Controls.Add(this.pictureBox_bt_acessar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ed_codigo);
            this.Controls.Add(this.ed_usuario);
            this.Controls.Add(this.ed_senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_login_inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_login_inicial";
            this.Load += new System.EventHandler(this.Form_login_inicial_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_login_inicial_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ed_codigo;
        private System.Windows.Forms.TextBox ed_usuario;
        private System.Windows.Forms.TextBox ed_senha;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton pictureBox_bt_acessar;
        private FontAwesome.Sharp.IconButton pictureBox_bt_sair;
    }
}