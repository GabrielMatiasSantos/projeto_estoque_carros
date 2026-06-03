using System.Data.Common;


namespace estoque_carros.Infraestrutura
{
    public static class MetodoExtensao
    {
        public static void Parametros(this DbCommand cmd, string variavel, object valor)
        {
            DbParameter parametros = cmd.CreateParameter();

            parametros.ParameterName = variavel;
            parametros.Value = valor;

            cmd.Parameters.Add(parametros);
        }
    }
}
