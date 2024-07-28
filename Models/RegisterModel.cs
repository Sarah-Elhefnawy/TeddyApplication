using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeddyApplication.Models
{
    
    public class RegisterModel
    {
        [Key]
        [StringLength(100)]
        public string UserName { get; set; }

        [EmailAddress]
        [StringLength(128)]
        public string Email { get; set; }

        [StringLength(256)]
        public string? Password { get; set; }

        [StringLength(256)]
        [NotMapped]
        [Compare("Password", ErrorMessage = "Password and confirm password did not match.")]
        public string ConfirmPassword { get; set; }
    }
}
