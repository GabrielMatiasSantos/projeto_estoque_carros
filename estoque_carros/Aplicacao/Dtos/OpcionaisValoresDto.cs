using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Dominio
{
    public class OpcionaisValoresDto
    {
        private int indice;

        private string nome;

        private string valor;

        private string valorAbreviado;

        public OpcionaisValoresDto(int indice, string nome, string valor, string valorAbreviado)
        {
           this.indice = indice;
            this.nome = nome;
            this.valor = valor;
            this.valorAbreviado = valorAbreviado;
        }

        public OpcionaisValoresDto(string valor, string valorAbreviado)
        {
            this.valor = valor;
            this.valorAbreviado = valorAbreviado;
        }

        public int Indice
        {
            get { return indice; }
        }

        public string Nome
        {
            get { return nome; }
        }

        public string Valor
        {
            get { return valor; }
        }

        public string ValorAbreviado
        {
            get { return valorAbreviado; }
        }
    }
}
