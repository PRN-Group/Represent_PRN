using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmX.Migrations
{
    public partial class ModifySeat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_seats_showTimes_ShowTimeId",
                table: "seats");

            migrationBuilder.RenameColumn(
                name: "ShowTimeId",
                table: "seats",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_seats_ShowTimeId",
                table: "seats",
                newName: "IX_seats_RoomId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "3e9183b5-c38d-455d-a1e4-fa83ba28dc6a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "af741988-bee9-4691-92a1-099322fc398e");

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 24, 21, 16, 43, 37, DateTimeKind.Local).AddTicks(8380), new DateTime(2022, 3, 24, 21, 16, 43, 37, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 24, 21, 16, 43, 37, DateTimeKind.Local).AddTicks(9577), new DateTime(2022, 3, 24, 21, 16, 43, 37, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 24, 21, 16, 43, 37, DateTimeKind.Local).AddTicks(9581), new DateTime(2022, 3, 24, 21, 16, 43, 37, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 24, 21, 16, 43, 38, DateTimeKind.Local).AddTicks(850), new DateTime(2022, 3, 24, 21, 16, 43, 38, DateTimeKind.Local).AddTicks(1683), new DateTime(2022, 3, 24, 21, 16, 43, 38, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 24, 21, 16, 43, 38, DateTimeKind.Local).AddTicks(4128), new DateTime(2022, 3, 24, 21, 16, 43, 38, DateTimeKind.Local).AddTicks(4130), new DateTime(2022, 3, 24, 21, 16, 43, 38, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 24, 21, 16, 43, 38, DateTimeKind.Local).AddTicks(4136), new DateTime(2022, 3, 24, 21, 16, 43, 38, DateTimeKind.Local).AddTicks(4137), new DateTime(2022, 3, 24, 21, 16, 43, 38, DateTimeKind.Local).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 24, 21, 16, 43, 38, DateTimeKind.Local).AddTicks(4142), new DateTime(2022, 3, 24, 21, 16, 43, 38, DateTimeKind.Local).AddTicks(4143), new DateTime(2022, 3, 24, 21, 16, 43, 38, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 24, 21, 16, 43, 38, DateTimeKind.Local).AddTicks(4147), new DateTime(2022, 3, 24, 21, 16, 43, 38, DateTimeKind.Local).AddTicks(4149), new DateTime(2022, 3, 24, 21, 16, 43, 38, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 24, 21, 16, 43, 35, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 24, 21, 16, 43, 36, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 24, 21, 16, 43, 36, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 24, 21, 16, 43, 36, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.AddForeignKey(
                name: "FK_seats_rooms_RoomId",
                table: "seats",
                column: "RoomId",
                principalTable: "rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_seats_rooms_RoomId",
                table: "seats");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "seats",
                newName: "ShowTimeId");

            migrationBuilder.RenameIndex(
                name: "IX_seats_RoomId",
                table: "seats",
                newName: "IX_seats_ShowTimeId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "3fe775ff-1479-49f7-abbc-f6bbdae45f8c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "625d59f4-8d8b-483b-8ca9-1717c49a163a");

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(759), new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(1956), new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "filmCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(1960), new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(3287), new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(4137), new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(6810), new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(6812), new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(6818), new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(6820), new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(6824), new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(6825), new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "PublicDate" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(6829), new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(6830), new DateTime(2022, 3, 24, 17, 53, 49, 187, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 24, 17, 53, 49, 185, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 24, 17, 53, 49, 186, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 24, 17, 53, 49, 186, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 24, 17, 53, 49, 186, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.AddForeignKey(
                name: "FK_seats_showTimes_ShowTimeId",
                table: "seats",
                column: "ShowTimeId",
                principalTable: "showTimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
