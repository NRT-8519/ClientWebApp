using System.ComponentModel.DataAnnotations;

namespace ClientWebApp.DTOs
{
    public class IssuerDTO
    {
        public Guid UUID { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Must be between 2 and 50 characters!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(36, MinimumLength = 2, ErrorMessage = "Must be between 2 and 36 characters!")]
        public string City { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(36, MinimumLength = 2, ErrorMessage = "Must be between 2 and 36 characters!")]
        public string Area { get; set; }
    }
}
