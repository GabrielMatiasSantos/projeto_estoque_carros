namespace estoque_carros.Apresentacao.Dtos
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
