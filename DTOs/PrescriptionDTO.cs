using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ClientWebApp.DTOs
{
    public class PrescriptionDTO
    {
        public uint Id { get; set; }

        [Required(ErrorMessage = "Doctor field is required!")]
        public string Doctor { get; set; }

        [Required(ErrorMessage = "Patient field is required!")]
        public string Patient { get; set; }

        [Required(ErrorMessage = "Medicine field is required!")]
        public string Medicine { get; set; }

        [AllowNull]
        [DataType(DataType.Date)]
        public DateOnly? Prescribed { get; set; }

        [AllowNull]
        [DataType(DataType.Date)]
        public DateOnly? Administered { get; set; }

        [StringLength(100, ErrorMessage = "Exceeded maximum note length!")]
        public string Notes { get; set; }
    }
}
