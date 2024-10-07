using Ecommerce_Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ecommerce_Application.Areas.Identity.Pages.Payment
{
    public class PaymentModel : PageModel
    {
        private readonly PaymentService _paymentService;
        private readonly IConfiguration _configuration;

        public PaymentModel(PaymentService paymentService, IConfiguration configuration)
        {
            _paymentService = paymentService;
            _configuration = configuration;
        }

        public string CheckoutSessionId { get; set; }
        public string PublishableKey => _configuration["Stripe:PublishableKey"];

        public async Task<IActionResult> OnPostCreateCheckout(string productName, long amount)
        {
            var session = await _paymentService.CreateCheckoutSessionAsync(User.Identity.Name, productName, amount);
            CheckoutSessionId = session.Id;
            return Page();
        }
    }
}
