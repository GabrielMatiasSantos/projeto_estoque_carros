namespace estoque_carros.Apresentacao.Formularios
{
    partial class frmCarrosEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarrosEstoque));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tcCarros = new TabControl();
            tabCores = new TabPage();
            lblPesquisarCor = new Label();
            txtPesquisarCor = new TextBox();
            btnCorSalvar = new Button();
            lblCor = new Label();
            txtCor = new TextBox();
            lblCores = new Label();
            dgvCores = new DataGridView();
            tabMarcas = new TabPage();
            lblPesquisarMarca = new Label();
            txtPesquisarMarca = new TextBox();
            btnMarcaSalvar = new Button();
            lblMarca = new Label();
            txtMarca = new TextBox();
            lblMarcas = new Label();
            dgvMarcas = new DataGridView();
            tabModelos = new TabPage();
            cbModeloMotor = new ComboBox();
            lblModeloMotor = new Label();
            cbModeloPortas = new ComboBox();
            lblModeloPortas = new Label();
            cbModeloMarca = new ComboBox();
            lblModeloMarca = new Label();
            lblPesquisarModelos = new Label();
            txtPesquisarModelo = new TextBox();
            btnModeloSalvar = new Button();
            lblModelo = new Label();
            txtModelo = new TextBox();
            lblModelos = new Label();
            dgvModelos = new DataGridView();
            tabEstoqueCarros = new TabPage();
            btnImprimir = new Button();
            lblPesquisarCarro = new Label();
            txtPesquisarCarro = new TextBox();
            dgvCarros = new DataGridView();
            btnInserir = new Button();
            label1 = new Label();
            tcCarros.SuspendLayout();
            tabCores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCores).BeginInit();
            tabMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
            tabModelos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModelos).BeginInit();
            tabEstoqueCarros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarros).BeginInit();
            SuspendLayout();
            // 
            // tcCarros
            // 
            tcCarros.Controls.Add(tabCores);
            tcCarros.Controls.Add(tabMarcas);
            tcCarros.Controls.Add(tabModelos);
            tcCarros.Controls.Add(tabEstoqueCarros);
            tcCarros.Location = new Point(0, -1);
            tcCarros.Name = "tcCarros";
            tcCarros.SelectedIndex = 0;
            tcCarros.Size = new Size(1233, 601);
            tcCarros.TabIndex = 0;
            // 
            // tabCores
            // 
            tabCores.BackColor = Color.WhiteSmoke;
            tabCores.Controls.Add(lblPesquisarCor);
            tabCores.Controls.Add(txtPesquisarCor);
            tabCores.Controls.Add(btnCorSalvar);
            tabCores.Controls.Add(lblCor);
            tabCores.Controls.Add(txtCor);
            tabCores.Controls.Add(lblCores);
            tabCores.Controls.Add(dgvCores);
            tabCores.Location = new Point(4, 29);
            tabCores.Name = "tabCores";
            tabCores.Padding = new Padding(3);
            tabCores.Size = new Size(1225, 568);
            tabCores.TabIndex = 2;
            tabCores.Text = "Cores";
            tabCores.Enter += tabCores_Enter;
            // 
            // lblPesquisarCor
            // 
            lblPesquisarCor.AutoSize = true;
            lblPesquisarCor.Location = new Point(39, 525);
            lblPesquisarCor.Name = "lblPesquisarCor";
            lblPesquisarCor.Size = new Size(184, 20);
            lblPesquisarCor.TabIndex = 19;
            lblPesquisarCor.Text = "Pesquisar por uma cor:";
            // 
            // txtPesquisarCor
            // 
            txtPesquisarCor.Location = new Point(240, 522);
            txtPesquisarCor.Name = "txtPesquisarCor";
            txtPesquisarCor.ShortcutsEnabled = false;
            txtPesquisarCor.Size = new Size(161, 27);
            txtPesquisarCor.TabIndex = 18;
            txtPesquisarCor.TextChanged += txtPesquisarCor_TextChanged;
            txtPesquisarCor.KeyPress += txtPesquisarCor_KeyPress;
            // 
            // btnCorSalvar
            // 
            btnCorSalvar.Location = new Point(570, 457);
            btnCorSalvar.Name = "btnCorSalvar";
            btnCorSalvar.Size = new Size(88, 31);
            btnCorSalvar.TabIndex = 17;
            btnCorSalvar.Text = "Salvar";
            btnCorSalvar.UseVisualStyleBackColor = true;
            btnCorSalvar.Click += btnCorSalvar_Click;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(32, 83);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(41, 20);
            lblCor.TabIndex = 16;
            lblCor.Text = "Cor:";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(35, 115);
            txtCor.Name = "txtCor";
            txtCor.ShortcutsEnabled = false;
            txtCor.Size = new Size(161, 27);
            txtCor.TabIndex = 15;
            txtCor.KeyPress += txtCor_KeyPress;
            // 
            // lblCores
            // 
            lblCores.AutoSize = true;
            lblCores.Location = new Point(32, 30);
            lblCores.Name = "lblCores";
            lblCores.Size = new Size(408, 20);
            lblCores.TabIndex = 14;
            lblCores.Text = "Para registrar uma nova cor de carro, informe abaixo:";
            // 
            // dgvCores
            // 
            dgvCores.AllowUserToAddRows = false;
            dgvCores.AllowUserToDeleteRows = false;
            dgvCores.AllowUserToResizeColumns = false;
            dgvCores.AllowUserToResizeRows = false;
            dgvCores.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCores.Location = new Point(472, 180);
            dgvCores.MultiSelect = false;
            dgvCores.Name = "dgvCores";
            dgvCores.ReadOnly = true;
            dgvCores.RowHeadersWidth = 51;
            dgvCores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCores.Size = new Size(279, 254);
            dgvCores.TabIndex = 13;
            dgvCores.DoubleClick += dgvCores_DoubleClick;
            // 
            // tabMarcas
            // 
            tabMarcas.BackColor = Color.WhiteSmoke;
            tabMarcas.Controls.Add(lblPesquisarMarca);
            tabMarcas.Controls.Add(txtPesquisarMarca);
            tabMarcas.Controls.Add(btnMarcaSalvar);
            tabMarcas.Controls.Add(lblMarca);
            tabMarcas.Controls.Add(txtMarca);
            tabMarcas.Controls.Add(lblMarcas);
            tabMarcas.Controls.Add(dgvMarcas);
            tabMarcas.Location = new Point(4, 29);
            tabMarcas.Name = "tabMarcas";
            tabMarcas.Padding = new Padding(3);
            tabMarcas.Size = new Size(1225, 568);
            tabMarcas.TabIndex = 1;
            tabMarcas.Text = "Marcas";
            tabMarcas.Enter += tabMarcas_Enter;
            // 
            // lblPesquisarMarca
            // 
            lblPesquisarMarca.AutoSize = true;
            lblPesquisarMarca.Location = new Point(39, 525);
            lblPesquisarMarca.Name = "lblPesquisarMarca";
            lblPesquisarMarca.Size = new Size(207, 20);
            lblPesquisarMarca.TabIndex = 12;
            lblPesquisarMarca.Text = "Pesquisar por uma marca:";
            // 
            // txtPesquisarMarca
            // 
            txtPesquisarMarca.Location = new Point(262, 522);
            txtPesquisarMarca.Name = "txtPesquisarMarca";
            txtPesquisarMarca.ShortcutsEnabled = false;
            txtPesquisarMarca.Size = new Size(161, 27);
            txtPesquisarMarca.TabIndex = 11;
            txtPesquisarMarca.TextChanged += txtPesquisarMarca_TextChanged;
            txtPesquisarMarca.KeyPress += txtPesquisarMarca_KeyPress;
            // 
            // btnMarcaSalvar
            // 
            btnMarcaSalvar.Location = new Point(563, 458);
            btnMarcaSalvar.Name = "btnMarcaSalvar";
            btnMarcaSalvar.Size = new Size(88, 31);
            btnMarcaSalvar.TabIndex = 10;
            btnMarcaSalvar.Text = "Salvar";
            btnMarcaSalvar.UseVisualStyleBackColor = true;
            btnMarcaSalvar.Click += btnMarcaSalvar_Click;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(32, 83);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(61, 20);
            lblMarca.TabIndex = 9;
            lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(35, 115);
            txtMarca.Name = "txtMarca";
            txtMarca.ShortcutsEnabled = false;
            txtMarca.Size = new Size(161, 27);
            txtMarca.TabIndex = 8;
            txtMarca.KeyPress += txtMarca_KeyPress;
            // 
            // lblMarcas
            // 
            lblMarcas.AutoSize = true;
            lblMarcas.Location = new Point(32, 30);
            lblMarcas.Name = "lblMarcas";
            lblMarcas.Size = new Size(431, 20);
            lblMarcas.TabIndex = 7;
            lblMarcas.Text = "Para registrar uma nova marca de carro, informe abaixo:";
            // 
            // dgvMarcas
            // 
            dgvMarcas.AllowUserToAddRows = false;
            dgvMarcas.AllowUserToDeleteRows = false;
            dgvMarcas.AllowUserToResizeColumns = false;
            dgvMarcas.AllowUserToResizeRows = false;
            dgvMarcas.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarcas.Location = new Point(473, 182);
            dgvMarcas.MultiSelect = false;
            dgvMarcas.Name = "dgvMarcas";
            dgvMarcas.ReadOnly = true;
            dgvMarcas.RowHeadersWidth = 51;
            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarcas.Size = new Size(275, 254);
            dgvMarcas.TabIndex = 6;
            dgvMarcas.DoubleClick += dgvMarcas_DoubleClick;
            // 
            // tabModelos
            // 
            tabModelos.BackColor = Color.WhiteSmoke;
            tabModelos.Controls.Add(cbModeloMotor);
            tabModelos.Controls.Add(lblModeloMotor);
            tabModelos.Controls.Add(cbModeloPortas);
            tabModelos.Controls.Add(lblModeloPortas);
            tabModelos.Controls.Add(cbModeloMarca);
            tabModelos.Controls.Add(lblModeloMarca);
            tabModelos.Controls.Add(lblPesquisarModelos);
            tabModelos.Controls.Add(txtPesquisarModelo);
            tabModelos.Controls.Add(btnModeloSalvar);
            tabModelos.Controls.Add(lblModelo);
            tabModelos.Controls.Add(txtModelo);
            tabModelos.Controls.Add(lblModelos);
            tabModelos.Controls.Add(dgvModelos);
            tabModelos.Location = new Point(4, 29);
            tabModelos.Name = "tabModelos";
            tabModelos.Padding = new Padding(3);
            tabModelos.Size = new Size(1225, 568);
            tabModelos.TabIndex = 3;
            tabModelos.Text = "Modelos";
            tabModelos.Enter += tabModelos_Enter;
            // 
            // cbModeloMotor
            // 
            cbModeloMotor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModeloMotor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbModeloMotor.FormattingEnabled = true;
            cbModeloMotor.Location = new Point(584, 135);
            cbModeloMotor.Name = "cbModeloMotor";
            cbModeloMotor.Size = new Size(85, 28);
            cbModeloMotor.TabIndex = 64;
            // 
            // lblModeloMotor
            // 
            lblModeloMotor.AutoSize = true;
            lblModeloMotor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModeloMotor.Location = new Point(584, 100);
            lblModeloMotor.Name = "lblModeloMotor";
            lblModeloMotor.Size = new Size(57, 20);
            lblModeloMotor.TabIndex = 63;
            lblModeloMotor.Text = "Motor:";
            // 
            // cbModeloPortas
            // 
            cbModeloPortas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModeloPortas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbModeloPortas.FormattingEnabled = true;
            cbModeloPortas.Location = new Point(475, 135);
            cbModeloPortas.Name = "cbModeloPortas";
            cbModeloPortas.Size = new Size(50, 28);
            cbModeloPortas.TabIndex = 62;
            // 
            // lblModeloPortas
            // 
            lblModeloPortas.AutoSize = true;
            lblModeloPortas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModeloPortas.Location = new Point(475, 100);
            lblModeloPortas.Name = "lblModeloPortas";
            lblModeloPortas.Size = new Size(63, 20);
            lblModeloPortas.TabIndex = 61;
            lblModeloPortas.Text = "Portas:";
            // 
            // cbModeloMarca
            // 
            cbModeloMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModeloMarca.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbModeloMarca.FormattingEnabled = true;
            cbModeloMarca.Location = new Point(255, 135);
            cbModeloMarca.Name = "cbModeloMarca";
            cbModeloMarca.Size = new Size(161, 28);
            cbModeloMarca.TabIndex = 55;
            // 
            // lblModeloMarca
            // 
            lblModeloMarca.AutoSize = true;
            lblModeloMarca.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModeloMarca.Location = new Point(255, 100);
            lblModeloMarca.Name = "lblModeloMarca";
            lblModeloMarca.Size = new Size(61, 20);
            lblModeloMarca.TabIndex = 54;
            lblModeloMarca.Text = "Marca:";
            // 
            // lblPesquisarModelos
            // 
            lblPesquisarModelos.AutoSize = true;
            lblPesquisarModelos.Location = new Point(31, 529);
            lblPesquisarModelos.Name = "lblPesquisarModelos";
            lblPesquisarModelos.Size = new Size(205, 20);
            lblPesquisarModelos.TabIndex = 19;
            lblPesquisarModelos.Text = "Pesquisar por um modelo:";
            // 
            // txtPesquisarModelo
            // 
            txtPesquisarModelo.Location = new Point(258, 526);
            txtPesquisarModelo.Name = "txtPesquisarModelo";
            txtPesquisarModelo.ShortcutsEnabled = false;
            txtPesquisarModelo.Size = new Size(161, 27);
            txtPesquisarModelo.TabIndex = 18;
            txtPesquisarModelo.TextChanged += txtPesquisarModelo_TextChanged;
            txtPesquisarModelo.KeyPress += txtPesquisarModelo_KeyPress;
            // 
            // btnModeloSalvar
            // 
            btnModeloSalvar.Location = new Point(565, 478);
            btnModeloSalvar.Name = "btnModeloSalvar";
            btnModeloSalvar.Size = new Size(88, 31);
            btnModeloSalvar.TabIndex = 17;
            btnModeloSalvar.Text = "Salvar";
            btnModeloSalvar.UseVisualStyleBackColor = true;
            btnModeloSalvar.Click += btnModeloSalvar_Click;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(35, 100);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(137, 20);
            lblModelo.TabIndex = 16;
            lblModelo.Text = "Modelo e versão:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(35, 134);
            txtModelo.Name = "txtModelo";
            txtModelo.ShortcutsEnabled = false;
            txtModelo.Size = new Size(161, 27);
            txtModelo.TabIndex = 15;
            txtModelo.KeyPress += txtModelo_KeyPress;
            // 
            // lblModelos
            // 
            lblModelos.AutoSize = true;
            lblModelos.Location = new Point(32, 30);
            lblModelos.Name = "lblModelos";
            lblModelos.Size = new Size(430, 20);
            lblModelos.TabIndex = 14;
            lblModelos.Text = "Informe o modelo e versão de um carro a ser registrado:";
            // 
            // dgvModelos
            // 
            dgvModelos.AllowUserToAddRows = false;
            dgvModelos.AllowUserToDeleteRows = false;
            dgvModelos.AllowUserToResizeColumns = false;
            dgvModelos.AllowUserToResizeRows = false;
            dgvModelos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvModelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModelos.Location = new Point(368, 204);
            dgvModelos.MultiSelect = false;
            dgvModelos.Name = "dgvModelos";
            dgvModelos.ReadOnly = true;
            dgvModelos.RowHeadersWidth = 51;
            dgvModelos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModelos.Size = new Size(480, 254);
            dgvModelos.TabIndex = 13;
            dgvModelos.DoubleClick += dgvModelos_DoubleClick;
            // 
            // tabEstoqueCarros
            // 
            tabEstoqueCarros.BackColor = Color.WhiteSmoke;
            tabEstoqueCarros.Controls.Add(btnImprimir);
            tabEstoqueCarros.Controls.Add(lblPesquisarCarro);
            tabEstoqueCarros.Controls.Add(txtPesquisarCarro);
            tabEstoqueCarros.Controls.Add(dgvCarros);
            tabEstoqueCarros.Controls.Add(btnInserir);
            tabEstoqueCarros.Controls.Add(label1);
            tabEstoqueCarros.Location = new Point(4, 29);
            tabEstoqueCarros.Name = "tabEstoqueCarros";
            tabEstoqueCarros.Padding = new Padding(3);
            tabEstoqueCarros.Size = new Size(1225, 568);
            tabEstoqueCarros.TabIndex = 0;
            tabEstoqueCarros.Text = "Carros - estoque";
            tabEstoqueCarros.Enter += tabEstoqueCarros_Enter;
            // 
            // btnImprimir
            // 
            btnImprimir.BackgroundImage = (Image)resources.GetObject("btnImprimir.BackgroundImage");
            btnImprimir.Location = new Point(1149, 501);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(58, 52);
            btnImprimir.TabIndex = 22;
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblPesquisarCarro
            // 
            lblPesquisarCarro.AutoSize = true;
            lblPesquisarCarro.Location = new Point(18, 529);
            lblPesquisarCarro.Name = "lblPesquisarCarro";
            lblPesquisarCarro.Size = new Size(354, 20);
            lblPesquisarCarro.TabIndex = 21;
            lblPesquisarCarro.Text = "Pesquisar por um carro pelo modelo e versão:";
            // 
            // txtPesquisarCarro
            // 
            txtPesquisarCarro.Location = new Point(395, 526);
            txtPesquisarCarro.Name = "txtPesquisarCarro";
            txtPesquisarCarro.ShortcutsEnabled = false;
            txtPesquisarCarro.Size = new Size(161, 27);
            txtPesquisarCarro.TabIndex = 20;
            txtPesquisarCarro.TextChanged += txtPesquisarCarro_TextChanged;
            txtPesquisarCarro.KeyPress += txtPesquisarCarro_KeyPress;
            // 
            // dgvCarros
            // 
            dgvCarros.AllowUserToAddRows = false;
            dgvCarros.AllowUserToDeleteRows = false;
            dgvCarros.AllowUserToResizeColumns = false;
            dgvCarros.AllowUserToResizeRows = false;
            dgvCarros.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCarros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarros.Location = new Point(17, 105);
            dgvCarros.MultiSelect = false;
            dgvCarros.Name = "dgvCarros";
            dgvCarros.ReadOnly = true;
            dgvCarros.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvCarros.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCarros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarros.Size = new Size(1190, 380);
            dgvCarros.TabIndex = 5;
            dgvCarros.DoubleClick += dgvCarros_DoubleClick;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(352, 34);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(88, 31);
            btnInserir.TabIndex = 4;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 39);
            label1.Name = "label1";
            label1.Size = new Size(302, 20);
            label1.TabIndex = 3;
            label1.Text = "Para inserir um novo carro, clique aqui:";
            // 
            // frmCarrosEstoque
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 600);
            Controls.Add(tcCarros);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmCarrosEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Matias Veículos - Estoque";
            FormClosed += frmCarrosEstoque_FormClosed;
            tcCarros.ResumeLayout(false);
            tabCores.ResumeLayout(false);
            tabCores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCores).EndInit();
            tabMarcas.ResumeLayout(false);
            tabMarcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).EndInit();
            tabModelos.ResumeLayout(false);
            tabModelos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModelos).EndInit();
            tabEstoqueCarros.ResumeLayout(false);
            tabEstoqueCarros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarros).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCarros;
        private System.Windows.Forms.TabPage tabEstoqueCarros;
        private System.Windows.Forms.TabPage tabMarcas;
        private System.Windows.Forms.TabPage tabCores;
        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabModelos;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblPesquisarMarca;
        private System.Windows.Forms.TextBox txtPesquisarMarca;
        private System.Windows.Forms.Button btnMarcaSalvar;
        private System.Windows.Forms.Label lblPesquisarCor;
        private System.Windows.Forms.TextBox txtPesquisarCor;
        private System.Windows.Forms.Button btnCorSalvar;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.DataGridView dgvCores;
        private System.Windows.Forms.Label lblPesquisarModelos;
        private System.Windows.Forms.TextBox txtPesquisarModelo;
        private System.Windows.Forms.Button btnModeloSalvar;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelos;
        private System.Windows.Forms.DataGridView dgvModelos;
        private System.Windows.Forms.ComboBox cbModeloMarca;
        private System.Windows.Forms.Label lblModeloMarca;
        private System.Windows.Forms.ComboBox cbModeloMotor;
        private System.Windows.Forms.Label lblModeloMotor;
        private System.Windows.Forms.ComboBox cbModeloPortas;
        private System.Windows.Forms.Label lblModeloPortas;
        private System.Windows.Forms.Label lblPesquisarCarro;
        private System.Windows.Forms.TextBox txtPesquisarCarro;
        private System.Windows.Forms.Button btnImprimir;
    }
}

