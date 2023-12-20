using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymReservationWebApi.Migrations
{
    public partial class DateOnlyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ReservationDate",
                table: "GymReservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ReservationServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "ReservationServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "ReservationServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "ReservationStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "ReservationStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 55, 53, 943, DateTimeKind.Local).AddTicks(2253));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationDate",
                table: "GymReservations");

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

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "ReservationTime",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2877));
        }
    }
}
