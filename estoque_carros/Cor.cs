using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros
{
    public class Cor
    {
        private int id;
        private string cor;

        
        public Cor(string cor)
        {
            this.cor = cor;
        }

        public Cor(int id)
        {
            this.id = id;
        }

        public Cor(int id, string cor)
        {
            this.id = id;
            this.cor = cor;
        }

        public int Id
        {
            get { return this.id; }
        }

        public string Cor1
        {
            get { return this.cor; }
        }
    }
}
