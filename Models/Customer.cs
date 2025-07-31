using System.ComponentModel.DataAnnotations;

namespace HelloWorldRazor.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string FirstName { get; set; }
        public string? MiddleName { get; set; }
        [Required]
        public required string LastName { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        [Phone]
        public required string MobileNum { get; set; }

        // Address details
        [Required]
        public required string Address { get; set; }
        [Required]
        public required string Suburb { get; set; }
        [Required]
        [EnumDataType(typeof(States))]
        public States State { get; set; }
        [Required]
        public required string Postcode { get; set; }
        [Required]
        public required string Country { get; set; }

        // Date of Birth and License details
        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Required]
        public required string License { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public required DateTime LicenseExp { get; set; }

        // Navigation property
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    }
}


