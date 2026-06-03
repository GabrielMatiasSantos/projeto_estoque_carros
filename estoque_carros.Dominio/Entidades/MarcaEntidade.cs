namespace estoque_carros.Entidades
{
    public class MarcaEntidade
    {
        private int id;
        private string marca;


        public MarcaEntidade(string marca)
        {            
            this.marca = marca;
        }

        public MarcaEntidade(int id, string marca)
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
