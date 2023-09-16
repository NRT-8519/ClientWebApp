using System.ComponentModel.DataAnnotations;

namespace ClientWebApp.DTOs
{
    public class ReportDTO
    {
        public Guid UUID { get; set; }
        public Guid ReportedBy { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Must be between 2 and 50 characters!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Must be between 2 and 100 characters!")]
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
