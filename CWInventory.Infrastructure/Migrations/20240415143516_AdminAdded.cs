using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWInventory.Infrastructure.Migrations
{
    public partial class AdminAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StorageId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "67e4c2d0-dc48-4004-b692-35f04e7f64a0", 0, "7aa6be7a-06fd-4fb7-abf6-8f7b4d8f36e8", "admin@workforce.bg", false, "Great", "Admin", false, null, "ADMIN@WORKFORCE.BG", "ADMIN@WORKFORCE.BG", "AQAAAAEAACcQAAAAEPU1URxWY7a/+3e6NSC5yV+kSf4F7/UZP245YMcQb++xCKykUY7ks8PSasVzF5Frpw==", null, false, "00b24ec2-c88c-4422-81cb-ebf733ad55b4", null, false, "admin@workforce.bg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0");
        }
    }
}
