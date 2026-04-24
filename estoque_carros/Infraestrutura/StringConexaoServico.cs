using estoque_carros.Serviços.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros
{
    public class StringConexaoServico: StringConexaoInterface
    {
        public string StringConexao()
        {
            return "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Infraestrutura\\BancoDeDados\\dbEstoqueCarros.mdf;Integrated Security=True;Connect Timeout=60;";
        }
    }
}
