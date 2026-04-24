using estoque_carros.Dtos;
using estoque_carros.Infraestrutura;
using estoque_carros.Repositórios.Interfaces;
using estoque_carros.Serviços.Interfaces;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque_carros.Repositórios
{
    public class ModeloRepositorio: ModeloRepositorioInterface
    {
       public async Task<List<ModeloDto>> PesquisarTudo(DbConnection conexao)
       {
            List<ModeloDto> modelos = new List<ModeloDto>();

            using (DbCommand pesquisar = conexao.CreateCommand())
            {
                pesquisar.CommandText = "SELECT modelo_id, modelo_nome, marca_nome FROM tb_modelos INNER JOIN tb_marcas ON tb_modelos.modelo_marca = tb_marcas.marca_id ORDER BY modelo_nome";

                using (DbDataReader registros = await pesquisar.ExecuteReaderAsync())
                {
                    while (await registros.ReadAsync())
                    {
                        modelos.Add(new ModeloDto(Convert.ToInt32(registros["modelo_id"]), registros["modelo_nome"].ToString(), registros["marca_nome"].ToString()));
                    }
                }

                return modelos;
            }
       }

        public async Task<int> PesquisarModeloRepetido1(string modelo, DbConnection conexao)
        {
            using (DbCommand pesquisar = conexao.CreateCommand())
            {
                pesquisar.CommandText = "SELECT COUNT(*) FROM tb_modelos WHERE modelo_nome = @modelo";

                pesquisar.Parametros("@modelo", modelo);

                int quantidade = Convert.ToInt32(await pesquisar.ExecuteScalarAsync());

                return quantidade;
            }
        }

        public async Task<int> PesquisarModeloRepetido2(int id, string modelo, DbConnection conexao)
        {
            using (DbCommand pesquisar = conexao.CreateCommand())
            {
                pesquisar.CommandText = "SELECT COUNT(*) FROM tb_modelos WHERE modelo_nome = @modelo AND NOT modelo_id = @id";

                pesquisar.Parametros("@modelo", modelo);
                pesquisar.Parametros("@id", id);

                int quantidade = Convert.ToInt32(await pesquisar.ExecuteScalarAsync());

                return quantidade;
            }
        }

        public async Task<List<ModeloDto>> PesquisarModelo(string modelo, DbConnection conexao)
        {
            List<ModeloDto> modelos = new List<ModeloDto>();

            using (DbCommand pesquisar = conexao.CreateCommand())
            {
                pesquisar.CommandText = "SELECT modelo_id, modelo_nome, marca_nome FROM tb_modelos INNER JOIN tb_marcas ON tb_modelos.modelo_marca = tb_marcas.marca_id WHERE modelo_nome LIKE @modelo ORDER BY modelo_nome;";

                pesquisar.Parametros("@modelo", '%' + modelo + '%');

                using (DbDataReader registros = await pesquisar.ExecuteReaderAsync())
                {
                    while (await registros.ReadAsync())
                    {
                        modelos.Add(new ModeloDto(Convert.ToInt32(registros["modelo_id"]), registros["modelo_nome"].ToString(), registros["marca_nome"].ToString()));
                    }
                }
            }

            return modelos;
        }

        public async Task<List<ModeloDto>> PesquisarModeloMarca(int marca, DbConnection conexao)
        {
            List<ModeloDto> modelos = new List<ModeloDto>();

            using (DbCommand pesquisar = conexao.CreateCommand())
            {
                pesquisar.CommandText = "SELECT modelo_id, modelo_nome FROM tb_modelos WHERE modelo_marca = @marca";

                pesquisar.Parametros("@marca", marca);

                using (DbDataReader registros = await pesquisar.ExecuteReaderAsync())
                {
                    while (await  registros.ReadAsync())
                    {
                        modelos.Add(new ModeloDto(Convert.ToInt32(registros["modelo_id"]), registros["modelo_nome"].ToString()));
                    }
                }

                return modelos;
            }
        }
      
        public async Task InserirModelo(int marca, string modelo, DbConnection conexao)
        {
            using (DbCommand inserir = conexao.CreateCommand())
            {
                inserir.CommandText = "INSERT INTO tb_modelos VALUES(@marca, @modelo);";

                inserir.Parametros("@marca", marca);
                inserir.Parametros("@modelo", modelo);

                await inserir.ExecuteNonQueryAsync();
            }
        }

        public async Task AlterarModelo(int id, int marca, string modelo, DbConnection conexao)
        {
            using (DbCommand alterar = conexao.CreateCommand())
            {
                alterar.CommandText = "UPDATE tb_modelos SET modelo_marca = @marca, modelo_nome = @modelo WHERE modelo_id = @id ";

                alterar.Parametros("@marca", marca);
                alterar.Parametros("@modelo", modelo);
                alterar.Parametros("@id", id);

                await alterar.ExecuteNonQueryAsync();
            }
        } 
        
        public async Task ExcluirModelo(int id, DbConnection conexao)
        {
            using (DbCommand excluir = conexao.CreateCommand())
            {
                excluir.CommandText = "DELETE FROM tb_modelos WHERE modelo_id = @id";

                excluir.Parametros("@id", id);

                await excluir.ExecuteNonQueryAsync();
            }
        }
    }
}
