using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmX.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<short>(type: "smallint", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    YearOfBirth = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "costTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_costTickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "filmCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filmCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeRow = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    PublicDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Producer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Directors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    NumOfViews = table.Column<int>(type: "int", nullable: false),
                    TotalVote = table.Column<int>(type: "int", nullable: false),
                    NumberOfVote = table.Column<int>(type: "int", nullable: false),
                    LimitAge = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_films", x => x.Id);
                    table.ForeignKey(
                        name: "FK_films_filmCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "filmCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "showTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeShow = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    TypeFilm = table.Column<short>(type: "smallint", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_showTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_showTimes_films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_showTimes_rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "seats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<int>(type: "int", nullable: false),
                    IsEmpty = table.Column<bool>(type: "bit", nullable: false),
                    ShowTimeId = table.Column<int>(type: "int", nullable: false),
                    TypeSeat = table.Column<short>(type: "smallint", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_seats_showTimes_ShowTimeId",
                        column: x => x.ShowTimeId,
                        principalTable: "showTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "55ebac46-1b89-400c-8def-9c8a72593739", "Admin", null },
                    { 2, "878c7df9-d919-4bac-a715-c5da2e0b61b3", "Customer", null }
                });

            migrationBuilder.InsertData(
                table: "filmCategories",
                columns: new[] { "Id", "CreatedOn", "IsDeleted", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 22, 19, 59, 17, 331, DateTimeKind.Local).AddTicks(9359), false, new DateTime(2022, 3, 22, 19, 59, 17, 331, DateTimeKind.Local).AddTicks(9836), "Chelsea" },
                    { 2, new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(285), false, new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(286), "Liverpool" },
                    { 3, new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(288), false, new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(289), "Real" }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "Id", "CreatedOn", "IsDeleted", "ModifiedOn", "Name", "SizeRow" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 22, 19, 59, 17, 330, DateTimeKind.Local).AddTicks(4193), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "R1", 8 },
                    { 2, new DateTime(2022, 3, 22, 19, 59, 17, 331, DateTimeKind.Local).AddTicks(1731), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "R2", 8 },
                    { 3, new DateTime(2022, 3, 22, 19, 59, 17, 331, DateTimeKind.Local).AddTicks(1743), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "R3", 8 },
                    { 4, new DateTime(2022, 3, 22, 19, 59, 17, 331, DateTimeKind.Local).AddTicks(1745), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "R4", 8 }
                });

            migrationBuilder.InsertData(
                table: "films",
                columns: new[] { "Id", "CategoryId", "Country", "CreatedOn", "Directors", "Duration", "ImagePath", "IsDeleted", "LimitAge", "ModifiedOn", "Name", "NumOfViews", "NumberOfVote", "Producer", "PublicDate", "Status", "TotalVote" },
                values: new object[,]
                {
                    { 1, 1, "Viet Nam", new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(1260), "Ngoc Hoi", 150, "batman.jpg", false, 18, new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(1844), "Bat Man", 1200, 5, "Joker", new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(2584), true, 5 },
                    { 2, 1, "Viet Nam", new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3608), "Illa Oi", 150, "spiderman.jpg", false, 18, new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3610), "Spiderman", 1200, 5, "Ngoc Hoi", new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3611), true, 5 },
                    { 3, 1, "Viet Nam", new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3614), "Missfortune", 150, "supper.jpg", false, 18, new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3615), "Supperman", 1200, 5, "Vi", new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3616), true, 5 },
                    { 4, 1, "Viet Nam", new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3618), "Jayce", 150, "thor.jpg", false, 18, new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3619), "Thor Ranarok", 1200, 5, "Vi", new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3620), true, 5 },
                    { 5, 1, "Viet Nam", new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3622), "Olivia Giroud", 150, "iron.jpg", false, 18, new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3623), "Ironman 3", 1200, 5, "Gumayusy", new DateTime(2022, 3, 22, 19, 59, 17, 332, DateTimeKind.Local).AddTicks(3624), true, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_films_CategoryId",
                table: "films",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_seats_ShowTimeId",
                table: "seats",
                column: "ShowTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_showTimes_FilmId",
                table: "showTimes",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_showTimes_RoomId",
                table: "showTimes",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "costTickets");

            migrationBuilder.DropTable(
                name: "seats");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "showTimes");

            migrationBuilder.DropTable(
                name: "films");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "filmCategories");
        }
    }
}
