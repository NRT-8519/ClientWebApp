namespace ClientWebApp.DTOs
{
    public class ReportDTO
    {
        public Guid ReportedBy { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
