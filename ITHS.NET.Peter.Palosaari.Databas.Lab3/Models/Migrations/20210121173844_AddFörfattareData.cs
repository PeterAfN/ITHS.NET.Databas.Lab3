using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Migrations
{
    public partial class AddFörfattareData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Författare",
                columns: new[] { "ID", "Efternamn", "Födelsedatum", "Förnamn" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1949, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delia" },
                    { 2, null, new DateTime(1972, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jenny" },
                    { 3, null, new DateTime(1983, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stina" },
                    { 4, null, new DateTime(1978, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tommy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Författare",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Författare",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Författare",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Författare",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
