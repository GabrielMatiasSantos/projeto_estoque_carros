using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Dominio.Resultados;



namespace estoque_carros.Aplicacao.Interfaces.Servicos
{
    public interface CarroServicoInterface
    {       
        Task<Resultado1<List<CarroDto>>> PesquisarTudo();

        Task<Resultado1<List<CarroDto>>> PesquisarCarro(string carro);

        Task<Resultado2> PesquisarCarroCor(int id);

        Task<Resultado2> PesquisarCarroModelo(int modelo);

        Task<Resultado2> InserirCarro(int modelo, int marca, string ano, int anoFabricacao, int anoModelo, int cor, string cambio, string combustivel, int km, int placaFinal, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco);

        Task<Resultado2> AlterarCarro(int id, int modelo, int marca, string ano, int anoFabricacao, int anoModelo, int cor, string cambio, string combustivel, int km, int placaFinal, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco);

        Task<Resultado2> AlterarCarroMarca(int marca, int modelo);

        Task<Resultado2> ExcluirCarro(int id);
    }
}
