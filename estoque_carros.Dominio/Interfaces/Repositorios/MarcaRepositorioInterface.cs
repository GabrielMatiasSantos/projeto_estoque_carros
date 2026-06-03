namespace estoque_carros.Dominio.Interfaces.Repositorios
{
    public interface MarcaRepositorioInterface
    {
        Task<int> PesquisarMarcaRepetida1(string marca);

        Task<int> PesquisarMarcaRepetida2(string marca, int id);

        Task InserirMarca(string marca);

        Task AlterarMarca(string marca, int id);

        Task ExcluirMarca(int id);
    }
}
