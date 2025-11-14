namespace MarketHub_API.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order? Order { get; set; }


        public int PlatterId { get; set; }
        public Platter? Platter { get; set; }


        public string? PlatterName { get; set; }
        public ServingSize Size { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }


        public DateTime PickupDate { get; set; }
        public TimeSpan PickupTime { get; set; }

        public string? SpecialInstructions { get; set; }

    }
}
