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
        private readonly CartService _cartService;
        private readonly ILogger<ProductListingModel> _logger;

        public ProductListingModel(AppDbContext context, CartService cartService, ILogger<ProductListingModel> logger)
        {
            _context = context;
            _cartService = cartService;
            _logger = logger;
        }

        public IEnumerable<Product> Products { get; set; }
        public string ErrorMessage { get; set; }

        public async Task OnGetAsync(string searchTerm, string category, string priceRange)
        {
            try
            {
                var productsQuery = _context.Products.AsQueryable();

                // Search by name or description
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    searchTerm = searchTerm.Trim().ToLower();
                    productsQuery = productsQuery.Where(p => p.Name.ToLower().Contains(searchTerm) || p.Description.ToLower().Contains(searchTerm));
                }

                // Filter by category
                if (!string.IsNullOrEmpty(category))
                {
                    productsQuery = productsQuery.Where(p => p.Category == category);
                }

                // Filter by price range
                if (!string.IsNullOrEmpty(priceRange))
                {
                    var priceRangeValues = priceRange.Split('-').Select(decimal.Parse).ToArray();
                    var minPrice = priceRangeValues[0];
                    var maxPrice = priceRangeValues[1];

                    productsQuery = productsQuery.Where(p => p.Price >= minPrice && p.Price <= maxPrice);
                }

                Products = await productsQuery.ToListAsync() ?? new List<Product>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving products.");
                ErrorMessage = "An error occurred while retrieving products.";
                Products = new List<Product>();
            }
        }

        public IActionResult OnPostAddToCart(int productId)
        {
            try
            {
                _cartService.AddToCart(productId);
                return RedirectToPage();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while adding the product to the cart.");
                ErrorMessage = "An error occurred while adding the product to the cart.";
                return Page();
            }
        }
    }
}