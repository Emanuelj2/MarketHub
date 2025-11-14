namespace MarketHub_API.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public string? OrderNumber { get; set; }

        public ICollection<CartItem>? Items { get; set; }


        public decimal Subtotal { get; set; }
        public decimal DepositAmount { get; set; }
        public decimal Total { get; set; }


        public OrderStatus Status { get; set; }
        public DateTime OrderDate { get; set; }

        public string? ConformationEmail { get; set; }
    }
}
