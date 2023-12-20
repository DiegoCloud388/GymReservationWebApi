using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymReservationWebApi.Migrations
{
    public partial class SeedCatalogData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ReservationStates",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "Name" },
                values: new object[] { 1, "system", new DateTime(2023, 11, 18, 14, 11, 53, 427, DateTimeKind.Local).AddTicks(9182), 1, "Reservováno" });

            migrationBuilder.InsertData(
                table: "ReservationStates",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "Name" },
                values: new object[] { 2, "system", new DateTime(2023, 11, 18, 14, 11, 53, 427, DateTimeKind.Local).AddTicks(9217), 1, "Zrušeno" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReservationStates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReservationStates",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
