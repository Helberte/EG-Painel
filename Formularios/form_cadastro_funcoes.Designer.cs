namespace EGP_PAINEL.Formularios
{
    partial class form_cadastro_funcoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cadastro_funcoes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ed_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome_funcao = new System.Windows.Forms.Label();
            this.ed_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.tabControl_funcao = new System.Windows.Forms.TabControl();
            this.tabPage_funcao = new System.Windows.Forms.TabPage();
            this.panel_lupa = new System.Windows.Forms.Panel();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.dataGrid_funcao = new System.Windows.Forms.DataGridView();
            this.ed_consulta = new System.Windows.Forms.TextBox();
            this.tabPage_nova = new System.Windows.Forms.TabPage();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.tabControl_funcao.SuspendLayout();
            this.tabPage_funcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_funcao)).BeginInit();
            this.tabPage_nova.SuspendLayout();
            this.SuspendLayout();
            // 
            // ed_nome
            // 
            this.ed_nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ed_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ed_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_nome.Location = new System.Drawing.Point(6, 37);
            this.ed_nome.Name = "ed_nome";
            this.ed_nome.Size = new System.Drawing.Size(565, 22);
            this.ed_nome.TabIndex = 1;
            this.ed_nome.Tag = "0";
            this.ed_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_nome_KeyPress);
            // 
            // lbl_nome_funcao
            // 
            this.lbl_nome_funcao.AutoSize = true;
            this.lbl_nome_funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_funcao.Location = new System.Drawing.Point(3, 17);
            this.lbl_nome_funcao.Name = "lbl_nome_funcao";
            this.lbl_nome_funcao.Size = new System.Drawing.Size(98, 15);
            this.lbl_nome_funcao.TabIndex = 1;
            this.lbl_nome_funcao.Text = "Nome da função";
            // 
            // ed_descricao
            // 
            this.ed_descricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ed_descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ed_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_descricao.Location = new System.Drawing.Point(6, 99);
            this.ed_descricao.Multiline = true;
            this.ed_descricao.Name = "ed_descricao";
            this.ed_descricao.Size = new System.Drawing.Size(787, 282);
            this.ed_descricao.TabIndex = 2;
            this.ed_descricao.Tag = "1";
            this.ed_descricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_descricao_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição da função";
            // 
            // bt_salvar
            // 
            this.bt_salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(65)))));
            this.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.bt_salvar.Location = new System.Drawing.Point(12, 410);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(81, 39);
            this.bt_salvar.TabIndex = 3;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // tabControl_funcao
            // 
            this.tabControl_funcao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_funcao.Controls.Add(this.tabPage_funcao);
            this.tabControl_funcao.Controls.Add(this.tabPage_nova);
            this.tabControl_funcao.Location = new System.Drawing.Point(-4, 2);
            this.tabControl_funcao.Name = "tabControl_funcao";
            this.tabControl_funcao.SelectedIndex = 0;
            this.tabControl_funcao.Size = new System.Drawing.Size(807, 482);
            this.tabControl_funcao.TabIndex = 4;
            this.tabControl_funcao.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_funcao_Selecting);
            // 
            // tabPage_funcao
            // 
            this.tabPage_funcao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.tabPage_funcao.Controls.Add(this.panel_lupa);
            this.tabPage_funcao.Controls.Add(this.bt_novo);
            this.tabPage_funcao.Controls.Add(this.bt_alterar);
            this.tabPage_funcao.Controls.Add(this.bt_excluir);
            this.tabPage_funcao.Controls.Add(this.dataGrid_funcao);
            this.tabPage_funcao.Controls.Add(this.ed_consulta);
            this.tabPage_funcao.Location = new System.Drawing.Point(4, 22);
            this.tabPage_funcao.Name = "tabPage_funcao";
            this.tabPage_funcao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_funcao.Size = new System.Drawing.Size(799, 427);
            this.tabPage_funcao.TabIndex = 0;
            this.tabPage_funcao.Text = "Funções ";
            // 
            // panel_lupa
            // 
            this.panel_lupa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_lupa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_lupa.BackgroundImage")));
            this.panel_lupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_lupa.Location = new System.Drawing.Point(209, 374);
            this.panel_lupa.Name = "panel_lupa";
            this.panel_lupa.Size = new System.Drawing.Size(41, 39);
            this.panel_lupa.TabIndex = 7;
            // 
            // bt_novo
            // 
            this.bt_novo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(135)))), ((int)(((byte)(47)))));
            this.bt_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_novo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.bt_novo.Location = new System.Drawing.Point(707, 374);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(82, 39);
            this.bt_novo.TabIndex = 6;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = false;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_alterar
            // 
            this.bt_alterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.bt_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.bt_alterar.Location = new System.Drawing.Point(620, 374);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(82, 39);
            this.bt_alterar.TabIndex = 5;
            this.bt_alterar.Text = "Alterar";
            this.bt_alterar.UseVisualStyleBackColor = false;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.bt_excluir.Location = new System.Drawing.Point(533, 374);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(82, 39);
            this.bt_excluir.TabIndex = 4;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = false;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // dataGrid_funcao
            // 
            this.dataGrid_funcao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_funcao.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGrid_funcao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_funcao.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGrid_funcao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_funcao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_funcao.ColumnHeadersHeight = 30;
            this.dataGrid_funcao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_funcao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_funcao.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid_funcao.EnableHeadersVisualStyles = false;
            this.dataGrid_funcao.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGrid_funcao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGrid_funcao.Location = new System.Drawing.Point(0, 1);
            this.dataGrid_funcao.MultiSelect = false;
            this.dataGrid_funcao.Name = "dataGrid_funcao";
            this.dataGrid_funcao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGrid_funcao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid_funcao.RowHeadersVisible = false;
            this.dataGrid_funcao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid_funcao.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_funcao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_funcao.Size = new System.Drawing.Size(796, 336);
            this.dataGrid_funcao.StandardTab = true;
            this.dataGrid_funcao.TabIndex = 1;
            this.dataGrid_funcao.VirtualMode = true;
            this.dataGrid_funcao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_funcao_CellClick);
            this.dataGrid_funcao.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_funcao_ColumnHeaderMouseClick);
            this.dataGrid_funcao.SelectionChanged += new System.EventHandler(this.dataGrid_funcao_SelectionChanged);
            // 
            // ed_consulta
            // 
            this.ed_consulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ed_consulta.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_consulta.Location = new System.Drawing.Point(6, 374);
            this.ed_consulta.MaxLength = 30;
            this.ed_consulta.Multiline = true;
            this.ed_consulta.Name = "ed_consulta";
            this.ed_consulta.Size = new System.Drawing.Size(197, 39);
            this.ed_consulta.TabIndex = 0;
            this.ed_consulta.Text = "Pesquise";
            this.ed_consulta.Enter += new System.EventHandler(this.ed_consulta_Enter);
            this.ed_consulta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ed_consulta_KeyDown);
            this.ed_consulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ed_consulta_KeyPress);
            this.ed_consulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ed_consulta_KeyUp);
            this.ed_consulta.Validating += new System.ComponentModel.CancelEventHandler(this.ed_consulta_Validating);
            // 
            // tabPage_nova
            // 
            this.tabPage_nova.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.tabPage_nova.Controls.Add(this.bt_cancelar);
            this.tabPage_nova.Controls.Add(this.lbl_nome_funcao);
            this.tabPage_nova.Controls.Add(this.bt_salvar);
            this.tabPage_nova.Controls.Add(this.ed_nome);
            this.tabPage_nova.Controls.Add(this.ed_descricao);
            this.tabPage_nova.Controls.Add(this.label2);
            this.tabPage_nova.Location = new System.Drawing.Point(4, 22);
            this.tabPage_nova.Name = "tabPage_nova";
            this.tabPage_nova.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_nova.Size = new System.Drawing.Size(799, 456);
            this.tabPage_nova.TabIndex = 1;
            this.tabPage_nova.Text = "Edição";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.bt_cancelar.Location = new System.Drawing.Point(99, 410);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(81, 39);
            this.bt_cancelar.TabIndex = 4;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // form_cadastro_funcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(803, 482);
            this.Controls.Add(this.tabControl_funcao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_cadastro_funcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funções";
            this.Load += new System.EventHandler(this.form_cadastro_funcoes_Load);
            this.Shown += new System.EventHandler(this.form_cadastro_funcoes_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cadastro_funcoes_KeyPress);
            this.tabControl_funcao.ResumeLayout(false);
            this.tabPage_funcao.ResumeLayout(false);
            this.tabPage_funcao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_funcao)).EndInit();
            this.tabPage_nova.ResumeLayout(false);
            this.tabPage_nova.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ed_nome;
        private System.Windows.Forms.Label lbl_nome_funcao;
        private System.Windows.Forms.TextBox ed_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.TabControl tabControl_funcao;
        private System.Windows.Forms.TabPage tabPage_funcao;
        private System.Windows.Forms.DataGridView dataGrid_funcao;
        private System.Windows.Forms.TextBox ed_consulta;
        private System.Windows.Forms.TabPage tabPage_nova;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Panel panel_lupa;
    }
}