namespace IniciacaoLista.Entities
{
    internal class Item
    {
        public int Value { get; set; }
        public Item Next { get; set; }

        public Item(int x)
        {
            //toda vez que um objeto é criado seu próxim é null
            Value = x;
            Next = null;
        }
    }
}
