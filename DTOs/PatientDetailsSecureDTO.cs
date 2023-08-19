namespace ClientWebApp.DTOs
{
    public class PatientDetailsSecureDTO : PatientDetailsDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
