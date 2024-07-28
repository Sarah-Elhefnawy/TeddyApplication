using System.ComponentModel.DataAnnotations;

namespace TeddyApplication.Models
{
    public class TokenRequestModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
