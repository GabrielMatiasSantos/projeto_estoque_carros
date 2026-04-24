using estoque_carros.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque_carros.Repositórios.Interfaces
{
    public interface ModeloRepositorioInterface
    {
        Task<List<ModeloDto>> PesquisarTudo(DbConnection conexao);

        Task<int> PesquisarModeloRepetido1(string modelo, DbConnection conexao);

        Task<int> PesquisarModeloRepetido2(int id, string modelo, DbConnection conexao);

        Task<List<ModeloDto>> PesquisarModelo(string modelo, DbConnection conexao);

        Task<List<ModeloDto>> PesquisarModeloMarca(int marca, DbConnection conexao);

        Task InserirModelo(int marca, string modelo, DbConnection conexao);

        Task AlterarModelo(int id, int marca, string modelo, DbConnection conexao);

        Task ExcluirModelo(int id, DbConnection conexao);
    }
}
