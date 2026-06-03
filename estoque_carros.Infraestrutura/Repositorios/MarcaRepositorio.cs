using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Aplicacao.Interfaces;
using System.Data.Common;
using estoque_carros.Dominio.Interfaces.Repositorios;
using estoque_carros.Dominio.Interfaces;


namespace estoque_carros.Infraestrutura.Repositorios
{
    public class MarcaRepositorio: MarcaRepositorioInterface, MarcaPesquisarInterface
    {
        private readonly CriarConexaoInterface _criarConexao;

        public MarcaRepositorio(CriarConexaoInterface criarConexao)
        {
            _criarConexao = criarConexao;
        }


        public async Task<List<MarcaDto>> PesquisarTudo()
        {
            List<MarcaDto> marcas = new List<MarcaDto>();

            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand pesquisar = conexao.CreateCommand())
                {
                    pesquisar.CommandText = "SELECT * FROM tb_marcas ORDER BY marca_nome";

                    DbDataReader registros = await pesquisar.ExecuteReaderAsync();

                    while (await registros.ReadAsync())
                    {
                        marcas.Add(new MarcaDto(Convert.ToInt32(registros["marca_id"]), registros["marca_nome"].ToString()!));
                    }
                }
            }
            return marcas;
        }

        public async Task<int> PesquisarMarcaRepetida1(string marca)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand pesquisar = conexao.CreateCommand())
                {
                    pesquisar.CommandText = "SELECT COUNT(*) FROM tb_marcas WHERE marca_nome = @marca";

                    pesquisar.Parametros("@marca", marca);

                    int quantidade = Convert.ToInt32(await pesquisar.ExecuteScalarAsync());

                    return quantidade;
                }
            }                             
        }


        public async Task<int> PesquisarMarcaRepetida2(string marca, int id)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand pesquisar = conexao.CreateCommand())
                {
                    pesquisar.CommandText = "SELECT COUNT(*) FROM tb_marcas WHERE marca_nome = @marca AND NOT marca_id = @id";

                    pesquisar.Parametros("@marca", marca);
                    pesquisar.Parametros("@id", id);

                    int quantidade = Convert.ToInt32(await pesquisar.ExecuteScalarAsync());

                    return quantidade;
                }
            }          
        }

        public async Task<List<MarcaDto>> PesquisarMarca(string marca)
        {
            List<MarcaDto> marcas = new List<MarcaDto>();

            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand pesquisar = conexao.CreateCommand())
                {
                    pesquisar.CommandText = "SELECT * FROM tb_marcas WHERE marca_nome LIKE @marca ORDER BY marca_nome";

                    pesquisar.Parametros("@marca", '%' + marca + '%');

                    using (DbDataReader registros = await pesquisar.ExecuteReaderAsync())
                    {
                        while (registros.Read())
                        {
                            marcas.Add(new MarcaDto(Convert.ToInt32(registros["marca_id"]), registros["marca_nome"].ToString()!));
                        }
                    }
                }
            }
            
            return marcas;
        }

        public async Task InserirMarca(string marca)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand inserir = conexao.CreateCommand())
                {
                    inserir.CommandText = "INSERT INTO tb_marcas VALUES(@marca);";

                    inserir.Parametros("@marca", marca);

                    await inserir.ExecuteNonQueryAsync();
                }
            }          
        }


        public async Task AlterarMarca(string marca, int id)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand alterar = conexao.CreateCommand())
                {
                    alterar.CommandText = "UPDATE tb_marcas SET marca_nome = @marca WHERE marca_id = @id";

                    alterar.Parametros("@marca", marca);
                    alterar.Parametros("@id", id);

                    await alterar.ExecuteNonQueryAsync();
                }
            }         
        }

        public async Task ExcluirMarca(int id)
        {
            using (DbConnection conexao = await _criarConexao.Conexao())
            {
                using (DbCommand excluir = conexao.CreateCommand())
                {
                    excluir.CommandText = "DELETE FROM tb_marcas WHERE marca_id = @id";

                    excluir.Parametros("@id", id);

                    await excluir.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
