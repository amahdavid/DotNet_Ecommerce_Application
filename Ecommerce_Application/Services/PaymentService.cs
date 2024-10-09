using Stripe;
using Stripe.Checkout;

namespace Ecommerce_Application.Services
{
    public class PaymentService
    {
        public PaymentService(string stripeSecretKey) 
        {
            StripeConfiguration.ApiKey = stripeSecretKey;
        }
        public async Task<Session> CreateCheckoutSessionAsync(string custormerEmail, string productName, decimal amount)
        {
            var amountInCents = (long)(amount * 100);
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            UnitAmount = amountInCents,
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
                SuccessUrl = "http://localhost:5212/Identity/Payment/PaymentSuccess",
                CancelUrl = "http://localhost:5212/Identity/Payment/PaymentCancel",
            };
            var service = new SessionService();
            var session = await service.CreateAsync(options);
            return session;
        }
    }
}
