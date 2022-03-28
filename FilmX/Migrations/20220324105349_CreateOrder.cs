using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmX.Migrations
{
    public partial class CreateOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostTicketId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    FilmId = table.Column<int>(type: "int", nullable: true),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    SeatId = table.Column<int>(type: "int", nullable: true),
                    showTimeId = table.Column<int>(type: "int", nullable: true),
                    roomId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orders_costTickets_CostTicketId",
                        column: x => x.CostTicketId,
                        principalTable: "costTickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orders_films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orders_rooms_roomId",
                        column: x => x.roomId,
                        principalTable: "rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orders_seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "seats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orders_showTimes_showTimeId",
                        column: x => x.showTimeId,
                        principalTable: "showTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_orders_CostTicketId",
                table: "orders",
                column: "CostTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_FilmId",
                table: "orders",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_roomId",
                table: "orders",
                column: "roomId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_SeatId",
                table: "orders",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_showTimeId",
                table: "orders",
                column: "showTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_UserId",
                table: "orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders");

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
    }
}
