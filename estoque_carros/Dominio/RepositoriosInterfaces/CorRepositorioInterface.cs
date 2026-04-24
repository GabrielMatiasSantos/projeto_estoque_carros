using estoque_carros.Aplicacao.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace estoque_carros.Repositórios.Interfaces
{
    public interface CorRepositorioInterface
    {
        Task<List<CorDto>> PesquisarTudo(DbConnection conexao);

        Task<int> PesquisarCorRepetida1(string cor, DbConnection conexao);

        Task<int> PesquisarCorRepetida2(string cor, int id, DbConnection conexao);

        Task<List<CorDto>> PesquisarCor(string cor, DbConnection conexao);

        Task InserirCor(string cor, DbConnection conexao);

        Task AlterarCor(string cor, int id, DbConnection conexao);

        Task ExcluirCor(int id, DbConnection conexao);
    }
}
