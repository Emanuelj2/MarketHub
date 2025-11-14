using System.ComponentModel.DataAnnotations;

namespace MarketHub_API.Models
{
    public class Platter
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }

        [Required]
        public Department Department { get; set; }

        public string? ImageUrl { get; set; }

        public bool IsSpecialDeal { get; set; }


        //prices for different serving sizes
        public decimal SmallPrice { get; set; }
        public decimal MediumPrice { get; set; }
        public decimal LargePrice { get; set; }

        public int SmallServing { get; set; }
        public int MediumServing { get; set; }
        public int LargeServing { get; set; }

        public bool IsAvailable { get; set; }

    }
}
