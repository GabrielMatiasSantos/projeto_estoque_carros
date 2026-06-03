using estoque_carros.Aplicacao.Dtos;


namespace estoque_carros.Aplicacao.Interfaces
{
    public interface CarroPesquisarInterface
    {
        Task<List<CarroDto>> PesquisarTudo();

        Task<List<CarroDto>> EstoqueImprimir();

        Task<List<CarroDto>> PesquisarCarro(string modelo);
    }
}
