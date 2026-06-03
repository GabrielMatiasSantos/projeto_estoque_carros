using estoque_carros.Dominio.Resultados;
using System.Runtime.Versioning;


namespace estoque_carros.CamadaApresentacao.Helpers
{
    [SupportedOSPlatform("windows")]

    public static class Mensagens
    {
        public static DialogResult Confirmar(string texto)
        {
            DialogResult botao = MessageBox.Show(texto, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return botao;
        }

        public static void Sucesso<T>(Resultado1<T> resultado) where T : class
        {
            MessageBox.Show(resultado.Mensagem, "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Sucesso(Resultado2 resultado)
        {
            MessageBox.Show(resultado.Mensagem, "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


       public static void Falha<T>(Resultado1<T> resultado) where T : class
       {
            MessageBoxIcon icone;

            if (resultado.FalhaCatch)
            {
                icone = MessageBoxIcon.Error;
            }
            else
            {
                icone = MessageBoxIcon.Warning;
            }

            MessageBox.Show(resultado.Mensagem, "Atenção", MessageBoxButtons.OK, icone);
       }

        public static void Falha(Resultado2 resultado)
        {
            MessageBoxIcon icone;

            if (resultado.FalhaCatch)
            {
                icone = MessageBoxIcon.Error;
            }
            else
            {
                icone = MessageBoxIcon.Warning;
            }

            MessageBox.Show(resultado.Mensagem, "Atenção", MessageBoxButtons.OK, icone);
        }
    }
}
