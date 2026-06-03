namespace estoque_carros.Entidades
{
    public class CorEntidade
    {
        private int id;
        private string cor;

        
        public CorEntidade(string cor)
        {
            this.cor = cor;
        }

        public CorEntidade(int id, string cor)
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
