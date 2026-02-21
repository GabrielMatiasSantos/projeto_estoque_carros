using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros
{
    public class Marca
    {
        private int id;
        private string marca;


        public Marca(string marca)
        {            
            this.marca = marca;
        }

        public Marca(int id)
        {
            this.id = id;          
        }

        public Marca(int id, string marca)
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
