using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string GLN { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string PharmacyName { get; set; } = string.Empty;

        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? PostalCode { get; set; }
        public string? ServicePackage { get; set; }
        public string? Role { get; set; } = "User";
        public string? ProfileImagePath { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
