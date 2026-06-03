using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Aplicacao.Interfaces;
using estoque_carros.Dominio.Interfaces;
using estoque_carros.Dominio.Interfaces.Repositorios;
using System.Data.Common;


namespace estoque_carros.Infraestrutura.Repositorios
{
    public class CarroRepositorio: CarroRepositorioInterface, CarroPesquisarInterface
    {
        private readonly CriarConexaoInterface _criarConexao;

        public CarroRepositorio(CriarConexaoInterface criarConexao)
        {
            _criarConexao = criarConexao;
        }

        public async Task<List<CarroDto>> PesquisarTudo()
        {
            List<CarroDto>  carros = new List<CarroDto>();

            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand pesquisar = conexao.CreateCommand())
                {
                    pesquisar.CommandText = "SELECT carro_id, modelo_nome, marca_nome, carro_ano, cor_nome, carro_cambio, carro_combustivel, carro_quilometragem, carro_placa_final, carro_opcionais, carro_observacoes, carro_preco FROM tb_carros INNER JOIN tb_cores ON tb_carros.carro_cor = tb_cores.cor_id INNER JOIN tb_marcas ON tb_carros.carro_marca = tb_marcas.marca_id INNER JOIN tb_modelos ON tb_carros.carro_modelo = tb_modelos.modelo_id ORDER BY modelo_nome;";

                    using (DbDataReader registros = await pesquisar.ExecuteReaderAsync())
                    {
                        while (await registros.ReadAsync())
                        {
                            carros.Add(new CarroDto(Convert.ToInt32(registros["carro_id"]), registros["modelo_nome"].ToString()!, registros["marca_nome"].ToString()!, registros["carro_ano"].ToString()!, registros["cor_nome"].ToString()!, registros["carro_cambio"].ToString()!, registros["carro_combustivel"].ToString()!, Convert.ToInt32(registros["carro_quilometragem"]).ToString("N0"), Convert.ToInt32(registros["carro_placa_final"]), registros["carro_opcionais"].ToString()!, registros["carro_observacoes"].ToString()!, Convert.ToDecimal(registros["carro_preco"]).ToString("N2")));
                        }
                    }                
                }
            }

            return carros;
        }

        public async Task<List<CarroDto>> EstoqueImprimir()
        {
            List<CarroDto> carros = new List<CarroDto>();

            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand pesquisar = conexao.CreateCommand())
                {
                    pesquisar.CommandText = "SELECT carro_id, modelo_nome, marca_nome, carro_ano, cor_nome, carro_cambio, carro_combustivel, carro_quilometragem, carro_placa_final, carro_opcionais_abreviacao, carro_observacoes, carro_preco FROM tb_carros INNER JOIN tb_cores ON tb_carros.carro_cor = tb_cores.cor_id INNER JOIN tb_marcas ON tb_carros.carro_marca = tb_marcas.marca_id INNER JOIN tb_modelos ON tb_carros.carro_modelo = tb_modelos.modelo_id ORDER BY modelo_nome;";

                    using (DbDataReader registros = await pesquisar.ExecuteReaderAsync())
                    {
                        while (await registros.ReadAsync())
                        {
                            carros.Add(new CarroDto(Convert.ToInt32(registros["carro_id"]), registros["modelo_nome"].ToString()!, registros["marca_nome"].ToString()!, registros["carro_ano"].ToString()!, registros["cor_nome"].ToString()!, registros["carro_cambio"].ToString()!, registros["carro_combustivel"].ToString()!, Convert.ToInt32(registros["carro_quilometragem"]).ToString("N0"), Convert.ToInt32(registros["carro_placa_final"]), registros["carro_opcionais_abreviacao"].ToString()!, registros["carro_observacoes"].ToString()!, Convert.ToDecimal(registros["carro_preco"]).ToString("N2")));
                        }
                    }
                }
            }

            return carros;
        }

        public async Task<List<CarroDto>> PesquisarCarro(string modelo)
        {
            List<CarroDto> carros = new List<CarroDto>();

            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand pesquisar = conexao.CreateCommand())
                {
                    pesquisar.CommandText = "SELECT carro_id, modelo_nome, marca_nome, carro_ano, cor_nome, carro_cambio, carro_combustivel, carro_quilometragem, carro_placa_final, carro_opcionais, carro_observacoes, carro_preco FROM tb_carros INNER JOIN tb_cores ON tb_carros.carro_cor = tb_cores.cor_id INNER JOIN tb_marcas ON tb_carros.carro_marca = tb_marcas.marca_id INNER JOIN tb_modelos ON tb_carros.carro_modelo = tb_modelos.modelo_id WHERE modelo_nome LIKE @modelo ORDER BY modelo_nome;";

                    pesquisar.Parametros("@modelo", '%' + modelo + '%');

                    using (DbDataReader registros = await pesquisar.ExecuteReaderAsync())
                    {
                        while (await registros.ReadAsync())
                        {
                            carros.Add(new CarroDto(Convert.ToInt32(registros["carro_id"]), registros["modelo_nome"].ToString()!, registros["marca_nome"].ToString()!, registros["carro_ano"].ToString()!, registros["cor_nome"].ToString()!, registros["carro_cambio"].ToString()!, registros["carro_combustivel"].ToString()!, Convert.ToInt32(registros["carro_quilometragem"]).ToString("N0"), Convert.ToInt32(registros["carro_placa_final"]), registros["carro_opcionais"].ToString()!, registros["carro_observacoes"].ToString()!, Convert.ToDecimal(registros["carro_preco"]).ToString("N2")));
                        }
                    }                
                }
            }

            return carros;
        }

        public async Task<int> PesquisarCarroCor(int cor)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand pesquisar = conexao.CreateCommand())
                {
                    pesquisar.CommandText = "SELECT COUNT(*) FROM tb_carros WHERE carro_cor = @cor";

                    pesquisar.Parametros("@cor", cor);

                    int quantidade = Convert.ToInt32(await pesquisar.ExecuteScalarAsync());

                    return quantidade;
                }
            }
        }

        public async Task<int> PesquisarCarroModelo(int modelo)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand pesquisar = conexao.CreateCommand())
                {
                    pesquisar.CommandText = "SELECT COUNT(*) FROM tb_carros WHERE carro_modelo = @modelo";

                    pesquisar.Parametros("@modelo", modelo);

                    int quantidade = Convert.ToInt32(await pesquisar.ExecuteScalarAsync());

                    return quantidade;
                }
            }
        }

        public async Task InserirCarro(int modelo, int marca, string ano, int cor, string cambio, string combustivel, int km, int placaFinal, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand inserir = conexao.CreateCommand())
                {
                    inserir.CommandText = "INSERT INTO tb_carros VALUES(@modelo, @marca, @ano, @cor, @cambio, @combustivel, @km, @placaFinal, @opcionais, @opcionaisAbreviacao, @observacoes, @preco);";

                    inserir.Parametros("@modelo", modelo);
                    inserir.Parametros("@marca", marca);
                    inserir.Parametros("@ano", ano);
                    inserir.Parametros("@cor", cor);
                    inserir.Parametros("@cambio", cambio);
                    inserir.Parametros("@combustivel", combustivel);
                    inserir.Parametros("@km", km);
                    inserir.Parametros("@placaFinal", placaFinal);
                    inserir.Parametros("@opcionais", opcionais);
                    inserir.Parametros("@opcionaisAbreviacao", opcionaisAbreviacao);
                    inserir.Parametros("@observacoes", observacoes);
                    inserir.Parametros("@preco", preco);

                    await inserir.ExecuteNonQueryAsync();
                }
            }          
        }

        public async Task AlterarCarro(int id, int modelo, int marca, string ano, int cor, string cambio, string combustivel, int km, int placaFinal, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand alterar = conexao.CreateCommand())
                {
                    alterar.CommandText = "UPDATE tb_carros SET carro_modelo = @modelo, carro_marca = @marca, carro_ano = @ano, carro_cor = @cor, carro_cambio = @cambio, carro_combustivel = @combustivel, carro_quilometragem = @km, carro_placa_final = @placaFinal, carro_opcionais = @opcionais, carro_opcionais_abreviacao = @opcionaisAbreviacao, carro_observacoes = @observacoes, carro_preco = @preco WHERE carro_id = @id";

                    alterar.Parametros("@id", id);
                    alterar.Parametros("@modelo", modelo);
                    alterar.Parametros("@marca", marca);
                    alterar.Parametros("@ano", ano);
                    alterar.Parametros("@cor", cor);
                    alterar.Parametros("@cambio", cambio);
                    alterar.Parametros("@combustivel", combustivel);
                    alterar.Parametros("@km", km);
                    alterar.Parametros("@placaFinal", placaFinal);
                    alterar.Parametros("@opcionais", opcionais);
                    alterar.Parametros("@opcionaisAbreviacao", opcionaisAbreviacao);
                    alterar.Parametros("@observacoes", observacoes);
                    alterar.Parametros("@preco", preco);

                    await alterar.ExecuteNonQueryAsync();
                }
            }           
        }

        public async Task AlterarCarroMarca(int marca, int modelo)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand alterar = conexao.CreateCommand())
                {
                    alterar.CommandText = "UPDATE tb_carros SET carro_marca = @marca WHERE carro_modelo = @modelo";

                    alterar.Parametros("@marca", marca);
                    alterar.Parametros("@modelo", modelo);

                    await alterar.ExecuteNonQueryAsync();
                }
            }          
        }

        public async Task ExcluirCarro(int id)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand excluir = conexao.CreateCommand())
                {
                    excluir.CommandText = "DELETE FROM tb_carros WHERE carro_id = @id";

                    excluir.Parametros("@id", id);

                    await excluir.ExecuteNonQueryAsync();
                }
            }           
        }
    }
}
