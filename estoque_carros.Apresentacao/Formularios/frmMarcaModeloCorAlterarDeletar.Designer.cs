namespace estoque_carros.Apresentacao.Formularios
{
    partial class frmMarcaModeloCorAlterarDeletar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcaModeloCorAlterarDeletar));
            lblMarcaModeloCor = new Label();
            txtMarcaModeloCor = new TextBox();
            btnAlterar = new Button();
            btnExcluir = new Button();
            cbMarca = new ComboBox();
            lblMarca = new Label();
            cbPortas = new ComboBox();
            lblPortas = new Label();
            cbMotor = new ComboBox();
            lblMotor = new Label();
            SuspendLayout();
            // 
            // lblMarcaModeloCor
            // 
            lblMarcaModeloCor.AutoSize = true;
            lblMarcaModeloCor.Location = new Point(20, 28);
            lblMarcaModeloCor.Margin = new Padding(4, 0, 4, 0);
            lblMarcaModeloCor.Name = "lblMarcaModeloCor";
            lblMarcaModeloCor.Size = new Size(0, 20);
            lblMarcaModeloCor.TabIndex = 11;
            // 
            // txtMarcaModeloCor
            // 
            txtMarcaModeloCor.Location = new Point(23, 61);
            txtMarcaModeloCor.Margin = new Padding(4);
            txtMarcaModeloCor.Name = "txtMarcaModeloCor";
            txtMarcaModeloCor.ShortcutsEnabled = false;
            txtMarcaModeloCor.Size = new Size(161, 26);
            txtMarcaModeloCor.TabIndex = 10;
            txtMarcaModeloCor.KeyPress += txtMarcaModeloCor_KeyPress;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(127, 151);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(101, 35);
            btnAlterar.TabIndex = 50;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(433, 151);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(101, 35);
            btnExcluir.TabIndex = 51;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // cbMarca
            // 
            cbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMarca.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMarca.FormattingEnabled = true;
            cbMarca.Location = new Point(247, 61);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(161, 28);
            cbMarca.TabIndex = 55;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(247, 28);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(61, 20);
            lblMarca.TabIndex = 54;
            lblMarca.Text = "Marca:";
            // 
            // cbPortas
            // 
            cbPortas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPortas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPortas.FormattingEnabled = true;
            cbPortas.Items.AddRange(new object[] { "2P", "3P", "4P", "5P" });
            cbPortas.Location = new Point(471, 63);
            cbPortas.Name = "cbPortas";
            cbPortas.Size = new Size(50, 28);
            cbPortas.TabIndex = 58;
            // 
            // lblPortas
            // 
            lblPortas.AutoSize = true;
            lblPortas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPortas.Location = new Point(471, 28);
            lblPortas.Name = "lblPortas";
            lblPortas.Size = new Size(63, 20);
            lblPortas.TabIndex = 57;
            lblPortas.Text = "Portas:";
            // 
            // cbMotor
            // 
            cbMotor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMotor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMotor.FormattingEnabled = true;
            cbMotor.Items.AddRange(new object[] { "1.0", "1.2", "1.4", "1.6", "1.8", "2.0" });
            cbMotor.Location = new Point(584, 61);
            cbMotor.Name = "cbMotor";
            cbMotor.Size = new Size(85, 28);
            cbMotor.TabIndex = 60;
            // 
            // lblMotor
            // 
            lblMotor.AutoSize = true;
            lblMotor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMotor.Location = new Point(584, 28);
            lblMotor.Name = "lblMotor";
            lblMotor.Size = new Size(57, 20);
            lblMotor.TabIndex = 59;
            lblMotor.Text = "Motor:";
            // 
            // frmMarcaModeloCorAlterarDeletar
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 211);
            Controls.Add(cbMotor);
            Controls.Add(lblMotor);
            Controls.Add(cbPortas);
            Controls.Add(lblPortas);
            Controls.Add(cbMarca);
            Controls.Add(lblMarca);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(lblMarcaModeloCor);
            Controls.Add(txtMarcaModeloCor);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmMarcaModeloCorAlterarDeletar";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMarcaModeloCorAlterarDeletar_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcaModeloCor;
        private System.Windows.Forms.TextBox txtMarcaModeloCor;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbPortas;
        private System.Windows.Forms.Label lblPortas;
        private System.Windows.Forms.ComboBox cbMotor;
        private System.Windows.Forms.Label lblMotor;
    }
}