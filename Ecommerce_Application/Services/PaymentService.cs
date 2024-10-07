using Stripe;
using Stripe.Checkout;

namespace Ecommerce_Application.Services
{
    public class PaymentService
    {
        public async Task<Session> CreateCheckoutSessionAsync(string custormerEmail, string productName, long amount)
        {
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            UnitAmount = amount,
                            Currency = "cad",
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = productName,
                            },
                        },
                        Quantity = 1,
                    }
                },
                Mode = "payment",
                SuccessUrl = "https://localhost:7059/payment/success", // Change to your success URL
                CancelUrl = "https://localhost:7059/payment/cancel", // Change to your cancel URL
            };
            var service = new SessionService();
            var session = await service.CreateAsync(options);
            return session;
        }
    }
}
