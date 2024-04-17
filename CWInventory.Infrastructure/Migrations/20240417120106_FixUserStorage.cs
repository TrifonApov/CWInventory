using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWInventory.Infrastructure.Migrations
{
    public partial class FixUserStorage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b267d9c2-0937-4c56-a655-19ec25883019", "AQAAAAEAACcQAAAAELFdqDirrfMkqk/zwZLPuLMXuZRUWHoDrEQIVlvWl+iNL2juhq+Mz3xe7RoPKmW4Sw==", "9f27363d-e49b-4522-80a3-a653312db56a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92d17176-70e4-44ae-b871-2e6fbedd9ce0", "AQAAAAEAACcQAAAAEASKdqbd85aUqaf/P1MAVTsjHC4GcDpbP9hLW102/aPO0eybFZ8aMAP/awRDd50olg==", "17b78ea8-1ee9-4e26-869c-d8a4f11a8d7c" });
        }
    }
}
