using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros
{
    public class MarcaModelo
    {
        private int id;
        private string marca;


        public MarcaModelo(string marca)
        {            
            this.marca = marca;
        }

        public MarcaModelo(int id, string marca)
        {
            this.id = id;
            this.marca = marca;
        }

        public int Id
        {
            get { return this.id; }
        }

        public string Marca1
        {
            get { return this.marca; }
        }
    }
}
