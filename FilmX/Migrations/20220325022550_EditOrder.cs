using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmX.Migrations
{
    public partial class EditOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_AspNetUsers_UserId",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_UserId",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "orders");

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
                column: "CreatedOn",
                value: new DateTime(2022, 3, 25, 9, 25, 50, 49, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 25, 9, 25, 50, 49, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 25, 9, 25, 50, 49, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 25, 9, 25, 50, 49, DateTimeKind.Local).AddTicks(8926));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "orders",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "78758e9d-a964-41f3-929e-8a520852d334");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6af89119-2094-40a2-9de4-4e76e9c6870a");

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(4558), new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(5759), new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(5763), new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(6993), new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(7731), new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(9961), new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(9963), new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(9968), new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(9969), new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(9974), new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(9975), new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(9978), new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(9980), new DateTime(2022, 3, 25, 9, 22, 37, 880, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 25, 9, 22, 37, 878, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 25, 9, 22, 37, 879, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 25, 9, 22, 37, 879, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 25, 9, 22, 37, 879, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.CreateIndex(
                name: "IX_orders_UserId",
                table: "orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_AspNetUsers_UserId",
                table: "orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
