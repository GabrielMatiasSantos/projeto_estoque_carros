using estoque_carros.Dominio.Resultados;


namespace estoque_carros.Aplicacao.Interfaces
{
    public interface CriarPdfInterface
    {
        Task<Resultado2> EstoqueImprimir();
    }
}
