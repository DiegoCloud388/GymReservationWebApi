using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymReservationWebApi.Migrations
{
    public partial class AddReservationService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservationServiceId",
                table: "GymReservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ReservationServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityState = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationServices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ReservationServices",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "Name" },
                values: new object[,]
                {
                    { 1, "system", new DateTime(2023, 11, 18, 20, 42, 35, 634, DateTimeKind.Local).AddTicks(4466), 1, "Volejbal" },
                    { 2, "system", new DateTime(2023, 11, 18, 20, 42, 35, 634, DateTimeKind.Local).AddTicks(4475), 1, "Stolní tenis" },
                    { 3, "system", new DateTime(2023, 11, 18, 20, 42, 35, 634, DateTimeKind.Local).AddTicks(4478), 1, "Nohejbal" }
                });

            migrationBuilder.UpdateData(
                table: "ReservationStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 18, 20, 42, 35, 634, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "ReservationStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 18, 20, 42, 35, 634, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.CreateIndex(
                name: "IX_GymReservations_ReservationServiceId",
                table: "GymReservations",
                column: "ReservationServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_GymReservations_ReservationServices_ReservationServiceId",
                table: "GymReservations",
                column: "ReservationServiceId",
                principalTable: "ReservationServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymReservations_ReservationServices_ReservationServiceId",
                table: "GymReservations");

            migrationBuilder.DropTable(
                name: "ReservationServices");

            migrationBuilder.DropIndex(
                name: "IX_GymReservations_ReservationServiceId",
                table: "GymReservations");

            migrationBuilder.DropColumn(
                name: "ReservationServiceId",
                table: "GymReservations");

            migrationBuilder.UpdateData(
                table: "ReservationStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 18, 14, 11, 53, 427, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "ReservationStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 18, 14, 11, 53, 427, DateTimeKind.Local).AddTicks(9217));
        }
    }
}
