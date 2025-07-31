using System.ComponentModel.DataAnnotations;

namespace HelloWorldRazor.Models
{
    public enum States
    {
        QLD, NSW, VIC, ACT, SA, NT, WA, TAS,
    }
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Address { get; set; }
        [Required]
        public required string Email { get; set; }

        [EnumDataType(typeof(States))]
        public States State { get; set; }

        // Navigation property
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}