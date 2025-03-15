using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductService.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "High-performance laptop for professionals.", "Laptop", 1200.99m },
                    { 2, "Latest model with advanced features.", "Smartphone", 699.50m },
                    { 3, "Ergonomic design with smooth tracking.", "Wireless Mouse", 29.99m },
                    { 4, "Mechanical keyboard with RGB lighting.", "Keyboard", 49.99m },
                    { 5, "27-inch 4K UHD display.", "Monitor", 249.99m },
                    { 6, "Noise-canceling wireless headphones.", "Headphones", 89.99m },
                    { 7, "Fitness tracker with heart rate monitor.", "Smartwatch", 199.99m },
                    { 8, "10-inch tablet with stylus support.", "Tablet", 499.99m },
                    { 9, "1TB USB-C external hard drive.", "External Hard Drive", 129.99m },
                    { 10, "Next-gen gaming console with 4K support.", "Gaming Console", 399.99m },
                    { 11, "Mirrorless camera with 24MP sensor.", "Camera", 599.99m },
                    { 12, "Portable waterproof Bluetooth speaker.", "Bluetooth Speaker", 79.99m },
                    { 13, "High-speed WiFi 6 router.", "Router", 129.99m },
                    { 14, "10,000mAh fast-charging power bank.", "Power Bank", 39.99m },
                    { 15, "Immersive virtual reality headset.", "VR Headset", 299.99m },
                    { 16, "Lightweight e-reader with adjustable lighting.", "E-Reader", 149.99m },
                    { 17, "USB condenser microphone for podcasts.", "Microphone", 89.99m },
                    { 18, "Color-changing WiFi smart bulb.", "Smart Light Bulb", 24.99m },
                    { 19, "Professional-grade graphic drawing tablet.", "Graphic Tablet", 349.99m },
                    { 20, "4K home theater projector.", "Projector", 499.99m },
                    { 21, "Fast wireless charging pad.", "Wireless Charger", 29.99m },
                    { 22, "Energy-saving smart thermostat.", "Smart Thermostat", 199.99m },
                    { 23, "Foldable electric scooter with long range.", "Electric Scooter", 799.99m },
                    { 24, "Luxury automatic mechanical watch.", "Mechanical Watch", 249.99m },
                    { 25, "Full HD car dashboard camera.", "Car Dash Camera", 159.99m },
                    { 26, "Wireless home security camera.", "Security Camera", 199.99m },
                    { 27, "HEPA filter air purifier.", "Air Purifier", 349.99m },
                    { 28, "Programmable drip coffee maker.", "Coffee Maker", 99.99m },
                    { 29, "WiFi-enabled smart power plug.", "Smart Plug", 19.99m },
                    { 30, "4K aerial photography drone.", "Drone", 999.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
