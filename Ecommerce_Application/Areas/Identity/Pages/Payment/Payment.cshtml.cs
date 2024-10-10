using Ecommerce_Application.Configurations;
using Ecommerce_Application.Models;
using Ecommerce_Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Order = Ecommerce_Application.Models.Order;
using OrderService = Ecommerce_Application.Services.OrderService;

namespace Ecommerce_Application.Areas.Identity.Pages.Payment
{
    public class PaymentModel : PageModel
    {
        private readonly PaymentService _paymentService;
        private readonly CartService _cartService;
        private readonly StripeSettings _stripeSettings;
        private readonly OrderService _orderService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<PaymentModel> _logger;

        public string CheckoutSessionId { get; set; }
        public decimal TotalAmount { get; set; }
        public string PublishableKey => _stripeSettings.PublishableKey;
        public List<CartItem> CartItems { get; set; }
        public string ErrorMessage { get; set; }

        [BindProperty]
        public Order Order { get; set; } = new Order();

        public PaymentModel(PaymentService paymentService, CartService cartService,
            OrderService orderService, IOptions<StripeSettings> stripeOptions, IHttpContextAccessor contextAccessor,
            ILogger<PaymentModel> logger)
        {
            _paymentService = paymentService;
            _cartService = cartService;
            _stripeSettings = stripeOptions.Value;
            _contextAccessor = contextAccessor;
            _orderService = orderService;
            _logger = logger;
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
                _logger.LogWarning("Cart items not found in session.");
                ErrorMessage = "Your cart items could not be retrieved.";
            }
        }

        public async Task<IActionResult> OnPostCreateCheckout(string productName, decimal amount, bool isGuest)
        {
            try
            {
                Guid customerId = isGuest ? Guid.NewGuid() : Guid.Empty; // Temporary ID for guests

                if (!isGuest)
                {
                    if (!string.IsNullOrEmpty(User.Identity.Name) && Guid.TryParse(User.Identity.Name, out var parsedId))
                    {
                        customerId = parsedId;
                    }
                }

                var cartItems = _cartService.GetCart();
                amount = _cartService.GetTotalAmount();
                var order = new Order
                {
                    Name = Order.Name,
                    Email = Order.Email,
                    Phone = Order.Phone,
                    City = Order.City,
                    Region = Order.Region,
                    PostalCode = Order.PostalCode,
                    CustomerId = customerId,
                    TotalAmount = amount,
                    OrderDate = DateTime.UtcNow
                };

                var savedOrder = await _orderService.CreateOrderAsync(order);

                var session = await _paymentService.CreateCheckoutSessionAsync(order.Email, productName, amount);
                CheckoutSessionId = session.Id;
                _cartService.ClearCart();
                return Page();
            }
            catch (DbUpdateException dbEx)
            {
                _logger.LogError(dbEx, "An error occurred while saving the order.");
                ErrorMessage = "An error occurred while saving the order: " + dbEx.InnerException?.Message ?? dbEx.Message;
                return Page();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating the checkout session.");
                ErrorMessage = "An error occurred while creating the checkout session: " + ex.Message;
                return Page();
            }
        }
    }
}