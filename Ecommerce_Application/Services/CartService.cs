using Ecommerce_Application.Data;
using Ecommerce_Application.Models;
using Microsoft.Extensions.Logging;

namespace Ecommerce_Application.Services
{
    public class CartService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<CartService> _logger;

        public CartService(AppDbContext context, IHttpContextAccessor contextAccessor, ILogger<CartService> logger)
        {
            _context = context;
            _contextAccessor = contextAccessor;
            _logger = logger;
        }

        public List<CartItem> GetCart()
        {
            try
            {
                var session = _contextAccessor.HttpContext.Session;
                var cart = session.GetObjectFromJson<List<CartItem>>("Cart");
                return cart ?? new List<CartItem>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting cart.");
                return new List<CartItem>();
            }
        }

        public void AddToCart(int productId, int quantity = 1)
        {
            try
            {
                var cart = GetCart();
                var existingItem = cart.FirstOrDefault(c => c.Product.Id == productId);

                if (existingItem != null)
                {
                    existingItem.Quantity += quantity;
                }
                else
                {
                    var product = _context.Products.Find(productId);
                    if (product != null)
                    {
                        cart.Add(new CartItem { Product = product, Quantity = quantity });
                    }
                }

                SaveCart(cart);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding to cart.");
            }
        }

        public void RemoveFromCart(int productId)
        {
            try
            {
                var cart = GetCart();
                var existingItem = cart.FirstOrDefault(c => c.Product.Id == productId);

                if (existingItem != null)
                {
                    cart.Remove(existingItem);
                }

                SaveCart(cart);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error removing from cart.");
            }
        }

        public decimal GetTotalAmount()
        {
            try
            {
                var cart = GetCart();
                var total = cart.Sum(item => item.Product.Price * item.Quantity);
                return total;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error calculating total amount.");
                return 0;
            }
        }

        private void SaveCart(List<CartItem> cart)
        {
            try
            {
                var session = _contextAccessor.HttpContext.Session;
                session.SetObjectAsJson("Cart", cart);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving cart.");
            }
        }
    }
}
