using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWInventory.Infrastructure.Migrations
{
    public partial class rebuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Storages_AspNetUsers_ManagerId",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Storages_ManagerId",
                table: "Storages");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "Storages",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "Storage manager identifier");

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Manager identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier"),
                    StorageId = table.Column<int>(type: "int", nullable: false, comment: "Manager's storage identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Managers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Managers_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93006816-a50b-4f12-a9cf-b36537d52081", "AQAAAAEAACcQAAAAEH8ZzGYPCi2gPO7KcEix2AFeOO6WQcWYaQHcHbb+MpVHYRyoi+gkc6F52aIHEDP1dg==", "81d6e781-457c-49ac-9034-4baa78ea2311" });

            migrationBuilder.CreateIndex(
                name: "IX_Managers_StorageId",
                table: "Managers",
                column: "StorageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Managers_UserId",
                table: "Managers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.AlterColumn<string>(
                name: "ManagerId",
                table: "Storages",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                comment: "Storage manager identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e4c2d0-dc48-4004-b692-35f04e7f64a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b58071a3-c911-4d58-95e4-3ec5afc37eee", "AQAAAAEAACcQAAAAEGol+LpmAE95mnVwgzMYX9QJ9zDZ4hfx07ANw76dadJNzWmhX2bjKw5JHb4ozwwy5Q==", "341ba413-4ff6-441e-8d95-4b804680a53f" });

            migrationBuilder.CreateIndex(
                name: "IX_Storages_ManagerId",
                table: "Storages",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_AspNetUsers_ManagerId",
                table: "Storages",
                column: "ManagerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
