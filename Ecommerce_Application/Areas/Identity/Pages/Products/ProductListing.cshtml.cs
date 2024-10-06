using Ecommerce_Application.Data;
using Ecommerce_Application.Models;
using Ecommerce_Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Application.Areas.Identity.Pages.Products
{
    public class ProductListingModel : PageModel
    {
        private readonly AppDbContext _context;
        private  readonly CartService _cartService;

        public ProductListingModel(AppDbContext context, CartService cartService)
        {
            _context = context;
            _cartService = cartService;
        }

        public IEnumerable<Product> Products { get; set; }

        public async Task OnGetAsync(string searchTerm, string category, string priceRange)
        {
            var productsQuery = _context.Products.AsQueryable();

            // search by name or description
            if (!string.IsNullOrEmpty(searchTerm))
            {
                searchTerm = searchTerm.Trim().ToLower();
                productsQuery = productsQuery.Where(p => p.Name.ToLower().Contains(searchTerm) || p.Description.ToLower().Contains(searchTerm));
            }

            // filter by category
            if (!string.IsNullOrEmpty(category))
            {
                productsQuery = productsQuery.Where(p => p.Category == category);
            }

            if (!string.IsNullOrEmpty(priceRange))
            {
                var priceRangeValues = priceRange.Split('-').Select(decimal.Parse).ToArray();
                var minPrice = priceRangeValues[0];
                var maxPrice = priceRangeValues[1];

                productsQuery = productsQuery.Where(p => p.Price >= minPrice && p.Price <= maxPrice);
            }

            // execute the query and return results
            Products = await productsQuery.ToListAsync() ?? new List<Product>();
        }

        public IActionResult OnPostAddToCart(int productId)
        {
            _cartService.AddToCart(productId);
            return RedirectToPage();
        }
    }
}
