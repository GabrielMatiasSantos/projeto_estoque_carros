using estoque_carros.Dominio.Resultados;
using estoque_carros.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Aplicacao.Servicos.Interfaces
{
    public interface CarroServicoInterface
    {
        Resultado2 Verificar(int modelo, int marca, string ano, int cor, string cambio, string combustivel, string km, string placaFinal, string preco);
        Task<Resultado1<List<CarroDto>>> PesquisarTudo();

        Task<Resultado1<List<CarroDto>>> PesquisarCarro(string carro);

        Task<Resultado2> InserirCarro(int modelo, int marca, string ano, int cor, string cambio, string combustivel, int km, int placaFinal, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco);

        Task<Resultado2> AlterarCarro(int id, int modelo, int marca, string ano, int cor, string cambio, string combustivel, int km, int placaFinal, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco);

        Task<Resultado2> AlterarCarroMarca(int marca, int modelo);

        Task<Resultado2> ExcluirCarro(int id);
    }
}
