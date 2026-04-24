using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Aplicacao.Dtos.Formularios
{
    public class Formulario2Dto
    {
        private string cabecalho;

        private bool alterar;

        private bool excluir;

        private bool salvar;

        
        public Formulario2Dto(string cabecalho, bool salvar, bool alterar, bool excluir)
        {
            this.cabecalho = cabecalho;
            this.salvar = salvar;
            this.alterar = alterar;
            this.excluir = excluir;
        }


        public string Cabecalho
        {
            get { return cabecalho; }
        }

        public bool Alterar
        {
            get { return alterar; }
        }

        public bool Excluir
        {
            get { return excluir; }
        }

        public bool Salvar
        {
            get { return salvar; }
        }
    }
}
