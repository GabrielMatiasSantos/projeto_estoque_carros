using System.Data.Common;


namespace estoque_carros.Dominio.Interfaces
{
    public interface CriarConexaoInterface
    {
        Task<DbConnection> Conexao();
    }
}
