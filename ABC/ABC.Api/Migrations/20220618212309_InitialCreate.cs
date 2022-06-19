using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABC.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharTypes",
                columns: table => new
                {
                    CharTypeCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CharTypeText = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    CreatedDtm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharTypes", x => x.CharTypeCode);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TCKN = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    CreatedDtm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    UpdatedDtm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonelTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    CreatedDtm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    UpdatedDtm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    RoomPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FloorType = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    CreatedDtm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    UpdatedDtm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsPartTime = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    StartDateOfWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateOfWork = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PersonelTypeId = table.Column<string>(type: "nvarchar(26)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    CreatedDtm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    UpdatedDtm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personels_PersonelTypes_PersonelTypeId",
                        column: x => x.PersonelTypeId,
                        principalTable: "PersonelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    ReservationDtm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    RoomId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    IsReservationComplate = table.Column<bool>(type: "bit", nullable: false),
                    MyProperty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    CreatedDtm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    UpdatedDtm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room_Chars",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    Val = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CharTypeId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    RoomId = table.Column<string>(type: "nvarchar(26)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    CreatedDtm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    UpdatedDtm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room_Chars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_Chars_CharTypes_CharTypeId",
                        column: x => x.CharTypeId,
                        principalTable: "CharTypes",
                        principalColumn: "CharTypeCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Room_Chars_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomPriceHistories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    RoomPriceOld = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RoomId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    CreatedDtm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    UpdatedDtm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomPriceHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomPriceHistories_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonelPriceHistories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    OldPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PersonelId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    CreatedDtm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedId = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    UpdatedDtm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelPriceHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonelPriceHistories_Personels_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonelPriceHistories_PersonelId",
                table: "PersonelPriceHistories",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_PersonelTypeId",
                table: "Personels",
                column: "PersonelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservations",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Chars_CharTypeId",
                table: "Room_Chars",
                column: "CharTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Chars_RoomId",
                table: "Room_Chars",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomPriceHistories_RoomId",
                table: "RoomPriceHistories",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonelPriceHistories");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Room_Chars");

            migrationBuilder.DropTable(
                name: "RoomPriceHistories");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "CharTypes");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "PersonelTypes");
        }
    }
}
