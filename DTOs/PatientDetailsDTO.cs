namespace ClientWebApp.DTOs
{
    public class PatientDetailsDTO : UserDetailsDTO
    {
        public UserBasicDTO AssignedDoctor { get; set; }
    }
}
