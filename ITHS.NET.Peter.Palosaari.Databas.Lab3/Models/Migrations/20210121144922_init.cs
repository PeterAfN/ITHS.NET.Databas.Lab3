using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Butiker",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Postnummer = table.Column<int>(type: "int", nullable: true),
                    Stad = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Land = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true, defaultValueSql: "('Sverige')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Butiker", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Författare",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Förnamn = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Efternamn = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Födelsedatum = table.Column<DateTime>(type: "datetime2", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Författare", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Förlag",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Beskrivning = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Telefonnummer = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Epost = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Förlag", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kunder",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Användarnamn = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Lösenord = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Förnamn = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Efternamn = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Epost = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Telefonnummer = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunder", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Böcker",
                columns: table => new
                {
                    ISBN13 = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Språk = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Pris = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    Utgivningsdatum = table.Column<DateTime>(type: "datetime2", unicode: false, maxLength: 10, nullable: true),
                    FörlagID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Böcker", x => x.ISBN13);
                    table.ForeignKey(
                        name: "FK_Böcker_Förlag",
                        column: x => x.FörlagID,
                        principalTable: "Förlag",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ordrar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ButikID = table.Column<int>(type: "int", nullable: false),
                    KundID = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: true, defaultValueSql: "(getdate())"),
                    FörsäljarId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Fraktavgift = table.Column<double>(type: "float", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Stad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Region = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Postnummer = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Land = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordrar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ordrar_Butiker",
                        column: x => x.ButikID,
                        principalTable: "Butiker",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ordrar_Kunder",
                        column: x => x.KundID,
                        principalTable: "Kunder",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FörfattareBöcker_Junction",
                columns: table => new
                {
                    FörfattareID = table.Column<int>(type: "int", nullable: false),
                    BokID = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FörfattareBöcker_Junction", x => new { x.FörfattareID, x.BokID });
                    table.ForeignKey(
                        name: "FK_FörfattareBöcker_Junction_Böcker",
                        column: x => x.BokID,
                        principalTable: "Böcker",
                        principalColumn: "ISBN13",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FörfattareBöcker_Junction_Författare",
                        column: x => x.FörfattareID,
                        principalTable: "Författare",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LagerSaldo",
                columns: table => new
                {
                    ButikID = table.Column<int>(type: "int", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Antal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LagerSaldo", x => new { x.ButikID, x.ISBN });
                    table.ForeignKey(
                        name: "FK_LagerSaldo_Butiker",
                        column: x => x.ButikID,
                        principalTable: "Butiker",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LagerSaldo_Böcker",
                        column: x => x.ISBN,
                        principalTable: "Böcker",
                        principalColumn: "ISBN13",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetaljer",
                columns: table => new
                {
                    ProduktId = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProduktPris = table.Column<double>(type: "float", nullable: true),
                    ProduktAntal = table.Column<int>(type: "int", nullable: true),
                    ProduktRabattProcent = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetaljer", x => new { x.ProduktId, x.OrderID });
                    table.ForeignKey(
                        name: "FK_OrderDetaljer_Böcker",
                        column: x => x.ProduktId,
                        principalTable: "Böcker",
                        principalColumn: "ISBN13",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetaljer_Ordrar",
                        column: x => x.OrderID,
                        principalTable: "Ordrar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Böcker_FörlagID",
                table: "Böcker",
                column: "FörlagID");

            migrationBuilder.CreateIndex(
                name: "IX_FörfattareBöcker_Junction_BokID",
                table: "FörfattareBöcker_Junction",
                column: "BokID");

            migrationBuilder.CreateIndex(
                name: "IX_LagerSaldo_ISBN",
                table: "LagerSaldo",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetaljer_OrderID",
                table: "OrderDetaljer",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Ordrar_ButikID",
                table: "Ordrar",
                column: "ButikID");

            migrationBuilder.CreateIndex(
                name: "IX_Ordrar_KundID",
                table: "Ordrar",
                column: "KundID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FörfattareBöcker_Junction");

            migrationBuilder.DropTable(
                name: "LagerSaldo");

            migrationBuilder.DropTable(
                name: "OrderDetaljer");

            migrationBuilder.DropTable(
                name: "Författare");

            migrationBuilder.DropTable(
                name: "Böcker");

            migrationBuilder.DropTable(
                name: "Ordrar");

            migrationBuilder.DropTable(
                name: "Förlag");

            migrationBuilder.DropTable(
                name: "Butiker");

            migrationBuilder.DropTable(
                name: "Kunder");
        }
    }
}
