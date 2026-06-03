namespace estoque_carros.Dominio.Interfaces.Repositorios
{
    public interface CorRepositorioInterface
    {
        Task<int> PesquisarCorRepetida1(string cor);

        Task<int> PesquisarCorRepetida2(string cor, int id);

        Task InserirCor(string cor);

        Task AlterarCor(string cor, int id);

        Task ExcluirCor(int id);
    }
}
