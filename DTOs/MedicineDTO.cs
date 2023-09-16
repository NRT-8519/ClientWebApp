using System.ComponentModel.DataAnnotations;

namespace ClientWebApp.DTOs
{
    public class MedicineDTO
    {
        public Guid UUID { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Must be between 2 and 100 characters!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Must be between 2 and 100 characters!")]
        public string Dosage { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Must be between 2 and 100 characters!")]
        public string DosageType { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"^[0-9]{13}$", ErrorMessage = "Invalid EAN.\nEAN is 13 digits long")]
        public string EAN { get; set; }

        [RegularExpression(@"(^[ABCDGHJLMNPRSV][0-1][0-9][A-Z]{2}[0-9]{2})?", ErrorMessage = "Invalid EAN.\nEAN is 13 digits long")]
        public string ATC { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(7, ErrorMessage = "Must be 7 characters long!")]
        public string UniqueClassification { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Must be between 2 and 1000 characters!")]
        public string INN { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Prescription type is required!")]
        public string PrescriptionType { get; set; }
        public CompanyDTO Company { get; set; }
        public IssuerDTO Issuer { get; set; }
        public ClearanceDTO Clearance { get; set; }
    }
}
