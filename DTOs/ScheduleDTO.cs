using System.ComponentModel.DataAnnotations;

namespace ClientWebApp.DTOs
{
    public class ScheduleDTO
    {
        public uint? Id { get; set; }

        [Required(ErrorMessage = "Doctor is required!")]
        public Guid DoctorUUID { get; set; }

        [Required(ErrorMessage = "Patient is required!")]
        public Guid PatientUUID { get; set; }

        [Required(ErrorMessage = "Date is required!")]
        [DataType(DataType.DateTime)]
        public DateTime ScheduledDateTime { get; set; }

        [Required(ErrorMessage = "Event name is required!")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Event name must be between 2 and 30 characters")]
        public string Event { get; set; }
    }
}
