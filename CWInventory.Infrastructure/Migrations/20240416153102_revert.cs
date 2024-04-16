using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWInventory.Infrastructure.Migrations
{
    public partial class revert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4867467a-5ed1-44d1-852b-2edc599649c4", "AQAAAAEAACcQAAAAEPYi9EmWV3HQYYjKupiwLCeCg2sD2ZaMQXdNi6pakoDzpsFFwMMjg08XFy0RiXFkDA==", "01b8bb78-5b41-4d4e-b240-e0997c2253c3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d76f2d3-b5da-4249-82f7-2a8684e1a6fc", "AQAAAAEAACcQAAAAEHWz99JPom9n+6PJWNWJAT6r6O0KhrThkBIeUNyhsibwujpx1F8IuDPn6b9iXa1WHA==", "dac287da-9e49-4304-a7b3-109932a46242" });
        }
    }
}
