namespace EGP_PAINEL.Formularios
{
    partial class form_cadastro_camara
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
            this.tab_Camara = new System.Windows.Forms.TabControl();
            this.tabPage_camaras = new System.Windows.Forms.TabPage();
            this.ed_consulta = new System.Windows.Forms.TextBox();
            this.bt_nova = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.dataGrid_camaras = new System.Windows.Forms.DataGridView();
            this.tabPage_edicao = new System.Windows.Forms.TabPage();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.pcb_imagem = new System.Windows.Forms.PictureBox();
            this.groupBox_endereco = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.msk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ed_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.msk_cep = new System.Windows.Forms.MaskedTextBox();
            this.ed_bairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.msk_numero = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ed_cidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ed_rua = new System.Windows.Forms.TextBox();
            this.msk_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ed_nome = new System.Windows.Forms.TextBox();
            this.bt_excluir_foto = new System.Windows.Forms.Button();
            this.tab_Camara.SuspendLayout();
            this.tabPage_camaras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_camaras)).BeginInit();
            this.tabPage_edicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagem)).BeginInit();
            this.groupBox_endereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Camara
            // 
            this.tab_Camara.Controls.Add(this.tabPage_camaras);
            this.tab_Camara.Controls.Add(this.tabPage_edicao);
            this.tab_Camara.Location = new System.Drawing.Point(0, -1);
            this.tab_Camara.Name = "tab_Camara";
            this.tab_Camara.SelectedIndex = 0;
            this.tab_Camara.Size = new System.Drawing.Size(787, 516);
            this.tab_Camara.TabIndex = 1;
            this.tab_Camara.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tab_Camara_Selecting);
            // 
            // tabPage_camaras
            // 
            this.tabPage_camaras.Controls.Add(this.ed_consulta);
            this.tabPage_camaras.Controls.Add(this.bt_nova);
            this.tabPage_camaras.Controls.Add(this.bt_excluir);
            this.tabPage_camaras.Controls.Add(this.bt_alterar);
            this.tabPage_camaras.Controls.Add(this.dataGrid_camaras);
            this.tabPage_camaras.Location = new System.Drawing.Point(4, 22);
            this.tabPage_camaras.Name = "tabPage_camaras";
            this.tabPage_camaras.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_camaras.Size = new System.Drawing.Size(779, 490);
            this.tabPage_camaras.TabIndex = 0;
            this.tabPage_camaras.Text = "Camaras";
            this.tabPage_camaras.UseVisualStyleBackColor = true;
            // 
            // ed_consulta
            // 
            this.ed_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_consulta.Location = new System.Drawing.Point(8, 21);
            this.ed_consulta.Name = "ed_consulta";
            this.ed_consulta.Size = new System.Drawing.Size(519, 22);
            this.ed_consulta.TabIndex = 4;
            this.ed_consulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_consulta_KeyPress);
            this.ed_consulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ed_consulta_KeyUp);
            // 
            // bt_nova
            // 
            this.bt_nova.Location = new System.Drawing.Point(89, 460);
            this.bt_nova.Name = "bt_nova";
            this.bt_nova.Size = new System.Drawing.Size(75, 23);
            this.bt_nova.TabIndex = 3;
            this.bt_nova.Text = "Nova";
            this.bt_nova.UseVisualStyleBackColor = true;
            this.bt_nova.Click += new System.EventHandler(this.bt_nova_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(170, 460);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_excluir.TabIndex = 2;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Visible = false;
            // 
            // bt_alterar
            // 
            this.bt_alterar.Location = new System.Drawing.Point(8, 460);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(75, 23);
            this.bt_alterar.TabIndex = 1;
            this.bt_alterar.Text = "Alterar";
            this.bt_alterar.UseVisualStyleBackColor = true;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // dataGrid_camaras
            // 
            this.dataGrid_camaras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_camaras.Location = new System.Drawing.Point(0, 49);
            this.dataGrid_camaras.Name = "dataGrid_camaras";
            this.dataGrid_camaras.Size = new System.Drawing.Size(779, 405);
            this.dataGrid_camaras.TabIndex = 0;
            this.dataGrid_camaras.SelectionChanged += new System.EventHandler(this.dataGrid_camaras_SelectionChanged);
            // 
            // tabPage_edicao
            // 
            this.tabPage_edicao.Controls.Add(this.bt_excluir_foto);
            this.tabPage_edicao.Controls.Add(this.bt_cancelar);
            this.tabPage_edicao.Controls.Add(this.bt_salvar);
            this.tabPage_edicao.Controls.Add(this.pcb_imagem);
            this.tabPage_edicao.Controls.Add(this.groupBox_endereco);
            this.tabPage_edicao.Controls.Add(this.msk_cnpj);
            this.tabPage_edicao.Controls.Add(this.label3);
            this.tabPage_edicao.Controls.Add(this.label1);
            this.tabPage_edicao.Controls.Add(this.ed_nome);
            this.tabPage_edicao.Location = new System.Drawing.Point(4, 22);
            this.tabPage_edicao.Name = "tabPage_edicao";
            this.tabPage_edicao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_edicao.Size = new System.Drawing.Size(779, 490);
            this.tabPage_edicao.TabIndex = 1;
            this.tabPage_edicao.Text = "Edição";
            this.tabPage_edicao.UseVisualStyleBackColor = true;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(573, 385);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(89, 23);
            this.bt_cancelar.TabIndex = 21;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.Location = new System.Drawing.Point(668, 385);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(100, 23);
            this.bt_salvar.TabIndex = 22;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // pcb_imagem
            // 
            this.pcb_imagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_imagem.Location = new System.Drawing.Point(484, 19);
            this.pcb_imagem.Name = "pcb_imagem";
            this.pcb_imagem.Size = new System.Drawing.Size(284, 258);
            this.pcb_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcb_imagem.TabIndex = 17;
            this.pcb_imagem.TabStop = false;
            this.pcb_imagem.DoubleClick += new System.EventHandler(this.pcb_imagem_DoubleClick);
            // 
            // groupBox_endereco
            // 
            this.groupBox_endereco.Controls.Add(this.label9);
            this.groupBox_endereco.Controls.Add(this.msk_telefone);
            this.groupBox_endereco.Controls.Add(this.label8);
            this.groupBox_endereco.Controls.Add(this.ed_email);
            this.groupBox_endereco.Controls.Add(this.label7);
            this.groupBox_endereco.Controls.Add(this.msk_cep);
            this.groupBox_endereco.Controls.Add(this.ed_bairro);
            this.groupBox_endereco.Controls.Add(this.label6);
            this.groupBox_endereco.Controls.Add(this.label5);
            this.groupBox_endereco.Controls.Add(this.msk_numero);
            this.groupBox_endereco.Controls.Add(this.label2);
            this.groupBox_endereco.Controls.Add(this.ed_cidade);
            this.groupBox_endereco.Controls.Add(this.label4);
            this.groupBox_endereco.Controls.Add(this.ed_rua);
            this.groupBox_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_endereco.Location = new System.Drawing.Point(11, 153);
            this.groupBox_endereco.Name = "groupBox_endereco";
            this.groupBox_endereco.Size = new System.Drawing.Size(446, 255);
            this.groupBox_endereco.TabIndex = 5;
            this.groupBox_endereco.TabStop = false;
            this.groupBox_endereco.Text = "Endereço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(307, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefone";
            // 
            // msk_telefone
            // 
            this.msk_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telefone.Location = new System.Drawing.Point(310, 225);
            this.msk_telefone.Mask = "(00) 0000-0000";
            this.msk_telefone.Name = "msk_telefone";
            this.msk_telefone.Size = new System.Drawing.Size(112, 22);
            this.msk_telefone.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Email";
            // 
            // ed_email
            // 
            this.ed_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_email.Location = new System.Drawing.Point(17, 225);
            this.ed_email.Name = "ed_email";
            this.ed_email.Size = new System.Drawing.Size(277, 22);
            this.ed_email.TabIndex = 5;
            this.ed_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_nome_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(307, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "CEP";
            // 
            // msk_cep
            // 
            this.msk_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cep.Location = new System.Drawing.Point(310, 167);
            this.msk_cep.Mask = "00,000-000";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(112, 22);
            this.msk_cep.TabIndex = 7;
            // 
            // ed_bairro
            // 
            this.ed_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_bairro.Location = new System.Drawing.Point(17, 167);
            this.ed_bairro.Name = "ed_bairro";
            this.ed_bairro.Size = new System.Drawing.Size(277, 22);
            this.ed_bairro.TabIndex = 4;
            this.ed_bairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_nome_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Número";
            // 
            // msk_numero
            // 
            this.msk_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_numero.Location = new System.Drawing.Point(310, 110);
            this.msk_numero.Mask = "000000";
            this.msk_numero.Name = "msk_numero";
            this.msk_numero.Size = new System.Drawing.Size(112, 22);
            this.msk_numero.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cidade";
            // 
            // ed_cidade
            // 
            this.ed_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_cidade.Location = new System.Drawing.Point(17, 110);
            this.ed_cidade.Name = "ed_cidade";
            this.ed_cidade.Size = new System.Drawing.Size(277, 22);
            this.ed_cidade.TabIndex = 3;
            this.ed_cidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_nome_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rua";
            // 
            // ed_rua
            // 
            this.ed_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_rua.Location = new System.Drawing.Point(17, 52);
            this.ed_rua.Name = "ed_rua";
            this.ed_rua.Size = new System.Drawing.Size(405, 22);
            this.ed_rua.TabIndex = 2;
            this.ed_rua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_nome_KeyPress);
            // 
            // msk_cnpj
            // 
            this.msk_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cnpj.Location = new System.Drawing.Point(10, 108);
            this.msk_cnpj.Mask = "00,000,000/0000-00";
            this.msk_cnpj.Name = "msk_cnpj";
            this.msk_cnpj.Size = new System.Drawing.Size(218, 22);
            this.msk_cnpj.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "CNPJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // ed_nome
            // 
            this.ed_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_nome.Location = new System.Drawing.Point(11, 46);
            this.ed_nome.Name = "ed_nome";
            this.ed_nome.Size = new System.Drawing.Size(446, 22);
            this.ed_nome.TabIndex = 0;
            this.ed_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_nome_KeyPress);
            // 
            // bt_excluir_foto
            // 
            this.bt_excluir_foto.Location = new System.Drawing.Point(668, 290);
            this.bt_excluir_foto.Name = "bt_excluir_foto";
            this.bt_excluir_foto.Size = new System.Drawing.Size(100, 23);
            this.bt_excluir_foto.TabIndex = 23;
            this.bt_excluir_foto.Text = "Excluir foto";
            this.bt_excluir_foto.UseVisualStyleBackColor = true;
            this.bt_excluir_foto.Click += new System.EventHandler(this.bt_excluir_foto_Click);
            // 
            // form_cadastro_camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(788, 516);
            this.Controls.Add(this.tab_Camara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_cadastro_camara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Câmara";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_cadastro_camara_FormClosed);
            this.Load += new System.EventHandler(this.form_cadastro_camara_Load);
            this.Shown += new System.EventHandler(this.form_cadastro_camara_Shown_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form_cadastro_camara_KeyPress);
            this.tab_Camara.ResumeLayout(false);
            this.tabPage_camaras.ResumeLayout(false);
            this.tabPage_camaras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_camaras)).EndInit();
            this.tabPage_edicao.ResumeLayout(false);
            this.tabPage_edicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagem)).EndInit();
            this.groupBox_endereco.ResumeLayout(false);
            this.groupBox_endereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Camara;
        private System.Windows.Forms.TabPage tabPage_camaras;
        private System.Windows.Forms.TextBox ed_consulta;
        private System.Windows.Forms.Button bt_nova;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.DataGridView dataGrid_camaras;
        private System.Windows.Forms.TabPage tabPage_edicao;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.PictureBox pcb_imagem;
        private System.Windows.Forms.GroupBox groupBox_endereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox msk_telefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ed_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msk_cep;
        private System.Windows.Forms.TextBox ed_bairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msk_numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ed_cidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ed_rua;
        private System.Windows.Forms.MaskedTextBox msk_cnpj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ed_nome;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_excluir_foto;
    }
}