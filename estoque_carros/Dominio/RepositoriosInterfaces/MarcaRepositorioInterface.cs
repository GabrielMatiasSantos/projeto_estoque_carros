using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque_carros.Repositórios.Interfaces
{
    public interface MarcaRepositorioInterface
    {
        Task<List<MarcaDto>> PesquisarTudo(DbConnection conexao);

        Task<int> PesquisarMarcaRepetida1(string marca, DbConnection conexao);

        Task<int> PesquisarMarcaRepetida2(string marca, int id, DbConnection conexao);

        Task<List<MarcaDto>> PesquisarMarca(string marca, DbConnection conexao);

        Task InserirMarca(string marca, DbConnection conexao);

        Task AlterarMarca(string marca, int id, DbConnection conexao);

        Task ExcluirMarca(int id, DbConnection conexao);
    }
}
