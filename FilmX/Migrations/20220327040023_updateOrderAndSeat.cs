using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmX.Migrations
{
    public partial class updateOrderAndSeat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShowTimeId",
                table: "seats",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "13e4229c-cf7f-4b66-b6fc-73e8e9e834ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2244469c-18d1-4935-ae94-0b87843a302a");

            migrationBuilder.UpdateData(
                table: "costTickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 886, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "costTickets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 886, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 27, 11, 0, 22, 886, DateTimeKind.Local).AddTicks(7021), new DateTime(2022, 3, 27, 11, 0, 22, 886, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 27, 11, 0, 22, 886, DateTimeKind.Local).AddTicks(8054), new DateTime(2022, 3, 27, 11, 0, 22, 886, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 27, 11, 0, 22, 886, DateTimeKind.Local).AddTicks(8057), new DateTime(2022, 3, 27, 11, 0, 22, 886, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(607), new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(1239), new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(3241), new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(3243), new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(3247), new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(3248), new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(3251), new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(3252), new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(3313), new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(3314), new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 885, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 885, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 885, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 885, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 893, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "showTimes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 887, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "showTimes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 27, 11, 0, 22, 892, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.CreateIndex(
                name: "IX_seats_ShowTimeId",
                table: "seats",
                column: "ShowTimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_seats_showTimes_ShowTimeId",
                table: "seats",
                column: "ShowTimeId",
                principalTable: "showTimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_seats_showTimes_ShowTimeId",
                table: "seats");

            migrationBuilder.DropIndex(
                name: "IX_seats_ShowTimeId",
                table: "seats");

            migrationBuilder.DropColumn(
                name: "ShowTimeId",
                table: "seats");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7049e467-e6ff-478e-a620-6da74e11321a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "413361d0-47e3-4743-ac1e-65ed33ebf130");

            migrationBuilder.UpdateData(
                table: "costTickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "costTickets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(1627), new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(2995), new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(3000), new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(6285), new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(7042), new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(9259), new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(9262), new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(9267), new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(9269), new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(9274), new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(9275), new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(9280), new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(9281), new DateTime(2022, 3, 26, 1, 47, 25, 417, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 415, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 416, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 416, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 416, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 430, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "showTimes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 418, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "showTimes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 47, 25, 429, DateTimeKind.Local).AddTicks(9971));
        }
    }
}
