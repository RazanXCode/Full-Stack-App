
using Microsoft.EntityFrameworkCore;
using OrderService.Model;

namespace OrderService.Data
{



    public class MyAppDbContext : DbContext
    {

        // MyAppDbContext constructore
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options) { }

        // Datasets
        public DbSet<Order> orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, Status = "Pending", TotalAmount = 150.75m },
                new Order { Id = 2, Status = "Completed", TotalAmount = 299.99m },
                new Order { Id = 3, Status = "Cancelled", TotalAmount = 50.00m },
                new Order { Id = 4, Status = "Shipped", TotalAmount = 120.00m },
                new Order { Id = 5, Status = "Processing", TotalAmount = 75.45m },
                new Order { Id = 6, Status = "Pending", TotalAmount = 89.99m },
                new Order { Id = 7, Status = "Completed", TotalAmount = 205.99m },
                new Order { Id = 8, Status = "Cancelled", TotalAmount = 65.25m },
                new Order { Id = 9, Status = "Shipped", TotalAmount = 310.99m },
                new Order { Id = 10, Status = "Processing", TotalAmount = 129.50m },
                new Order { Id = 11, Status = "Pending", TotalAmount = 222.22m },
                new Order { Id = 12, Status = "Completed", TotalAmount = 432.10m },
                new Order { Id = 13, Status = "Cancelled", TotalAmount = 98.76m },
                new Order { Id = 14, Status = "Shipped", TotalAmount = 87.65m },
                new Order { Id = 15, Status = "Processing", TotalAmount = 190.55m },
                new Order { Id = 16, Status = "Pending", TotalAmount = 300.25m },
                new Order { Id = 17, Status = "Completed", TotalAmount = 99.99m },
                new Order { Id = 18, Status = "Cancelled", TotalAmount = 210.75m },
                new Order { Id = 19, Status = "Shipped", TotalAmount = 150.00m },
                new Order { Id = 20, Status = "Processing", TotalAmount = 88.88m },
                new Order { Id = 21, Status = "Pending", TotalAmount = 134.50m },
                new Order { Id = 22, Status = "Completed", TotalAmount = 250.00m },
                new Order { Id = 23, Status = "Cancelled", TotalAmount = 77.45m },
                new Order { Id = 24, Status = "Shipped", TotalAmount = 310.10m },
                new Order { Id = 25, Status = "Processing", TotalAmount = 210.99m },
                new Order { Id = 26, Status = "Pending", TotalAmount = 120.00m },
                new Order { Id = 27, Status = "Completed", TotalAmount = 330.75m },
                new Order { Id = 28, Status = "Cancelled", TotalAmount = 125.99m },
                new Order { Id = 29, Status = "Shipped", TotalAmount = 400.25m },
                new Order { Id = 30, Status = "Processing", TotalAmount = 290.99m }


            );
        }

    }


}
