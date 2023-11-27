using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Currency.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Announcements_Create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "083d8547-f310-4296-82b3-e34371c42192");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e3bc22c-aef9-4668-b8af-2d97fe740b61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d6bc33d-73ee-4f2c-bd5c-d58fed8411b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d287f833-b290-46b7-a73a-0343ad572582");

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ba14f50-33ab-4e88-85e5-eacf9e7c889f", "be92963f-991f-48d7-91f8-1a6bf18c1a52", "SuperAdmin", "SUPERADMİN" },
                    { "a5387522-1cf9-45b3-9e9a-f5761b5f8fc7", "f93a92b9-1de2-41f7-9327-361319933277", "User", "USER" },
                    { "bf4563b3-b171-4e8e-9dc2-a747506167c1", "ca4652c7-edd8-46bb-a07f-27a19ed98adf", "None", "NONE" },
                    { "cd6fe4df-92ef-47d4-9832-4386278354c8", "b8a4de31-2f53-40a0-a091-307eab71a1fc", "Admin", "ADMİN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ba14f50-33ab-4e88-85e5-eacf9e7c889f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5387522-1cf9-45b3-9e9a-f5761b5f8fc7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf4563b3-b171-4e8e-9dc2-a747506167c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd6fe4df-92ef-47d4-9832-4386278354c8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "083d8547-f310-4296-82b3-e34371c42192", "98e2392a-b351-4d75-b95f-52a29e2bf6b9", "SuperAdmin", "SUPERADMİN" },
                    { "0e3bc22c-aef9-4668-b8af-2d97fe740b61", "008031dc-a040-4ef3-9a7a-ceb7cd626838", "None", "NONE" },
                    { "6d6bc33d-73ee-4f2c-bd5c-d58fed8411b7", "b8fcab3d-32eb-4c1a-babd-536a5e6d7b0c", "Admin", "ADMİN" },
                    { "d287f833-b290-46b7-a73a-0343ad572582", "c5951fcb-7954-4fb4-a30b-5f0381b6176a", "User", "USER" }
                });
        }
    }
}
