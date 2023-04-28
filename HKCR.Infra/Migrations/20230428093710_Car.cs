using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HKCR.Infra.Migrations
{
    public partial class Car : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarID = table.Column<Guid>(type: "uuid", nullable: false),
                    CarName = table.Column<string>(type: "text", nullable: false),
                    CarBrand = table.Column<string>(type: "text", nullable: false),
                    CarModel = table.Column<string>(type: "text", nullable: false),
                    CarColor = table.Column<string>(type: "text", nullable: false),
                    CarRentalRate = table.Column<string>(type: "text", nullable: false),
                    CarAvailability = table.Column<string>(type: "text", nullable: false),
                    CarNoOfRent = table.Column<string>(type: "text", nullable: false),
                    CarLastRented = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "185a0c16-24af-4d13-abb4-aa2f8494642b", "AQAAAAEAACcQAAAAEEEmnPKSpqf0mDx4eP7noNMSj4Z23GBwzNENrWdy90ZucSrXM6ewNEX2BI9thqg2Lw==", "bf78f669-7374-42e0-a47f-0b42a5b572a0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "User",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2e08a76-de83-4681-b4f8-20ac73bcd29d", "AQAAAAEAACcQAAAAEIXp1y6QlkF9IR1gl/5hxZ1JRYRM9w4th3Tz15Z1tI4nYWSJ3DC/rMm8459KklJp0w==", "c9e751fa-0819-4181-b756-72dfaa0f6810" });
        }
    }
}
