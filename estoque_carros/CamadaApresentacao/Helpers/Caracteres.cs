using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque_carros.CamadaApresentacao.Helpers
{
    public static class Caracteres
    {
        public static void Nome1(KeyPressEventArgs e, string texto)
        {
            if (texto == "")
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        public static void Nome2(KeyPressEventArgs e, string texto)
        {
            if (texto == "")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != 8)
                {
                    if (!".!/-()'".Contains(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        public static void Texto(KeyPressEventArgs e, string texto)
        {
            if (texto == "")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        public static void Km(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public static void Preco(KeyPressEventArgs e, string texto)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 8)
            {
                texto = "";
            }
        }
    }
}
