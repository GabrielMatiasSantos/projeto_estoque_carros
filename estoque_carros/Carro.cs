using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros
{
    internal class Carro
    {
        private int id;
        private int modelo;
        private int marca;
        private string ano;
        private int cor;
        private string cambio;
        private string combustivel;
        private decimal km;
        private int placa;
        private string opcionais;
        private string opcionais2;
        private string observacoes;
        private decimal preco;


        public Carro(int id)
        {
            this.id = id;
        }

        public Carro(int modelo, int marca, string ano, int cor, string cambio, string combustivel, decimal km, int placa, decimal preco)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.ano = ano;
            this.cor = cor;
            this.cambio = cambio;
            this.combustivel = combustivel;
            this.km = km;
            this.placa = placa;                      
            this.preco = preco;
        }

        public Carro(int id, int modelo, int marca, string ano, int cor, string cambio, string combustivel, decimal km, int placa, decimal preco)
        {
            this.id = id;
            this.modelo = modelo;
            this.marca = marca;
            this.ano = ano;
            this.cor = cor;
            this.cambio = cambio;
            this.combustivel = combustivel;
            this.km = km;
            this.placa = placa;                       
            this.preco = preco;
        }

        public int Id
        {
            get { return this.id; }
        }

        public int Modelo
        {
            get { return this.modelo; }
        }

        public int Marca
        {
            get { return this.marca; }
        }

        public string Ano
        {
            get { return this.ano; }
        }

        public int Cor
        {
            get { return this.cor; }
        }

        public string Cambio
        {
            get { return this.cambio; }
        }

        public string Combustivel
        {
            get { return this.combustivel; }
        }

        public decimal Km
        {
            get { return this.km; }
        }

        public int Placa
        {
            get { return this.placa; }
        }

        public string Opcionais
        {
            get { return this.opcionais; }
            set { this.opcionais = value; }
        }

        public string Opcionais2
        {
            get { return this.opcionais2; }
            set { this.opcionais2 = value; }
        }

        public string Observacoes
        {
            get { return this.observacoes; }
            set { this.observacoes = value;}
        }

        public decimal Preco
        {
            get { return this.preco; }
        }
    }
}
