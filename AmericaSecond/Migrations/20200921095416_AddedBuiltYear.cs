using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AmericaSecond.Migrations
{
    public partial class AddedBuiltYear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Built",
                table: "Cars",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "LicensePlate", "Built", "Make", "Model", "OwnerId" },
                values: new object[,]
                {
                    { "1-NLD-73", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Renault", "Capture", null },
                    { "C#-13-37", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tesla", "S", null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ISOCode", "Name" },
                values: new object[,]
                {
                    { "NLD", "The Kingdom of the Netherlands" },
                    { "USA", "The United States of America" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName", "NationalityISOCode", "TelephoneNumber" },
                values: new object[,]
                {
                    { 3, new DateTime(1974, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eric", "Kuijpers", null, "+31651312408" },
                    { 4, new DateTime(1982, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carron", "Schilders", null, "+112" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "1-NLD-73");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "C#-13-37");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "NLD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "USA");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Built",
                table: "Cars");
        }
    }
}
