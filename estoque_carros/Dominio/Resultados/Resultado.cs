using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Dominio.Resultados
{
    public abstract class Resultado
    {
        protected bool sucesso;
        protected bool falhaCatch;
        protected string mensagem;

        public Resultado(bool sucesso, bool falhaCatch, string mensagem)
        {
            this.sucesso = sucesso;
            this.falhaCatch = falhaCatch;
            this.mensagem = mensagem;            
        }

        public Resultado(bool sucesso, string mensagem)
        {
            this.sucesso = sucesso;            
            this.mensagem = mensagem;
        }

        public Resultado(bool sucesso)
        {
            this.sucesso = sucesso;
        }


        public bool Sucesso
        {
            get { return this.sucesso; }
        }

        public bool FalhaCatch
        {
            get { return this.falhaCatch; }
        }

        public string Mensagem
        {
            get { return this.mensagem; }
        }
    }
}
