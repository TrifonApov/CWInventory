using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWInventory.Infrastructure.Migrations
{
    public partial class MakeImageUrlNullable : Migration
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
                values: new object[] { "f70bf5e3-c350-4eb8-a834-48985b4ea2a6", "AQAAAAEAACcQAAAAEAOJPbjbpiH3YTwFex1WT2a+q0zKCvMcy2Juc0NdgZ90elJgDGuIVMbqNdiS4KodkA==", "55304bea-1b6e-4888-ad00-e36a9b7cc17b" });
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
                values: new object[] { "4867467a-5ed1-44d1-852b-2edc599649c4", "AQAAAAEAACcQAAAAEPYi9EmWV3HQYYjKupiwLCeCg2sD2ZaMQXdNi6pakoDzpsFFwMMjg08XFy0RiXFkDA==", "01b8bb78-5b41-4d4e-b240-e0997c2253c3" });
        }
    }
}
