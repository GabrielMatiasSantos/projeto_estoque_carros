using System.Data.Common;
using Microsoft.Data.SqlClient;
using estoque_carros.Infraestrutura.Interfaces;
using estoque_carros.Dominio.Interfaces;


namespace estoque_carros.Infraestrutura
{
    public class CriarConexao: CriarConexaoInterface
    {
        private readonly StringConexaoInterface _stringConexão;
      

        public CriarConexao(StringConexaoInterface stringConexao)
        {
            _stringConexão = stringConexao;
        }

        public async Task<DbConnection> Conexao()
        {
            SqlConnection conexao = new SqlConnection(_stringConexão.StrConexao());

            await conexao.OpenAsync();

            return conexao;
        }
    }
}
