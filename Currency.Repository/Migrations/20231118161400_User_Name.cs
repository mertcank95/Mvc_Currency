using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Currency.Repository.Migrations
{
    /// <inheritdoc />
    public partial class User_Name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cc5ece8-8af3-4d95-a626-c6b8f6fa57b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "377b92a3-1db5-4107-92fa-61ddd11d274e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69f79f7c-d799-45d9-9e18-3f4f7f069237");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb1f0e71-43ad-433c-8fc0-01f6bb37ca78");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0cc5ece8-8af3-4d95-a626-c6b8f6fa57b6", "3c111ce8-70d2-4d82-bd00-c125c9754560", "User", "USER" },
                    { "377b92a3-1db5-4107-92fa-61ddd11d274e", "4da181c9-baf6-448c-9805-d78cf3f0748b", "Admin", "ADMİN" },
                    { "69f79f7c-d799-45d9-9e18-3f4f7f069237", "2fa168f2-06f1-4964-8e01-7d91edb3f5a1", "None", "NONE" },
                    { "cb1f0e71-43ad-433c-8fc0-01f6bb37ca78", "c2584d32-fcbb-4889-85f7-7c30273a4ad7", "SuperAdmin", "SUPERADMİN" }
                });
        }
    }
}
