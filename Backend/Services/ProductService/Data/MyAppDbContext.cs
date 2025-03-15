
using Microsoft.EntityFrameworkCore;
using ProductService.Model;

namespace ProductService.Data
{



    public class MyAppDbContext : DbContext
    {

        // MyAppDbContext constructore
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options) { }

        // Datasets
        public DbSet<Product> products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Price = 1200.99m, Description = "High-performance laptop for professionals." },
                new Product { Id = 2, Name = "Smartphone", Price = 699.50m, Description = "Latest model with advanced features." },
                new Product { Id = 3, Name = "Wireless Mouse", Price = 29.99m, Description = "Ergonomic design with smooth tracking." },
                new Product { Id = 4, Name = "Keyboard", Price = 49.99m, Description = "Mechanical keyboard with RGB lighting." },
                new Product { Id = 5, Name = "Monitor", Price = 249.99m, Description = "27-inch 4K UHD display." },
                new Product { Id = 6, Name = "Headphones", Price = 89.99m, Description = "Noise-canceling wireless headphones." },
                new Product { Id = 7, Name = "Smartwatch", Price = 199.99m, Description = "Fitness tracker with heart rate monitor." },
                new Product { Id = 8, Name = "Tablet", Price = 499.99m, Description = "10-inch tablet with stylus support." },
                new Product { Id = 9, Name = "External Hard Drive", Price = 129.99m, Description = "1TB USB-C external hard drive." },
                new Product { Id = 10, Name = "Gaming Console", Price = 399.99m, Description = "Next-gen gaming console with 4K support." },
                new Product { Id = 11, Name = "Camera", Price = 599.99m, Description = "Mirrorless camera with 24MP sensor." },
                new Product { Id = 12, Name = "Bluetooth Speaker", Price = 79.99m, Description = "Portable waterproof Bluetooth speaker." },
                new Product { Id = 13, Name = "Router", Price = 129.99m, Description = "High-speed WiFi 6 router." },
                new Product { Id = 14, Name = "Power Bank", Price = 39.99m, Description = "10,000mAh fast-charging power bank." },
                new Product { Id = 15, Name = "VR Headset", Price = 299.99m, Description = "Immersive virtual reality headset." },
                new Product { Id = 16, Name = "E-Reader", Price = 149.99m, Description = "Lightweight e-reader with adjustable lighting." },
                new Product { Id = 17, Name = "Microphone", Price = 89.99m, Description = "USB condenser microphone for podcasts." },
                new Product { Id = 18, Name = "Smart Light Bulb", Price = 24.99m, Description = "Color-changing WiFi smart bulb." },
                new Product { Id = 19, Name = "Graphic Tablet", Price = 349.99m, Description = "Professional-grade graphic drawing tablet." },
                new Product { Id = 20, Name = "Projector", Price = 499.99m, Description = "4K home theater projector." },
                new Product { Id = 21, Name = "Wireless Charger", Price = 29.99m, Description = "Fast wireless charging pad." },
                new Product { Id = 22, Name = "Smart Thermostat", Price = 199.99m, Description = "Energy-saving smart thermostat." },
                new Product { Id = 23, Name = "Electric Scooter", Price = 799.99m, Description = "Foldable electric scooter with long range." },
                new Product { Id = 24, Name = "Mechanical Watch", Price = 249.99m, Description = "Luxury automatic mechanical watch." },
                new Product { Id = 25, Name = "Car Dash Camera", Price = 159.99m, Description = "Full HD car dashboard camera." },
                new Product { Id = 26, Name = "Security Camera", Price = 199.99m, Description = "Wireless home security camera." },
                new Product { Id = 27, Name = "Air Purifier", Price = 349.99m, Description = "HEPA filter air purifier." },
                new Product { Id = 28, Name = "Coffee Maker", Price = 99.99m, Description = "Programmable drip coffee maker." },
                new Product { Id = 29, Name = "Smart Plug", Price = 19.99m, Description = "WiFi-enabled smart power plug." },
                new Product { Id = 30, Name = "Drone", Price = 999.99m, Description = "4K aerial photography drone." }


            );
        }

    }


}
