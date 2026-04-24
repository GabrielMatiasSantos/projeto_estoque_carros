using estoque_carros.Dominio.Resultados;
using estoque_carros.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Aplicacao.Servicos.Interfaces
{
    public interface ModeloServicoInterface
    {
        Resultado2 Verificar(int marca, string modelo, string portas, string motor);

        Task<Resultado1<List<ModeloDto>>> PesquisarTudo();

        Task<Resultado1<List<ModeloDto>>> PesquisarModelo(string modelo);

        Task<Resultado1<List<ModeloDto>>> PesquisarModeloMarca(int marca);

        Task<Resultado2> InserirModelo(int marca, string modelo, string motor, string portas);

        Task<Resultado2> AlterarModelo(int id, int marca, string modelo, string motor, string portas);

        Task<Resultado2> ExcluirModelo(int id);
    }
}
