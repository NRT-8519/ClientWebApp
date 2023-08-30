using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ClientWebApp.Auth
{
    public class UserAuth
    {
        [Required(ErrorMessage = "Please type in a username")]
        [StringLength(30)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please type in a password")]
        [StringLength(45)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
