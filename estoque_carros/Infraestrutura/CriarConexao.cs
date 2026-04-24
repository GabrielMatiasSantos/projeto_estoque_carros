using estoque_carros.Dominio;
using estoque_carros.Serviços.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Infraestrutura
{
    public class CriarConexao: CriarConexaoInterface
    {
        private readonly StringConexaoInterface _stringConexão;

        

        public CriarConexao(StringConexaoInterface stringConexao)
        {
            _stringConexão = stringConexao;
        }

        public DbConnection Conexao()
        {
            return new SqlConnection(_stringConexão.StringConexao());
        }
    }
}
