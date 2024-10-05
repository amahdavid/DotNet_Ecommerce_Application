using Ecommerce_Application.Data;
using Ecommerce_Application.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Application.Areas.Identity.Pages.Products
{
    public class ProductListingModel : PageModel
    {
        private readonly AppDbContext _context;

        public ProductListingModel(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> Products { get; set; } // Use IEnumerable instead of List

        public async Task OnGetAsync(string searchTerm, string category, string priceRange)
        {
            var productsQuery = _context.Products.AsQueryable();

            // search by name or description
            if (!string.IsNullOrEmpty(searchTerm))
            {
                productsQuery = productsQuery.Where(p => p.Name.Contains(searchTerm) || p.Description.Contains(searchTerm));
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
    }
}
