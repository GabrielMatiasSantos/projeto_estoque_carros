using estoque_carros.Aplicacao.Dtos;


namespace estoque_carros.Aplicacao.Interfaces
{
    public interface MarcaPesquisarInterface
    {
        Task<List<MarcaDto>> PesquisarTudo();

        Task<List<MarcaDto>> PesquisarMarca(string marca);
    }
}
