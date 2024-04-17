using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWInventory.Infrastructure.Migrations
{
    public partial class FixConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Storages_StorageId1",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_StorageId1",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "StorageId1",
                table: "Documents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92d17176-70e4-44ae-b871-2e6fbedd9ce0", "AQAAAAEAACcQAAAAEASKdqbd85aUqaf/P1MAVTsjHC4GcDpbP9hLW102/aPO0eybFZ8aMAP/awRDd50olg==", "17b78ea8-1ee9-4e26-869c-d8a4f11a8d7c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StorageId1",
                table: "Documents",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93006816-a50b-4f12-a9cf-b36537d52081", "AQAAAAEAACcQAAAAEH8ZzGYPCi2gPO7KcEix2AFeOO6WQcWYaQHcHbb+MpVHYRyoi+gkc6F52aIHEDP1dg==", "81d6e781-457c-49ac-9034-4baa78ea2311" });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_StorageId1",
                table: "Documents",
                column: "StorageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Storages_StorageId1",
                table: "Documents",
                column: "StorageId1",
                principalTable: "Storages",
                principalColumn: "Id");
        }
    }
}
