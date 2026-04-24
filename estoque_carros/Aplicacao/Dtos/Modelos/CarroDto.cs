using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Dtos
{
    public class CarroDto
    {
        private int id;
        private string modelo;
        private string marca;
        private string ano;
        private string cor;
        private string cambio;
        private string combustivel;
        private string km;
        private int placa;
        private string opcionais;
        private string observacoes;
        private string preco;


        public CarroDto(int id, string modelo, string marca, string ano, string cor, string cambio, string combustivel, string km, int placa, string opcionais, string observacoes, string preco)
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
            this.opcionais = opcionais;
            this.observacoes = observacoes;
            this.preco = preco;
        }


        public int Id
        {
            get { return id; }
        }

        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca
        {
            get { return marca; }
        }

        public string Ano
        {
            get { return ano; }
        }

        public string Cor
        {
            get { return cor; }
        }

        public string Cambio
        {
            get { return cambio; }
        }

        public string Combustivel
        {
            get { return combustivel; }
        }

        public string Km
        {
            get { return km; }
        }

        public int Placa
        {
            get { return placa; }
        }

        public string Opcionais
        {
            get { return opcionais; }
        }

        public string Observacoes
        {
            get { return observacoes; }
        }

        public string Preco
        {
            get { return preco; }
        }
    }
}
