namespace estoque_carros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcCarros = new System.Windows.Forms.TabControl();
            this.tabCores = new System.Windows.Forms.TabPage();
            this.lblPesquisarCor = new System.Windows.Forms.Label();
            this.txtPesquisarCor = new System.Windows.Forms.TextBox();
            this.btnCorSalvar = new System.Windows.Forms.Button();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblCores = new System.Windows.Forms.Label();
            this.dgvCores = new System.Windows.Forms.DataGridView();
            this.tabMarcas = new System.Windows.Forms.TabPage();
            this.lblPesquisarMarca = new System.Windows.Forms.Label();
            this.txtPesquisarMarca = new System.Windows.Forms.TextBox();
            this.btnMarcaSalvar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.tabModelos = new System.Windows.Forms.TabPage();
            this.cbModeloMotor = new System.Windows.Forms.ComboBox();
            this.lblModeloMotor = new System.Windows.Forms.Label();
            this.cbModeloPortas = new System.Windows.Forms.ComboBox();
            this.lblModeloPortas = new System.Windows.Forms.Label();
            this.cbModeloMarca = new System.Windows.Forms.ComboBox();
            this.lblModeloMarca = new System.Windows.Forms.Label();
            this.lblPesquisarModelos = new System.Windows.Forms.Label();
            this.txtPesquisarModelo = new System.Windows.Forms.TextBox();
            this.btnModeloSalvar = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelos = new System.Windows.Forms.Label();
            this.dgvModelos = new System.Windows.Forms.DataGridView();
            this.tabEstoqueCarros = new System.Windows.Forms.TabPage();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblPesquisarCarro = new System.Windows.Forms.Label();
            this.txtPesquisarCarro = new System.Windows.Forms.TextBox();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tcCarros.SuspendLayout();
            this.tabCores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCores)).BeginInit();
            this.tabMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.tabModelos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).BeginInit();
            this.tabEstoqueCarros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCarros
            // 
            this.tcCarros.Controls.Add(this.tabCores);
            this.tcCarros.Controls.Add(this.tabMarcas);
            this.tcCarros.Controls.Add(this.tabModelos);
            this.tcCarros.Controls.Add(this.tabEstoqueCarros);
            this.tcCarros.Location = new System.Drawing.Point(0, -1);
            this.tcCarros.Name = "tcCarros";
            this.tcCarros.SelectedIndex = 0;
            this.tcCarros.Size = new System.Drawing.Size(1233, 601);
            this.tcCarros.TabIndex = 0;
            this.tcCarros.SelectedIndexChanged += new System.EventHandler(this.tcCarros_SelectedIndexChanged);
            // 
            // tabCores
            // 
            this.tabCores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCores.Controls.Add(this.lblPesquisarCor);
            this.tabCores.Controls.Add(this.txtPesquisarCor);
            this.tabCores.Controls.Add(this.btnCorSalvar);
            this.tabCores.Controls.Add(this.lblCor);
            this.tabCores.Controls.Add(this.txtCor);
            this.tabCores.Controls.Add(this.lblCores);
            this.tabCores.Controls.Add(this.dgvCores);
            this.tabCores.Location = new System.Drawing.Point(4, 26);
            this.tabCores.Name = "tabCores";
            this.tabCores.Padding = new System.Windows.Forms.Padding(3);
            this.tabCores.Size = new System.Drawing.Size(1225, 571);
            this.tabCores.TabIndex = 2;
            this.tabCores.Text = "Cores";
            this.tabCores.Enter += new System.EventHandler(this.tabCores_Enter);
            // 
            // lblPesquisarCor
            // 
            this.lblPesquisarCor.AutoSize = true;
            this.lblPesquisarCor.Location = new System.Drawing.Point(39, 525);
            this.lblPesquisarCor.Name = "lblPesquisarCor";
            this.lblPesquisarCor.Size = new System.Drawing.Size(155, 17);
            this.lblPesquisarCor.TabIndex = 19;
            this.lblPesquisarCor.Text = "Pesquisar por uma cor:";
            // 
            // txtPesquisarCor
            // 
            this.txtPesquisarCor.Location = new System.Drawing.Point(200, 525);
            this.txtPesquisarCor.Name = "txtPesquisarCor";
            this.txtPesquisarCor.ShortcutsEnabled = false;
            this.txtPesquisarCor.Size = new System.Drawing.Size(113, 23);
            this.txtPesquisarCor.TabIndex = 18;
            this.txtPesquisarCor.TextChanged += new System.EventHandler(this.txtPesquisarCor_TextChanged);
            // 
            // btnCorSalvar
            // 
            this.btnCorSalvar.Location = new System.Drawing.Point(581, 456);
            this.btnCorSalvar.Name = "btnCorSalvar";
            this.btnCorSalvar.Size = new System.Drawing.Size(88, 31);
            this.btnCorSalvar.TabIndex = 17;
            this.btnCorSalvar.Text = "Salvar";
            this.btnCorSalvar.UseVisualStyleBackColor = true;
            this.btnCorSalvar.Click += new System.EventHandler(this.btnCorSalvar_Click);
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(32, 83);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(34, 17);
            this.lblCor.TabIndex = 16;
            this.lblCor.Text = "Cor:";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(35, 115);
            this.txtCor.Name = "txtCor";
            this.txtCor.ShortcutsEnabled = false;
            this.txtCor.Size = new System.Drawing.Size(113, 23);
            this.txtCor.TabIndex = 15;
            this.txtCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCor_KeyPress);
            // 
            // lblCores
            // 
            this.lblCores.AutoSize = true;
            this.lblCores.Location = new System.Drawing.Point(32, 30);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(346, 17);
            this.lblCores.TabIndex = 14;
            this.lblCores.Text = "Para registrar uma nova cor de carro, informe abaixo:";
            // 
            // dgvCores
            // 
            this.dgvCores.AllowUserToAddRows = false;
            this.dgvCores.AllowUserToDeleteRows = false;
            this.dgvCores.AllowUserToResizeColumns = false;
            this.dgvCores.AllowUserToResizeRows = false;
            this.dgvCores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCores.Location = new System.Drawing.Point(527, 182);
            this.dgvCores.MultiSelect = false;
            this.dgvCores.Name = "dgvCores";
            this.dgvCores.ReadOnly = true;
            this.dgvCores.RowHeadersWidth = 51;
            this.dgvCores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCores.Size = new System.Drawing.Size(204, 254);
            this.dgvCores.TabIndex = 13;
            this.dgvCores.DoubleClick += new System.EventHandler(this.dgvCores_DoubleClick);
            // 
            // tabMarcas
            // 
            this.tabMarcas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabMarcas.Controls.Add(this.lblPesquisarMarca);
            this.tabMarcas.Controls.Add(this.txtPesquisarMarca);
            this.tabMarcas.Controls.Add(this.btnMarcaSalvar);
            this.tabMarcas.Controls.Add(this.lblMarca);
            this.tabMarcas.Controls.Add(this.txtMarca);
            this.tabMarcas.Controls.Add(this.lblMarcas);
            this.tabMarcas.Controls.Add(this.dgvMarcas);
            this.tabMarcas.Location = new System.Drawing.Point(4, 26);
            this.tabMarcas.Name = "tabMarcas";
            this.tabMarcas.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarcas.Size = new System.Drawing.Size(1225, 571);
            this.tabMarcas.TabIndex = 1;
            this.tabMarcas.Text = "Marcas";
            this.tabMarcas.Enter += new System.EventHandler(this.tabMarcas_Enter);
            // 
            // lblPesquisarMarca
            // 
            this.lblPesquisarMarca.AutoSize = true;
            this.lblPesquisarMarca.Location = new System.Drawing.Point(39, 525);
            this.lblPesquisarMarca.Name = "lblPesquisarMarca";
            this.lblPesquisarMarca.Size = new System.Drawing.Size(174, 17);
            this.lblPesquisarMarca.TabIndex = 12;
            this.lblPesquisarMarca.Text = "Pesquisar por uma marca:";
            // 
            // txtPesquisarMarca
            // 
            this.txtPesquisarMarca.Location = new System.Drawing.Point(219, 525);
            this.txtPesquisarMarca.Name = "txtPesquisarMarca";
            this.txtPesquisarMarca.ShortcutsEnabled = false;
            this.txtPesquisarMarca.Size = new System.Drawing.Size(113, 23);
            this.txtPesquisarMarca.TabIndex = 11;
            this.txtPesquisarMarca.TextChanged += new System.EventHandler(this.txtPesquisarMarca_TextChanged);
            // 
            // btnMarcaSalvar
            // 
            this.btnMarcaSalvar.Location = new System.Drawing.Point(581, 456);
            this.btnMarcaSalvar.Name = "btnMarcaSalvar";
            this.btnMarcaSalvar.Size = new System.Drawing.Size(88, 31);
            this.btnMarcaSalvar.TabIndex = 10;
            this.btnMarcaSalvar.Text = "Salvar";
            this.btnMarcaSalvar.UseVisualStyleBackColor = true;
            this.btnMarcaSalvar.Click += new System.EventHandler(this.btnMarcaSalvar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(32, 83);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 17);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(35, 115);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ShortcutsEnabled = false;
            this.txtMarca.Size = new System.Drawing.Size(113, 23);
            this.txtMarca.TabIndex = 8;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Location = new System.Drawing.Point(32, 30);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(365, 17);
            this.lblMarcas.TabIndex = 7;
            this.lblMarcas.Text = "Para registrar uma nova marca de carro, informe abaixo:";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.AllowUserToResizeColumns = false;
            this.dgvMarcas.AllowUserToResizeRows = false;
            this.dgvMarcas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(527, 182);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(204, 254);
            this.dgvMarcas.TabIndex = 6;
            this.dgvMarcas.DoubleClick += new System.EventHandler(this.dgvMarcas_DoubleClick);
            // 
            // tabModelos
            // 
            this.tabModelos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabModelos.Controls.Add(this.cbModeloMotor);
            this.tabModelos.Controls.Add(this.lblModeloMotor);
            this.tabModelos.Controls.Add(this.cbModeloPortas);
            this.tabModelos.Controls.Add(this.lblModeloPortas);
            this.tabModelos.Controls.Add(this.cbModeloMarca);
            this.tabModelos.Controls.Add(this.lblModeloMarca);
            this.tabModelos.Controls.Add(this.lblPesquisarModelos);
            this.tabModelos.Controls.Add(this.txtPesquisarModelo);
            this.tabModelos.Controls.Add(this.btnModeloSalvar);
            this.tabModelos.Controls.Add(this.lblModelo);
            this.tabModelos.Controls.Add(this.txtModelo);
            this.tabModelos.Controls.Add(this.lblModelos);
            this.tabModelos.Controls.Add(this.dgvModelos);
            this.tabModelos.Location = new System.Drawing.Point(4, 26);
            this.tabModelos.Name = "tabModelos";
            this.tabModelos.Padding = new System.Windows.Forms.Padding(3);
            this.tabModelos.Size = new System.Drawing.Size(1225, 571);
            this.tabModelos.TabIndex = 3;
            this.tabModelos.Text = "Modelos";
            this.tabModelos.Enter += new System.EventHandler(this.tabModelos_Enter);
            // 
            // cbModeloMotor
            // 
            this.cbModeloMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModeloMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModeloMotor.FormattingEnabled = true;
            this.cbModeloMotor.Items.AddRange(new object[] {
            "1.0",
            "1.2",
            "1.4",
            "1.6",
            "1.8",
            "2.0"});
            this.cbModeloMotor.Location = new System.Drawing.Point(586, 135);
            this.cbModeloMotor.Name = "cbModeloMotor";
            this.cbModeloMotor.Size = new System.Drawing.Size(41, 24);
            this.cbModeloMotor.TabIndex = 64;
            // 
            // lblModeloMotor
            // 
            this.lblModeloMotor.AutoSize = true;
            this.lblModeloMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloMotor.Location = new System.Drawing.Point(584, 100);
            this.lblModeloMotor.Name = "lblModeloMotor";
            this.lblModeloMotor.Size = new System.Drawing.Size(44, 16);
            this.lblModeloMotor.TabIndex = 63;
            this.lblModeloMotor.Text = "Motor:";
            // 
            // cbModeloPortas
            // 
            this.cbModeloPortas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModeloPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModeloPortas.FormattingEnabled = true;
            this.cbModeloPortas.Items.AddRange(new object[] {
            "2P",
            "3P",
            "4P",
            "5P"});
            this.cbModeloPortas.Location = new System.Drawing.Point(468, 135);
            this.cbModeloPortas.Name = "cbModeloPortas";
            this.cbModeloPortas.Size = new System.Drawing.Size(41, 24);
            this.cbModeloPortas.TabIndex = 62;
            // 
            // lblModeloPortas
            // 
            this.lblModeloPortas.AutoSize = true;
            this.lblModeloPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloPortas.Location = new System.Drawing.Point(465, 100);
            this.lblModeloPortas.Name = "lblModeloPortas";
            this.lblModeloPortas.Size = new System.Drawing.Size(49, 16);
            this.lblModeloPortas.TabIndex = 61;
            this.lblModeloPortas.Text = "Portas:";
            // 
            // cbModeloMarca
            // 
            this.cbModeloMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModeloMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModeloMarca.FormattingEnabled = true;
            this.cbModeloMarca.Location = new System.Drawing.Point(261, 135);
            this.cbModeloMarca.Name = "cbModeloMarca";
            this.cbModeloMarca.Size = new System.Drawing.Size(130, 24);
            this.cbModeloMarca.TabIndex = 55;
            this.cbModeloMarca.DropDown += new System.EventHandler(this.cbModeloMarca_DropDown);
            // 
            // lblModeloMarca
            // 
            this.lblModeloMarca.AutoSize = true;
            this.lblModeloMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloMarca.Location = new System.Drawing.Point(258, 100);
            this.lblModeloMarca.Name = "lblModeloMarca";
            this.lblModeloMarca.Size = new System.Drawing.Size(48, 16);
            this.lblModeloMarca.TabIndex = 54;
            this.lblModeloMarca.Text = "Marca:";
            // 
            // lblPesquisarModelos
            // 
            this.lblPesquisarModelos.AutoSize = true;
            this.lblPesquisarModelos.Location = new System.Drawing.Point(31, 529);
            this.lblPesquisarModelos.Name = "lblPesquisarModelos";
            this.lblPesquisarModelos.Size = new System.Drawing.Size(173, 17);
            this.lblPesquisarModelos.TabIndex = 19;
            this.lblPesquisarModelos.Text = "Pesquisar por um modelo:";
            // 
            // txtPesquisarModelo
            // 
            this.txtPesquisarModelo.Location = new System.Drawing.Point(210, 529);
            this.txtPesquisarModelo.Name = "txtPesquisarModelo";
            this.txtPesquisarModelo.ShortcutsEnabled = false;
            this.txtPesquisarModelo.Size = new System.Drawing.Size(150, 23);
            this.txtPesquisarModelo.TabIndex = 18;
            this.txtPesquisarModelo.TextChanged += new System.EventHandler(this.txtPesquisarModelo_TextChanged);
            // 
            // btnModeloSalvar
            // 
            this.btnModeloSalvar.Location = new System.Drawing.Point(587, 473);
            this.btnModeloSalvar.Name = "btnModeloSalvar";
            this.btnModeloSalvar.Size = new System.Drawing.Size(88, 31);
            this.btnModeloSalvar.TabIndex = 17;
            this.btnModeloSalvar.Text = "Salvar";
            this.btnModeloSalvar.UseVisualStyleBackColor = true;
            this.btnModeloSalvar.Click += new System.EventHandler(this.btnModeloSalvar_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(33, 99);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(117, 17);
            this.lblModelo.TabIndex = 16;
            this.lblModelo.Text = "Modelo e versão:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(35, 134);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ShortcutsEnabled = false;
            this.txtModelo.Size = new System.Drawing.Size(149, 23);
            this.txtModelo.TabIndex = 15;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModelo_KeyPress);
            // 
            // lblModelos
            // 
            this.lblModelos.AutoSize = true;
            this.lblModelos.Location = new System.Drawing.Point(32, 30);
            this.lblModelos.Name = "lblModelos";
            this.lblModelos.Size = new System.Drawing.Size(364, 17);
            this.lblModelos.TabIndex = 14;
            this.lblModelos.Text = "Informe o modelo e versão de um carro a ser registrado:";
            // 
            // dgvModelos
            // 
            this.dgvModelos.AllowUserToAddRows = false;
            this.dgvModelos.AllowUserToDeleteRows = false;
            this.dgvModelos.AllowUserToResizeColumns = false;
            this.dgvModelos.AllowUserToResizeRows = false;
            this.dgvModelos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelos.Location = new System.Drawing.Point(442, 199);
            this.dgvModelos.MultiSelect = false;
            this.dgvModelos.Name = "dgvModelos";
            this.dgvModelos.ReadOnly = true;
            this.dgvModelos.RowHeadersWidth = 51;
            this.dgvModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModelos.Size = new System.Drawing.Size(384, 254);
            this.dgvModelos.TabIndex = 13;
            this.dgvModelos.DoubleClick += new System.EventHandler(this.dgvModelos_DoubleClick);
            // 
            // tabEstoqueCarros
            // 
            this.tabEstoqueCarros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabEstoqueCarros.Controls.Add(this.btnImprimir);
            this.tabEstoqueCarros.Controls.Add(this.lblPesquisarCarro);
            this.tabEstoqueCarros.Controls.Add(this.txtPesquisarCarro);
            this.tabEstoqueCarros.Controls.Add(this.dgvCarros);
            this.tabEstoqueCarros.Controls.Add(this.btnInserir);
            this.tabEstoqueCarros.Controls.Add(this.label1);
            this.tabEstoqueCarros.Location = new System.Drawing.Point(4, 26);
            this.tabEstoqueCarros.Name = "tabEstoqueCarros";
            this.tabEstoqueCarros.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstoqueCarros.Size = new System.Drawing.Size(1225, 571);
            this.tabEstoqueCarros.TabIndex = 0;
            this.tabEstoqueCarros.Text = "Carros - estoque";
            this.tabEstoqueCarros.Enter += new System.EventHandler(this.tabEstoqueCarros_Enter);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.Location = new System.Drawing.Point(1161, 504);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(46, 48);
            this.btnImprimir.TabIndex = 22;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblPesquisarCarro
            // 
            this.lblPesquisarCarro.AutoSize = true;
            this.lblPesquisarCarro.Location = new System.Drawing.Point(18, 529);
            this.lblPesquisarCarro.Name = "lblPesquisarCarro";
            this.lblPesquisarCarro.Size = new System.Drawing.Size(300, 17);
            this.lblPesquisarCarro.TabIndex = 21;
            this.lblPesquisarCarro.Text = "Pesquisar por um carro pelo modelo e versão:";
            // 
            // txtPesquisarCarro
            // 
            this.txtPesquisarCarro.Location = new System.Drawing.Point(324, 529);
            this.txtPesquisarCarro.Name = "txtPesquisarCarro";
            this.txtPesquisarCarro.ShortcutsEnabled = false;
            this.txtPesquisarCarro.Size = new System.Drawing.Size(150, 23);
            this.txtPesquisarCarro.TabIndex = 20;
            this.txtPesquisarCarro.TextChanged += new System.EventHandler(this.txtPesquisarCarro_TextChanged);
            // 
            // dgvCarros
            // 
            this.dgvCarros.AllowUserToAddRows = false;
            this.dgvCarros.AllowUserToDeleteRows = false;
            this.dgvCarros.AllowUserToResizeColumns = false;
            this.dgvCarros.AllowUserToResizeRows = false;
            this.dgvCarros.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(17, 105);
            this.dgvCarros.MultiSelect = false;
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.ReadOnly = true;
            this.dgvCarros.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCarros.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarros.Size = new System.Drawing.Size(1190, 380);
            this.dgvCarros.TabIndex = 5;
            this.dgvCarros.DoubleClick += new System.EventHandler(this.dgvCarros_DoubleClick);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(294, 32);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(88, 31);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Para inserir um novo carro, clique aqui:";
            // 
            // frmCarrosEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 600);
            this.Controls.Add(this.tcCarros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCarrosEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matias Veículos - Estoque";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCarrosEstoque_FormClosed);
            this.tcCarros.ResumeLayout(false);
            this.tabCores.ResumeLayout(false);
            this.tabCores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCores)).EndInit();
            this.tabMarcas.ResumeLayout(false);
            this.tabMarcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.tabModelos.ResumeLayout(false);
            this.tabModelos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).EndInit();
            this.tabEstoqueCarros.ResumeLayout(false);
            this.tabEstoqueCarros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);

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

