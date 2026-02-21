namespace estoque_carros
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
            this.lblMarcaModeloCor = new System.Windows.Forms.Label();
            this.txtMarcaModeloCor = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbPortas = new System.Windows.Forms.ComboBox();
            this.lblPortas = new System.Windows.Forms.Label();
            this.cbMotor = new System.Windows.Forms.ComboBox();
            this.lblMotor = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMarcaModeloCor
            // 
            this.lblMarcaModeloCor.AutoSize = true;
            this.lblMarcaModeloCor.Location = new System.Drawing.Point(20, 28);
            this.lblMarcaModeloCor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaModeloCor.Name = "lblMarcaModeloCor";
            this.lblMarcaModeloCor.Size = new System.Drawing.Size(0, 20);
            this.lblMarcaModeloCor.TabIndex = 11;
            // 
            // txtMarcaModeloCor
            // 
            this.txtMarcaModeloCor.Location = new System.Drawing.Point(23, 61);
            this.txtMarcaModeloCor.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarcaModeloCor.Name = "txtMarcaModeloCor";
            this.txtMarcaModeloCor.ShortcutsEnabled = false;
            this.txtMarcaModeloCor.Size = new System.Drawing.Size(149, 26);
            this.txtMarcaModeloCor.TabIndex = 10;
            this.txtMarcaModeloCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarcaModeloCor_KeyPress);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(127, 151);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 35);
            this.btnAlterar.TabIndex = 50;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(433, 151);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 35);
            this.btnExcluir.TabIndex = 51;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(264, 61);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(130, 28);
            this.cbMarca.TabIndex = 55;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(261, 28);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(61, 20);
            this.lblMarca.TabIndex = 54;
            this.lblMarca.Text = "Marca:";
            // 
            // cbPortas
            // 
            this.cbPortas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPortas.FormattingEnabled = true;
            this.cbPortas.Items.AddRange(new object[] {
            "2P",
            "3P",
            "4P",
            "5P"});
            this.cbPortas.Location = new System.Drawing.Point(486, 63);
            this.cbPortas.Name = "cbPortas";
            this.cbPortas.Size = new System.Drawing.Size(41, 28);
            this.cbPortas.TabIndex = 58;
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortas.Location = new System.Drawing.Point(483, 28);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(63, 20);
            this.lblPortas.TabIndex = 57;
            this.lblPortas.Text = "Portas:";
            // 
            // cbMotor
            // 
            this.cbMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotor.FormattingEnabled = true;
            this.cbMotor.Items.AddRange(new object[] {
            "1.0",
            "1.2",
            "1.4",
            "1.6",
            "1.8",
            "2.0"});
            this.cbMotor.Location = new System.Drawing.Point(619, 61);
            this.cbMotor.Name = "cbMotor";
            this.cbMotor.Size = new System.Drawing.Size(41, 28);
            this.cbMotor.TabIndex = 60;
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotor.Location = new System.Drawing.Point(616, 28);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(57, 20);
            this.lblMotor.TabIndex = 59;
            this.lblMotor.Text = "Motor:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(23, 110);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(30, 26);
            this.txtId.TabIndex = 61;
            this.txtId.Visible = false;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(74, 110);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(30, 26);
            this.txtMarca.TabIndex = 62;
            this.txtMarca.Visible = false;
            // 
            // frmMarcaModeloCorAlterarDeletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 211);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbMotor);
            this.Controls.Add(this.lblMotor);
            this.Controls.Add(this.cbPortas);
            this.Controls.Add(this.lblPortas);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblMarcaModeloCor);
            this.Controls.Add(this.txtMarcaModeloCor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMarcaModeloCorAlterarDeletar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMarcaModeloCorAlterarDeletar_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtMarca;
    }
}