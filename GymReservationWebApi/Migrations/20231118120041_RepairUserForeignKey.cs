using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymReservationWebApi.Migrations
{
    public partial class RepairUserForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymReservations_AspNetUsers_UserId1",
                table: "GymReservations");

            migrationBuilder.DropIndex(
                name: "IX_GymReservations_UserId1",
                table: "GymReservations");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "GymReservations");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "GymReservations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_GymReservations_UserId",
                table: "GymReservations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GymReservations_AspNetUsers_UserId",
                table: "GymReservations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymReservations_AspNetUsers_UserId",
                table: "GymReservations");

            migrationBuilder.DropIndex(
                name: "IX_GymReservations_UserId",
                table: "GymReservations");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "GymReservations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "GymReservations",
                type: "nvarchar(450)",
                nullable: true);

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
        }
    }
}
