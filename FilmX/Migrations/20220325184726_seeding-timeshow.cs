using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmX.Migrations
{
    public partial class seedingtimeshow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "showTimes");

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

            migrationBuilder.InsertData(
                table: "showTimes",
                columns: new[] { "Id", "CreatedOn", "FilmId", "IsDeleted", "ModifiedOn", "Price", "RoomId", "TimeShow", "TypeFilm" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 3, 26, 1, 47, 25, 429, DateTimeKind.Local).AddTicks(9971), 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1, new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), (short)0 },
                    { 1, new DateTime(2022, 3, 26, 1, 47, 25, 418, DateTimeKind.Local), 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1, new DateTime(2020, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), (short)0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "showTimes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "showTimes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "showTimes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8747f1cd-3e65-4ddb-9f22-95ab3bf6a80d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d19c18d7-5a77-44a8-84a4-c183a251ef3c");

            migrationBuilder.UpdateData(
                table: "costTickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 79, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "costTickets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 79, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 26, 35, 79, DateTimeKind.Local).AddTicks(5871), new DateTime(2022, 3, 26, 1, 26, 35, 79, DateTimeKind.Local).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 26, 35, 79, DateTimeKind.Local).AddTicks(7232), new DateTime(2022, 3, 26, 1, 26, 35, 79, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 26, 35, 79, DateTimeKind.Local).AddTicks(7237), new DateTime(2022, 3, 26, 1, 26, 35, 79, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(571), new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(1382), new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(3805), new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(3808), new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(3815), new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(3817), new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(3823), new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(3826), new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(3831), new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(3832), new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 77, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 78, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 78, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 78, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7481));
        }
    }
}
