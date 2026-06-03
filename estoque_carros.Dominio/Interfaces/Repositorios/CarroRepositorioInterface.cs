namespace estoque_carros.Dominio.Interfaces.Repositorios
{
    public interface CarroRepositorioInterface
    {
        Task<int> PesquisarCarroCor(int cor);

        Task<int> PesquisarCarroModelo(int modelo);

        Task InserirCarro(int modelo, int marca, string ano, int cor, string cambio, string combustivel, int km, int placaFinal, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco);

        Task AlterarCarro(int id, int modelo, int marca, string ano, int cor, string cambio, string combustivel, int km, int placaFinal, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco);

        Task AlterarCarroMarca(int marca, int modelo);

        Task ExcluirCarro(int id);
    }
}
