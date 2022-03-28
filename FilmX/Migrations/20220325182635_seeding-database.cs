using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmX.Migrations
{
    public partial class seedingdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_costTickets_CostTicketID",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_films_FilmID",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_rooms_RoomID",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_seats_SeatID",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_showTimes_ShowTimeID",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_showTimes_films_FilmId",
                table: "showTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_showTimes_rooms_RoomId",
                table: "showTimes");

            migrationBuilder.DropIndex(
                name: "IX_orders_CostTicketID",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_FilmID",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_RoomID",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_SeatID",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_ShowTimeID",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "TypeSeat",
                table: "seats");

            migrationBuilder.DropColumn(
                name: "CostTicketID",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "FilmID",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "RoomID",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "SeatID",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "ShowTimeID",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "orders",
                newName: "userId");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "showTimes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FilmId",
                table: "showTimes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isCompleted",
                table: "orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<short>(
                name: "TypeFilm",
                table: "costTickets",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.CreateTable(
                name: "orderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    ShowTimeId = table.Column<int>(type: "int", nullable: true),
                    SeatId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orderDetails_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orderDetails_seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "seats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orderDetails_showTimes_ShowTimeId",
                        column: x => x.ShowTimeId,
                        principalTable: "showTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.InsertData(
                table: "costTickets",
                columns: new[] { "Id", "CreatedOn", "IsDeleted", "ModifiedOn", "Name", "Price", "TypeFilm" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 26, 1, 26, 35, 79, DateTimeKind.Local).AddTicks(7814), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 2D", 10m, (short)0 },
                    { 2, new DateTime(2022, 3, 26, 1, 26, 35, 79, DateTimeKind.Local).AddTicks(9066), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 3D", 15m, (short)1 }
                });

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

            migrationBuilder.InsertData(
                table: "seats",
                columns: new[] { "Id", "CreatedOn", "IsDeleted", "IsEmpty", "Location", "ModifiedOn", "RoomId" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7422), false, true, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 20, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7481), false, true, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 19, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7479), false, true, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 18, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7478), false, true, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 17, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7475), false, true, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 15, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7472), false, true, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7470), false, true, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 13, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7469), false, true, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7468), false, true, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7466), false, true, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7465), false, true, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7462), false, true, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7461), false, true, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7459), false, true, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7458), false, true, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7432), false, true, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7430), false, true, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7429), false, true, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 1, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(6558), false, true, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 16, new DateTime(2022, 3, 26, 1, 26, 35, 80, DateTimeKind.Local).AddTicks(7474), false, true, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_orders_userId",
                table: "orders",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetails_OrderId",
                table: "orderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetails_SeatId",
                table: "orderDetails",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetails_ShowTimeId",
                table: "orderDetails",
                column: "ShowTimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_AspNetUsers_userId",
                table: "orders",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_showTimes_films_FilmId",
                table: "showTimes",
                column: "FilmId",
                principalTable: "films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_showTimes_rooms_RoomId",
                table: "showTimes",
                column: "RoomId",
                principalTable: "rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_AspNetUsers_userId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_showTimes_films_FilmId",
                table: "showTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_showTimes_rooms_RoomId",
                table: "showTimes");

            migrationBuilder.DropTable(
                name: "orderDetails");

            migrationBuilder.DropIndex(
                name: "IX_orders_userId",
                table: "orders");

            migrationBuilder.DeleteData(
                table: "costTickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "costTickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "seats",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "isCompleted",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "TypeFilm",
                table: "costTickets");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "orders",
                newName: "TotalPrice");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "showTimes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FilmId",
                table: "showTimes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<short>(
                name: "TypeSeat",
                table: "seats",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<int>(
                name: "CostTicketID",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FilmID",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomID",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeatID",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShowTimeID",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                column: "CreatedOn",
                value: new DateTime(2022, 3, 25, 11, 50, 26, 884, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 25, 11, 50, 26, 886, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 25, 11, 50, 26, 886, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 3, 25, 11, 50, 26, 886, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.CreateIndex(
                name: "IX_orders_CostTicketID",
                table: "orders",
                column: "CostTicketID");

            migrationBuilder.CreateIndex(
                name: "IX_orders_FilmID",
                table: "orders",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_orders_RoomID",
                table: "orders",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_orders_SeatID",
                table: "orders",
                column: "SeatID");

            migrationBuilder.CreateIndex(
                name: "IX_orders_ShowTimeID",
                table: "orders",
                column: "ShowTimeID");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_costTickets_CostTicketID",
                table: "orders",
                column: "CostTicketID",
                principalTable: "costTickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_films_FilmID",
                table: "orders",
                column: "FilmID",
                principalTable: "films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_rooms_RoomID",
                table: "orders",
                column: "RoomID",
                principalTable: "rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_seats_SeatID",
                table: "orders",
                column: "SeatID",
                principalTable: "seats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_showTimes_ShowTimeID",
                table: "orders",
                column: "ShowTimeID",
                principalTable: "showTimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_showTimes_films_FilmId",
                table: "showTimes",
                column: "FilmId",
                principalTable: "films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_showTimes_rooms_RoomId",
                table: "showTimes",
                column: "RoomId",
                principalTable: "rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
