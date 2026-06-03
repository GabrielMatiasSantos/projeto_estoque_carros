using estoque_carros.CamadaApresentacao.Helpers;


namespace estoque_carros.Apresentacao.Helpers
{
    public static class ManipularTexto
    {
        public static string Modelo(string modelo, string motor, string portas)
        {
            string modeloCompleto;

            if (motor == MenuValores.motorOutros)
            {
                modeloCompleto = $"{modelo} {portas}";
            }
            else
            {
                modeloCompleto = $"{modelo} {motor} {portas}";
            }

            return modeloCompleto;
        }
    }
}
