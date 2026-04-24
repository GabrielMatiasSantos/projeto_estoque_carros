using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros
{
    public class CorModelo
    {
        private int id;
        private string cor;

        
        public CorModelo(string cor)
        {
            this.cor = cor;
        }

        public CorModelo(int id, string cor)
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
