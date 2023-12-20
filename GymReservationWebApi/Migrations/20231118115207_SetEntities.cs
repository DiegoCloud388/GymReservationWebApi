using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymReservationWebApi.Migrations
{
    public partial class SetEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EntityState",
                table: "GymReservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservationStateId",
                table: "GymReservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "GymReservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "GymReservations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ReservationStates",
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
                    table.PrimaryKey("PK_ReservationStates", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GymReservations_ReservationStateId",
                table: "GymReservations",
                column: "ReservationStateId");

            migrationBuilder.CreateIndex(
                name: "IX_GymReservations_UserId1",
                table: "GymReservations",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_GymReservations_AspNetUsers_UserId1",
                table: "GymReservations",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GymReservations_ReservationStates_ReservationStateId",
                table: "GymReservations",
                column: "ReservationStateId",
                principalTable: "ReservationStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymReservations_AspNetUsers_UserId1",
                table: "GymReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_GymReservations_ReservationStates_ReservationStateId",
                table: "GymReservations");

            migrationBuilder.DropTable(
                name: "ReservationStates");

            migrationBuilder.DropIndex(
                name: "IX_GymReservations_ReservationStateId",
                table: "GymReservations");

            migrationBuilder.DropIndex(
                name: "IX_GymReservations_UserId1",
                table: "GymReservations");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "GymReservations");

            migrationBuilder.DropColumn(
                name: "ReservationStateId",
                table: "GymReservations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "GymReservations");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "GymReservations");
        }
    }
}
