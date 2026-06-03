using estoque_carros.Aplicacao.Dtos;


namespace estoque_carros.Aplicacao.Interfaces
{
    public interface CorPesquisarInterface
    {
        Task<List<CorDto>> PesquisarTudo();

        Task<List<CorDto>> PesquisarCor(string cor);
    }
}
