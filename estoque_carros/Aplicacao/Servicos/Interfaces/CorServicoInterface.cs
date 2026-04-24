using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Dominio.Resultados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Aplicacao.Servicos.Interfaces
{
    public interface CorServicoInterface
    {
        Resultado2 Verificar(string texto);

        Task<Resultado1<List<CorDto>>> PesquisarTudo();

        Task<Resultado1<List<CorDto>>> PesquisarCor(string cor);

        Task<Resultado2> InserirCor(string cor);

        Task<Resultado2> AlterarCor(string cor, int id);

        Task<Resultado2> ExcluirCor(int id);
    }
}
