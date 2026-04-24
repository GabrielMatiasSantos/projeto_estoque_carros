using estoque_carros.Dominio.Resultados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Aplicacao.Servicos.Interfaces
{
    public interface CriarPdfServicoInterface
    {
        Task<Resultado2> EstoqueImprimir();
    }
}
