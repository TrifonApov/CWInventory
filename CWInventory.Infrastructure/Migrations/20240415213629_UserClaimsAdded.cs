using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWInventory.Infrastructure.Migrations
{
    public partial class UserClaimsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "user:fullname", "Great Admin", "67e4c2d0-dc48-4004-b692-35f04e7f64a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d76f2d3-b5da-4249-82f7-2a8684e1a6fc", "AQAAAAEAACcQAAAAEHWz99JPom9n+6PJWNWJAT6r6O0KhrThkBIeUNyhsibwujpx1F8IuDPn6b9iXa1WHA==", "dac287da-9e49-4304-a7b3-109932a46242" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7aa6be7a-06fd-4fb7-abf6-8f7b4d8f36e8", "AQAAAAEAACcQAAAAEPU1URxWY7a/+3e6NSC5yV+kSf4F7/UZP245YMcQb++xCKykUY7ks8PSasVzF5Frpw==", "00b24ec2-c88c-4422-81cb-ebf733ad55b4" });
        }
    }
}
