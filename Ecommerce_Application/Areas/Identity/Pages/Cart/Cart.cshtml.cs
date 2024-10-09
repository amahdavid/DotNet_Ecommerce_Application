using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ecommerce_Application.Services;
using Ecommerce_Application.Models;

namespace Ecommerce_Application.Areas.Identity.Pages.Cart
{
    public class CartModel : PageModel
    {
        private readonly CartService _cartService;
        private readonly IHttpContextAccessor _contextAccessor;
        public List<CartItem> CartItems { get; set; }
        public CartModel(CartService cartService, IHttpContextAccessor contextAccessor)
        {
            _cartService = cartService;
            _contextAccessor = contextAccessor;
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

        public IActionResult OnPostCheckout()
        {
            var amount = _cartService.GetTotalAmount();
            var cartItems = _cartService.GetCart();
            var session = _contextAccessor.HttpContext.Session;
            session.SetObjectAsJson("Cart", cartItems); 
            return RedirectToPage("/Payment/Payment", new { totalAmount = amount });
        }
    }
}
