using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Currency.Repository.Migrations
{
    /// <inheritdoc />
    public partial class User_Email_Token : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41fe77c2-b5e5-45e0-83d6-0a16a6d5a1ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da26af02-6462-445b-9b7f-f100427208fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e279ee63-4376-4435-9a41-57f158672545");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7fe0201-b917-4c58-b668-2ad95ee8b598");

            migrationBuilder.AddColumn<string>(
                name: "EmailVertificationCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "EmailVertificationCode",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "41fe77c2-b5e5-45e0-83d6-0a16a6d5a1ba", "b3b6911f-f0ff-4f25-b122-40a971c6d535", "Admin", "ADMİN" },
                    { "da26af02-6462-445b-9b7f-f100427208fb", "14573337-453b-482e-a709-621009a53f16", "None", "NONE" },
                    { "e279ee63-4376-4435-9a41-57f158672545", "6d78b891-0557-4498-bc74-8296641d5a18", "SuperAdmin", "SUPERADMİN" },
                    { "e7fe0201-b917-4c58-b668-2ad95ee8b598", "dbbf701c-0b5b-4362-b4da-d552b2a46c00", "User", "USER" }
                });
        }
    }
}
