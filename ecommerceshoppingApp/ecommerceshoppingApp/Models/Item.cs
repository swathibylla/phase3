namespace ecommerceshoppingApp.Models
{
    public class Item
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public double cost
        {
            get { return (Product.Price) * Quantity; }
        }
    }
}
