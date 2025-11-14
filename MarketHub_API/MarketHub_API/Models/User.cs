using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MarketHub_API.Models
{
    public class User
    {
        public int Id { get; set;}

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? PasswordHash { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        public string? Phone { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


    }
}
