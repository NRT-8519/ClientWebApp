using System.ComponentModel.DataAnnotations;

namespace ClientWebApp.DTOs
{
    public class TimeStaticDTO
    {
        [RegularExpression(@"[0-5]{1}[0-9]{1}", ErrorMessage = "Hours must contain 2 digits!")]
        public string timeHours { get; set; } = "10";

        [RegularExpression(@"[0-2]{1}[0-3]{1}", ErrorMessage = "Minutes must contain 2 digits!")]
        public string timeMinutes { get; set; } = "00";
    }
}
