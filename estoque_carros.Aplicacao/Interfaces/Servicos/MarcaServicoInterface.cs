using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Dominio.Resultados;


namespace estoque_carros.Aplicacao.Interfaces.Servicos
{
    public interface MarcaServicoInterface
    {
        Task<Resultado1<List<MarcaDto>>> PesquisarTudo();

        Task<Resultado1<List<MarcaDto>>> PesquisarMarca(string marca);

        Task<Resultado2> InserirMarca(string marca);

        Task<Resultado2> AlterarMarca(string marca, int id);

        Task<Resultado2> ExcluirMarca(int id);
    }
}
