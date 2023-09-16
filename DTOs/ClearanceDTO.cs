using System.ComponentModel.DataAnnotations;

namespace ClientWebApp.DTOs
{
    public class ClearanceDTO
    {
        public Guid? UUID { get; set; }

        [Required(ErrorMessage = "Clarance Number is required!")]
        [RegularExpression(@"515-01-0[0-9]{4}-[0-9]{2}-[0-9]{3}", ErrorMessage = "Clearance Number starts with 515-01-0\nIt is in the following format: 515-01-01234-56-789")]
        public string ClearanceNumber { get; set; }

        [Required(ErrorMessage = "Required")]
        public DateOnly BeginDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public DateOnly ExpiryDate { get; set;}
    }
}
