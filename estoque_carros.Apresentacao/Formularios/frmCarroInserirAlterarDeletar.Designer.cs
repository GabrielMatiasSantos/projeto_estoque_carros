namespace estoque_carros.Apresentacao.Formularios
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
            lblMarca = new Label();
            lblAno = new Label();
            mtbAno = new MaskedTextBox();
            lblCombustivel = new Label();
            cbCombustivel = new ComboBox();
            lblCambio = new Label();
            cbCambio = new ComboBox();
            lblKm = new Label();
            txtKm = new TextBox();
            lblOpcionais = new Label();
            chbDirecaoHidraulica = new CheckBox();
            chbDirecaoEletrica = new CheckBox();
            chbVidrosEletricos = new CheckBox();
            chbTravasEletricas = new CheckBox();
            chbAlarme = new CheckBox();
            chbArCondicionado = new CheckBox();
            chbRetrovisoresEletricos = new CheckBox();
            chbTetoSolar = new CheckBox();
            chbArQuente = new CheckBox();
            chbDesembaçadorLimpadorTraseiro = new CheckBox();
            chbEncostoCabecaTraseiro = new CheckBox();
            chbParaChoqueCor = new CheckBox();
            chbCentralMultimidia = new CheckBox();
            chbSensorEstacionamento = new CheckBox();
            chbPinturaMetalizada = new CheckBox();
            chbRodasLigaLeve = new CheckBox();
            chbBancosCouro = new CheckBox();
            chbVolanteRegulagemAltura = new CheckBox();
            chbFreioAbs = new CheckBox();
            chbGps = new CheckBox();
            chbAirBag = new CheckBox();
            chbTracao4x4 = new CheckBox();
            lblPlaca = new Label();
            lblPreco = new Label();
            txtPreco = new TextBox();
            lblObservacoes = new Label();
            txtObservacoes = new TextBox();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            lblCor = new Label();
            cbCor = new ComboBox();
            cbMarca = new ComboBox();
            cbModelo = new ComboBox();
            lblModelo = new Label();
            cbPlaca = new ComboBox();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(27, 18);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(61, 20);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca:";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAno.Location = new Point(666, 18);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(211, 20);
            lblAno.TabIndex = 2;
            lblAno.Text = "Ano (fabricação e modelo):";
            // 
            // mtbAno
            // 
            mtbAno.Location = new Point(666, 61);
            mtbAno.Mask = "9999/9999";
            mtbAno.Name = "mtbAno";
            mtbAno.ShortcutsEnabled = false;
            mtbAno.Size = new Size(81, 26);
            mtbAno.TabIndex = 7;
            // 
            // lblCombustivel
            // 
            lblCombustivel.AutoSize = true;
            lblCombustivel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCombustivel.Location = new Point(27, 117);
            lblCombustivel.Name = "lblCombustivel";
            lblCombustivel.Size = new Size(106, 20);
            lblCombustivel.TabIndex = 10;
            lblCombustivel.Text = "Combustível:";
            // 
            // cbCombustivel
            // 
            cbCombustivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCombustivel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCombustivel.FormattingEnabled = true;
            cbCombustivel.Location = new Point(27, 159);
            cbCombustivel.Name = "cbCombustivel";
            cbCombustivel.Size = new Size(152, 28);
            cbCombustivel.TabIndex = 14;
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCambio.Location = new Point(1192, 18);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(71, 20);
            lblCambio.TabIndex = 4;
            lblCambio.Text = "Câmbio:";
            // 
            // cbCambio
            // 
            cbCambio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCambio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCambio.FormattingEnabled = true;
            cbCambio.Location = new Point(1192, 59);
            cbCambio.Name = "cbCambio";
            cbCambio.Size = new Size(170, 28);
            cbCambio.TabIndex = 9;
            // 
            // lblKm
            // 
            lblKm.AutoSize = true;
            lblKm.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKm.Location = new Point(330, 117);
            lblKm.Name = "lblKm";
            lblKm.Size = new Size(128, 20);
            lblKm.TabIndex = 11;
            lblKm.Text = "Quilometragem:";
            // 
            // txtKm
            // 
            txtKm.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKm.Location = new Point(330, 159);
            txtKm.Name = "txtKm";
            txtKm.ShortcutsEnabled = false;
            txtKm.Size = new Size(99, 26);
            txtKm.TabIndex = 15;
            txtKm.TextChanged += txtKm_TextChanged;
            txtKm.KeyPress += txtKm_KeyPress;
            // 
            // lblOpcionais
            // 
            lblOpcionais.AutoSize = true;
            lblOpcionais.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOpcionais.Location = new Point(10, 310);
            lblOpcionais.Name = "lblOpcionais";
            lblOpcionais.Size = new Size(89, 20);
            lblOpcionais.TabIndex = 21;
            lblOpcionais.Text = "Opcionais:";
            // 
            // chbDirecaoHidraulica
            // 
            chbDirecaoHidraulica.AutoSize = true;
            chbDirecaoHidraulica.Location = new Point(117, 311);
            chbDirecaoHidraulica.Name = "chbDirecaoHidraulica";
            chbDirecaoHidraulica.Size = new Size(167, 24);
            chbDirecaoHidraulica.TabIndex = 22;
            chbDirecaoHidraulica.Text = "Direção hidráulica";
            chbDirecaoHidraulica.UseVisualStyleBackColor = true;
            chbDirecaoHidraulica.CheckedChanged += chbDirecaoHidraulica_CheckedChanged;
            // 
            // chbDirecaoEletrica
            // 
            chbDirecaoEletrica.AutoSize = true;
            chbDirecaoEletrica.Location = new Point(373, 313);
            chbDirecaoEletrica.Name = "chbDirecaoEletrica";
            chbDirecaoEletrica.Size = new Size(150, 24);
            chbDirecaoEletrica.TabIndex = 23;
            chbDirecaoEletrica.Text = "Direção elétrica";
            chbDirecaoEletrica.UseVisualStyleBackColor = true;
            chbDirecaoEletrica.CheckedChanged += chbDirecaoEletrica_CheckedChanged;
            // 
            // chbVidrosEletricos
            // 
            chbVidrosEletricos.AutoSize = true;
            chbVidrosEletricos.Location = new Point(1218, 312);
            chbVidrosEletricos.Name = "chbVidrosEletricos";
            chbVidrosEletricos.Size = new Size(148, 24);
            chbVidrosEletricos.TabIndex = 26;
            chbVidrosEletricos.Text = "Vidros elétricos";
            chbVidrosEletricos.UseVisualStyleBackColor = true;
            // 
            // chbTravasEletricas
            // 
            chbTravasEletricas.AutoSize = true;
            chbTravasEletricas.Location = new Point(978, 313);
            chbTravasEletricas.Name = "chbTravasEletricas";
            chbTravasEletricas.Size = new Size(151, 24);
            chbTravasEletricas.TabIndex = 25;
            chbTravasEletricas.Text = "Travas elétricas";
            chbTravasEletricas.UseVisualStyleBackColor = true;
            // 
            // chbAlarme
            // 
            chbAlarme.AutoSize = true;
            chbAlarme.Location = new Point(612, 339);
            chbAlarme.Name = "chbAlarme";
            chbAlarme.Size = new Size(84, 24);
            chbAlarme.TabIndex = 29;
            chbAlarme.Text = "Alarme";
            chbAlarme.UseVisualStyleBackColor = true;
            // 
            // chbArCondicionado
            // 
            chbArCondicionado.AutoSize = true;
            chbArCondicionado.Location = new Point(117, 340);
            chbArCondicionado.Name = "chbArCondicionado";
            chbArCondicionado.Size = new Size(152, 24);
            chbArCondicionado.TabIndex = 27;
            chbArCondicionado.Text = "Ar-condicionado";
            chbArCondicionado.UseVisualStyleBackColor = true;
            // 
            // chbRetrovisoresEletricos
            // 
            chbRetrovisoresEletricos.AutoSize = true;
            chbRetrovisoresEletricos.Location = new Point(978, 340);
            chbRetrovisoresEletricos.Name = "chbRetrovisoresEletricos";
            chbRetrovisoresEletricos.Size = new Size(195, 24);
            chbRetrovisoresEletricos.TabIndex = 30;
            chbRetrovisoresEletricos.Text = "Retrovisores elétricos";
            chbRetrovisoresEletricos.UseVisualStyleBackColor = true;
            // 
            // chbTetoSolar
            // 
            chbTetoSolar.AutoSize = true;
            chbTetoSolar.Location = new Point(117, 369);
            chbTetoSolar.Name = "chbTetoSolar";
            chbTetoSolar.Size = new Size(106, 24);
            chbTetoSolar.TabIndex = 32;
            chbTetoSolar.Text = "Teto solar";
            chbTetoSolar.UseVisualStyleBackColor = true;
            // 
            // chbArQuente
            // 
            chbArQuente.AutoSize = true;
            chbArQuente.Location = new Point(373, 342);
            chbArQuente.Name = "chbArQuente";
            chbArQuente.Size = new Size(103, 24);
            chbArQuente.TabIndex = 28;
            chbArQuente.Text = "Ar quente";
            chbArQuente.UseVisualStyleBackColor = true;
            // 
            // chbDesembaçadorLimpadorTraseiro
            // 
            chbDesembaçadorLimpadorTraseiro.AutoSize = true;
            chbDesembaçadorLimpadorTraseiro.Location = new Point(612, 400);
            chbDesembaçadorLimpadorTraseiro.Name = "chbDesembaçadorLimpadorTraseiro";
            chbDesembaçadorLimpadorTraseiro.Size = new Size(295, 24);
            chbDesembaçadorLimpadorTraseiro.TabIndex = 39;
            chbDesembaçadorLimpadorTraseiro.Text = "Desembaçador e limpador traseiro ";
            chbDesembaçadorLimpadorTraseiro.UseVisualStyleBackColor = true;
            // 
            // chbEncostoCabecaTraseiro
            // 
            chbEncostoCabecaTraseiro.AutoSize = true;
            chbEncostoCabecaTraseiro.Location = new Point(373, 371);
            chbEncostoCabecaTraseiro.Name = "chbEncostoCabecaTraseiro";
            chbEncostoCabecaTraseiro.Size = new Size(236, 24);
            chbEncostoCabecaTraseiro.TabIndex = 33;
            chbEncostoCabecaTraseiro.Text = "Encosto de cabeça traseiro";
            chbEncostoCabecaTraseiro.UseVisualStyleBackColor = true;
            // 
            // chbParaChoqueCor
            // 
            chbParaChoqueCor.AutoSize = true;
            chbParaChoqueCor.Location = new Point(373, 429);
            chbParaChoqueCor.Name = "chbParaChoqueCor";
            chbParaChoqueCor.Size = new Size(258, 24);
            chbParaChoqueCor.TabIndex = 43;
            chbParaChoqueCor.Text = "Para-choque na cor do veículo";
            chbParaChoqueCor.UseVisualStyleBackColor = true;
            // 
            // chbCentralMultimidia
            // 
            chbCentralMultimidia.AutoSize = true;
            chbCentralMultimidia.Location = new Point(1218, 340);
            chbCentralMultimidia.Name = "chbCentralMultimidia";
            chbCentralMultimidia.Size = new Size(166, 24);
            chbCentralMultimidia.TabIndex = 31;
            chbCentralMultimidia.Text = "Central multimídia";
            chbCentralMultimidia.UseVisualStyleBackColor = true;
            // 
            // chbSensorEstacionamento
            // 
            chbSensorEstacionamento.AutoSize = true;
            chbSensorEstacionamento.Location = new Point(612, 369);
            chbSensorEstacionamento.Name = "chbSensorEstacionamento";
            chbSensorEstacionamento.Size = new Size(230, 24);
            chbSensorEstacionamento.TabIndex = 34;
            chbSensorEstacionamento.Text = "Sensor de estacionamento";
            chbSensorEstacionamento.UseVisualStyleBackColor = true;
            // 
            // chbPinturaMetalizada
            // 
            chbPinturaMetalizada.AutoSize = true;
            chbPinturaMetalizada.Location = new Point(117, 427);
            chbPinturaMetalizada.Name = "chbPinturaMetalizada";
            chbPinturaMetalizada.Size = new Size(170, 24);
            chbPinturaMetalizada.TabIndex = 42;
            chbPinturaMetalizada.Text = "Pintura metalizada";
            chbPinturaMetalizada.UseVisualStyleBackColor = true;
            // 
            // chbRodasLigaLeve
            // 
            chbRodasLigaLeve.AutoSize = true;
            chbRodasLigaLeve.Location = new Point(373, 400);
            chbRodasLigaLeve.Name = "chbRodasLigaLeve";
            chbRodasLigaLeve.Size = new Size(168, 24);
            chbRodasLigaLeve.TabIndex = 38;
            chbRodasLigaLeve.Text = "Rodas de liga leve";
            chbRodasLigaLeve.UseVisualStyleBackColor = true;
            // 
            // chbBancosCouro
            // 
            chbBancosCouro.AutoSize = true;
            chbBancosCouro.Location = new Point(978, 399);
            chbBancosCouro.Name = "chbBancosCouro";
            chbBancosCouro.Size = new Size(161, 24);
            chbBancosCouro.TabIndex = 40;
            chbBancosCouro.Text = "Bancos de Couro";
            chbBancosCouro.UseVisualStyleBackColor = true;
            // 
            // chbVolanteRegulagemAltura
            // 
            chbVolanteRegulagemAltura.AutoSize = true;
            chbVolanteRegulagemAltura.Location = new Point(612, 311);
            chbVolanteRegulagemAltura.Name = "chbVolanteRegulagemAltura";
            chbVolanteRegulagemAltura.Size = new Size(277, 24);
            chbVolanteRegulagemAltura.TabIndex = 24;
            chbVolanteRegulagemAltura.Text = "Volante com regulagem de altura";
            chbVolanteRegulagemAltura.UseVisualStyleBackColor = true;
            // 
            // chbFreioAbs
            // 
            chbFreioAbs.AutoSize = true;
            chbFreioAbs.Location = new Point(1218, 369);
            chbFreioAbs.Name = "chbFreioAbs";
            chbFreioAbs.Size = new Size(108, 24);
            chbFreioAbs.TabIndex = 36;
            chbFreioAbs.Text = "Freio ABS";
            chbFreioAbs.UseVisualStyleBackColor = true;
            // 
            // chbGps
            // 
            chbGps.AutoSize = true;
            chbGps.Location = new Point(117, 398);
            chbGps.Name = "chbGps";
            chbGps.Size = new Size(66, 24);
            chbGps.TabIndex = 37;
            chbGps.Text = "GPS";
            chbGps.UseVisualStyleBackColor = true;
            // 
            // chbAirBag
            // 
            chbAirBag.AutoSize = true;
            chbAirBag.Location = new Point(978, 369);
            chbAirBag.Name = "chbAirBag";
            chbAirBag.Size = new Size(82, 24);
            chbAirBag.TabIndex = 35;
            chbAirBag.Text = "AirBag";
            chbAirBag.UseVisualStyleBackColor = true;
            // 
            // chbTracao4x4
            // 
            chbTracao4x4.AutoSize = true;
            chbTracao4x4.Location = new Point(1218, 399);
            chbTracao4x4.Name = "chbTracao4x4";
            chbTracao4x4.Size = new Size(117, 24);
            chbTracao4x4.TabIndex = 41;
            chbTracao4x4.Text = "Tração 4X4";
            chbTracao4x4.UseVisualStyleBackColor = true;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlaca.Location = new Point(669, 117);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(118, 20);
            lblPlaca.TabIndex = 12;
            lblPlaca.Text = "Final de placa:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(889, 117);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(58, 20);
            lblPreco.TabIndex = 13;
            lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreco.Location = new Point(889, 161);
            txtPreco.Name = "txtPreco";
            txtPreco.ShortcutsEnabled = false;
            txtPreco.Size = new Size(88, 26);
            txtPreco.TabIndex = 17;
            txtPreco.TextChanged += txtPreco_TextChanged;
            txtPreco.KeyPress += txtPreco_KeyPress;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObservacoes.Location = new Point(30, 230);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(113, 20);
            lblObservacoes.TabIndex = 18;
            lblObservacoes.Text = "Observações:";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservacoes.Location = new Point(160, 230);
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.ShortcutsEnabled = false;
            txtObservacoes.Size = new Size(314, 26);
            txtObservacoes.TabIndex = 19;
            txtObservacoes.KeyPress += txtObservacoes_KeyPress;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(666, 489);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(106, 35);
            btnSalvar.TabIndex = 45;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(325, 489);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(106, 35);
            btnAlterar.TabIndex = 44;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(972, 489);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(106, 35);
            btnExcluir.TabIndex = 46;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCor.Location = new Point(889, 18);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(41, 20);
            lblCor.TabIndex = 3;
            lblCor.Text = "Cor:";
            // 
            // cbCor
            // 
            cbCor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCor.FormattingEnabled = true;
            cbCor.Location = new Point(889, 61);
            cbCor.Name = "cbCor";
            cbCor.Size = new Size(161, 28);
            cbCor.TabIndex = 8;
            // 
            // cbMarca
            // 
            cbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMarca.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMarca.FormattingEnabled = true;
            cbMarca.Location = new Point(27, 59);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(161, 28);
            cbMarca.TabIndex = 5;
            cbMarca.SelectedIndexChanged += cbMarca_SelectedIndexChanged;
            // 
            // cbModelo
            // 
            cbModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModelo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbModelo.FormattingEnabled = true;
            cbModelo.Location = new Point(330, 61);
            cbModelo.Name = "cbModelo";
            cbModelo.Size = new Size(194, 28);
            cbModelo.TabIndex = 6;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModelo.Location = new Point(330, 18);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(68, 20);
            lblModelo.TabIndex = 1;
            lblModelo.Text = "Modelo:";
            // 
            // cbPlaca
            // 
            cbPlaca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPlaca.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPlaca.FormattingEnabled = true;
            cbPlaca.Location = new Point(669, 159);
            cbPlaca.Name = "cbPlaca";
            cbPlaca.Size = new Size(42, 28);
            cbPlaca.TabIndex = 16;
            // 
            // frmCarroInserirAlterarDeletar
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 562);
            Controls.Add(chbDirecaoHidraulica);
            Controls.Add(chbDirecaoEletrica);
            Controls.Add(chbVolanteRegulagemAltura);
            Controls.Add(chbTravasEletricas);
            Controls.Add(chbVidrosEletricos);
            Controls.Add(chbArCondicionado);
            Controls.Add(chbArQuente);
            Controls.Add(chbAlarme);
            Controls.Add(chbRetrovisoresEletricos);
            Controls.Add(chbEncostoCabecaTraseiro);
            Controls.Add(chbSensorEstacionamento);
            Controls.Add(chbAirBag);
            Controls.Add(chbFreioAbs);
            Controls.Add(chbGps);
            Controls.Add(chbRodasLigaLeve);
            Controls.Add(chbTetoSolar);
            Controls.Add(chbCentralMultimidia);
            Controls.Add(chbDesembaçadorLimpadorTraseiro);
            Controls.Add(chbBancosCouro);
            Controls.Add(chbTracao4x4);
            Controls.Add(chbPinturaMetalizada);
            Controls.Add(chbParaChoqueCor);
            Controls.Add(cbPlaca);
            Controls.Add(cbModelo);
            Controls.Add(lblModelo);
            Controls.Add(cbMarca);
            Controls.Add(lblCor);
            Controls.Add(cbCor);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnSalvar);
            Controls.Add(lblObservacoes);
            Controls.Add(txtObservacoes);
            Controls.Add(lblPreco);
            Controls.Add(txtPreco);
            Controls.Add(lblPlaca);
            Controls.Add(lblOpcionais);
            Controls.Add(lblKm);
            Controls.Add(txtKm);
            Controls.Add(lblCombustivel);
            Controls.Add(cbCombustivel);
            Controls.Add(lblCambio);
            Controls.Add(cbCambio);
            Controls.Add(mtbAno);
            Controls.Add(lblAno);
            Controls.Add(lblMarca);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmCarroInserirAlterarDeletar";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmCarroInserirAlterarDeletar_Load;
            ResumeLayout(false);
            PerformLayout();

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
    }
}