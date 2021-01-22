# Demo bokhandel - SQL Server demo klient
## Instruktioner för att starta programmet i Visual Studio:
- För att kunna starta programmet ifrån Visual studio måste en Sql Server vara installerad och igång på samma dator. Efter att detta projekt har laddats ner och öppnats i Visual Studio behöver en databas skapas enligt:

  - Öppna 'Packet Manager Console' i Visual studio genom att gå till Tools-> NuGet Package Manager-> Packet Manager Console.
  - För att skapa databasen som programmet kommer att använda, skriv kommandot "update-database" (utan citattecken) i Packet Manager Console.
  - Om inga rödmarkerade felmeddelanden visades är databasen nu skapad.
  - Nu kan programmet startas i Visual studio. Den kommer att använda sig av databasen som skapades.
