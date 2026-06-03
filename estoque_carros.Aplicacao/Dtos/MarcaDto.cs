using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Aplicacao.Dtos
{
    public class MarcaDto
    {
        private int id;
        private string marca;

        public MarcaDto(int id, string marca)
        {
            this.id = id;
            this.marca = marca;
        }


        public int Id
        {
            get { return id; }
        }

        public string Marca
        {
            get { return marca; }
        }
    }
}
