namespace MarketHub_API.Data
using Microsoft.EntityFrameworkCore;
using MarketHub_API.Models;

namespace MarketHub_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        // make the connections of how the models relate to each other
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //user congiguration
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
            
            modelBuilder.Entity<Platter>()
                .Property(p => p.SmallPrice)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Platter>()
                .Property(p => p.MediumPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Platter>()
                .Property(p => p.LargePrice)
                .HasPrecision(10, 2);

            // Cart configuration
            modelBuilder.Entity<Cart>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId);

            // CartItem configuration
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Cart)
                .WithMany(c => c.Items)
                .HasForeignKey(ci => ci.CartId);

            modelBuilder.Entity<CartItem>()
                .Property(ci => ci.Price)
                .HasPrecision(10, 2);

            // Order configuration
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId);

            modelBuilder.Entity<Order>()
                .Property(o => o.Subtotal)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .Property(o => o.DepositAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .Property(o => o.Total)
                .HasPrecision(10, 2);

            // OrderItem configuration
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.Items)
                .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.Price)
                .HasPrecision(10, 2);

            // Seed data
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Seed Platters
            modelBuilder.Entity<Platter>().HasData(
                // Deli Department
                new Platter
                {
                    Id = 1,
                    Name = "Cold Chicken Platter",
                    Description = "Assorted cold chicken cuts with garnish",
                    Department = Department.Deli,
                    ImageUrl = "/images/platters/cold-chicken.jpg",
                    IsSpecialDeal = true,
                    SmallPrice = 29.99m,
                    MediumPrice = 49.99m,
                    LargePrice = 79.99m,
                    SmallServings = 10,
                    MediumServings = 20,
                    LargeServings = 30,
                    IsAvailable = true
                },
                new Platter
                {
                    Id = 2,
                    Name = "Deli Meat & Cheese Platter",
                    Description = "Premium selection of deli meats and artisan cheeses",
                    Department = Department.Deli,
                    ImageUrl = "/images/platters/deli-meat-cheese.jpg",
                    IsSpecialDeal = false,
                    SmallPrice = 34.99m,
                    MediumPrice = 54.99m,
                    LargePrice = 89.99m,
                    SmallServings = 10,
                    MediumServings = 20,
                    LargeServings = 30,
                    IsAvailable = true
                },

                // Bakery Department
                new Platter
                {
                    Id = 3,
                    Name = "Cookie Platter",
                    Description = "Assorted fresh-baked cookies",
                    Department = Department.Bakery,
                    ImageUrl = "/images/platters/cookie-platter.jpg",
                    IsSpecialDeal = true,
                    SmallPrice = 19.99m,
                    MediumPrice = 34.99m,
                    LargePrice = 54.99m,
                    SmallServings = 12,
                    MediumServings = 24,
                    LargeServings = 36,
                    IsAvailable = true
                },
                new Platter
                {
                    Id = 4,
                    Name = "Pastry Platter",
                    Description = "Variety of Danish, croissants, and muffins",
                    Department = Department.Bakery,
                    ImageUrl = "/images/platters/pastry-platter.jpg",
                    IsSpecialDeal = false,
                    SmallPrice = 24.99m,
                    MediumPrice = 44.99m,
                    LargePrice = 69.99m,
                    SmallServings = 10,
                    MediumServings = 20,
                    LargeServings = 30,
                    IsAvailable = true
                },

                // Meat Department
                new Platter
                {
                    Id = 5,
                    Name = "BBQ Meat Platter",
                    Description = "Smoked brisket, ribs, and chicken",
                    Department = Department.Meat,
                    ImageUrl = "/images/platters/bbq-platter.jpg",
                    IsSpecialDeal = false,
                    SmallPrice = 44.99m,
                    MediumPrice = 74.99m,
                    LargePrice = 119.99m,
                    SmallServings = 8,
                    MediumServings = 16,
                    LargeServings = 24,
                    IsAvailable = true
                },
                new Platter
                {
                    Id = 6,
                    Name = "Grilled Chicken Wings Platter",
                    Description = "Grilled wings with various sauces",
                    Department = Department.Meat,
                    ImageUrl = "/images/platters/wings-platter.jpg",
                    IsSpecialDeal = true,
                    SmallPrice = 32.99m,
                    MediumPrice = 52.99m,
                    LargePrice = 84.99m,
                    SmallServings = 10,
                    MediumServings = 20,
                    LargeServings = 30,
                    IsAvailable = true
                }
            );
        }
    }
}