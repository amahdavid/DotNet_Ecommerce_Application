using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ecommerce_Application.Services;
using Ecommerce_Application.Models;

namespace Ecommerce_Application.Areas.Identity.Pages.Cart
{
    public class CartModel : PageModel
    {
        private readonly CartService _cartService;
        public List<CartItem> CartItems { get; set; }
        public CartModel(CartService cartService)
        {
            _cartService = cartService;
        }
        public void OnGet()
        {
            CartItems = _cartService.GetCart();
        }

        public IActionResult OnPostRemove(int productId)
        {
            _cartService.RemoveFromCart(productId);
            return RedirectToPage();
        }
    }
}
