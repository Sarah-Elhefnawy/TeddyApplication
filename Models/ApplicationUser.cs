using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TeddyApplication.Models
{
    public class ApplicationUser : IdentityUser
    {
        //[MaxLength(50)]
        //public string UserName { get; set; }
        //public string Password { get; set; }

        public List<RefreshToken>? RefreshTokens { get; set; }
    }
}
