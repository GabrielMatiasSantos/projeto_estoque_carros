using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Aplicacao.Dtos.Formularios
{
    public class Formulario1Dto
    {
        private int largura;

        private string cabecalho;

        private string rotulo;

        private bool marca1;

        private bool marca2;

        private bool portas1;

        private bool portas2;

        private bool motor1;

        private bool motor2;

        private int alterar;

        private int excluir;


        public Formulario1Dto(int largura, string cabecalho, string rotulo, bool marca1, bool marca2, bool portas1, bool portas2, bool motor1, bool motor2, int alterar, int excluir)
        {
            this.largura = largura;
            this.cabecalho = cabecalho;
            this.rotulo = rotulo;
            this.marca1 = marca1;
            this.marca2 = marca2;
            this.portas1 = portas1;
            this.portas2 = portas2;
            this.motor1 = motor1;
            this.motor2 = motor2;
            this.alterar = alterar;
            this.excluir = excluir;
        }

        public int Largura
        {
            get { return this.largura; }
        }

        public string Cabecalho
        {
            get { return this.cabecalho; }
        }

        public string Rotulo
        {
            get { return this.rotulo; }
        }

        public bool Marca1
        {
            get { return this.marca1; }
        }

        public bool Marca2
        {
            get { return this.marca2; }
        }

        public bool Portas1
        {
            get { return this.portas1; }
        }

        public bool Portas2
        {
            get { return this.portas2; }
        }

        public bool Motor1
        {
            get { return this.motor1; }
        }

        public bool Motor2
        {
            get { return this.motor2; }
        }

        public int Alterar
        {
            get { return this.alterar; }
        }

        public int Excluir
        {
            get { return this.excluir; }
        }
    }
}
