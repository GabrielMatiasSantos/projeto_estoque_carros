using estoque_carros.CamadaApresentacao.Helpers;
using estoque_carros.Dominio.Resultados;
using System.Runtime.Versioning;


namespace estoque_carros.Apresentacao.Helpers
{
    [SupportedOSPlatform("windows")]
    public static class ResultadoOperacao
    {
        public static void Resultado(Form formulario, Resultado2 resultado)
        {
            if (resultado.Sucesso)
            {
                Mensagens.Sucesso(resultado);

                formulario.DialogResult = DialogResult.OK;

                formulario.Close();
            }
            else
            {
                Mensagens.Falha(resultado);
            }
        }
    }
}
