using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Migrations
{
    public partial class editFörfattareData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Författare",
                keyColumn: "ID",
                keyValue: 1,
                column: "Efternamn",
                value: "Owens");

            migrationBuilder.UpdateData(
                table: "Författare",
                keyColumn: "ID",
                keyValue: 2,
                column: "Efternamn",
                value: "Colgan");

            migrationBuilder.UpdateData(
                table: "Författare",
                keyColumn: "ID",
                keyValue: 3,
                column: "Efternamn",
                value: "Jackson");

            migrationBuilder.UpdateData(
                table: "Författare",
                keyColumn: "ID",
                keyValue: 4,
                column: "Efternamn",
                value: "Myllymäki");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Författare",
                keyColumn: "ID",
                keyValue: 1,
                column: "Efternamn",
                value: null);

            migrationBuilder.UpdateData(
                table: "Författare",
                keyColumn: "ID",
                keyValue: 2,
                column: "Efternamn",
                value: null);

            migrationBuilder.UpdateData(
                table: "Författare",
                keyColumn: "ID",
                keyValue: 3,
                column: "Efternamn",
                value: null);

            migrationBuilder.UpdateData(
                table: "Författare",
                keyColumn: "ID",
                keyValue: 4,
                column: "Efternamn",
                value: null);
        }
    }
}
