using Ecommerce_Application.Data;
using Ecommerce_Application.Models;
using Ecommerce_Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Application.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppDbContext _context;
        private readonly CartService _cartService;

        public IndexModel(ILogger<IndexModel> logger, AppDbContext context, CartService cartService)
        {
            _logger = logger;
            _context = context;
            _cartService = cartService;
        }

        public List<Product> Products { get; set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }

        public IActionResult OnPostAddToCart(Guid productId)
        {
            _cartService.AddToCart(productId);
            return RedirectToPage();
        }
    }
}