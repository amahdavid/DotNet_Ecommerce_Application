using Microsoft.AspNetCore.Identity;

namespace Ecommerce_Application.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public DateTime RegisteredDate { get; set; } = DateTime.UtcNow;
    }
}