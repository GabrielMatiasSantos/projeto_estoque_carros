using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Aplicacao.Dtos
{
    public class MenuValoresDto
    {
        int id;
        string item;


        public MenuValoresDto(int id, string item)
        {
            this.id = id;
            this.item = item;
        }

        public int Id
        {
            get { return id; }
        }

        public string Item
        {
            get { return item; }
        }
    }
}
