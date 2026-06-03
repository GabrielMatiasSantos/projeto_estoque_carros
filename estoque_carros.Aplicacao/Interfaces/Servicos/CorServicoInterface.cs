using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Dominio.Resultados;


namespace estoque_carros.Aplicacao.Interfaces.Servicos
{
    public interface CorServicoInterface
    {
        Task<Resultado1<List<CorDto>>> PesquisarTudo();

        Task<Resultado1<List<CorDto>>> PesquisarCor(string cor);

        Task<Resultado2> InserirCor(string cor);

        Task<Resultado2> AlterarCor(string cor, int id);

        Task<Resultado2> ExcluirCor(int id);
    }
}
