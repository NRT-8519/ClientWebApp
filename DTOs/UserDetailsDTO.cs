using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ClientWebApp.DTOs
{
    public class UserDetailsDTO
    {
        public Guid UUID { get; set; }

        [Required(ErrorMessage = "First name is required!")]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Middle name is required!")]
        [StringLength(30)]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last name is required!")]
        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Username is required!")]
        [StringLength(30)]
        public string Username { get; set; }

        [AllowNull]
        [StringLength(45)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Email address is required!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email address")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required!")]
        [DataType(DataType.PhoneNumber)]
        [Phone(ErrorMessage = "Invalid phone number format")]
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
        [StringLength(13, ErrorMessage = "Social Security Number must contain 13 numbers")]
        public string SSN { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime PasswordExpiryDate { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsExpired { get; set; }
    }
}
