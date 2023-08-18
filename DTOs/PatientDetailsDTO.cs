﻿namespace ClientWebApp.DTOs
{
    public class PatientDetailsDTO
    {
        public Guid UUID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public List<EmailDTO> Emails { get; set; } = new();
        public List<PhoneNumberDTO> PhoneNumbers { get; set; } = new();
        public DateOnly DateOfBirth { get; set; }
        public char Gender { get; set; }
        public string SSN { get; set; }
        public DateTime PasswordExpiryDate { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsExpired { get; set; }
        public DoctorBasicDTO AssignedDoctor { get; set; }
    }
}