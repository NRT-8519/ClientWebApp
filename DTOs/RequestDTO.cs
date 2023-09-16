using System.ComponentModel.DataAnnotations;

namespace ClientWebApp.DTOs
{
    public class RequestDTO
    {
        public Guid UUID { get; set; }
        public string Patient { get; set; }
        public string Doctor { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Must be between 2 and 50 characters!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Must be between 2 and 100 characters!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Type { get; set; }

        public string Status { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Must be between 2 and 100 characters!")]
        public string Reason { get; set; }
    }
}
