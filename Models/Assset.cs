using System.ComponentModel.DataAnnotations;

namespace HelloWorldRazor.Models
{
    public class Asset
    {
        [Key]
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int OdometerKm { get; set; }
        public int Year { get; set; }
        public string State { get; set; }
        public string NumberPlate { get; set; }
    }
}