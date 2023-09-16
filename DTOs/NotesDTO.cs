using System.ComponentModel.DataAnnotations;

namespace ClientWebApp.DTOs
{
    public class NotesDTO
    {
        public uint Id { get; set; }

        [Required(ErrorMessage = "Required")]
        public Guid DoctorUUID { get; set; }

        [Required(ErrorMessage = "Required")]
        public Guid PatientUUID { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Must be between 2 and 30 characters!")]
        public string NoteTitle { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Note { get; set; }

        [Required(ErrorMessage = "Required")]
        public DateTime NoteDate { get; set; }
    }
}
