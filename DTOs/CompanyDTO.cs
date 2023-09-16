using System.ComponentModel.DataAnnotations;

namespace ClientWebApp.DTOs
{
    public class CompanyDTO
    {
        public Guid UUID { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Must be between 2 and 100 characters!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(36, MinimumLength = 2, ErrorMessage = "Must be between 2 and 36 characters!")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Must be between 2 and 100 characters!")]
        public string City { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Must be between 2 and 100 characters!")]
        public string Address { get; set; }
    }
}
