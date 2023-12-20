using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymReservationWebApi.Migrations
{
    public partial class createReservationTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "GymReservations");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "GymReservations");

            migrationBuilder.AddColumn<int>(
                name: "ReservationTimeId",
                table: "GymReservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ReservationTime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityState = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationTime", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ReservationServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "ReservationServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "ReservationServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "ReservationStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "ReservationStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.InsertData(
                table: "ReservationTime",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EndTime", "EntityState", "StartTime" },
                values: new object[,]
                {
                    { 1, "system", new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2857), new TimeSpan(0, 8, 30, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, "system", new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2860), new TimeSpan(0, 9, 30, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { 3, "system", new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2862), new TimeSpan(0, 10, 30, 0, 0), 1, new TimeSpan(0, 10, 0, 0, 0) },
                    { 4, "system", new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2864), new TimeSpan(0, 11, 30, 0, 0), 1, new TimeSpan(0, 11, 0, 0, 0) },
                    { 5, "system", new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2865), new TimeSpan(0, 12, 30, 0, 0), 1, new TimeSpan(0, 12, 0, 0, 0) },
                    { 6, "system", new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2867), new TimeSpan(0, 13, 30, 0, 0), 1, new TimeSpan(0, 13, 0, 0, 0) },
                    { 7, "system", new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2868), new TimeSpan(0, 14, 30, 0, 0), 1, new TimeSpan(0, 14, 0, 0, 0) },
                    { 8, "system", new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2870), new TimeSpan(0, 15, 30, 0, 0), 1, new TimeSpan(0, 15, 0, 0, 0) },
                    { 9, "system", new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2871), new TimeSpan(0, 16, 30, 0, 0), 1, new TimeSpan(0, 16, 0, 0, 0) },
                    { 10, "system", new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2872), new TimeSpan(0, 17, 30, 0, 0), 1, new TimeSpan(0, 17, 0, 0, 0) },
                    { 11, "system", new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2874), new TimeSpan(0, 18, 30, 0, 0), 1, new TimeSpan(0, 18, 0, 0, 0) },
                    { 12, "system", new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2876), new TimeSpan(0, 19, 30, 0, 0), 1, new TimeSpan(0, 19, 0, 0, 0) },
                    { 13, "system", new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2877), new TimeSpan(0, 20, 30, 0, 0), 1, new TimeSpan(0, 20, 0, 0, 0) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GymReservations_ReservationTimeId",
                table: "GymReservations",
                column: "ReservationTimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_GymReservations_ReservationTime_ReservationTimeId",
                table: "GymReservations",
                column: "ReservationTimeId",
                principalTable: "ReservationTime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymReservations_ReservationTime_ReservationTimeId",
                table: "GymReservations");

            migrationBuilder.DropTable(
                name: "ReservationTime");

            migrationBuilder.DropIndex(
                name: "IX_GymReservations_ReservationTimeId",
                table: "GymReservations");

            migrationBuilder.DropColumn(
                name: "ReservationTimeId",
                table: "GymReservations");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "GymReservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "GymReservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ReservationServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 18, 20, 42, 35, 634, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "ReservationServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 18, 20, 42, 35, 634, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "ReservationServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 18, 20, 42, 35, 634, DateTimeKind.Local).AddTicks(4478));

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
        }
    }
}
