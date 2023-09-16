using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ClientWebApp.DTOs
{
    public class UserDetailsDTO
    {
        public Guid UUID { get; set; }

        [Required(ErrorMessage = "First name is required!")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Must be between 2 and 3 characters!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Middle name is required!")]
        [StringLength(30, ErrorMessage = "Must be between 2 and 3 characters!")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last name is required!")]
        [StringLength(30, ErrorMessage = "Must be between 2 and 3 characters!")]
        public string LastName { get; set; }

        [StringLength(30, MinimumLength = 2, ErrorMessage = "Maximum length for a title is 30 characters!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Username is required!")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Username length is between 6 and 30 characters!")]
        public string Username { get; set; }

        [AllowNull]
        [StringLength(45, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 45 characters!")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Email address is required!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email address")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Password must be between 4 and 50 characters!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required!")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"\+[1-9][0-9]{1,2}[0-9]{8,9}$", ErrorMessage = "Invalid phone number format")]
        [StringLength(13)]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }

        [NotNull]
        [Required(ErrorMessage = "Select a gender!")]
        [RegularExpression(@"(M|F){1}", ErrorMessage = "Select a gender!")]
        public char Gender { get; set; }

        [Required(ErrorMessage = "Social Security Number is required!")]
        [RegularExpression(@"[0-9]{13}", ErrorMessage = "SSN Contains 13 digits!")]
        public string SSN { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime PasswordExpiryDate { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsExpired { get; set; }
    }
}
