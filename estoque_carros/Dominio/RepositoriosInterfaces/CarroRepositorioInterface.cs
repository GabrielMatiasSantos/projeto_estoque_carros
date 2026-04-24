using estoque_carros.Dominio;
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
    public interface CarroRepositorioInterface
    {
        Task<List<CarroDto>> PesquisarTudo(DbConnection conexao);

        Task<List<CarroDto>> EstoqueImprimir(DbConnection conexao);

        Task<List<CarroDto>> PesquisarCarro(string modelo, DbConnection conexao);

        Task InserirCarro(int modelo, int marca, string ano, int cor, string cambio, string combustivel, int km, int placaFinal, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco, DbConnection conexao);

        Task AlterarCarro(int id, int modelo, int marca, string ano, int cor, string cambio, string combustivel, int km, int placaFinal, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco, DbConnection conexao);

        Task AlterarCarroMarca(int marca, int modelo, DbConnection conexao);

        Task ExcluirCarro(int id, DbConnection conexao);
    }
}
