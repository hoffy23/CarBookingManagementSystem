using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelloWorldRazor.Models
{
    public enum BookingStatus
    {
        Pending, Confirmed, InProgress, Completed, Cancelled,
    }
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        // Foreign keys with navigation properties
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; } = null!;

        public int AssetId { get; set; }
        [ForeignKey("AssetId")]
        public Asset Asset { get; set; } = null!;

        [Required]
        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location Location { get; set; } = null!;

        // Booking details
        [DataType(DataType.DateTime)]
        public DateTime CheckOut { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DueIn { get; set; }


        public BookingStatus Status { get; set; } = BookingStatus.Pending;
    }
}
