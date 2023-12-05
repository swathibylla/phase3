using ecommerceshoppingApp.Models;
namespace ecommerceshoppingApp
{
    public interface ICartService
    {
        void AddItem(Product product, int quantity);

        void RemoveItem(string productId);
        void ClearCart();
        Cart GetCart();
    }
}
