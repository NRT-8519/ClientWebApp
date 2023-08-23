using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ClientWebApp.DTOs
{
    public class DoctorDetailsDTO : UserDetailsDTO
    {
        [Required(ErrorMessage = "Area of expertise is required!")]
        [StringLength(100)]
        public string AreaOfExpertise { get; set; }

        [Required]
        [Range(100, 999, ErrorMessage = "Room number must be between 100 and 999")]
        public int RoomNumber { get; set; }
        public List<UserBasicDTO> Patients { get; set; } = new();
    }
}
