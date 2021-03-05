namespace EGP_Tela_Inicial_04_02.Formularios
{
    partial class form_acessos
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_usuarios = new System.Windows.Forms.TabPage();
            this.tabPage_acessos = new System.Windows.Forms.TabPage();
            this.dataGrid_usuarios = new System.Windows.Forms.DataGridView();
            this.ed_consulta = new System.Windows.Forms.TextBox();
            this.bt_acessos = new System.Windows.Forms.Button();
            this.dataGrid_acessos = new System.Windows.Forms.DataGridView();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.lbl_nome_usuario = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage_usuarios.SuspendLayout();
            this.tabPage_acessos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_acessos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage_usuarios);
            this.tabControl.Controls.Add(this.tabPage_acessos);
            this.tabControl.Location = new System.Drawing.Point(4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(801, 454);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_usuarios
            // 
            this.tabPage_usuarios.Controls.Add(this.bt_acessos);
            this.tabPage_usuarios.Controls.Add(this.ed_consulta);
            this.tabPage_usuarios.Controls.Add(this.dataGrid_usuarios);
            this.tabPage_usuarios.Location = new System.Drawing.Point(4, 22);
            this.tabPage_usuarios.Name = "tabPage_usuarios";
            this.tabPage_usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_usuarios.Size = new System.Drawing.Size(793, 428);
            this.tabPage_usuarios.TabIndex = 0;
            this.tabPage_usuarios.Text = "Usuários";
            this.tabPage_usuarios.UseVisualStyleBackColor = true;
            // 
            // tabPage_acessos
            // 
            this.tabPage_acessos.Controls.Add(this.lbl_nome_usuario);
            this.tabPage_acessos.Controls.Add(this.bt_salvar);
            this.tabPage_acessos.Controls.Add(this.bt_cancelar);
            this.tabPage_acessos.Controls.Add(this.lbl_usuario);
            this.tabPage_acessos.Controls.Add(this.dataGrid_acessos);
            this.tabPage_acessos.Location = new System.Drawing.Point(4, 22);
            this.tabPage_acessos.Name = "tabPage_acessos";
            this.tabPage_acessos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_acessos.Size = new System.Drawing.Size(793, 428);
            this.tabPage_acessos.TabIndex = 1;
            this.tabPage_acessos.Text = "Acessos";
            this.tabPage_acessos.UseVisualStyleBackColor = true;
            // 
            // dataGrid_usuarios
            // 
            this.dataGrid_usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_usuarios.Location = new System.Drawing.Point(3, 6);
            this.dataGrid_usuarios.Name = "dataGrid_usuarios";
            this.dataGrid_usuarios.Size = new System.Drawing.Size(785, 368);
            this.dataGrid_usuarios.TabIndex = 0;
            this.dataGrid_usuarios.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_usuarios_ColumnHeaderMouseClick);
            // 
            // ed_consulta
            // 
            this.ed_consulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ed_consulta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_consulta.Location = new System.Drawing.Point(3, 382);
            this.ed_consulta.Multiline = true;
            this.ed_consulta.Name = "ed_consulta";
            this.ed_consulta.Size = new System.Drawing.Size(436, 35);
            this.ed_consulta.TabIndex = 1;
            // 
            // bt_acessos
            // 
            this.bt_acessos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_acessos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.bt_acessos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_acessos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_acessos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.bt_acessos.Location = new System.Drawing.Point(669, 380);
            this.bt_acessos.Name = "bt_acessos";
            this.bt_acessos.Size = new System.Drawing.Size(120, 35);
            this.bt_acessos.TabIndex = 2;
            this.bt_acessos.Text = "Acessos";
            this.bt_acessos.UseVisualStyleBackColor = false;
            // 
            // dataGrid_acessos
            // 
            this.dataGrid_acessos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_acessos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_acessos.Location = new System.Drawing.Point(3, 6);
            this.dataGrid_acessos.Name = "dataGrid_acessos";
            this.dataGrid_acessos.Size = new System.Drawing.Size(785, 365);
            this.dataGrid_acessos.TabIndex = 0;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(-1, 397);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(63, 19);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "Usuário:";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.bt_cancelar.Location = new System.Drawing.Point(676, 383);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(111, 33);
            this.bt_cancelar.TabIndex = 2;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.bt_salvar.Location = new System.Drawing.Point(559, 383);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(111, 33);
            this.bt_salvar.TabIndex = 3;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = false;
            // 
            // lbl_nome_usuario
            // 
            this.lbl_nome_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_nome_usuario.AutoSize = true;
            this.lbl_nome_usuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_usuario.Location = new System.Drawing.Point(68, 397);
            this.lbl_nome_usuario.Name = "lbl_nome_usuario";
            this.lbl_nome_usuario.Size = new System.Drawing.Size(139, 19);
            this.lbl_nome_usuario.TabIndex = 4;
            this.lbl_nome_usuario.Text = "Eduardo da Fonseca";
            // 
            // form_acessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 461);
            this.Controls.Add(this.tabControl);
            this.Name = "form_acessos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acessos";
            this.Load += new System.EventHandler(this.form_acessos_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_usuarios.ResumeLayout(false);
            this.tabPage_usuarios.PerformLayout();
            this.tabPage_acessos.ResumeLayout(false);
            this.tabPage_acessos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_acessos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_usuarios;
        private System.Windows.Forms.Button bt_acessos;
        private System.Windows.Forms.TextBox ed_consulta;
        private System.Windows.Forms.DataGridView dataGrid_usuarios;
        private System.Windows.Forms.TabPage tabPage_acessos;
        private System.Windows.Forms.Label lbl_nome_usuario;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.DataGridView dataGrid_acessos;
    }
}