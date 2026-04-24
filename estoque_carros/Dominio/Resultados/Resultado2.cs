using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Dominio.Resultados
{
    public class Resultado2: Resultado
    {
        public Resultado2(bool sucesso) : base(sucesso)
        {
        }

        public Resultado2(bool sucesso, string mensagem) : base(sucesso, mensagem)
        {
        }

        public Resultado2(bool sucesso, bool falhaCatch, string mensagem) : base(sucesso, falhaCatch, mensagem)
        {
        }

        
        public static Resultado2 Sucesso1()
        {
            return new Resultado2(true);
        }

        public static Resultado2 Sucesso1(string mensagem)
        {
            return new Resultado2(true, mensagem);
        }

        public static Resultado2 Falha(string mensagem)
        {
            return new Resultado2(false, false, mensagem);
        }

        public static Resultado2 Falha(Exception erro)
        {
            return new Resultado2(false, true, erro.Message);
        }
    }
}
