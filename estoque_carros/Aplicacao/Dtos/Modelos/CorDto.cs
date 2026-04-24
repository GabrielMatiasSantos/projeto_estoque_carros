using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Aplicacao.Dtos
{
    public class CorDto
    {
        private int id;
        private string cor;

        public CorDto(int id, string cor)
        {
            this.id = id;
            this.cor = cor;
        }

        public int Id 
        { 
            get { return id; } 
        }
        public string Cor 
        { 
            get { return cor; } 
        }
    }
}
