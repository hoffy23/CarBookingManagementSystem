using System.ComponentModel.DataAnnotations;

namespace CarBookingManagementSystem.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Make { get; set; }
        [Required]
        public required string Model { get; set; }
        [Required]
        public int OdometerKm { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        [EnumDataType(typeof(States))]
        public States State { get; set; }
        [Required]
        public string? NumberPlate { get; set; }

        // Navigation property
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}