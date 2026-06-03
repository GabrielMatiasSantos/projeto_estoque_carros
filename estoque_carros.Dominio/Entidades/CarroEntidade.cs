using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Dominio.Entidades
{
    public class CarroEntidade
    {
        private int id;
        private int modelo;
        private int marca;
        private string ano;
        private int anoFabricacao;
        private int anoModelo;
        private int cor;
        private string cambio;
        private string combustivel;
        private int km;
        private int placa;
        private string opcionais;
        private string opcionaisAbreviacao;
        private string observacoes;
        private decimal preco;


        public CarroEntidade(int modelo, int marca, string ano, int anoFabricacao, int anoModelo, int cor, string cambio, string combustivel, int km, int placa, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.ano = ano;
            this.anoFabricacao = anoFabricacao;
            this.anoModelo = anoModelo;
            this.cor = cor;
            this.cambio = cambio;
            this.combustivel = combustivel;
            this.km = km;
            this.placa = placa;  
            this.opcionais = opcionais;
            this.opcionaisAbreviacao = opcionaisAbreviacao;
            this.observacoes = observacoes;
            this.preco = preco;
        }

        public CarroEntidade(int id, int modelo, int marca, string ano, int anoFabricacao, int anoModelo, int cor, string cambio, string combustivel, int km, int placa, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco)
        {
            this.id = id;
            this.modelo = modelo;
            this.marca = marca;
            this.ano = ano;
            this.anoFabricacao = anoFabricacao;
            this.anoModelo = anoModelo;
            this.cor = cor;
            this.cambio = cambio;
            this.combustivel = combustivel;
            this.km = km;
            this.placa = placa;
            this.opcionais = opcionais;
            this.opcionaisAbreviacao = opcionaisAbreviacao;
            this.observacoes = observacoes;
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

        public int Km
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
        }

        public string OpcionaisAbreviacao
        {
            get { return this.opcionaisAbreviacao; }           
        }

        public string Observacoes
        {
            get { return this.observacoes; }
        }

        public decimal Preco
        {
            get { return this.preco; }
        }


        public bool VerificarFabricacao()
        {
            return this.anoFabricacao >= 1950 && this.anoFabricacao <= 2099;
        }

        public bool VerificarAno()
        {
            return this.anoFabricacao == this.anoModelo || this.anoFabricacao == this.anoModelo - 1;
        }

        public bool VerificarPreco()
        {
            return this.preco > 0;
        }
    }
}
