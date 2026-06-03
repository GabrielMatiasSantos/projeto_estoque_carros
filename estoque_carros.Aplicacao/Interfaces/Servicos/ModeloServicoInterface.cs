using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Dominio.Resultados;


namespace estoque_carros.Aplicacao.Interfaces.Servicos
{
    public interface ModeloServicoInterface
    {
        Task<Resultado1<List<ModeloDto>>> PesquisarTudo();

        Task<Resultado1<List<ModeloDto>>> PesquisarModelo(string modelo);

        Task<Resultado1<List<ModeloDto>>> PesquisarModeloMarca1(int marca);

        Task<Resultado2> PesquisarModeloMarca2(int marca);

        Task<Resultado2> InserirModelo(int marca, string modelo);

        Task<Resultado2> AlterarModelo(int id, int marca, string modelo);

        Task<Resultado2> ExcluirModelo(int id);
    }
}
