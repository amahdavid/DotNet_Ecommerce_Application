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
        private readonly StripeSettings _stripeSettings;
        private readonly IHttpContextAccessor _contextAccessor;
        public string CheckoutSessionId { get; set; }
        public long TotalAmount { get; set; }
        public string PublishableKey => _stripeSettings.PublishableKey;
        public List<CartItem> CartItems { get; set; } // New property for cart items

        public PaymentModel(PaymentService paymentService, IOptions<StripeSettings> stripeOptions, IHttpContextAccessor contextAccessor)
        {
            _paymentService = paymentService;
            _stripeSettings = stripeOptions.Value;
            _contextAccessor = contextAccessor; // Initialize _contextAccessor
            CartItems = new List<CartItem>(); // Initialize cart items
        }

        public void OnGet(long totalAmount)
        {
            TotalAmount = totalAmount;
            System.Diagnostics.Debug.WriteLine("Total amount: " + TotalAmount);

            // Attempt to get cart items from session
            var session = _contextAccessor.HttpContext.Session;
            var cartItemsJson = session.GetString("Cart"); // Retrieve from session

            if (!string.IsNullOrEmpty(cartItemsJson))
            {
                CartItems = JsonConvert.DeserializeObject<List<CartItem>>(cartItemsJson); // Deserialize the cart items
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Cart items not found in session.");
            }
        }

        public IActionResult OnPostCreateCheckout(string productName, long amount)
        {
            var session = _paymentService.CreateCheckoutSessionAsync(User.Identity.Name, productName, amount).Result; // Handle async properly in production
            CheckoutSessionId = session.Id;
            return Page();
        }
    }
}
