using estoque_carros.Apresentacao.Dtos;
using estoque_carros.CamadaApresentacao.Helpers;
using estoque_carros.Dominio.Resultados;


namespace estoque_carros.Apresentacao.Helpers
{
    public static class Verificacao
    {
        public static Resultado2 VerificarCor(string cor)
        {
            if (cor == "")
            {
                return Resultado2.Falha("Informe uma cor");
            }
            else
            {
                return Resultado2.Sucesso1();
            }
        }

        public static Resultado2 VerificarMarca(string marca)
        {
            if (marca== "")
            {
                return Resultado2.Falha("Informe uma marca");
            }
            else
            {
                return Resultado2.Sucesso1();
            }
        }


        public static Resultado2 VerificarModelo(string marca, string modelo, string motor, string portas)
        {
            if (marca == "" || modelo == "" || motor == "" || portas == "")
            {
                return Resultado2.Falha("Preencha todos os campos");
            }
            else
            {
                string[] modeloVerificar = modelo.Split(' ');

                List<MenuValoresDto> listaPortas = MenuValores.Portas();

                bool verificar = false;

                foreach (string modeloParte in modeloVerificar)
                {
                    foreach (MenuValoresDto listaValor in listaPortas)
                    {
                        if (modeloParte.Equals(listaValor.Item, StringComparison.OrdinalIgnoreCase))
                        {
                            verificar = true;
                            break;
                        }

                        if (verificar)
                        {
                            break;
                        }
                    }
                }

                if (verificar)
                {
                    return Resultado2.Falha("Não informe o número de portas na área de informar o modelo");
                }
                else
                {
                    verificar = false;

                    List<MenuValoresDto> listaMotor = MenuValores.Motor();


                    foreach (string modeloParte in modeloVerificar)
                    {
                        foreach (MenuValoresDto listaValor in listaMotor)
                        {
                            if (modeloParte.Equals(listaValor.Item))
                            {
                                verificar = true;
                                break;
                            }
                        }

                        if (verificar)
                        {
                            break;
                        }
                    }

                    if (verificar)
                    {
                        return Resultado2.Falha("Não informe o motor na área de informar o modelo");
                    }
                    else
                    {
                        return Resultado2.Sucesso1();
                    }
                }
            }
        }
    }
}
