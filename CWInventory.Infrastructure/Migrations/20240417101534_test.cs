using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWInventory.Infrastructure.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b58071a3-c911-4d58-95e4-3ec5afc37eee", "AQAAAAEAACcQAAAAEGol+LpmAE95mnVwgzMYX9QJ9zDZ4hfx07ANw76dadJNzWmhX2bjKw5JHb4ozwwy5Q==", "341ba413-4ff6-441e-8d95-4b804680a53f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f70bf5e3-c350-4eb8-a834-48985b4ea2a6", "AQAAAAEAACcQAAAAEAOJPbjbpiH3YTwFex1WT2a+q0zKCvMcy2Juc0NdgZ90elJgDGuIVMbqNdiS4KodkA==", "55304bea-1b6e-4888-ad00-e36a9b7cc17b" });
        }
    }
}
