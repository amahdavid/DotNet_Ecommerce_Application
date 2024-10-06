using Ecommerce_Application.Data;
using Ecommerce_Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Application.Services
{
    public class CartService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ISession _session;

        public CartService(AppDbContext context, IHttpContextAccessor contextAccessor, ISession session)
        {
            _context = context;
            _contextAccessor = contextAccessor;
            _session = session;
        }

        public List<CartItem> GetCart()
        {
            var cart = _session.GetObjectFromJson<List<CartItem>>("Cart");
            return cart ?? new List<CartItem>();
        }

        public void AddToCart(int productId, int quantity = 1)
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

        public void RemoveFromCart(int productId)
        {
            var cart = GetCart();
            var existingItem = cart.FirstOrDefault(c => c.Product.Id == productId);
            if (existingItem != null)
            {
                cart.Remove(existingItem);
            }
            SaveCart(cart);
        }

        private void SaveCart(List<CartItem> cart)
        {
            _session.SetObjectAsJson("Cart", cart);
        }
    }
}
