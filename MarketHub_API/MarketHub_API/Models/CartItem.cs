using System.ComponentModel.DataAnnotations;

namespace MarketHub_API.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        
        public int CartId { get; set; }
        public Cart? Cart { get; set; }


        public int PlatterId { get; set; }
        public Platter? Platter { get; set; }


        [Required]
        public ServingSize ServingSize { get; set; }
        public int Quantity { get; set; }

        [Required]
        public DateTime PickupDate { get; set; }
        [Required]
        public TimeSpan PickupTime { get; set; }


        public decimal Price { get; set; }

        public string? SpecialInstructions { get; set; }
    }
}
