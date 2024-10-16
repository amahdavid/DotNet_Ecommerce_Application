using Ecommerce_Application.Data;
using Ecommerce_Application.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Application.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppDbContext _context;

        public IndexModel(ILogger<IndexModel> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;

        }

        public List<Product> Products { get; set; }


        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}