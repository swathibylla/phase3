using ecommerceshoppingA;
using ecommerceshoppingApp.Data;
using ecommerceshoppingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ecommerceshoppingApp.Controllers
{
    public class CartController : Controller
    {
        private readonly CartService _cartService;
        private readonly ProductContext _context;

        public CartController(CartService cartService, ProductContext context)
        {
            _cartService = cartService;
            _context = context;
        }
        public IActionResult Index()
        {
            var cart = _cartService.GetCart();
            return View(cart);
        }
        public async Task<IActionResult> Buy(string id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product != null)
            {
                //_cartService.AddItem(product, 1);
            }
            return RedirectToAction("Index", "Cart");
        }
        public async Task<IActionResult> Add(string productId, int quantity)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product != null)
            {
                //_cartService.AddItem(product, quantity);
                return Ok();
            }
            return BadRequest();
        }
        [HttpPost]
        public IActionResult AddToCart([FromBody] AddToCartViewModel model)
        {
            if (ModelState.IsValid)
            {
                var cart = _cartService.GetCart();

                var existingItem = cart.Items.FirstOrDefault(item => item.Product.Id == model.ProductId);

                if (existingItem != null)
                {
                    existingItem.Quantity = model.Quantity;
                    _cartService.UpdateCart(cart);

                    return Json(new { updated = true });
                }

                //public IActionResult AddToCart([FromBody] AddToCartViewModel model)

                //_cartService.AddToCart(model.ProductId, model.Quantity);
                _cartService.UpdateCart(cart);

                return Json(new { updated = false });
            }
            return BadRequest();
        }
   

        public IActionResult Remove(string  productid)
        {
            _cartService.RemoveItem(productid);
            return RedirectToAction("Index", "Cart");
        }



        public IActionResult Clear()
        {
            _cartService.ClearCart();
            return RedirectToAction("Index", "Cart");
        }
    }
}
