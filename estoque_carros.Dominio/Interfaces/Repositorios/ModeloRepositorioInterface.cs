namespace estoque_carros.Dominio.Interfaces.Repositorios
{
    public interface ModeloRepositorioInterface
    {
        Task<int> PesquisarModeloRepetido1(string modelo);

        Task<int> PesquisarModeloRepetido2(int id, string modelo);

        Task<int> PesquisarModeloMarca2(int marca);

        Task InserirModelo(int marca, string modelo);

        Task AlterarModelo(int id, int marca, string modelo);

        Task ExcluirModelo(int id);
    }
}
