using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Dtos
{
    public class ModeloDto
    {
        private int id;

        private string marca;

        private string modelo;


        public ModeloDto(int id, string marca, string modelo)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
        }

        public ModeloDto(int id, string modelo)
        {
            this.id = id;
            this.modelo = modelo;
        }


        public int Id
        {
            get { return id; }
        }

        public string Marca
        {
            get { return marca; }
        }

        public string Modelo
        {
            get { return modelo; }
        }
    }
}
