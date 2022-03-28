using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmX.Migrations
{
    public partial class OrderCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d77350cd-5786-4fc1-a0fb-9542e4835dfa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "9eb16602-b779-4e8e-a572-394610955466");

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 49, 26, 810, DateTimeKind.Local).AddTicks(9805), new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(1141), new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(1146), new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(2535), new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(3508), new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(6103), new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(6106), new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(6111), new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(6113), new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(6183), new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(6186), new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(6191), new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(6193), new DateTime(2022, 3, 24, 17, 49, 26, 811, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 24, 17, 49, 26, 808, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 24, 17, 49, 26, 809, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 24, 17, 49, 26, 809, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 24, 17, 49, 26, 809, DateTimeKind.Local).AddTicks(8875));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "55ebac46-1b89-400c-8def-9c8a72593739");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "878c7df9-d919-4bac-a715-c5da2e0b61b3");

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 59, 17, 331, DateTimeKind.Local).AddTicks(9359), new DateTime(2022, 3, 22, 19, 59, 17, 331, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(285), new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(288), new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(1260), new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(1844), new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3608), new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3610), new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3614), new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3615), new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3618), new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3619), new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3622), new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3623), new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 22, 19, 59, 17, 330, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 22, 19, 59, 17, 331, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 22, 19, 59, 17, 331, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 22, 19, 59, 17, 331, DateTimeKind.Local).AddTicks(1745));
        }
    }
}
