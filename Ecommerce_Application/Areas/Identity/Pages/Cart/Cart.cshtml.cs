using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ecommerce_Application.Services;
using Ecommerce_Application.Models;
using Microsoft.Extensions.Logging;

namespace Ecommerce_Application.Areas.Identity.Pages.Cart
{
    public class CartModel : PageModel
    {
        private readonly CartService _cartService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<CartModel> _logger;

        public List<CartItem> CartItems { get; set; }
        public string ErrorMessage { get; set; }

        public CartModel(CartService cartService, IHttpContextAccessor contextAccessor, ILogger<CartModel> logger)
        {
            _cartService = cartService;
            _contextAccessor = contextAccessor;
            _logger = logger;
        }

        public void OnGet()
        {
            try
            {
                CartItems = _cartService.GetCart();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving the cart.");
                ErrorMessage = "There was an issue loading your cart. Please try again later.";
            }
        }

        public IActionResult OnPostRemove(Guid productId)
        {
            try
            {
                _cartService.RemoveFromCart(productId);
                return RedirectToPage();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while removing product with ID {productId} from the cart.");
                ErrorMessage = "There was an issue removing the item from your cart. Please try again.";
                return RedirectToPage();
            }
        }

        public IActionResult OnPostCheckout()
        {
            try
            {
                var amount = _cartService.GetTotalAmount();
                var cartItems = _cartService.GetCart();

                if (amount <= 0)
                {
                    ErrorMessage = "Your cart is empty or there was an issue with the total amount.";
                    return RedirectToPage();
                }

                var session = _contextAccessor.HttpContext.Session;
                session.SetObjectAsJson("Cart", cartItems);
                return RedirectToPage("/Payment/Payment", new { totalAmount = amount });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred during the checkout process.");
                ErrorMessage = "There was an issue with the checkout process. Please try again.";
                return RedirectToPage();
            }
        }
    }
}