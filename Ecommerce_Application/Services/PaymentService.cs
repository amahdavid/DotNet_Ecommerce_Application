using Stripe;
using Stripe.Checkout;

namespace Ecommerce_Application.Services
{
    public class PaymentService
    {
        private readonly ILogger<PaymentService> _logger;

        public PaymentService(string stripeSecretKey, ILogger<PaymentService> logger)
        {
            StripeConfiguration.ApiKey = stripeSecretKey;
            _logger = logger;
        }

        public async Task<Session> CreateCheckoutSessionAsync(string customerEmail, string productName, decimal amount)
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

            try
            {
                var session = await service.CreateAsync(options);
                return session;
            }
            catch (StripeException stripeEx)
            {
                _logger.LogError(stripeEx, "Stripe error while creating checkout session for product '{ProductName}': {Message}", productName, stripeEx.Message);
                throw;
            }
            catch (Exception ex) // Catch all other exceptions
            {
                _logger.LogError(ex, "Error while creating checkout session for product '{ProductName}': {Message}", productName, ex.Message);
                throw;
            }
        }
    }
}