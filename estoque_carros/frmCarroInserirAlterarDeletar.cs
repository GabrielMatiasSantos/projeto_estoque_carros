using estoque_carros.dbEstoqueCarrosDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque_carros
{
    public partial class frmCarroInserirAlterarDeletar : Form
    {
        public frmCarroInserirAlterarDeletar()
        {
            InitializeComponent();
        }

        public frmCarroInserirAlterarDeletar(string marca, string modelo, string ano, string cor, string cambio, string combustivel, string km, string placa, string opcionais, string observacoes, string preco, string id)
        {
            InitializeComponent();


            Marcas();

            cbMarca.Text = marca;


            Modelos();

            cbModelo.Text = modelo;

            mtbAno.Text = ano;


            Cores();

            cbCor.Text = cor;

            cbCambio.Text = cambio;

            cbCombustivel.Text = combustivel;

            txtKm.Text = km;

            cbPlaca.Text = placa;

            txtObservacoes.Text = observacoes;

            txtPreco.Text = preco;

            txtId.Text = id;


            if (opcionais.Contains(chbDirecaoHidraulica.Text))
            {
                chbDirecaoHidraulica.Checked = true;
            }

            if (opcionais.Contains(chbDirecaoEletrica.Text))
            {
                chbDirecaoEletrica.Checked = true;
            }

            if (opcionais.Contains(chbVolanteRegulagemAltura.Text))
            {
                chbVolanteRegulagemAltura.Checked = true;
            }

            if (opcionais.Contains(chbTravasEletricas.Text))
            {
                chbTravasEletricas.Checked = true;
            }

            if (opcionais.Contains(chbVidrosEletricos.Text))
            {
                chbVidrosEletricos.Checked = true;
            }

            if (opcionais.Contains(chbArCondicionado.Text))
            {
                chbArCondicionado.Checked = true;
            }

            if (opcionais.Contains(chbArQuente.Text))
            {
                chbArQuente.Checked = true;
            }

            if (opcionais.Contains(chbAlarme.Text))
            {
                chbAlarme.Checked = true;
            }

            if (opcionais.Contains(chbRetrovisoresEletricos.Text))
            {
                chbRetrovisoresEletricos.Checked = true;
            }

            if (opcionais.Contains(chbCentralMultimidia.Text))
            {
                chbCentralMultimidia.Checked = true;
            }

            if (opcionais.Contains(chbTetoSolar.Text))
            {
                chbTetoSolar.Checked = true;
            }

            if (opcionais.Contains(chbEncostoCabecaTraseiro.Text))
            {
                chbEncostoCabecaTraseiro.Checked = true;
            }

            if (opcionais.Contains(chbSensorEstacionamento.Text))
            {
                chbSensorEstacionamento.Checked = true;
            }

            if (opcionais.Contains(chbAirBag.Text))
            {
                chbAirBag.Checked = true;
            }

            if (opcionais.Contains(chbFreioAbs.Text))
            {
                chbFreioAbs.Checked = true;
            }

            if (opcionais.Contains(chbGps.Text))
            {
                chbGps.Checked = true;
            }

            if (opcionais.Contains(chbRodasLigaLeve.Text))
            {
                chbRodasLigaLeve.Checked = true;
            }

            if (opcionais.Contains(chbDesembaçadorLimpadorTraseiro.Text))
            {
                chbDesembaçadorLimpadorTraseiro.Checked = true;
            }

            if (opcionais.Contains(chbBancosCouro.Text))
            {
                chbBancosCouro.Checked = true;
            }

            if (opcionais.Contains(chbTracao4x4.Text))
            {
                chbTracao4x4.Checked = true;
            }

            if (opcionais.Contains(chbPinturaMetalizada.Text))
            {
                chbPinturaMetalizada.Checked = true;
            }

            if (opcionais.Contains(chbParaChoqueCor.Text))
            {
                chbParaChoqueCor.Checked = true;
            }
        }

  
        public void Marcas()
        {
            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection(StringConexao.stringConexao);

                SqlCommand pesquisar = new SqlCommand("SELECT * FROM tb_marcas ORDER BY marca_nome;", conexao);

                conexao.Open();

                SqlDataAdapter registros = new SqlDataAdapter(pesquisar);

                conexao.Close();

                DataTable tabela = new DataTable();

                registros.Fill(tabela);

                cbMarca.ValueMember = "marca_id";
                cbMarca.DisplayMember = "marca_nome";
                cbMarca.DataSource = tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexao != null && conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public void Modelos()
        {
            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection(StringConexao.stringConexao);

                SqlCommand pesquisar = new SqlCommand("SELECT modelo_id, modelo_nome FROM tb_modelos WHERE modelo_marca = @marca ORDER BY modelo_nome;", conexao);

                pesquisar.Parameters.AddWithValue("@marca", Convert.ToInt32(cbMarca.SelectedValue));

                conexao.Open();

                SqlDataAdapter registros = new SqlDataAdapter(pesquisar);

                conexao.Close();

                DataTable tabela = new DataTable();

                registros.Fill(tabela);

                cbModelo.ValueMember = "modelo_id";
                cbModelo.DisplayMember = "modelo_nome";
                cbModelo.DataSource = tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexao != null && conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public void Cores()
        {
            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection(StringConexao.stringConexao);

                SqlCommand pesquisar = new SqlCommand("SELECT * FROM tb_cores ORDER BY cor_nome;", conexao);

                conexao.Open();

                SqlDataAdapter registros = new SqlDataAdapter(pesquisar);

                conexao.Close();

                DataTable tabela = new DataTable();

                registros.Fill(tabela);

                cbCor.ValueMember = "cor_id";
                cbCor.DisplayMember = "cor_nome";
                cbCor.DataSource = tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexao != null && conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }


        public string Cabecalho
        {
            set { this.Text = value; }
        }

        public bool Salvar
        {
            set { btnSalvar.Visible = value; }
        }

        public bool Alterar
        {
            set { btnAlterar.Visible = value; }
        }

        public bool Excluir
        {
            set { btnExcluir.Visible = value; }
        }

        private void frmCarroInserirAlterarDeletar_Activated(object sender, EventArgs e)
        {
            cbMarca.Focus();
        }

        private void frmCarroInserirAlterarDeletar_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCarrosEstoque carros = new frmCarrosEstoque();

            carros.Aba = 3;

            carros.Show();
        }

        private void cbMarca_DropDown(object sender, EventArgs e)
        {
            cbModelo.SelectedIndex = -1;

            Marcas();
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbModelo.SelectedIndex = -1;
        }

        private void cbModelo_DropDown(object sender, EventArgs e)
        {           
           if (cbMarca.SelectedIndex == -1)
           {
                cbModelo.Items.Clear();

                MessageBox.Show("Primeiro selecione uma marca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
           else
           {
                Modelos();     
           }
        }

        private void cbCor_DropDown(object sender, EventArgs e)
        {
            Cores();
        }

        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }            
        }

        private void txtKm_TextChanged(object sender, EventArgs e)
        {
            if (txtKm.Text != "")
            {
                int cursor = txtKm.SelectionStart;

                int quantidade = txtKm.Text.Length;

                txtKm.Text = Convert.ToDecimal(txtKm.Text).ToString("N0");

                int quantidade2 = txtKm.Text.Length;

                if (quantidade2 > quantidade && txtKm.Text.Contains('.'))
                {
                    txtKm.SelectionStart = cursor + 1;
                }
                else
                {
                    txtKm.SelectionStart = cursor;
                }
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 8)
            {
                txtPreco.Clear();
            }
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
           if (txtPreco.Text != "")
           {
               int cursor = txtPreco.SelectionStart;

               int quantidade = txtPreco.Text.Length;

               txtPreco.Text = Convert.ToDecimal(txtPreco.Text).ToString("N");

               int quantidade2 = txtPreco.Text.Length;

               if (quantidade2 > quantidade && txtPreco.Text.Contains('.'))
               {
                   txtPreco.SelectionStart = cursor + 1;
               }
               else
               {
                   txtPreco.SelectionStart = cursor;
               }
           }
        }

        private void txtObservacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtObservacoes.Text == "")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
           else
           {
                if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void chbDirecaoHidraulica_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDirecaoHidraulica.Checked)
            {
                chbDirecaoEletrica.Checked = false;
            }
        }

        private void chbDirecaoEletrica_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDirecaoEletrica.Checked)
            {
                chbDirecaoHidraulica.Checked = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cbMarca.Text == "" || cbModelo.Text == "" || cbCor.Text == "" || cbCambio.Text == "" || cbCombustivel.Text == "" || txtKm.Text == "" || cbPlaca.Text == "" || txtPreco.Text == "")
            {
                MessageBox.Show("Apenas os campos 'Opcionais' e 'Observações' podem ficar sem informações. Os demais devem ser preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mtbAno.Text.Length < 9)
            {
                MessageBox.Show("Preencha o campo 'Ano (fabricação e modelo)' corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var ano = mtbAno.Text.Split('/');

                if (Convert.ToInt32(ano[0]) < 1960 || Convert.ToInt32(ano[0]) > 2099)
                {
                    MessageBox.Show("Ano de fabricação inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Convert.ToInt32(ano[1]) != Convert.ToInt32(ano[0]) && Convert.ToInt32(ano[1]) != Convert.ToInt32(ano[0]) + 1)
                {
                    MessageBox.Show("Ano de modelo de carro inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var botao = MessageBox.Show("Confirmar registro de um novo carro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    
                    if (botao == DialogResult.Yes)
                    {
                        SqlConnection conexao = null;

                        try
                        {
                            Carro carro = new Carro(Convert.ToInt32(cbModelo.SelectedValue), Convert.ToInt32(cbMarca.SelectedValue), mtbAno.Text, Convert.ToInt32(cbCor.SelectedValue), cbCambio.Text, cbCombustivel.Text, Convert.ToDecimal(txtKm.Text), Convert.ToInt32(cbPlaca.Text), Convert.ToDecimal(txtPreco.Text));

                            carro.Opcionais = default;
                            carro.Opcionais2 = default;
                            carro.Observacoes = default;

                            if (chbDirecaoHidraulica.Checked == false && chbDirecaoEletrica.Checked == false && chbVolanteRegulagemAltura.Checked == false && chbTravasEletricas.Checked == false && chbVidrosEletricos.Checked == false && chbArCondicionado.Checked == false && chbArQuente.Checked == false && chbAlarme.Checked == false && chbRetrovisoresEletricos.Checked == false && chbCentralMultimidia.Checked == false && chbTetoSolar.Checked == false && chbEncostoCabecaTraseiro.Checked == false && chbSensorEstacionamento.Checked == false && chbAirBag.Checked == false && chbFreioAbs.Checked == false && chbGps.Checked == false && chbRodasLigaLeve.Checked == false && chbDesembaçadorLimpadorTraseiro.Checked == false && chbBancosCouro.Checked == false && chbTracao4x4.Checked == false && chbPinturaMetalizada.Checked == false && chbParaChoqueCor.Checked == false)
                            {
                                carro.Opcionais = "Básico";
                                carro.Opcionais2 = "Básico";
                            }
                            else
                            {
                                if (chbDirecaoHidraulica.Checked)
                                {
                                    carro.Opcionais = chbDirecaoHidraulica.Text;
                                    carro.Opcionais2 = "Dir.Hid.";
                                }

                                if (chbDirecaoEletrica.Checked)
                                {
                                    carro.Opcionais = chbDirecaoEletrica.Text;
                                    carro.Opcionais2 = "Dir.Ele.";
                                }

                                if (chbVolanteRegulagemAltura.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbVolanteRegulagemAltura.Text;
                                    carro.Opcionais2 += "Vo.Reg.Alt.";
                                }

                                if (chbTravasEletricas.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbTravasEletricas.Text;
                                    carro.Opcionais2 += "Tr.Ele.";
                                }

                                if (chbVidrosEletricos.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbVidrosEletricos.Text;
                                    carro.Opcionais2 += "Vi.Ele.";
                                }

                                if (chbArCondicionado.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbArCondicionado.Text;
                                    carro.Opcionais2 += "ArCon.";
                                }

                                if (chbArQuente.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbArQuente.Text;
                                    carro.Opcionais2 += "ArQue.";
                                }

                                if (chbAlarme.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbAlarme.Text;
                                    carro.Opcionais2 += "Alm.";
                                }

                                if (chbRetrovisoresEletricos.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbRetrovisoresEletricos.Text;
                                    carro.Opcionais2 += "Ret.Ele.";
                                }

                                if (chbCentralMultimidia.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbCentralMultimidia.Text;
                                    carro.Opcionais2 += "Cen.Mult.";
                                }

                                if (chbTetoSolar.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbTetoSolar.Text;
                                    carro.Opcionais2 += "T.So.";
                                }

                                if (chbEncostoCabecaTraseiro.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbEncostoCabecaTraseiro.Text;
                                    carro.Opcionais2 += "En.Cab.Tra.";
                                }

                                if (chbSensorEstacionamento.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbSensorEstacionamento.Text;
                                    carro.Opcionais2 += "Sen.Est";
                                }

                                if (chbAirBag.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbAirBag.Text;
                                    carro.Opcionais2 += "A.Bag";
                                }

                                if (chbFreioAbs.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbFreioAbs.Text;
                                    carro.Opcionais2 += "ABS";
                                }

                                if (chbGps.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbGps.Text;
                                    carro.Opcionais2 += "GPS";
                                }

                                if (chbRodasLigaLeve.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbRodasLigaLeve.Text;
                                    carro.Opcionais2 += "R.L.Leve";
                                }

                                if (chbDesembaçadorLimpadorTraseiro.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbDesembaçadorLimpadorTraseiro.Text;
                                    carro.Opcionais2 += "Des.Lim.Tras.";
                                }

                                if (chbBancosCouro.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbBancosCouro.Text;
                                    carro.Opcionais2 += "BancoCouro";
                                }

                                if (chbTracao4x4.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbTracao4x4.Text;
                                    carro.Opcionais2 += "4X4";
                                }

                                if (chbPinturaMetalizada.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbPinturaMetalizada.Text;
                                    carro.Opcionais2 += "Pin.Met.";
                                }

                                if (chbParaChoqueCor.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbParaChoqueCor.Text;
                                    carro.Opcionais2 += "Pc.Cor";
                                }
                            }

                            if (txtObservacoes.Text != "")
                            {
                                carro.Observacoes = txtObservacoes.Text;                                
                            }
                            else
                            {
                                carro.Observacoes = "";
                            }

                            conexao = new SqlConnection(StringConexao.stringConexao);

                            SqlCommand inserir = new SqlCommand("INSERT INTO tb_carros VALUES(@modelo, @marca, @ano, @cor, @cambio, @combustivel, @km, @placa, @opcionais, @opcionais2, @observacoes, @preco);", conexao);

                            inserir.Parameters.AddWithValue("@modelo", carro.Modelo);
                            inserir.Parameters.AddWithValue("@marca", carro.Marca);
                            inserir.Parameters.AddWithValue("@ano", carro.Ano);
                            inserir.Parameters.AddWithValue("@cor", carro.Cor);
                            inserir.Parameters.AddWithValue("@cambio", carro.Cambio);
                            inserir.Parameters.AddWithValue("@combustivel", carro.Combustivel);
                            inserir.Parameters.AddWithValue("@km", carro.Km);
                            inserir.Parameters.AddWithValue("@placa", carro.Placa);
                            inserir.Parameters.AddWithValue("@opcionais", carro.Opcionais);
                            inserir.Parameters.AddWithValue("@opcionais2", carro.Opcionais2);
                            inserir.Parameters.AddWithValue("@observacoes", carro.Observacoes);
                            inserir.Parameters.AddWithValue("@preco", carro.Preco);

                            conexao.Open();

                            inserir.ExecuteNonQuery();

                            conexao.Close();

                            MessageBox.Show("Novo carro registrado com sucesso", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (conexao != null && conexao.State != ConnectionState.Closed)
                            {
                                conexao.Close();
                            }
                        }
                    }
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (cbMarca.Text == "" || cbModelo.Text == "" || cbCor.Text == "" || cbCambio.Text == "" || cbCombustivel.Text == "" || txtKm.Text == "" || cbPlaca.Text == "" || txtPreco.Text == "")
            {
                MessageBox.Show("Apenas os campos 'Opcionais' e 'Obervações' podem ficar sem informações. Os demais devem ser preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mtbAno.Text.Length < 9)
            {
                MessageBox.Show("Preencha o campo 'Ano (fabricação e modelo)' corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var ano = mtbAno.Text.Split('/');

                if (Convert.ToInt32(ano[0]) < 1960 || Convert.ToInt32(ano[0]) > 2099)
                {
                    MessageBox.Show("Ano de fabricação inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Convert.ToInt32(ano[1]) != Convert.ToInt32(ano[0]) && Convert.ToInt32(ano[1]) != Convert.ToInt32(ano[0]) + 1)
                {
                    MessageBox.Show("Ano de modelo de carro inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var botao = MessageBox.Show("Confirmar inserção de dados?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (botao == DialogResult.Yes)
                    {
                        SqlConnection conexao = null;

                        try
                        {
                            Carro carro = new Carro(Convert.ToInt32(txtId.Text), Convert.ToInt32(cbModelo.SelectedValue), Convert.ToInt32(cbMarca.SelectedValue), mtbAno.Text, Convert.ToInt32(cbCor.SelectedValue), cbCambio.Text, cbCombustivel.Text, Convert.ToDecimal(txtKm.Text), Convert.ToInt32(cbPlaca.Text), Convert.ToDecimal(txtPreco.Text));

                            carro.Opcionais = default;
                            carro.Opcionais2 = default;
                            carro.Observacoes = default;

                            if (chbDirecaoHidraulica.Checked == false && chbDirecaoEletrica.Checked == false && chbVolanteRegulagemAltura.Checked == false && chbTravasEletricas.Checked == false && chbVidrosEletricos.Checked == false && chbArCondicionado.Checked == false && chbArQuente.Checked == false && chbAlarme.Checked == false && chbRetrovisoresEletricos.Checked == false && chbCentralMultimidia.Checked == false && chbTetoSolar.Checked == false && chbEncostoCabecaTraseiro.Checked == false && chbSensorEstacionamento.Checked == false && chbAirBag.Checked == false && chbFreioAbs.Checked == false && chbGps.Checked == false && chbRodasLigaLeve.Checked == false && chbDesembaçadorLimpadorTraseiro.Checked == false && chbBancosCouro.Checked == false && chbTracao4x4.Checked == false && chbPinturaMetalizada.Checked == false && chbParaChoqueCor.Checked == false)
                            {
                                carro.Opcionais = "Básico";
                                carro.Opcionais2 = "Básico";
                            }
                            else
                            {
                                if (chbDirecaoHidraulica.Checked)
                                {
                                    carro.Opcionais = chbDirecaoHidraulica.Text;
                                    carro.Opcionais2 = "Dir.Hid.";
                                }

                                if (chbDirecaoEletrica.Checked)
                                {
                                    carro.Opcionais = chbDirecaoEletrica.Text;
                                    carro.Opcionais2 = "Dir.Ele.";
                                }

                                if (chbVolanteRegulagemAltura.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbVolanteRegulagemAltura.Text;
                                    carro.Opcionais2 += "Vo.Reg.Alt.";
                                }

                                if (chbTravasEletricas.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbTravasEletricas.Text;
                                    carro.Opcionais2 += "Tr.Ele.";
                                }

                                if (chbVidrosEletricos.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbVidrosEletricos.Text;
                                    carro.Opcionais2 += "Vi.Ele.";
                                }

                                if (chbArCondicionado.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbArCondicionado.Text;
                                    carro.Opcionais2 += "ArCon.";
                                }

                                if (chbArQuente.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbArQuente.Text;
                                    carro.Opcionais2 += "ArQue.";
                                }

                                if (chbAlarme.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbAlarme.Text;
                                    carro.Opcionais2 += "Alm.";
                                }

                                if (chbRetrovisoresEletricos.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbRetrovisoresEletricos.Text;
                                    carro.Opcionais2 += "Ret.Ele.";
                                }

                                if (chbCentralMultimidia.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbCentralMultimidia.Text;
                                    carro.Opcionais2 += "Cen.Mult.";
                                }

                                if (chbTetoSolar.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbTetoSolar.Text;
                                    carro.Opcionais2 += "T.So.";
                                }

                                if (chbEncostoCabecaTraseiro.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbEncostoCabecaTraseiro.Text;
                                    carro.Opcionais2 += "En.Cab.Tra.";
                                }

                                if (chbSensorEstacionamento.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbSensorEstacionamento.Text;
                                    carro.Opcionais2 += "Sen.Est";
                                }

                                if (chbAirBag.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbAirBag.Text;
                                    carro.Opcionais2 += "A.Bag";
                                }

                                if (chbFreioAbs.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbFreioAbs.Text;
                                    carro.Opcionais2 += "ABS";
                                }

                                if (chbGps.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbGps.Text;
                                    carro.Opcionais2 += "GPS";
                                }

                                if (chbRodasLigaLeve.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbRodasLigaLeve.Text;
                                    carro.Opcionais2 += "R.L.Leve";
                                }

                                if (chbDesembaçadorLimpadorTraseiro.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbDesembaçadorLimpadorTraseiro.Text;
                                    carro.Opcionais2 += "Des.Lim.Tras.";
                                }

                                if (chbBancosCouro.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbBancosCouro.Text;
                                    carro.Opcionais2 += "BancoCouro";
                                }

                                if (chbTracao4x4.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbTracao4x4.Text;
                                    carro.Opcionais2 += "4X4";
                                }

                                if (chbPinturaMetalizada.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbPinturaMetalizada.Text;
                                    carro.Opcionais2 += "Pin.Met.";
                                }

                                if (chbParaChoqueCor.Checked)
                                {
                                    if (carro.Opcionais != "")
                                    {
                                        carro.Opcionais += ", ";
                                        carro.Opcionais2 += ", ";
                                    }

                                    carro.Opcionais += chbParaChoqueCor.Text;
                                    carro.Opcionais2 += "Pc.Cor";
                                }
                            }

                            if (txtObservacoes.Text != "")
                            {
                                carro.Observacoes = txtObservacoes.Text;
                            }
                            else
                            {
                                carro.Observacoes = "";
                            }

                            conexao = new SqlConnection(StringConexao.stringConexao);

                            SqlCommand alterar = new SqlCommand("UPDATE tb_carros SET carro_modelo = @modelo, carro_marca = @marca, carro_ano = @ano, carro_cor = @cor, carro_cambio = @cambio, carro_combustivel = @combustivel, carro_quilometragem = @km, carro_placa_final = @placa, carro_opcionais = @opcionais, carro_opcionais_abreviacao = @opcionais2, carro_observacoes = @observacoes, carro_preco = @preco WHERE carro_id = @id;", conexao);

                            alterar.Parameters.AddWithValue("@id", carro.Id);
                            alterar.Parameters.AddWithValue("@modelo", carro.Modelo);
                            alterar.Parameters.AddWithValue("@marca", carro.Marca);
                            alterar.Parameters.AddWithValue("@ano", carro.Ano);
                            alterar.Parameters.AddWithValue("@cor", carro.Cor);
                            alterar.Parameters.AddWithValue("@cambio", carro.Cambio);
                            alterar.Parameters.AddWithValue("@combustivel", carro.Combustivel);
                            alterar.Parameters.AddWithValue("@km", carro.Km);
                            alterar.Parameters.AddWithValue("@placa", carro.Placa);
                            alterar.Parameters.AddWithValue("@opcionais", carro.Opcionais);
                            alterar.Parameters.AddWithValue("@opcionais2", carro.Opcionais2);
                            alterar.Parameters.AddWithValue("@observacoes", carro.Observacoes);
                            alterar.Parameters.AddWithValue("@preco", carro.Preco);

                            conexao.Open();

                            alterar.ExecuteNonQuery();

                            conexao.Close();

                            MessageBox.Show("Dados inseridos com sucesso", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (conexao != null && conexao.State != ConnectionState.Closed)
                            {
                                conexao.Close();
                            }
                        }
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var botao = MessageBox.Show("Confirmar remoção de registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (botao == DialogResult.Yes)
            {
                SqlConnection conexao = null;

                try
                {
                    Carro carro = new Carro(Convert.ToInt32(txtId.Text));

                    conexao = new SqlConnection(StringConexao.stringConexao);

                    SqlCommand deletar = new SqlCommand("DELETE FROM tb_carros WHERE carro_id = @id", conexao);

                    deletar.Parameters.AddWithValue("@id", carro.Id);

                    conexao.Open();

                    deletar.ExecuteNonQuery();

                    conexao.Close();

                    MessageBox.Show("Remoção feita com sucesso", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conexao != null && conexao.State != ConnectionState.Closed)
                    {
                        conexao.Close();
                    }
                }                
            }
        }        
    }
}
