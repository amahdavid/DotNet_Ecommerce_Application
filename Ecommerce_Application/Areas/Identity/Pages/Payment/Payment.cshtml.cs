using Ecommerce_Application.Configurations;
using Ecommerce_Application.Models;
using Ecommerce_Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Ecommerce_Application.Areas.Identity.Pages.Payment
{
    public class PaymentModel : PageModel
    {
        private readonly PaymentService _paymentService;
        private readonly CartService _cartService;
        private readonly StripeSettings _stripeSettings;
        private readonly IHttpContextAccessor _contextAccessor;

        public string CheckoutSessionId { get; set; }
        public decimal TotalAmount { get; set; }
        public string PublishableKey => _stripeSettings.PublishableKey;
        public List<CartItem> CartItems { get; set; }
        public string ErrorMessage { get; set; } // New property for error messages

        public PaymentModel(PaymentService paymentService, CartService cartService, IOptions<StripeSettings> stripeOptions, IHttpContextAccessor contextAccessor)
        {
            _paymentService = paymentService;
            _cartService = cartService;
            _stripeSettings = stripeOptions.Value;
            _contextAccessor = contextAccessor;
            CartItems = new List<CartItem>();
        }

        public void OnGet(decimal totalAmount)
        {
            TotalAmount = totalAmount;
            var session = _contextAccessor.HttpContext.Session;
            var cartItemsJson = session.GetString("Cart");

            if (!string.IsNullOrEmpty(cartItemsJson))
            {
                CartItems = JsonConvert.DeserializeObject<List<CartItem>>(cartItemsJson);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Cart items not found in session.");
                ErrorMessage = "Your cart items could not be retrieved.";
            }
        }

        public async Task<IActionResult> OnPostCreateCheckout(string productName, decimal amount)
        {
            try
            {
                var session = await _paymentService.CreateCheckoutSessionAsync(User.Identity.Name, productName, amount);
                CheckoutSessionId = session.Id;
                return Page();
            }
            catch (Exception ex)
            {
                ErrorMessage = "An error occurred while creating the checkout session: " + ex.Message;
                return Page();
            }
        }
    }
}
