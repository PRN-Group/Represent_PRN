using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmX.Migrations
{
    public partial class EditRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SizeRow",
                table: "rooms",
                newName: "AvailableSeats");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "da5a1133-ba15-4db5-b057-e261382bf77b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b7c06621-45cc-4936-80f0-38f25c529132");

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 50, 26, 887, DateTimeKind.Local).AddTicks(7746), new DateTime(2022, 3, 25, 11, 50, 26, 887, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 50, 26, 887, DateTimeKind.Local).AddTicks(8932), new DateTime(2022, 3, 25, 11, 50, 26, 887, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 50, 26, 887, DateTimeKind.Local).AddTicks(8936), new DateTime(2022, 3, 25, 11, 50, 26, 887, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 50, 26, 888, DateTimeKind.Local).AddTicks(196), new DateTime(2022, 3, 25, 11, 50, 26, 888, DateTimeKind.Local).AddTicks(932), new DateTime(2022, 3, 25, 11, 50, 26, 888, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 50, 26, 888, DateTimeKind.Local).AddTicks(3130), new DateTime(2022, 3, 25, 11, 50, 26, 888, DateTimeKind.Local).AddTicks(3131), new DateTime(2022, 3, 25, 11, 50, 26, 888, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 50, 26, 888, DateTimeKind.Local).AddTicks(3137), new DateTime(2022, 3, 25, 11, 50, 26, 888, DateTimeKind.Local).AddTicks(3138), new DateTime(2022, 3, 25, 11, 50, 26, 888, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 50, 26, 888, DateTimeKind.Local).AddTicks(3143), new DateTime(2022, 3, 25, 11, 50, 26, 888, DateTimeKind.Local).AddTicks(3144), new DateTime(2022, 3, 25, 11, 50, 26, 888, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 50, 26, 888, DateTimeKind.Local).AddTicks(3148), new DateTime(2022, 3, 25, 11, 50, 26, 888, DateTimeKind.Local).AddTicks(3149), new DateTime(2022, 3, 25, 11, 50, 26, 888, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableSeats", "CreatedOn" },
                values: new object[] { 40, new DateTime(2022, 3, 25, 11, 50, 26, 884, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableSeats", "CreatedOn" },
                values: new object[] { 40, new DateTime(2022, 3, 25, 11, 50, 26, 886, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvailableSeats", "CreatedOn" },
                values: new object[] { 40, new DateTime(2022, 3, 25, 11, 50, 26, 886, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvailableSeats", "CreatedOn" },
                values: new object[] { 40, new DateTime(2022, 3, 25, 11, 50, 26, 886, DateTimeKind.Local).AddTicks(6140) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvailableSeats",
                table: "rooms",
                newName: "SizeRow");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "10a1c51b-f43d-4650-aad8-7a78186459a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "be19b31b-7600-4fe0-bcfa-c8f7b6e2f119");

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 25, 50, 50, DateTimeKind.Local).AddTicks(8994), new DateTime(2022, 3, 25, 9, 25, 50, 50, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(162), new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(166), new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(1363), new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(4412), new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(4414), new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(4419), new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(4421), new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(4425), new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(4426), new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(4431), new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(4432), new DateTime(2022, 3, 25, 9, 25, 50, 51, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "SizeRow" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 25, 50, 49, DateTimeKind.Local).AddTicks(4353), 8 });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "SizeRow" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 25, 50, 49, DateTimeKind.Local).AddTicks(8908), 8 });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "SizeRow" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 25, 50, 49, DateTimeKind.Local).AddTicks(8924), 8 });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "SizeRow" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 25, 50, 49, DateTimeKind.Local).AddTicks(8926), 8 });
        }
    }
}
