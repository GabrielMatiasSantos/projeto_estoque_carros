using estoque_carros.Infraestrutura.Interfaces;


namespace estoque_carros.Infraestrutura
{
    public class StringConexao: StringConexaoInterface
    {
        public string StrConexao()
        {
            string projeto = AppDomain.CurrentDomain.BaseDirectory;

            string pasta = Path.GetFullPath(Path.Combine(projeto, @"../../../.."));

            string bancoDeDados = Path.Combine(pasta, "estoque_carros.Infraestrutura", "Dados", "dbEstoqueCarros.mdf");

            return $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={bancoDeDados};Integrated Security=True;Connect Timeout=30;Encrypt=False;;Integrated Security=True;Connect Timeout=60;";
        }
    }
}
