using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Dominio;
using estoque_carros.Dominio.Resultados;
using estoque_carros.Infraestrutura;
using estoque_carros.Repositórios.Interfaces;
using estoque_carros.Serviços.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque_carros.Repositórios
{
    public class MarcaRepositorio: MarcaRepositorioInterface
    {
        public async Task<List<MarcaDto>> PesquisarTudo(DbConnection conexao)
        {
            List<MarcaDto> marcas = new List<MarcaDto>();

            using (DbCommand pesquisar = conexao.CreateCommand())
            {
                pesquisar.CommandText = "SELECT * FROM tb_marcas ORDER BY marca_nome";

                DbDataReader registros = await pesquisar.ExecuteReaderAsync();

                while (await registros.ReadAsync())
                {
                    marcas.Add(new MarcaDto(Convert.ToInt32(registros["marca_id"]), registros["marca_nome"].ToString()));
                }
            }

            return marcas;
        }

        public async Task<int> PesquisarMarcaRepetida1(string marca, DbConnection conexao)
        {
            using (DbCommand pesquisar = conexao.CreateCommand())
            {
                pesquisar.CommandText = "SELECT COUNT(*) FROM tb_marcas WHERE marca_nome = @marca";

                pesquisar.Parametros("@marca", marca);

                int quantidade = Convert.ToInt32(await pesquisar.ExecuteScalarAsync());

                return quantidade;
            }                     
        }


        public async Task<int> PesquisarMarcaRepetida2(string marca, int id, DbConnection conexao)
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

        public async Task<List<MarcaDto>> PesquisarMarca(string marca, DbConnection conexao)
        {
            List<MarcaDto> marcas = new List<MarcaDto>();

            using (DbCommand pesquisar = conexao.CreateCommand())
            {
                pesquisar.CommandText = "SELECT * FROM tb_marcas WHERE marca_nome LIKE @marca ORDER BY marca_nome";

                pesquisar.Parametros("@marca", '%' + marca + '%');

                using (DbDataReader registros = await pesquisar.ExecuteReaderAsync())
                {
                    while (registros.Read())
                    {
                        marcas.Add(new MarcaDto(Convert.ToInt32(registros["marca_id"]), registros["marca_nome"].ToString()));
                    }
                }
            }

            return marcas;
        }

        public async Task InserirMarca(string marca, DbConnection conexao)
        {
            using (DbCommand inserir = conexao.CreateCommand())
            {
                inserir.CommandText = "INSERT INTO tb_marcas VALUES(@marca);";

                inserir.Parametros("@marca", marca);

                await inserir.ExecuteNonQueryAsync();
            }
        }


        public async Task AlterarMarca(string marca, int id, DbConnection conexao)
        {
            using (DbCommand alterar = conexao.CreateCommand())
            {
                alterar.CommandText = "UPDATE tb_marcas SET marca_nome = @marca WHERE marca_id = @id";

                alterar.Parametros("@marca", marca);
                alterar.Parametros("@id", id);

                await alterar.ExecuteNonQueryAsync();
            }
        }

        public async Task ExcluirMarca(int id, DbConnection conexao)
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
