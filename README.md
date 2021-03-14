# Demo bokhandel - SQL Server demo klient
## Instruktioner för att starta programmet i Visual Studio:
- För att kunna starta programmet ifrån Visual studio måste en Sql Server vara installerad och igång på samma dator. Efter att detta projekt har laddats ner och öppnats i Visual Studio behöver en databas skapas enligt:

  - Öppna 'Packet Manager Console' i Visual studio genom att gå till Tools-> NuGet Package Manager-> Packet Manager Console.
  - För att skapa databasen som programmet kommer att använda, skriv kommandot "update-database" (utan citattecken) i Packet Manager Console och tryck på Enter.
  - Om inga rödmarkerade felmeddelanden visas är databasen nu skapad.
  - Nu kan programmet startas i Visual studio. Den kommer att använda sig av databasen som skapades.

Denna lab är en fortsättning på [ITHS.NET.Databas.Lab2](https://github.com/PeterAfN/ITHS.NET.Databas.Lab2). Båda dessa labbarna ingick i kursen "Utveckling mot databas och databasadministration 45p" på IT-Högskolan i Göteborg som jag läste våren år 2021.

## Uppgiftsbeskrivningen för labben:
#### Utveckla en databasapp med Entity Framework Core
I denna lab utvecklar vi en applikation i C# som använder Entity Framework Core
för att låta användaren läsa och uppdatera data i en databas. Ni väljer själva om ni
vill göra en Console- eller WinForms-App, så länge funktionaliteten är på plats.
Ni kan välja på ett av de föreslagna projekten nedan, eller hitta på en egen idé och
skapa en databas med code first och migrations. OBS! Om ni väljer att göra ett
eget projekt så måste ni beskriva idén och omfånget för mig och få den godkänd
innan ni påbörjar utvecklingsarbetet. Detta för att jag ska kunna avgöra om det är
ett G- eller VG-projekt, samt säkerställa att ni inte väljer något som blir för
komplicerat för att hinna göra på den tid som är avsatt för detta.
#### Förslag 1
Skriv en applikation kopplad mot databasen för bokhandel som ni skapade i lab2.
För betyg G så ska användaren kunna lista lagersaldo för de olika butikerna, samt
kunna lägga till och ta bort böcker från butikerna. När man lägger till böcker ska
man kunna välja från samtliga böcker som redan finns i sortimentet (boktabellen).
För betyg VG så ska användaren dessutom kunna lägga till nya titlar i sortimentet,
och då kunna välja bland befintliga författare. Man ska även kunna lägga till nya
författare. När man lägger in nya böcker/författare måste man kunna mata in all
data om dessa, som t.ex antal sidor, pris, och utgivningsdatum. Man ska även
kunna redigera och ta bort titlar och författare.
#### Förslag 2
Skriv en applikation kopplad mot schema music i everyloop.
För betyg G så ska användaren kunna skapa nya, ta bort, samt modifiera befintliga
playlists genom att välja från biblioteket av låtar (från tabellen tracks).
För betyg VG så ska användaren dessutom kunna lägga in nya artister, album och
låtar, samt redigera och ta bort dessa. Förutom titlar ska man kunna se och
redigera längden på låtarna. 
#### Egna projekt
Ni kan föreslå egna projekt, men kom ihåg att ni i så fall ska beskriva idén och
omfånget och få den godkänd av mig innan ni påbörjar utvecklingsarbetet.
Minimum för G är att ni har minst två tabeller och att användaren både kan läsa
och uppdatera data i databasen på något sätt.
För VG behöver ni ytterligare någon eller några tabeller och mer funktionalitet. Se
förslag 1 och 2 ovan för att få en idé om hur stort omfånget på projektet bör vara.
Några förslag på idéer:
App där man kan bygga ihop lekar av pokemon-/magic-kort från en databas.
Frågespel där man får 4 alternativ, och kan lägga in egna frågor i olika kategorier.
Kokbok-app där användare kan lägga in recept och kommentera och betygsätta.
#### Redovisning
Lös uppgiften enskilt eller i grupper om 2-3 personer. Lägg upp en github-länk
som kommentar på ithsdistans. Om ni jobbat i grupp ska alla lägga upp en länk
och skriva vem/vilka ni jobbat ihop med.
Tänk på att jag måste kunna testa er applikation på ett smidigt sätt. Ni bör alltså
se till att checka in alla filer korrekt på github. Jag behöver också ha tillgång till
test-data, så antingen får ni sätta upp migrations med data seeding, eller (om det
är väldigt mycket data) så kan ni skicka med en backup av databasen. Skriv
instruktioner i ReadMe.md vad man behöver göra för att få igång projektet på en
ny dator. Testa även att checka ut projektet i en ny mapp och se så det fungerar
att sätta upp med ny databas enligt era instruktioner. 
För godkänt krävs:
 Ni har implementerat den funktionalitet vi kommit överens om för betyg
#### godkänt.
 Programmet fungerar utan större / uppenbara buggar.
 Jag måste kunna checka ut och testa projektet på ett smidigt sätt.
#### För väl godkänt krävs:
 Ni har implementerat den funktionalitet vi kommit överens om för betyg
väl godkänt.
 Programmet fungerar utan större / uppenbara buggar.
 Jag måste kunna checka ut och testa projektet på ett smidigt sätt.
 Projektet och koden är tydlig och väl strukturerad.
 Det är lätt att förstå och använda applikationen. 
