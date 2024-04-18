using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWInventory.Infrastructure.Migrations
{
    public partial class UserManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Managers_UserId",
                table: "Managers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db7de311-8279-4621-80a2-c5c65a35b22d", "AQAAAAEAACcQAAAAELxNZkM4wFS9+pGmBXr5uv0NCqHXnWJC5GUELcn6kJTxheNBe9gMQ5VYSvD+9NeF/w==", "f93c1a85-dc56-4ad8-847d-992dfb2df0ec" });

            migrationBuilder.CreateIndex(
                name: "IX_Managers_UserId",
                table: "Managers",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Managers_UserId",
                table: "Managers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b267d9c2-0937-4c56-a655-19ec25883019", "AQAAAAEAACcQAAAAELFdqDirrfMkqk/zwZLPuLMXuZRUWHoDrEQIVlvWl+iNL2juhq+Mz3xe7RoPKmW4Sw==", "9f27363d-e49b-4522-80a3-a653312db56a" });

            migrationBuilder.CreateIndex(
                name: "IX_Managers_UserId",
                table: "Managers",
                column: "UserId");
        }
    }
}
