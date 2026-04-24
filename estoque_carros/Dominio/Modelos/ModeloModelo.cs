using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros
{
    public class ModeloModelo
    {
        private int id;
        private int marca;
        private string modelo;


        public ModeloModelo(int marca, string modelo)
        {            
            this.marca = marca;
            this.modelo = modelo;
        }

        public ModeloModelo(int id, int marca,string modelo)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
        }


        public int Id
        {
            get { return id; }
        }

        public int Marca
        {
            get { return marca; }
        }

        public string Modelo1
        { 
            get { return modelo; }
        }
    }
}
