﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductService.Data;

#nullable disable

namespace ProductService.Migrations
{
    [DbContext(typeof(MyAppDbContext))]
    partial class MyAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductService.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "High-performance laptop for professionals.",
                            Name = "Laptop",
                            Price = 1200.99m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Latest model with advanced features.",
                            Name = "Smartphone",
                            Price = 699.50m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Ergonomic design with smooth tracking.",
                            Name = "Wireless Mouse",
                            Price = 29.99m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Mechanical keyboard with RGB lighting.",
                            Name = "Keyboard",
                            Price = 49.99m
                        },
                        new
                        {
                            Id = 5,
                            Description = "27-inch 4K UHD display.",
                            Name = "Monitor",
                            Price = 249.99m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Noise-canceling wireless headphones.",
                            Name = "Headphones",
                            Price = 89.99m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Fitness tracker with heart rate monitor.",
                            Name = "Smartwatch",
                            Price = 199.99m
                        },
                        new
                        {
                            Id = 8,
                            Description = "10-inch tablet with stylus support.",
                            Name = "Tablet",
                            Price = 499.99m
                        },
                        new
                        {
                            Id = 9,
                            Description = "1TB USB-C external hard drive.",
                            Name = "External Hard Drive",
                            Price = 129.99m
                        },
                        new
                        {
                            Id = 10,
                            Description = "Next-gen gaming console with 4K support.",
                            Name = "Gaming Console",
                            Price = 399.99m
                        },
                        new
                        {
                            Id = 11,
                            Description = "Mirrorless camera with 24MP sensor.",
                            Name = "Camera",
                            Price = 599.99m
                        },
                        new
                        {
                            Id = 12,
                            Description = "Portable waterproof Bluetooth speaker.",
                            Name = "Bluetooth Speaker",
                            Price = 79.99m
                        },
                        new
                        {
                            Id = 13,
                            Description = "High-speed WiFi 6 router.",
                            Name = "Router",
                            Price = 129.99m
                        },
                        new
                        {
                            Id = 14,
                            Description = "10,000mAh fast-charging power bank.",
                            Name = "Power Bank",
                            Price = 39.99m
                        },
                        new
                        {
                            Id = 15,
                            Description = "Immersive virtual reality headset.",
                            Name = "VR Headset",
                            Price = 299.99m
                        },
                        new
                        {
                            Id = 16,
                            Description = "Lightweight e-reader with adjustable lighting.",
                            Name = "E-Reader",
                            Price = 149.99m
                        },
                        new
                        {
                            Id = 17,
                            Description = "USB condenser microphone for podcasts.",
                            Name = "Microphone",
                            Price = 89.99m
                        },
                        new
                        {
                            Id = 18,
                            Description = "Color-changing WiFi smart bulb.",
                            Name = "Smart Light Bulb",
                            Price = 24.99m
                        },
                        new
                        {
                            Id = 19,
                            Description = "Professional-grade graphic drawing tablet.",
                            Name = "Graphic Tablet",
                            Price = 349.99m
                        },
                        new
                        {
                            Id = 20,
                            Description = "4K home theater projector.",
                            Name = "Projector",
                            Price = 499.99m
                        },
                        new
                        {
                            Id = 21,
                            Description = "Fast wireless charging pad.",
                            Name = "Wireless Charger",
                            Price = 29.99m
                        },
                        new
                        {
                            Id = 22,
                            Description = "Energy-saving smart thermostat.",
                            Name = "Smart Thermostat",
                            Price = 199.99m
                        },
                        new
                        {
                            Id = 23,
                            Description = "Foldable electric scooter with long range.",
                            Name = "Electric Scooter",
                            Price = 799.99m
                        },
                        new
                        {
                            Id = 24,
                            Description = "Luxury automatic mechanical watch.",
                            Name = "Mechanical Watch",
                            Price = 249.99m
                        },
                        new
                        {
                            Id = 25,
                            Description = "Full HD car dashboard camera.",
                            Name = "Car Dash Camera",
                            Price = 159.99m
                        },
                        new
                        {
                            Id = 26,
                            Description = "Wireless home security camera.",
                            Name = "Security Camera",
                            Price = 199.99m
                        },
                        new
                        {
                            Id = 27,
                            Description = "HEPA filter air purifier.",
                            Name = "Air Purifier",
                            Price = 349.99m
                        },
                        new
                        {
                            Id = 28,
                            Description = "Programmable drip coffee maker.",
                            Name = "Coffee Maker",
                            Price = 99.99m
                        },
                        new
                        {
                            Id = 29,
                            Description = "WiFi-enabled smart power plug.",
                            Name = "Smart Plug",
                            Price = 19.99m
                        },
                        new
                        {
                            Id = 30,
                            Description = "4K aerial photography drone.",
                            Name = "Drone",
                            Price = 999.99m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
