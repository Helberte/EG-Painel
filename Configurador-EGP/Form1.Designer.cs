
namespace Configurador_EGP
{
    partial class Form1
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
            this.ed_IP = new System.Windows.Forms.TextBox();
            this.ed_Usuario = new System.Windows.Forms.TextBox();
            this.ed_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ed_IP
            // 
            this.ed_IP.Location = new System.Drawing.Point(73, 20);
            this.ed_IP.Name = "ed_IP";
            this.ed_IP.Size = new System.Drawing.Size(211, 20);
            this.ed_IP.TabIndex = 0;
            // 
            // ed_Usuario
            // 
            this.ed_Usuario.Location = new System.Drawing.Point(73, 59);
            this.ed_Usuario.Name = "ed_Usuario";
            this.ed_Usuario.Size = new System.Drawing.Size(211, 20);
            this.ed_Usuario.TabIndex = 1;
            // 
            // ed_senha
            // 
            this.ed_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_senha.Location = new System.Drawing.Point(73, 98);
            this.ed_senha.Name = "ed_senha";
            this.ed_senha.PasswordChar = '*';
            this.ed_senha.Size = new System.Drawing.Size(211, 20);
            this.ed_senha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha:";
            // 
            // bt_gravar
            // 
            this.bt_gravar.Location = new System.Drawing.Point(167, 139);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(117, 23);
            this.bt_gravar.TabIndex = 6;
            this.bt_gravar.Text = "Gravar";
            this.bt_gravar.UseVisualStyleBackColor = true;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 186);
            this.Controls.Add(this.bt_gravar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ed_senha);
            this.Controls.Add(this.ed_Usuario);
            this.Controls.Add(this.ed_IP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure o Servidor EGP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ed_IP;
        private System.Windows.Forms.TextBox ed_Usuario;
        private System.Windows.Forms.TextBox ed_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_gravar;
    }
}

