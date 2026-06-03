using estoque_carros.Aplicacao.Interfaces;


namespace estoque_carros.Aplicacao.CriarArquivos
{
    public class CriarLogs: CriarLogsInterface
    {
        public void CriarLog(Exception erro)
        {
            string diretorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs de erro");

            string arquivo = $"Log de erro ({DateTime.Now:yyyy-MM-dd_HH-mm-ss}).log";

            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }

            string caminho = Path.Combine(diretorio, arquivo);

            using (StreamWriter arquivoLog = new StreamWriter(caminho))
            {
                arquivoLog.WriteLine("Mensagem do erro:");
                arquivoLog.WriteLine();
                arquivoLog.WriteLine(erro.Message);
                arquivoLog.WriteLine("\r\n");
                arquivoLog.WriteLine("Método onde o erro ocorreu:");
                arquivoLog.WriteLine();
                arquivoLog.WriteLine(erro.TargetSite);
                arquivoLog.WriteLine("\r\n");
                arquivoLog.WriteLine("Parte do código onde o erro ocorreu:");
                arquivoLog.WriteLine();
                arquivoLog.WriteLine(erro.StackTrace);
            }
        }
    }
}
