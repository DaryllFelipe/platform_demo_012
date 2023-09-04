using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    OrderNumber = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1L, "Carson Alexander", "09061111111" },
                    { 2L, "Meredith Alonso", "09061111111" },
                    { 3L, "Carson Anand", "09061111111" },
                    { 4L, "Arturo Barzdukas", "09061111111" },
                    { 5L, "Gytis Li", "09061111111" },
                    { 6L, "Yan Justice", "09061111111" },
                    { 7L, "Peggy Norman", "09061111111" },
                    { 8L, "Laura Olivetto", "09061111111" },
                    { 9L, "Nino Alexander", "09061111111" },
                    { 10L, "Samson Alexander", "09061111111" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderNumber" },
                values: new object[,]
                {
                    { 1L, 10.10m, 1L, 1L },
                    { 2L, 10.10m, 1L, 2L },
                    { 5L, 10.10m, 1L, 5L },
                    { 6L, 10.10m, 2L, 6L },
                    { 7L, 10.10m, 2L, 7L },
                    { 9L, 10.10m, 2L, 9L },
                    { 10L, 10.10m, 2L, 10L },
                    { 11L, 10.10m, 3L, 11L },
                    { 12L, 10.10m, 3L, 12L },
                    { 15L, 10.10m, 3L, 15L },
                    { 21L, 10.10m, 5L, 21L },
                    { 22L, 10.10m, 5L, 22L },
                    { 23L, 10.10m, 5L, 23L },
                    { 24L, 10.10m, 5L, 24L },
                    { 25L, 10.10m, 5L, 25L },
                    { 26L, 10.10m, 6L, 26L },
                    { 27L, 10.10m, 6L, 27L },
                    { 28L, 10.10m, 6L, 28L },
                    { 29L, 10.10m, 6L, 29L },
                    { 30L, 10.10m, 6L, 30L },
                    { 31L, 10.10m, 7L, 31L },
                    { 32L, 10.10m, 7L, 32L },
                    { 33L, 10.10m, 7L, 33L },
                    { 35L, 10.10m, 7L, 35L },
                    { 36L, 10.10m, 8L, 36L },
                    { 37L, 10.10m, 8L, 37L },
                    { 38L, 10.10m, 8L, 38L },
                    { 39L, 10.10m, 8L, 39L },
                    { 40L, 10.10m, 8L, 40L },
                    { 41L, 10.10m, 9L, 41L },
                    { 44L, 10.10m, 9L, 44L },
                    { 45L, 10.10m, 9L, 45L },
                    { 46L, 10.10m, 10L, 46L },
                    { 47L, 10.10m, 10L, 47L },
                    { 49L, 10.10m, 10L, 49L },
                    { 50L, 10.10m, 10L, 50L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
