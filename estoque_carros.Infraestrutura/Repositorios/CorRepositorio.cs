using estoque_carros.Aplicacao.Dtos;
using System.Data.Common;
using estoque_carros.Aplicacao.Interfaces;
using estoque_carros.Dominio.Interfaces.Repositorios;
using estoque_carros.Dominio.Interfaces;


namespace estoque_carros.Infraestrutura.Repositorios
{
    public class CorRepositorio : CorRepositorioInterface, CorPesquisarInterface
    {
        private readonly CriarConexaoInterface _criarConexao;

        public CorRepositorio(CriarConexaoInterface criarConexao)
        {
            _criarConexao = criarConexao;
        }


        public async Task<List<CorDto>> PesquisarTudo()
        {
            List<CorDto> cores = new List<CorDto>();

            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand pesquisar = conexao.CreateCommand())
                {
                    pesquisar.CommandText = "SELECT * FROM tb_cores ORDER BY cor_nome";

                    using (DbDataReader registros = await pesquisar.ExecuteReaderAsync())
                    {
                        while (await registros.ReadAsync())
                        {
                            cores.Add(new CorDto(Convert.ToInt32(registros["cor_id"]), registros["cor_nome"].ToString()!));
                        }
                    }
                }
            }
            
            return cores;             
        }

        
        public async Task<int> PesquisarCorRepetida1(string cor)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand pesquisar = conexao.CreateCommand())
                {
                    pesquisar.CommandText = "SELECT COUNT(*) FROM tb_cores WHERE cor_nome = @cor";

                    pesquisar.Parametros("@cor", cor);

                    int quantidade = Convert.ToInt32(await pesquisar.ExecuteScalarAsync());

                    return quantidade;
                }
            }
        }

        public async Task<int> PesquisarCorRepetida2(string cor, int id)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand pesquisar = conexao.CreateCommand())
                {
                    pesquisar.CommandText = "SELECT COUNT(*) FROM tb_cores WHERE cor_nome = @cor AND NOT cor_id = @id";

                    pesquisar.Parametros("@cor", cor);
                    pesquisar.Parametros("@id", id);

                    int quantidade = Convert.ToInt32(await pesquisar.ExecuteScalarAsync());

                    return quantidade;
                }
            }
        }

        public async Task<List<CorDto>> PesquisarCor(string cor)
        {
            List<CorDto> cores = new List<CorDto>();

            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand pesquisar = conexao.CreateCommand())
                {
                    pesquisar.CommandText = "SELECT * FROM tb_cores WHERE cor_nome LIKE @cor;";

                    pesquisar.Parametros("@cor", '%' + cor + '%');

                    using (DbDataReader registros = await pesquisar.ExecuteReaderAsync())
                    {
                        while (registros.Read())
                        {
                            cores.Add(new CorDto(Convert.ToInt32(registros["cor_id"]), registros["cor_nome"].ToString()!));
                        }
                    }
                }
            }

            return cores;
        }

        public async Task InserirCor(string cor)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand inserir = conexao.CreateCommand())
                {
                    inserir.CommandText = "INSERT INTO tb_cores VALUES(@cor);";

                    inserir.Parametros("@cor", cor);

                    await inserir.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task AlterarCor(string cor, int id)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand alterar = conexao.CreateCommand())
                {
                    alterar.CommandText = "UPDATE tb_cores SET cor_nome = @cor WHERE cor_id = @id";

                    alterar.Parametros("@cor", cor);
                    alterar.Parametros("@id", id);

                    await alterar.ExecuteNonQueryAsync();
                }
            }         
        }

        public async Task ExcluirCor(int id)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand excluir = conexao.CreateCommand())
                {
                    excluir.CommandText = "DELETE FROM tb_cores WHERE cor_id = @id";

                    excluir.Parametros("@id", id);

                    await excluir.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
