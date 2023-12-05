namespace ecommerceshoppingApp.Models
{
    public class Cart
    {
        public string Id { get; set; }

       public List<Item> Items { get; set; }
        public double TotalCost => Items.Sum(item => item.cost);

        

        public Cart()
        {
            Items = new List<Item>();
        }
    }
}
