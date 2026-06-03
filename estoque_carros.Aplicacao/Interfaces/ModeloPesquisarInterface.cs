using estoque_carros.Aplicacao.Dtos;


namespace estoque_carros.Aplicacao.Interfaces
{
    public interface ModeloPesquisarInterface
    {
        Task<List<ModeloDto>> PesquisarTudo();

        Task<List<ModeloDto>> PesquisarModelo(string modelo);

        Task<List<ModeloDto>> PesquisarModeloMarca1(int marca);
    }
}
