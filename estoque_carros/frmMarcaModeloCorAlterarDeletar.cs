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
    public partial class frmMarcaModeloCorAlterarDeletar : Form
    {
        public frmMarcaModeloCorAlterarDeletar(string corMarca, string id)
        {
            InitializeComponent();

            txtMarcaModeloCor.Text = corMarca;
            txtId.Text = id;
        }

        public frmMarcaModeloCorAlterarDeletar(string modelo, string marca, string id)
        {
            InitializeComponent();

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

            cbMarca.Text = marca;

            
            string[] motores = new string[] {"1.0", "1.2", "1.4", "1.6", "1.8", "2.0"};

            foreach (string motor1 in motores)
            {
                if (modelo.Contains(motor1))
                {
                    cbMotor.Text = motor1;

                    txtMarcaModeloCor.Text = modelo.Remove(modelo.IndexOf(" " + motor1));
;                }
            }


            string[] portas = new string[] {"2P", "3P", "4P", "5P"};

            foreach (string portas1 in portas)
            {
                if (modelo.Contains(portas1))
                {
                    cbPortas.Text = portas1;
                }
            }


            txtId.Text = id;

            txtMarca.Text = cbMarca.SelectedValue.ToString();
        }

       
        public int Largura
        {
            set { this.Width = value; }
        }

        public string Cabecalho
        {
            set { this.Text = value; }
        }

        public string Rotulo
        {
            set { lblMarcaModeloCor.Text = value; }
        }

        public bool LblMarca
        {
            set { lblMarca.Visible = value; }
        }

        public bool CbMarca
        {
            set { cbMarca.Visible = value; }
        }

        public bool LblPortas
        {
            set { lblPortas.Visible = value; }
        }

        public bool CbPortas
        {
            set { cbPortas.Visible = value; }
        }

        public bool LblMotor
        {
            set { lblMarca.Visible = value; }
        }

        public bool CbMotor
        {
            set { cbMotor.Visible = value; }
        }

        public int BtnAlterar
        {
            set { btnAlterar.Left = value; }
        }

        public int BtnExcluir
        {
            set { btnExcluir.Left = value; }
        }

        private void frmMarcaModeloCorAlterarDeletar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Text == "Marca - Alterar/Excluir")
            {
                frmCarrosEstoque frmCarros = new frmCarrosEstoque();

                frmCarros.Aba = 1;
                frmCarros.Show();
            }
            else if (this.Text == "Cor - Alterar/Excluir")
            {
                frmCarrosEstoque frmCarros = new frmCarrosEstoque();

                frmCarros.Aba = 0;
                frmCarros.Show();
            }
            else if (this.Text == "Modelo - Alterar/Excluir")
            {
                frmCarrosEstoque frmCarros = new frmCarrosEstoque();

                frmCarros.Aba = 2;
                frmCarros.Show();
            }
        }

        private void txtMarcaModeloCor_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (txtMarcaModeloCor.Text == "")
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (this.Text == "Marca - Alterar/Excluir" || this.Text == "Cor - Alterar/Excluir")
                {
                    if (!char.IsLetter(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != 8)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) & e.KeyChar != 32 && e.KeyChar != 8)
                    {
                        e.Handled = true;
                    }
                }               
            }
                       
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (this.Text == "Marca - Alterar/Excluir")
            {
                if (txtMarcaModeloCor.Text == "")
                {
                    MessageBox.Show("Preencha o campo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var botao = MessageBox.Show("Confirmar inserção de dados?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (botao == DialogResult.Yes)
                    {
                        SqlConnection conexao = null;

                        try
                        {
                            Marca marca = new Marca(Convert.ToInt32(txtId.Text), txtMarcaModeloCor.Text);

                            conexao = new SqlConnection(StringConexao.stringConexao);

                            SqlCommand pesquisar = new SqlCommand("SELECT COUNT(*) FROM tb_marcas WHERE marca_nome = @marca AND NOT marca_id = @id;", conexao);

                            pesquisar.Parameters.AddWithValue("@marca", marca.Marca1);
                            pesquisar.Parameters.AddWithValue("@id", marca.Id);

                            conexao.Open();

                            int quantidade = Convert.ToInt32(pesquisar.ExecuteScalar());


                            if (quantidade > 0)
                            {
                                MessageBox.Show("Esta marca já está registrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                conexao.Close();
                            }
                            else
                            {
                                SqlCommand atualizar = new SqlCommand("UPDATE tb_marcas SET marca_nome = @marca WHERE marca_id = @id;", conexao);

                                atualizar.Parameters.AddWithValue("@marca", marca.Marca1);
                                atualizar.Parameters.AddWithValue("@id", marca.Id);

                                atualizar.ExecuteScalar();

                                conexao.Close();

                                MessageBox.Show("Dados inseridos com sucesso", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
                            }
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
            else if (this.Text == "Cor - Alterar/Excluir")
            {
                if (txtMarcaModeloCor.Text == "")
                {
                    MessageBox.Show("Preencha o campo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var botao = MessageBox.Show("Confirmar inserção de dados?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (botao == DialogResult.Yes)
                    {
                        SqlConnection conexao = null;

                        try
                        {
                            Cor cor = new Cor(Convert.ToInt32(txtId.Text), txtMarcaModeloCor.Text);

                            conexao = new SqlConnection(StringConexao.stringConexao);

                            SqlCommand pesquisar = new SqlCommand("SELECT COUNT(*) FROM tb_cores WHERE cor_nome = @cor AND NOT cor_id = @id;", conexao);

                            pesquisar.Parameters.AddWithValue("@cor", cor.Cor1);
                            pesquisar.Parameters.AddWithValue("@id", cor.Id);

                            conexao.Open();

                            int quantidade = Convert.ToInt32(pesquisar.ExecuteScalar());


                            if (quantidade > 0)
                            {
                                MessageBox.Show("Esta cor já está registrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                conexao.Close();
                            }
                            else
                            {
                                SqlCommand atualizar = new SqlCommand("UPDATE tb_cores SET cor_nome = @cor WHERE cor_id = @id;", conexao);

                                atualizar.Parameters.AddWithValue("@cor", cor.Cor1);
                                atualizar.Parameters.AddWithValue("@id", cor.Id);

                                atualizar.ExecuteScalar();

                                conexao.Close();

                                MessageBox.Show("Dados inseridos com sucesso", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
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
            else if (this.Text == "Modelo - Alterar/Excluir")
            {
                if (txtMarcaModeloCor.Text == "" || cbPortas.Text == "" || cbMotor.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtMarcaModeloCor.Text.Contains(" 2P ") || txtMarcaModeloCor.Text.EndsWith(" 2P") || txtMarcaModeloCor.Text.Contains(" 2p ") || txtMarcaModeloCor.Text.EndsWith(" 2p") || txtMarcaModeloCor.Text.Contains(" 3P ") || txtMarcaModeloCor.Text.EndsWith(" 3P") || txtMarcaModeloCor.Text.Contains(" 3p ") || txtMarcaModeloCor.Text.EndsWith(" 3p") || txtMarcaModeloCor.Text.Contains(" 4P ") || txtMarcaModeloCor.Text.EndsWith(" 4P") || txtMarcaModeloCor.Text.Contains(" 4p ") || txtMarcaModeloCor.Text.EndsWith(" 4p") || txtMarcaModeloCor.Text.Contains(" 5P ") || txtMarcaModeloCor.Text.EndsWith(" 5P") || txtMarcaModeloCor.Text.Contains(" 5p ") || txtMarcaModeloCor.Text.EndsWith(" 5p"))
                {
                    MessageBox.Show("Não informe o número de portas no texto de modelo e versão. Apenas selecione uma opção na lista", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var botao = MessageBox.Show("Confirmar inserção de dados?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (botao == DialogResult.Yes)
                    {
                        SqlConnection conexao = null;

                        try
                        {
                            Modelo modelo = new Modelo(Convert.ToInt32(txtId.Text), Convert.ToInt32(cbMarca.SelectedValue), txtMarcaModeloCor.Text + " " + cbMotor.Text + " " + cbPortas.Text);

                            conexao = new SqlConnection(StringConexao.stringConexao);

                            SqlCommand pesquisar = new SqlCommand("SELECT COUNT(*) FROM tb_modelos WHERE modelo_nome = @modelo AND NOT modelo_id = @id;", conexao);

                            pesquisar.Parameters.AddWithValue("@modelo", modelo.Modelo1);
                            pesquisar.Parameters.AddWithValue("@id", modelo.Id);

                            conexao.Open();

                            int quantidade = Convert.ToInt32(pesquisar.ExecuteScalar());

                            if (quantidade > 0)
                            {
                                MessageBox.Show("Este modelo e versão de carro já está registrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                conexao.Close();
                            }
                            else
                            {
                                SqlCommand atualizar = new SqlCommand("UPDATE tb_modelos SET modelo_marca = @marca, modelo_nome = @modelo WHERE modelo_id = @id", conexao);

                                atualizar.Parameters.AddWithValue("@marca", modelo.Marca);
                                atualizar.Parameters.AddWithValue("@modelo", modelo.Modelo1);
                                atualizar.Parameters.AddWithValue("@id", modelo.Id);

                                atualizar.ExecuteNonQuery();

                                if (modelo.Marca != Convert.ToInt32(txtMarca.Text))
                                {
                                    SqlCommand atualizar2 = new SqlCommand("UPDATE tb_carros SET carro_marca = @marca WHERE carro_marca = @marca2", conexao);

                                    atualizar2.Parameters.AddWithValue("@marca", modelo.Marca);
                                    atualizar2.Parameters.AddWithValue("@marca2", Convert.ToInt32(txtMarca.Text));

                                    atualizar2.ExecuteNonQuery();
                                }

                                conexao.Close();

                                MessageBox.Show("Dados inseridos com sucesso", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
                            }
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
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.Text == "Marca - Alterar/Excluir")
            {
                var botao = MessageBox.Show("Confirmar remoção de registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (botao == DialogResult.Yes)
                {
                    SqlConnection conexao = null;

                    try
                    {
                        Marca marca = new Marca(Convert.ToInt32(txtId.Text));

                        conexao = new SqlConnection(StringConexao.stringConexao);

                        SqlCommand pesquisar = new SqlCommand("SELECT COUNT(*) FROM tb_modelos WHERE modelo_marca = @marca;", conexao);

                        pesquisar.Parameters.AddWithValue("@marca", marca.Id);

                        conexao.Open();

                        int quantidade = Convert.ToInt32(pesquisar.ExecuteScalar());

                        if (quantidade > 0)
                        {
                            MessageBox.Show("Pelo menos um registro na tabela de 'Modelos' está fazendo uso desta informação. Remova-os para poder apagar este registro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            conexao.Close();
                        }
                        else
                        {
                            SqlCommand deletar = new SqlCommand("DELETE FROM tb_marcas WHERE marca_id = @id;", conexao);

                            deletar.Parameters.AddWithValue("@id", marca.Id);                            

                            deletar.ExecuteNonQuery();

                            conexao.Close();

                            MessageBox.Show("Remoção feita com sucesso", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
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
            else if (this.Text == "Cor - Alterar/Excluir")
            {
                var botao = MessageBox.Show("Confirmar remoção de registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (botao == DialogResult.Yes)
                {
                    SqlConnection conexao = null;

                    try
                    {
                        Cor cor = new Cor(Convert.ToInt32(txtId.Text));

                        conexao = new SqlConnection(StringConexao.stringConexao);

                        SqlCommand pesquisar = new SqlCommand("SELECT COUNT(*) FROM tb_carros WHERE carro_cor = @cor;", conexao);

                        pesquisar.Parameters.AddWithValue("@cor", cor.Id);

                        conexao.Open();

                        int quantidade = Convert.ToInt32(pesquisar.ExecuteScalar());

                       if (quantidade > 0)
                       {
                            MessageBox.Show("Pelo menos um registro na tabela de 'Carros-estoque' está fazendo uso desta informação. Remova-os para poder apagar este registro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            conexao.Close();
                       }
                       else
                       {                           
                            SqlCommand deletar = new SqlCommand("DELETE FROM tb_cores WHERE cor_id = @id;", conexao);

                            deletar.Parameters.AddWithValue("@id", cor.Id);                            

                            deletar.ExecuteNonQuery();

                            conexao.Close();

                            MessageBox.Show("Remoção feita com sucesso", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
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
            else if (this.Text == "Modelo - Alterar/Excluir")
            {
                var botao = MessageBox.Show("Confirmar remoção de registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (botao == DialogResult.Yes)
                {
                    SqlConnection conexao = null;

                    try
                    {
                        Modelo modelo = new Modelo(Convert.ToInt32(txtId.Text));

                        conexao = new SqlConnection(StringConexao.stringConexao);

                        SqlCommand pesquisar = new SqlCommand("SELECT COUNT(*) FROM tb_carros WHERE carro_modelo = @modelo;", conexao);

                        pesquisar.Parameters.AddWithValue("@modelo", modelo.Id);

                        conexao.Open();

                        int quantidade = Convert.ToInt32(pesquisar.ExecuteScalar());

                       if (quantidade > 0)
                       {
                            MessageBox.Show("Pelo menos um registro na tabela de 'Carros-estoque' está fazendo uso desta informação. Remova-os para poder apagar este registro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            conexao.Close();
                       }
                       else
                       {
                            SqlCommand deletar = new SqlCommand("DELETE FROM tb_modelos WHERE modelo_id = @id;", conexao);

                            deletar.Parameters.AddWithValue("@id", modelo.Id);                            

                            deletar.ExecuteNonQuery();

                            conexao.Close();

                            MessageBox.Show("Remoção feita com sucesso", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
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
    }
}
