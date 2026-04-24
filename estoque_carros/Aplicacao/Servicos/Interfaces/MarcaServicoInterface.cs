using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Dominio.Resultados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Aplicacao.Servicos.Interfaces
{
    public interface MarcaServicoInterface
    {
        Resultado2 Verificar(string texto);

        Task<Resultado1<List<MarcaDto>>> PesquisarTudo();

        Task<Resultado1<List<MarcaDto>>> PesquisarMarca(string marca);

        Task<Resultado2> InserirMarca(string marca);

        Task<Resultado2> AlterarMarca(string marca, int id);

        Task<Resultado2> ExcluirMarca(int id);
    }
}
