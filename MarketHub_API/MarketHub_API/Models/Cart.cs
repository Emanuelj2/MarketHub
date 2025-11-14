namespace MarketHub_API.Models
{
    public class Cart
    {
        public int Id { get; set; }
        
        public int UserId { get; set; }
        public User? User { get; set; }

        public ICollection<CartItem>? Items { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } 


        public decimal GetTotal()
        {
            return Items?.Sum(item => item.Price * item.Quantity) ?? 0m;
        }
    }
}
