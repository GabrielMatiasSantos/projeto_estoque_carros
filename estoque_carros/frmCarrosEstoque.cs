using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Validation;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque_carros
{
    public partial class frmCarrosEstoque : Form
    {
        public frmCarrosEstoque()
        {
            InitializeComponent();
        }


        public void tabelaMarcas()
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

                dgvMarcas.DataSource = tabela;

                dgvMarcas.Columns[0].Visible = false;

                dgvMarcas.Columns[1].HeaderText = "Marca";

                dgvMarcas.Columns[1].Width = 150;
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

        public void tabelaCores()
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

                dgvCores.DataSource = tabela;

                dgvCores.Columns[0].Visible = false;

                dgvCores.Columns[1].HeaderText = "Cor";

                dgvCores.Columns[1].Width = 150;
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

        public void TabelaModelos()
        {
            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection(StringConexao.stringConexao);

                SqlCommand pesquisar = new SqlCommand("SELECT modelo_id, marca_nome, modelo_nome FROM tb_modelos INNER JOIN tb_marcas ON tb_modelos.modelo_marca = tb_marcas.marca_id ORDER BY modelo_nome;", conexao);

                conexao.Open();

                SqlDataAdapter registros = new SqlDataAdapter(pesquisar);

                conexao.Close();

                DataTable tabela = new DataTable();

                registros.Fill(tabela);

                dgvModelos.DataSource = tabela;

                dgvModelos.Columns[0].Visible = false;

                dgvModelos.Columns[1].HeaderText = "Marca";
                dgvModelos.Columns[2].HeaderText = "Modelo e versão";

                dgvModelos.Columns[1].Width = 130;
                dgvModelos.Columns[2].Width = 200;

                dgvModelos.Columns[1].DisplayIndex = 1;
                dgvModelos.Columns[2].DisplayIndex = 0;
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


        public void TabelaCarros()
        {
            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection(StringConexao.stringConexao);

                SqlCommand pesquisar = new SqlCommand("SELECT carro_id, modelo_nome, marca_nome, carro_ano, cor_nome, carro_cambio, carro_combustivel, FORMAT(carro_quilometragem, 'N0', 'pt-BR'), carro_placa_final, carro_opcionais, carro_observacoes, FORMAT(carro_preco, 'N', 'pt-BR') FROM tb_carros INNER JOIN tb_modelos ON tb_carros.carro_modelo = tb_modelos.modelo_id INNER JOIN tb_marcas ON tb_carros.carro_marca = tb_marcas.marca_id INNER JOIN tb_cores ON tb_carros.carro_cor = tb_cores.cor_id ORDER BY modelo_nome;", conexao);

                conexao.Open();

                SqlDataAdapter registros = new SqlDataAdapter(pesquisar);

                conexao.Close();

                DataTable tabela = new DataTable();

                registros.Fill(tabela);

                dgvCarros.DataSource = tabela;

                dgvCarros.Columns[0].Visible = false;

                dgvCarros.Columns[1].HeaderText = "Modelo e versão";
                dgvCarros.Columns[2].HeaderText = "Marca";
                dgvCarros.Columns[3].HeaderText = "Ano";
                dgvCarros.Columns[4].HeaderText = "Cor";
                dgvCarros.Columns[5].HeaderText = "Câmbio";
                dgvCarros.Columns[6].HeaderText = "Combustível";
                dgvCarros.Columns[7].HeaderText = "Quilometragem";
                dgvCarros.Columns[8].HeaderText = "Final de placa";
                dgvCarros.Columns[9].HeaderText = "Opcionais";
                dgvCarros.Columns[10].HeaderText = "Observações";
                dgvCarros.Columns[11].HeaderText = "Preço";

                dgvCarros.Columns[1].Width = 200;
                dgvCarros.Columns[2].Width = 130;
                dgvCarros.Columns[3].Width = 100;
                dgvCarros.Columns[4].Width = 120;
                dgvCarros.Columns[5].Width = 100;
                dgvCarros.Columns[6].Width = 100;
                dgvCarros.Columns[7].Width = 120;
                dgvCarros.Columns[8].Width = 120;
                dgvCarros.Columns[9].Width = 2200;
                dgvCarros.Columns[10].Width = 300;
                dgvCarros.Columns[11].Width = 85;

                dgvCarros.Columns[1].DisplayIndex = 0;
                dgvCarros.Columns[2].DisplayIndex = 1;
                dgvCarros.Columns[3].DisplayIndex = 2;
                dgvCarros.Columns[4].DisplayIndex = 3;
                dgvCarros.Columns[5].DisplayIndex = 4;
                dgvCarros.Columns[6].DisplayIndex = 5;
                dgvCarros.Columns[7].DisplayIndex = 6;
                dgvCarros.Columns[8].DisplayIndex = 7;
                dgvCarros.Columns[9].DisplayIndex = 8;
                dgvCarros.Columns[10].DisplayIndex = 9;
                dgvCarros.Columns[11].DisplayIndex = 10;
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


        private void frmCarrosEstoque_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tcCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcCarros.SelectedIndex == 0)
            {
                txtCor.Select();
            }
            else if (tcCarros.SelectedIndex == 1)
            {
                txtMarca.Select();
            }
            else if (tcCarros.SelectedIndex == 2)
            {
                txtModelo.Select();
            }
        }

        public int Aba
        {
            set { tcCarros.SelectedIndex = value; }
        }

        //Aba 'Cores'

        private void tabCores_Enter(object sender, EventArgs e)
        {
            
            tabelaCores();
            
            txtCor.Clear();
            txtCor.Select();
        }

        private void txtCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCor.Text == "")
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void btnCorSalvar_Click(object sender, EventArgs e)
        {
            if (txtCor.Text == "")
            {
                MessageBox.Show("Informe uma marca para registrar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var botao = MessageBox.Show("Confirmar registro de uma nova cor?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (botao == DialogResult.Yes)
                {
                    SqlConnection conexao = null;

                    try
                    {
                        Cor cor = new Cor(txtCor.Text);

                        conexao = new SqlConnection(StringConexao.stringConexao);

                        SqlCommand pesquisar = new SqlCommand("SELECT COUNT(*) FROM tb_cores WHERE cor_nome = @cor;", conexao);

                        pesquisar.Parameters.AddWithValue("@cor", cor.Cor1);

                        conexao.Open();

                        int quantidade = Convert.ToInt32(pesquisar.ExecuteScalar());

                        if (quantidade > 0)
                        {
                            MessageBox.Show("Esta cor já está registrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            conexao.Close();
                        }
                        else
                        {
                            SqlCommand inserir = new SqlCommand("INSERT INTO tb_cores VALUES(@cor);", conexao);

                            inserir.Parameters.AddWithValue("@cor", cor.Cor1);

                            inserir.ExecuteNonQuery();

                            conexao.Close();

                            MessageBox.Show("Nova cor registrada com sucesso", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtCor.Clear();

                            tabelaCores();
                        }
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

        private void txtPesquisarCor_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection(StringConexao.stringConexao);

                SqlCommand pesquisar = conexao.CreateCommand();

                if (txtPesquisarCor.Text == "")
                {
                    pesquisar.CommandText = "SELECT * FROM tb_cores ORDER BY cor_nome;";
                }
                else
                {
                    pesquisar.CommandText = "SELECT * FROM tb_cores WHERE cor_nome LIKE @cor ORDER BY cor_nome";

                    pesquisar.Parameters.AddWithValue("@cor", '%' + txtPesquisarCor.Text + '%');
                }

                conexao.Open();

                SqlDataAdapter registros = new SqlDataAdapter(pesquisar);

                conexao.Close();

                DataTable tabela = new DataTable();

                registros.Fill(tabela);

                dgvCores.DataSource = tabela;
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

        private void dgvCores_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCores.SelectedRows.Count == 1)
            {
                frmMarcaModeloCorAlterarDeletar cor = new frmMarcaModeloCorAlterarDeletar(dgvCores.SelectedRows[0].Cells[1].Value.ToString(), dgvCores.SelectedRows[0].Cells[0].Value.ToString());

                cor.Largura = 350;

                cor.Cabecalho = "Cor - Alterar/Excluir";

                cor.Rotulo = "Cor:";

                cor.LblMarca = false;

                cor.CbMarca = false;

                cor.LblPortas = false;

                cor.CbPortas = false;

                cor.LblMotor = false;

                cor.CbMotor = false;

                cor.BtnAlterar = 23;

                cor.BtnExcluir = 205;

                cor.Show();
                this.Hide();
            }
        }


        //Aba 'Modelos'

        private void tabModelos_Enter(object sender, EventArgs e)
        {
            TabelaModelos();
           
            txtModelo.Clear();
            cbModeloMarca.SelectedIndex = -1;
            cbModeloPortas.SelectedIndex = -1;
            cbModeloMotor.SelectedIndex = -1;
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtModelo.Text == "")
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void cbModeloMarca_DropDown(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(StringConexao.stringConexao);

                SqlCommand pesquisar = new SqlCommand("SELECT * FROM tb_marcas ORDER BY marca_nome;", conexao);

                conexao.Open();

                SqlDataAdapter registros = new SqlDataAdapter(pesquisar);

                conexao.Close();

                DataTable tabela = new DataTable();

                registros.Fill(tabela);

                cbModeloMarca.ValueMember = "marca_id";
                cbModeloMarca.DisplayMember = "marca_nome";
                cbModeloMarca.DataSource = tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModeloSalvar_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text == "" || cbModeloMarca.Text == "" || cbModeloPortas.Text == "" || cbModeloMotor.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtModelo.Text.Contains(" 2P ") || txtModelo.Text.EndsWith(" 2P") || txtModelo.Text.Contains(" 2p ") || txtModelo.Text.EndsWith(" 2p") || txtModelo.Text.Contains(" 3P ") || txtModelo.Text.EndsWith(" 3P") || txtModelo.Text.Contains(" 3p ") || txtModelo.Text.EndsWith(" 3p") || txtModelo.Text.Contains(" 4P ") || txtModelo.Text.EndsWith(" 4P") || txtModelo.Text.Contains(" 4p ") || txtModelo.Text.EndsWith(" 4p") || txtModelo.Text.Contains(" 5P ") || txtModelo.Text.EndsWith(" 5P") || txtModelo.Text.Contains(" 5p ") || txtModelo.Text.EndsWith(" 5p"))
            {
                MessageBox.Show("Não informe o número de portas no texto de modelo e versão. Apenas selecione uma opção na lista", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var botao = MessageBox.Show("Confirmar a inserção de um novo modelo e versão de carro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (botao == DialogResult.Yes)
                {
                    SqlConnection conexao = null;

                    try
                    {
                        Modelo modelo = new Modelo(Convert.ToInt32(cbModeloMarca.SelectedValue), txtModelo.Text + " " + cbModeloMotor.Text + " " + cbModeloPortas.Text);

                        conexao = new SqlConnection(StringConexao.stringConexao);

                        SqlCommand pesquisar = new SqlCommand("SELECT COUNT(*) FROM tb_modelos WHERE modelo_nome = @modelo;", conexao);

                        pesquisar.Parameters.AddWithValue("@modelo", modelo.Modelo1);

                        conexao.Open();

                        int quantidade = Convert.ToInt32(pesquisar.ExecuteScalar());

                        if (quantidade > 0)
                        {
                            MessageBox.Show("Este modelo e versão de carro já está registrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            conexao.Close();
                        }
                        else
                        {
                            SqlCommand inserir = new SqlCommand("INSERT INTO tb_modelos VALUES(@marca, @modelo);", conexao);

                            inserir.Parameters.AddWithValue("@marca", modelo.Marca);
                            inserir.Parameters.AddWithValue("@modelo", modelo.Modelo1);

                            inserir.ExecuteNonQuery();

                            conexao.Close();

                            MessageBox.Show("Novo modelo e versão de carro registrado com sucesso", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtModelo.Clear();
                            cbModeloMarca.SelectedIndex = -1;
                            cbModeloPortas.SelectedIndex = -1;
                            cbModeloMotor.SelectedIndex = -1;

                            TabelaModelos();
                        }
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

        private void txtPesquisarModelo_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection(StringConexao.stringConexao);

                SqlCommand pesquisar = conexao.CreateCommand();

                if (txtPesquisarModelo.Text == "")
                {
                    pesquisar.CommandText = "SELECT modelo_id, marca_nome, modelo_nome FROM tb_modelos INNER JOIN tb_marcas ON tb_modelos.modelo_marca = tb_marcas.marca_id ORDER BY modelo_nome;";
                }
                else
                {
                    pesquisar.CommandText = "SELECT modelo_id, marca_nome, modelo_nome FROM tb_modelos INNER JOIN tb_marcas ON tb_modelos.modelo_marca = tb_marcas.marca_id WHERE modelo_nome LIKE @modelo ORDER BY modelo_nome;";

                    pesquisar.Parameters.AddWithValue("@modelo", '%' + txtPesquisarModelo.Text + '%');
                }

                conexao.Open();

                SqlDataAdapter registros = new SqlDataAdapter(pesquisar);

                conexao.Close();

                DataTable tabela = new DataTable();

                registros.Fill(tabela);

                dgvModelos.DataSource = tabela;
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

        private void dgvModelos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvModelos.SelectedRows.Count == 1)
            {
                frmMarcaModeloCorAlterarDeletar modelo = new frmMarcaModeloCorAlterarDeletar(dgvModelos.SelectedRows[0].Cells[2].Value.ToString(), dgvModelos.SelectedRows[0].Cells[1].Value.ToString(), dgvModelos.SelectedRows[0].Cells[0].Value.ToString());

                modelo.Cabecalho = "Modelo - Alterar/Excluir";
                modelo.Rotulo = "Modelo e versão:";

                modelo.Show();
                this.Hide();
            }
        }


        //Aba ''Marcas'

        private void tabMarcas_Enter(object sender, EventArgs e)
        {         
            tabelaMarcas();       

            txtMarca.Clear();            
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMarca.Text == "")
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }       

        private void btnMarcaSalvar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")
            {
                MessageBox.Show("Informe uma marca para registrar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var botao = MessageBox.Show("Confirmar registro de uma nova marca?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (botao == DialogResult.Yes)
                {
                    SqlConnection conexao = null;

                    try
                    {
                        Marca marca = new Marca(txtMarca.Text);

                        conexao = new SqlConnection(StringConexao.stringConexao);

                        SqlCommand pesquisar = new SqlCommand("SELECT COUNT(*) FROM tb_marcas WHERE marca_nome = @marca;", conexao);

                        pesquisar.Parameters.AddWithValue("@marca", marca.Marca1);

                        conexao.Open();

                        int quantidade = Convert.ToInt32(pesquisar.ExecuteScalar());

                        if (quantidade > 0)
                        {
                            MessageBox.Show("Esta marca já está registrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            conexao.Close();
                        }
                        else
                        {
                            SqlCommand inserir = new SqlCommand("INSERT INTO tb_marcas VALUES(@marca);", conexao);

                            inserir.Parameters.AddWithValue("@marca", marca.Marca1);

                            inserir.ExecuteNonQuery();

                            conexao.Close();

                            MessageBox.Show("Nova marca registrada com sucesso", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtMarca.Clear();

                            tabelaMarcas();
                        }
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

        private void txtPesquisarMarca_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection(StringConexao.stringConexao);

                SqlCommand pesquisar = conexao.CreateCommand();

                if (txtPesquisarMarca.Text == "")
                {
                    pesquisar.CommandText = "SELECT * FROM tb_marcas ORDER BY marca_nome;";
                }
                else
                {
                    pesquisar.CommandText = "SELECT * FROM tb_marcas WHERE marca_nome LIKE @marca ORDER BY marca_nome;";

                    pesquisar.Parameters.AddWithValue("@marca", '%' + txtPesquisarMarca.Text + '%');
                }

                conexao.Open();

                SqlDataAdapter registros = new SqlDataAdapter(pesquisar);

                conexao.Close();

                DataTable tabela = new DataTable();

                registros.Fill(tabela);

                dgvMarcas.DataSource = tabela;
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

        private void dgvMarcas_DoubleClick(object sender, EventArgs e)
        {

            if (dgvMarcas.SelectedRows.Count == 1)
            {
                frmMarcaModeloCorAlterarDeletar marca = new frmMarcaModeloCorAlterarDeletar(dgvMarcas.SelectedRows[0].Cells[1].Value.ToString(), dgvMarcas.SelectedRows[0].Cells[0].Value.ToString());

                marca.Largura = 350;

                marca.Cabecalho = "Marca - Alterar/Excluir";

                marca.Rotulo = "Marca:";

                marca.LblMarca = false;

                marca.CbMarca = false;

                marca.LblPortas = false;

                marca.CbPortas = false;

                marca.LblMotor = false;

                marca.CbMotor = false;

                marca.BtnAlterar = 23;

                marca.BtnExcluir = 205;

                marca.Show();
                this.Hide();
            }
        }     

        //Aba 'Carros - estoque'
        
        private void tabEstoqueCarros_Enter(object sender, EventArgs e)
        {        
            TabelaCarros();  
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmCarroInserirAlterarDeletar carro = new frmCarroInserirAlterarDeletar();

            carro.Cabecalho = "Carro - Inserir";
            carro.Alterar = false;
            carro.Excluir = false;

            carro.Show();
            this.Hide();
        }

        private void txtPesquisarCarro_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection(StringConexao.stringConexao);

                SqlCommand pesquisar = conexao.CreateCommand();

                if (txtPesquisarCarro.Text == "")
                {
                    pesquisar.CommandText = "SELECT carro_id, modelo_nome, marca_nome, carro_ano, cor_nome, carro_cambio, carro_combustivel, FORMAT(carro_quilometragem, 'N0', 'pt-BR'), carro_placa_final, carro_opcionais, carro_observacoes, FORMAT(carro_preco, 'N', 'pt-BR') FROM tb_carros INNER JOIN tb_modelos ON tb_carros.carro_modelo = tb_modelos.modelo_id INNER JOIN tb_marcas ON tb_carros.carro_marca = tb_marcas.marca_id INNER JOIN tb_cores ON tb_carros.carro_cor = tb_cores.cor_id ORDER BY modelo_nome;";
                }
                else
                {
                    pesquisar.CommandText = "SELECT carro_id, modelo_nome, marca_nome, carro_ano, cor_nome, carro_cambio, carro_combustivel, FORMAT(carro_quilometragem, 'N0', 'pt-BR'), carro_placa_final, carro_opcionais, carro_observacoes, FORMAT(carro_preco, 'N', 'pt-BR') FROM tb_carros INNER JOIN tb_modelos ON tb_carros.carro_modelo = tb_modelos.modelo_id INNER JOIN tb_marcas ON tb_carros.carro_marca = tb_marcas.marca_id INNER JOIN tb_cores ON tb_carros.carro_cor = tb_cores.cor_id WHERE modelo_nome LIKE @modelo ORDER BY modelo_nome;";

                    pesquisar.Parameters.AddWithValue("@modelo", '%' + txtPesquisarCarro.Text + '%');
                }

                conexao.Open();

                SqlDataAdapter registros = new SqlDataAdapter(pesquisar);

                conexao.Close();

                DataTable tabela = new DataTable();

                registros.Fill(tabela);

                dgvCarros.DataSource = tabela;
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

        private void dgvCarros_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCarros.SelectedRows.Count == 1)
            {
                frmCarroInserirAlterarDeletar carro = new frmCarroInserirAlterarDeletar(dgvCarros.SelectedRows[0].Cells[2].Value.ToString(), dgvCarros.SelectedRows[0].Cells[1].Value.ToString(), dgvCarros.SelectedRows[0].Cells[3].Value.ToString(), dgvCarros.SelectedRows[0].Cells[4].Value.ToString(), dgvCarros.SelectedRows[0].Cells[5].Value.ToString(), dgvCarros.SelectedRows[0].Cells[6].Value.ToString(), dgvCarros.SelectedRows[0].Cells[7].Value.ToString(), dgvCarros.SelectedRows[0].Cells[8].Value.ToString(), dgvCarros.SelectedRows[0].Cells[9].Value.ToString(), dgvCarros.SelectedRows[0].Cells[10].Value.ToString(), dgvCarros.SelectedRows[0].Cells[11].Value.ToString(), dgvCarros.SelectedRows[0].Cells[0].Value.ToString());

                carro.Cabecalho = "Carro - Alterar/Excluir";
                carro.Salvar = false;

                carro.Show();
                this.Hide();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = null;

            try
            {
                PdfWriter pdf = new PdfWriter("C:\\Matias Veículos - Estoque\\Matias Veículos - Estoque.pdf");

                PdfDocument documentoPdf = new PdfDocument(pdf);

                Document documento = new Document(documentoPdf, PageSize.A4);


                Paragraph cabecalho = new Paragraph("Matias Veículos - estoque");
                cabecalho.SetTextAlignment(TextAlignment.CENTER);
                cabecalho.SetFontSize(16);

                documento.Add(cabecalho);

                Table tabela = new Table(UnitValue.CreatePercentArray(new float[] {10, 6, 6, 4, 6, 8, 8, 4, 30, 12, 6}));
                tabela.SetWidth(UnitValue.CreatePercentValue(100));

                Paragraph cabecalhoModelo = new Paragraph("Modelo e versão");
                cabecalhoModelo.SetFontSize(6);

                tabela.AddCell(cabecalhoModelo);

                Paragraph cabecalhoMarca = new Paragraph("Marca");
                cabecalhoMarca.SetFontSize(6);

                tabela.AddCell(cabecalhoMarca);

                Paragraph cabecalhoAno = new Paragraph("Ano");
                cabecalhoAno.SetFontSize(6);

                tabela.AddCell(cabecalhoAno);

                Paragraph cabecalhoCor = new Paragraph("Cor");
                cabecalhoCor.SetFontSize(6);

                tabela.AddCell(cabecalhoCor);

                Paragraph cabecalhoCambio = new Paragraph("Câmbio");
                cabecalhoCambio.SetFontSize(6);

                tabela.AddCell(cabecalhoCambio);

                Paragraph cabecalhoCombustivel = new Paragraph("Combustível");
                cabecalhoCombustivel.SetFontSize(6);

                tabela.AddCell(cabecalhoCombustivel);

                Paragraph cabecalhoKm = new Paragraph("Quilometragem");
                cabecalhoKm.SetFontSize(6);

                tabela.AddCell(cabecalhoKm);

                Paragraph cabecalhoPlaca = new Paragraph("Placa");
                cabecalhoPlaca.SetFontSize(6);

                tabela.AddCell(cabecalhoPlaca);

                Paragraph cabecalhoOpcionais = new Paragraph("Opcionais");
                cabecalhoOpcionais.SetFontSize(6);

                tabela.AddCell(cabecalhoOpcionais);

                Paragraph cabecalhoObservacoes = new Paragraph("Observações");
                cabecalhoObservacoes.SetFontSize(6);

                tabela.AddCell(cabecalhoObservacoes);

                Paragraph cabecalhoPreco = new Paragraph("Preço");
                cabecalhoPreco.SetFontSize(6);

                tabela.AddCell(cabecalhoPreco);

                conexao = new SqlConnection(StringConexao.stringConexao);

                SqlCommand pesquisar = new SqlCommand("SELECT modelo_nome, marca_nome, carro_ano, cor_nome, carro_cambio, carro_combustivel, carro_quilometragem, carro_placa_final, carro_opcionais, carro_opcionais_abreviacao, carro_observacoes, carro_preco FROM tb_carros INNER JOIN tb_modelos ON tb_carros.carro_modelo = tb_modelos.modelo_id INNER JOIN tb_marcas ON tb_carros.carro_marca = tb_marcas.marca_id INNER JOIN tb_cores ON tb_carros.carro_cor = tb_cores.cor_id ORDER BY modelo_nome;", conexao);

                conexao.Open();

                SqlDataReader registros = pesquisar.ExecuteReader();

                if (registros.HasRows)
                {
                    while (registros.Read())
                    {
                        Paragraph modelo = new Paragraph(registros["modelo_nome"].ToString());
                        modelo.SetFontSize(5);

                        tabela.AddCell(modelo);
                        
                        Paragraph marca = new Paragraph(registros["marca_nome"].ToString());
                        marca.SetFontSize(5);                        

                        tabela.AddCell(marca);

                        Paragraph ano = new Paragraph(registros["carro_ano"].ToString());
                        ano.SetFontSize(5);

                        tabela.AddCell(ano);

                        Paragraph cor = new Paragraph(registros["cor_nome"].ToString());
                        cor.SetFontSize(5);

                        tabela.AddCell(cor);

                        Paragraph cambio = new Paragraph(registros["carro_cambio"].ToString());
                        cambio.SetFontSize(5);

                        tabela.AddCell(cambio);

                        Paragraph combustivel = new Paragraph(registros["carro_combustivel"].ToString());
                        combustivel.SetFontSize(5);

                        tabela.AddCell(combustivel);

                        Paragraph km = new Paragraph(Convert.ToDecimal(registros["carro_quilometragem"]).ToString("N0"));
                        km.SetFontSize(5);

                        tabela.AddCell(km);

                        Paragraph placa = new Paragraph(Convert.ToDecimal(registros["carro_placa_final"]).ToString("N0"));
                        placa.SetFontSize(5);

                        tabela.AddCell(placa);

                        Paragraph opcionais = new Paragraph(registros["carro_opcionais_abreviacao"].ToString());
                        opcionais.SetFontSize(5);                     

                        tabela.AddCell(opcionais);

                        Paragraph observacoes = new Paragraph(registros["carro_observacoes"].ToString());
                        observacoes.SetFontSize(5);

                        tabela.AddCell(observacoes);

                        Paragraph preco = new Paragraph(Convert.ToDecimal(registros["carro_preco"]).ToString("N"));
                        preco.SetFontSize(5);

                        tabela.AddCell(preco);
                    }
                }

                conexao.Close();

                documento.Add(tabela);

                documento.Close();
                documentoPdf.Close();

                System.Diagnostics.Process.Start("C:\\Matias Veículos - Estoque\\Matias Veículos - Estoque.pdf");
            }
            catch(Exception erro)
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

