using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWInventory.Infrastructure.Migrations
{
    public partial class ImageUrlNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Likn to product image",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Likn to product image");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02364594-94c2-4365-93fe-95a4a3ff7b2d", "AQAAAAEAACcQAAAAEMffr0eH42ajWhnqZyEDLrIPn17hhZcurT7BZqvzu5MH5ubtzFjbLTQqL6nfoXY3ww==", "eec83dce-f244-4457-8560-b1ff844d9f7c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Likn to product image",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Likn to product image");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d76f2d3-b5da-4249-82f7-2a8684e1a6fc", "AQAAAAEAACcQAAAAEHWz99JPom9n+6PJWNWJAT6r6O0KhrThkBIeUNyhsibwujpx1F8IuDPn6b9iXa1WHA==", "dac287da-9e49-4304-a7b3-109932a46242" });
        }
    }
}
