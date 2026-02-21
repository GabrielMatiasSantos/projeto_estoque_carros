namespace estoque_carros
{
    partial class frmCarroInserirAlterarDeletar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarroInserirAlterarDeletar));
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.mtbAno = new System.Windows.Forms.MaskedTextBox();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.cbCombustivel = new System.Windows.Forms.ComboBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.cbCambio = new System.Windows.Forms.ComboBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.lblOpcionais = new System.Windows.Forms.Label();
            this.chbDirecaoHidraulica = new System.Windows.Forms.CheckBox();
            this.chbDirecaoEletrica = new System.Windows.Forms.CheckBox();
            this.chbVidrosEletricos = new System.Windows.Forms.CheckBox();
            this.chbTravasEletricas = new System.Windows.Forms.CheckBox();
            this.chbAlarme = new System.Windows.Forms.CheckBox();
            this.chbArCondicionado = new System.Windows.Forms.CheckBox();
            this.chbRetrovisoresEletricos = new System.Windows.Forms.CheckBox();
            this.chbTetoSolar = new System.Windows.Forms.CheckBox();
            this.chbArQuente = new System.Windows.Forms.CheckBox();
            this.chbDesembaçadorLimpadorTraseiro = new System.Windows.Forms.CheckBox();
            this.chbEncostoCabecaTraseiro = new System.Windows.Forms.CheckBox();
            this.chbParaChoqueCor = new System.Windows.Forms.CheckBox();
            this.chbCentralMultimidia = new System.Windows.Forms.CheckBox();
            this.chbSensorEstacionamento = new System.Windows.Forms.CheckBox();
            this.chbPinturaMetalizada = new System.Windows.Forms.CheckBox();
            this.chbRodasLigaLeve = new System.Windows.Forms.CheckBox();
            this.chbBancosCouro = new System.Windows.Forms.CheckBox();
            this.chbVolanteRegulagemAltura = new System.Windows.Forms.CheckBox();
            this.chbFreioAbs = new System.Windows.Forms.CheckBox();
            this.chbGps = new System.Windows.Forms.CheckBox();
            this.chbAirBag = new System.Windows.Forms.CheckBox();
            this.chbTracao4x4 = new System.Windows.Forms.CheckBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblCor = new System.Windows.Forms.Label();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cbPlaca = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(26, 26);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(61, 20);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(604, 28);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(211, 20);
            this.lblAno.TabIndex = 6;
            this.lblAno.Text = "Ano (fabricação e modelo):";
            // 
            // mtbAno
            // 
            this.mtbAno.Location = new System.Drawing.Point(607, 65);
            this.mtbAno.Mask = "9999/9999";
            this.mtbAno.Name = "mtbAno";
            this.mtbAno.ShortcutsEnabled = false;
            this.mtbAno.Size = new System.Drawing.Size(69, 26);
            this.mtbAno.TabIndex = 7;
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustivel.Location = new System.Drawing.Point(26, 112);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(106, 20);
            this.lblCombustivel.TabIndex = 12;
            this.lblCombustivel.Text = "Combustível:";
            // 
            // cbCombustivel
            // 
            this.cbCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCombustivel.FormattingEnabled = true;
            this.cbCombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Etanol",
            "Flex",
            "Diesel",
            "Gás natural",
            "Eletricidade"});
            this.cbCombustivel.Location = new System.Drawing.Point(29, 147);
            this.cbCombustivel.Name = "cbCombustivel";
            this.cbCombustivel.Size = new System.Drawing.Size(99, 28);
            this.cbCombustivel.TabIndex = 11;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(1037, 26);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(71, 20);
            this.lblCambio.TabIndex = 10;
            this.lblCambio.Text = "Câmbio:";
            // 
            // cbCambio
            // 
            this.cbCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCambio.FormattingEnabled = true;
            this.cbCambio.Items.AddRange(new object[] {
            "Manual",
            "Automático",
            "CVT",
            "Automatizado"});
            this.cbCambio.Location = new System.Drawing.Point(1040, 61);
            this.cbCambio.Name = "cbCambio";
            this.cbCambio.Size = new System.Drawing.Size(112, 28);
            this.cbCambio.TabIndex = 9;
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(284, 112);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(128, 20);
            this.lblKm.TabIndex = 14;
            this.lblKm.Text = "Quilometragem:";
            // 
            // txtKm
            // 
            this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKm.Location = new System.Drawing.Point(287, 147);
            this.txtKm.Name = "txtKm";
            this.txtKm.ShortcutsEnabled = false;
            this.txtKm.Size = new System.Drawing.Size(99, 26);
            this.txtKm.TabIndex = 13;
            this.txtKm.TextChanged += new System.EventHandler(this.txtKm_TextChanged);
            this.txtKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKm_KeyPress);
            // 
            // lblOpcionais
            // 
            this.lblOpcionais.AutoSize = true;
            this.lblOpcionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcionais.Location = new System.Drawing.Point(17, 299);
            this.lblOpcionais.Name = "lblOpcionais";
            this.lblOpcionais.Size = new System.Drawing.Size(89, 20);
            this.lblOpcionais.TabIndex = 15;
            this.lblOpcionais.Text = "Opcionais:";
            // 
            // chbDirecaoHidraulica
            // 
            this.chbDirecaoHidraulica.AutoSize = true;
            this.chbDirecaoHidraulica.Location = new System.Drawing.Point(107, 299);
            this.chbDirecaoHidraulica.Name = "chbDirecaoHidraulica";
            this.chbDirecaoHidraulica.Size = new System.Drawing.Size(167, 24);
            this.chbDirecaoHidraulica.TabIndex = 17;
            this.chbDirecaoHidraulica.Text = "Direção hidráulica";
            this.chbDirecaoHidraulica.UseVisualStyleBackColor = true;
            this.chbDirecaoHidraulica.CheckedChanged += new System.EventHandler(this.chbDirecaoHidraulica_CheckedChanged);
            // 
            // chbDirecaoEletrica
            // 
            this.chbDirecaoEletrica.AutoSize = true;
            this.chbDirecaoEletrica.Location = new System.Drawing.Point(321, 298);
            this.chbDirecaoEletrica.Name = "chbDirecaoEletrica";
            this.chbDirecaoEletrica.Size = new System.Drawing.Size(150, 24);
            this.chbDirecaoEletrica.TabIndex = 18;
            this.chbDirecaoEletrica.Text = "Direção elétrica";
            this.chbDirecaoEletrica.UseVisualStyleBackColor = true;
            this.chbDirecaoEletrica.CheckedChanged += new System.EventHandler(this.chbDirecaoEletrica_CheckedChanged);
            // 
            // chbVidrosEletricos
            // 
            this.chbVidrosEletricos.AutoSize = true;
            this.chbVidrosEletricos.Location = new System.Drawing.Point(1026, 299);
            this.chbVidrosEletricos.Name = "chbVidrosEletricos";
            this.chbVidrosEletricos.Size = new System.Drawing.Size(148, 24);
            this.chbVidrosEletricos.TabIndex = 19;
            this.chbVidrosEletricos.Text = "Vidros elétricos";
            this.chbVidrosEletricos.UseVisualStyleBackColor = true;
            // 
            // chbTravasEletricas
            // 
            this.chbTravasEletricas.AutoSize = true;
            this.chbTravasEletricas.Location = new System.Drawing.Point(824, 298);
            this.chbTravasEletricas.Name = "chbTravasEletricas";
            this.chbTravasEletricas.Size = new System.Drawing.Size(151, 24);
            this.chbTravasEletricas.TabIndex = 20;
            this.chbTravasEletricas.Text = "Travas elétricas";
            this.chbTravasEletricas.UseVisualStyleBackColor = true;
            // 
            // chbAlarme
            // 
            this.chbAlarme.AutoSize = true;
            this.chbAlarme.Location = new System.Drawing.Point(521, 324);
            this.chbAlarme.Name = "chbAlarme";
            this.chbAlarme.Size = new System.Drawing.Size(84, 24);
            this.chbAlarme.TabIndex = 21;
            this.chbAlarme.Text = "Alarme";
            this.chbAlarme.UseVisualStyleBackColor = true;
            // 
            // chbArCondicionado
            // 
            this.chbArCondicionado.AutoSize = true;
            this.chbArCondicionado.Location = new System.Drawing.Point(107, 325);
            this.chbArCondicionado.Name = "chbArCondicionado";
            this.chbArCondicionado.Size = new System.Drawing.Size(152, 24);
            this.chbArCondicionado.TabIndex = 22;
            this.chbArCondicionado.Text = "Ar-condicionado";
            this.chbArCondicionado.UseVisualStyleBackColor = true;
            // 
            // chbRetrovisoresEletricos
            // 
            this.chbRetrovisoresEletricos.AutoSize = true;
            this.chbRetrovisoresEletricos.Location = new System.Drawing.Point(824, 324);
            this.chbRetrovisoresEletricos.Name = "chbRetrovisoresEletricos";
            this.chbRetrovisoresEletricos.Size = new System.Drawing.Size(195, 24);
            this.chbRetrovisoresEletricos.TabIndex = 23;
            this.chbRetrovisoresEletricos.Text = "Retrovisores elétricos";
            this.chbRetrovisoresEletricos.UseVisualStyleBackColor = true;
            // 
            // chbTetoSolar
            // 
            this.chbTetoSolar.AutoSize = true;
            this.chbTetoSolar.Location = new System.Drawing.Point(107, 351);
            this.chbTetoSolar.Name = "chbTetoSolar";
            this.chbTetoSolar.Size = new System.Drawing.Size(106, 24);
            this.chbTetoSolar.TabIndex = 24;
            this.chbTetoSolar.Text = "Teto solar";
            this.chbTetoSolar.UseVisualStyleBackColor = true;
            // 
            // chbArQuente
            // 
            this.chbArQuente.AutoSize = true;
            this.chbArQuente.Location = new System.Drawing.Point(321, 324);
            this.chbArQuente.Name = "chbArQuente";
            this.chbArQuente.Size = new System.Drawing.Size(103, 24);
            this.chbArQuente.TabIndex = 25;
            this.chbArQuente.Text = "Ar quente";
            this.chbArQuente.UseVisualStyleBackColor = true;
            // 
            // chbDesembaçadorLimpadorTraseiro
            // 
            this.chbDesembaçadorLimpadorTraseiro.AutoSize = true;
            this.chbDesembaçadorLimpadorTraseiro.Location = new System.Drawing.Point(521, 376);
            this.chbDesembaçadorLimpadorTraseiro.Name = "chbDesembaçadorLimpadorTraseiro";
            this.chbDesembaçadorLimpadorTraseiro.Size = new System.Drawing.Size(295, 24);
            this.chbDesembaçadorLimpadorTraseiro.TabIndex = 26;
            this.chbDesembaçadorLimpadorTraseiro.Text = "Desembaçador e limpador traseiro ";
            this.chbDesembaçadorLimpadorTraseiro.UseVisualStyleBackColor = true;
            // 
            // chbEncostoCabecaTraseiro
            // 
            this.chbEncostoCabecaTraseiro.AutoSize = true;
            this.chbEncostoCabecaTraseiro.Location = new System.Drawing.Point(321, 350);
            this.chbEncostoCabecaTraseiro.Name = "chbEncostoCabecaTraseiro";
            this.chbEncostoCabecaTraseiro.Size = new System.Drawing.Size(236, 24);
            this.chbEncostoCabecaTraseiro.TabIndex = 27;
            this.chbEncostoCabecaTraseiro.Text = "Encosto de cabeça traseiro";
            this.chbEncostoCabecaTraseiro.UseVisualStyleBackColor = true;
            // 
            // chbParaChoqueCor
            // 
            this.chbParaChoqueCor.AutoSize = true;
            this.chbParaChoqueCor.Location = new System.Drawing.Point(321, 402);
            this.chbParaChoqueCor.Name = "chbParaChoqueCor";
            this.chbParaChoqueCor.Size = new System.Drawing.Size(258, 24);
            this.chbParaChoqueCor.TabIndex = 28;
            this.chbParaChoqueCor.Text = "Para-choque na cor do veículo";
            this.chbParaChoqueCor.UseVisualStyleBackColor = true;
            // 
            // chbCentralMultimidia
            // 
            this.chbCentralMultimidia.AutoSize = true;
            this.chbCentralMultimidia.Location = new System.Drawing.Point(1026, 325);
            this.chbCentralMultimidia.Name = "chbCentralMultimidia";
            this.chbCentralMultimidia.Size = new System.Drawing.Size(166, 24);
            this.chbCentralMultimidia.TabIndex = 29;
            this.chbCentralMultimidia.Text = "Central multimídia";
            this.chbCentralMultimidia.UseVisualStyleBackColor = true;
            // 
            // chbSensorEstacionamento
            // 
            this.chbSensorEstacionamento.AutoSize = true;
            this.chbSensorEstacionamento.Location = new System.Drawing.Point(521, 350);
            this.chbSensorEstacionamento.Name = "chbSensorEstacionamento";
            this.chbSensorEstacionamento.Size = new System.Drawing.Size(230, 24);
            this.chbSensorEstacionamento.TabIndex = 30;
            this.chbSensorEstacionamento.Text = "Sensor de estacionamento";
            this.chbSensorEstacionamento.UseVisualStyleBackColor = true;
            // 
            // chbPinturaMetalizada
            // 
            this.chbPinturaMetalizada.AutoSize = true;
            this.chbPinturaMetalizada.Location = new System.Drawing.Point(106, 403);
            this.chbPinturaMetalizada.Name = "chbPinturaMetalizada";
            this.chbPinturaMetalizada.Size = new System.Drawing.Size(170, 24);
            this.chbPinturaMetalizada.TabIndex = 31;
            this.chbPinturaMetalizada.Text = "Pintura metalizada";
            this.chbPinturaMetalizada.UseVisualStyleBackColor = true;
            // 
            // chbRodasLigaLeve
            // 
            this.chbRodasLigaLeve.AutoSize = true;
            this.chbRodasLigaLeve.Location = new System.Drawing.Point(321, 376);
            this.chbRodasLigaLeve.Name = "chbRodasLigaLeve";
            this.chbRodasLigaLeve.Size = new System.Drawing.Size(168, 24);
            this.chbRodasLigaLeve.TabIndex = 32;
            this.chbRodasLigaLeve.Text = "Rodas de liga leve";
            this.chbRodasLigaLeve.UseVisualStyleBackColor = true;
            // 
            // chbBancosCouro
            // 
            this.chbBancosCouro.AutoSize = true;
            this.chbBancosCouro.Location = new System.Drawing.Point(824, 376);
            this.chbBancosCouro.Name = "chbBancosCouro";
            this.chbBancosCouro.Size = new System.Drawing.Size(161, 24);
            this.chbBancosCouro.TabIndex = 33;
            this.chbBancosCouro.Text = "Bancos de Couro";
            this.chbBancosCouro.UseVisualStyleBackColor = true;
            // 
            // chbVolanteRegulagemAltura
            // 
            this.chbVolanteRegulagemAltura.AutoSize = true;
            this.chbVolanteRegulagemAltura.Location = new System.Drawing.Point(521, 298);
            this.chbVolanteRegulagemAltura.Name = "chbVolanteRegulagemAltura";
            this.chbVolanteRegulagemAltura.Size = new System.Drawing.Size(277, 24);
            this.chbVolanteRegulagemAltura.TabIndex = 34;
            this.chbVolanteRegulagemAltura.Text = "Volante com regulagem de altura";
            this.chbVolanteRegulagemAltura.UseVisualStyleBackColor = true;
            // 
            // chbFreioAbs
            // 
            this.chbFreioAbs.AutoSize = true;
            this.chbFreioAbs.Location = new System.Drawing.Point(1026, 351);
            this.chbFreioAbs.Name = "chbFreioAbs";
            this.chbFreioAbs.Size = new System.Drawing.Size(108, 24);
            this.chbFreioAbs.TabIndex = 36;
            this.chbFreioAbs.Text = "Freio ABS";
            this.chbFreioAbs.UseVisualStyleBackColor = true;
            // 
            // chbGps
            // 
            this.chbGps.AutoSize = true;
            this.chbGps.Location = new System.Drawing.Point(107, 377);
            this.chbGps.Name = "chbGps";
            this.chbGps.Size = new System.Drawing.Size(66, 24);
            this.chbGps.TabIndex = 37;
            this.chbGps.Text = "GPS";
            this.chbGps.UseVisualStyleBackColor = true;
            // 
            // chbAirBag
            // 
            this.chbAirBag.AutoSize = true;
            this.chbAirBag.Location = new System.Drawing.Point(824, 350);
            this.chbAirBag.Name = "chbAirBag";
            this.chbAirBag.Size = new System.Drawing.Size(82, 24);
            this.chbAirBag.TabIndex = 38;
            this.chbAirBag.Text = "AirBag";
            this.chbAirBag.UseVisualStyleBackColor = true;
            // 
            // chbTracao4x4
            // 
            this.chbTracao4x4.AutoSize = true;
            this.chbTracao4x4.Location = new System.Drawing.Point(1026, 377);
            this.chbTracao4x4.Name = "chbTracao4x4";
            this.chbTracao4x4.Size = new System.Drawing.Size(117, 24);
            this.chbTracao4x4.TabIndex = 39;
            this.chbTracao4x4.Text = "Tração 4X4";
            this.chbTracao4x4.UseVisualStyleBackColor = true;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(604, 114);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(118, 20);
            this.lblPlaca.TabIndex = 41;
            this.lblPlaca.Text = "Final de placa:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(799, 114);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(58, 20);
            this.lblPreco.TabIndex = 45;
            this.lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(802, 149);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ShortcutsEnabled = false;
            this.txtPreco.Size = new System.Drawing.Size(88, 26);
            this.txtPreco.TabIndex = 44;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.Location = new System.Drawing.Point(30, 230);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(113, 20);
            this.lblObservacoes.TabIndex = 47;
            this.lblObservacoes.Text = "Observações:";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Location = new System.Drawing.Point(128, 230);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.ShortcutsEnabled = false;
            this.txtObservacoes.Size = new System.Drawing.Size(314, 26);
            this.txtObservacoes.TabIndex = 46;
            this.txtObservacoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservacoes_KeyPress);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(545, 492);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(106, 35);
            this.btnSalvar.TabIndex = 48;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(306, 492);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(106, 35);
            this.btnAlterar.TabIndex = 49;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(734, 492);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(106, 35);
            this.btnExcluir.TabIndex = 50;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(799, 28);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(41, 20);
            this.lblCor.TabIndex = 52;
            this.lblCor.Text = "Cor:";
            // 
            // cbCor
            // 
            this.cbCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Location = new System.Drawing.Point(802, 61);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(112, 28);
            this.cbCor.TabIndex = 51;
            this.cbCor.DropDown += new System.EventHandler(this.cbCor_DropDown);
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(31, 61);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(130, 28);
            this.cbMarca.TabIndex = 53;
            this.cbMarca.DropDown += new System.EventHandler(this.cbMarca_DropDown);
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(287, 61);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(194, 28);
            this.cbModelo.TabIndex = 55;
            this.cbModelo.DropDown += new System.EventHandler(this.cbModelo_DropDown);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(284, 28);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(68, 20);
            this.lblModelo.TabIndex = 54;
            this.lblModelo.Text = "Modelo:";
            // 
            // cbPlaca
            // 
            this.cbPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlaca.FormattingEnabled = true;
            this.cbPlaca.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbPlaca.Location = new System.Drawing.Point(607, 147);
            this.cbPlaca.Name = "cbPlaca";
            this.cbPlaca.Size = new System.Drawing.Size(32, 28);
            this.cbPlaca.TabIndex = 56;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(607, 227);
            this.txtId.Name = "txtId";
            this.txtId.ShortcutsEnabled = false;
            this.txtId.Size = new System.Drawing.Size(32, 26);
            this.txtId.TabIndex = 57;
            this.txtId.Visible = false;
            // 
            // frmCarroInserirAlterarDeletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 562);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbPlaca);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.cbCor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblObservacoes);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.chbTracao4x4);
            this.Controls.Add(this.chbAirBag);
            this.Controls.Add(this.chbGps);
            this.Controls.Add(this.chbFreioAbs);
            this.Controls.Add(this.chbVolanteRegulagemAltura);
            this.Controls.Add(this.chbBancosCouro);
            this.Controls.Add(this.chbRodasLigaLeve);
            this.Controls.Add(this.chbPinturaMetalizada);
            this.Controls.Add(this.chbSensorEstacionamento);
            this.Controls.Add(this.chbCentralMultimidia);
            this.Controls.Add(this.chbParaChoqueCor);
            this.Controls.Add(this.chbEncostoCabecaTraseiro);
            this.Controls.Add(this.chbDesembaçadorLimpadorTraseiro);
            this.Controls.Add(this.chbArQuente);
            this.Controls.Add(this.chbTetoSolar);
            this.Controls.Add(this.chbRetrovisoresEletricos);
            this.Controls.Add(this.chbArCondicionado);
            this.Controls.Add(this.chbAlarme);
            this.Controls.Add(this.chbTravasEletricas);
            this.Controls.Add(this.chbVidrosEletricos);
            this.Controls.Add(this.chbDirecaoEletrica);
            this.Controls.Add(this.chbDirecaoHidraulica);
            this.Controls.Add(this.lblOpcionais);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.lblCombustivel);
            this.Controls.Add(this.cbCombustivel);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.cbCambio);
            this.Controls.Add(this.mtbAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblMarca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCarroInserirAlterarDeletar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmCarroInserirAlterarDeletar_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCarroInserirAlterarDeletar_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.MaskedTextBox mtbAno;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.ComboBox cbCombustivel;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.ComboBox cbCambio;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label lblOpcionais;
        private System.Windows.Forms.CheckBox chbDirecaoHidraulica;
        private System.Windows.Forms.CheckBox chbDirecaoEletrica;
        private System.Windows.Forms.CheckBox chbVidrosEletricos;
        private System.Windows.Forms.CheckBox chbTravasEletricas;
        private System.Windows.Forms.CheckBox chbAlarme;
        private System.Windows.Forms.CheckBox chbArCondicionado;
        private System.Windows.Forms.CheckBox chbRetrovisoresEletricos;
        private System.Windows.Forms.CheckBox chbTetoSolar;
        private System.Windows.Forms.CheckBox chbArQuente;
        private System.Windows.Forms.CheckBox chbDesembaçadorLimpadorTraseiro;
        private System.Windows.Forms.CheckBox chbEncostoCabecaTraseiro;
        private System.Windows.Forms.CheckBox chbParaChoqueCor;
        private System.Windows.Forms.CheckBox chbCentralMultimidia;
        private System.Windows.Forms.CheckBox chbSensorEstacionamento;
        private System.Windows.Forms.CheckBox chbPinturaMetalizada;
        private System.Windows.Forms.CheckBox chbRodasLigaLeve;
        private System.Windows.Forms.CheckBox chbBancosCouro;
        private System.Windows.Forms.CheckBox chbVolanteRegulagemAltura;
        private System.Windows.Forms.CheckBox chbFreioAbs;
        private System.Windows.Forms.CheckBox chbGps;
        private System.Windows.Forms.CheckBox chbAirBag;
        private System.Windows.Forms.CheckBox chbTracao4x4;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cbPlaca;
        private System.Windows.Forms.TextBox txtId;
    }
}