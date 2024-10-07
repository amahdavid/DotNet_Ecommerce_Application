using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ecommerce_Application.Services;
using Ecommerce_Application.Models;
using Newtonsoft.Json;

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
            var totalAmount = _cartService.GetTotalAmount(); // Get the total amount from the cart
            var cartItems = _cartService.GetCart(); // Get the cart items
            System.Diagnostics.Debug.WriteLine($"Total Amount Checkout: {totalAmount}"); // Log the total amount

            // Store in session as a backup
            var session = _contextAccessor.HttpContext.Session;
            session.SetObjectAsJson("Cart", cartItems); // Store the serialized cart items in session

            // Redirect to payment page with total amount
            return RedirectToPage("/Payment/Payment", new { totalAmount = (long)totalAmount });
        }
    }
}
