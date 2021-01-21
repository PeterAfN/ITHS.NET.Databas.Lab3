using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Migrations
{
    public partial class addDataForAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Butiker",
                columns: new[] { "ID", "Adress", "Land", "Namn", "Postnummer", "Stad" },
                values: new object[,]
                {
                    { 1, "Stora Torget 2", "Sverige", "Akademibokhandeln Alingsås", 44130, "Alingsås" },
                    { 2, "Norra Hamngatan 26", "Sverige", "Akademibokhandeln Nordstan", 41106, "Göteborg" },
                    { 3, "Norra Långgatan 26", "Sverige", "Akademibokhandeln Kalmar", 39232, "Kalmar" },
                    { 4, "Forelltorget 6", "Sverige", "Akademibokhandeln Huddinge Centrum", 14147, "Huddinge" },
                    { 5, "Götgatan 78", "Sverige", "Akademibokhandeln Stockholm Skrapan", 11830, "Stockholm" },
                    { 6, "Storgatan 22", "Sverige", "Akademibokhandeln Sundsvall Storgatan", 85230, "Sundsvall" }
                });

            migrationBuilder.InsertData(
                table: "Förlag",
                columns: new[] { "ID", "Beskrivning", "Epost", "Namn", "Telefonnummer" },
                values: new object[,]
                {
                    { 9, "Natur & Kultur (NoK) är ett svenskt bokförlag grundat 1922. Förlaget har en omfattande utgivning av läromedel och allmänlitteratur.", " info@nok.se", "Natur & Kultur", "08-453 86 00" },
                    { 8, "Hedvig vill vara läsarens bästa vän. Därför ger vi ut läsvänliga böcker för barn och vuxna som har lässvårigheter.", "hej@bokforlagethedvig.se", "Bokförlaget Hedvig", "08-696 80 00" },
                    { 6, "Hachette Book Group (HBG) is a publishing company owned by Hachette Livre, the largest publishing company in France.", "customer.service@hbgusa.com", "Hachette Book Group UK", "001800-759-0190" },
                    { 5, "Massolit förlag är ett svenskt bokförlag som grundades 2010 av Stefan Tegenfalk och Johannes Källström. Massolit ingår i Norstedts Förlagsgrupp.", "order@norstedts.se", "Massolit Förlag", "08-769 89 00" },
                    { 7, "Albert Bonniers Förlag, ibland omnämnt som Bonniers,[1] grundades 1837 av Albert Bonnier (1820–1900). Det är ett av de äldsta förlagen i Sverige.", "info@albertbonniers.se", "Albert Bonniers Förlag", "08 696 86 20" },
                    { 3, "Little, Brown and Company is an American publisher founded in 1837 by Charles Coffin Little and his partner, James Brown.", "leah.petrakis@hmhco.com", "Houghton Mifflin (Trade)", "-" },
                    { 2, "Little, Brown and Company is an American publisher founded in 1837 by Charles Coffin Little and his partner, James Brown.", "na@na", "Little, Brown & Company", "001617-227-0730" },
                    { 1, "Bokförlaget Forum (Swedish: Forum bokförlag) is a Swedish publishing company and a member of Bonnierförlagen, a publishing house within Bonnier Books Nordic.", "info@forum.se", "Bokförlaget Forum", "08-696 84 40" },
                    { 4, "Norstedts Förlagsgrupp AB är en svensk koncern av bokförlag. Norstedts förlag är Sveriges äldsta ännu verksamma bokförlag och ett av Sveriges största.", "order@norstedts.se", "Norstedts Förlag", "08-769 89 00" }
                });

            migrationBuilder.InsertData(
                table: "Kunder",
                columns: new[] { "ID", "Användarnamn", "Efternamn", "Epost", "Förnamn", "Lösenord", "Telefonnummer" },
                values: new object[,]
                {
                    { "841204-3830", "kajing", "Ingesson", "kaj.ingesson@gmail.com", "Kaj", "7a0c99ef914f596a9d745df32a9c84dd", "073-8740881" },
                    { "731012-9018", "gusber", "Berg", "gustav.berg@hotmail.com", "Gustav", "bbc595e205a865a6afd9a8584f319f3b", "0701-1998079" },
                    { "741109-2058", "aledah", "Dahl", "alexander.dahl@telia.se", "Alexander", "425e618ba6834cdff3e5235a648d7a49", "073-2172719" },
                    { "750210-6008", "beamol", "Möller", "beata.moller@hotmail.com", "Beata", "85267d349a5e647ff0a9edcb5ffd1e02", "070-3737944" },
                    { "751123-9724", "annake", "Åkerman", "anne.akerman@hotmail.com", "Anne", "ebf12cb74e96e67e63783d93c534ef27", "073-2485110" },
                    { "770422-8188", "maliek", "Ek", "malin.ek@telia.se", "Malin", "0866b954204f6576dcf4c59af968f2eb", "0701-1212603" },
                    { "800512-6752", "raneri", "Eriksson", "randi.eriksson@gmail.com", "Randi", "5128811422870279d063413608e0bc4b", "0702-8501636" },
                    { "801022-4516", "antrag", "Ragnvaldsson", "anton.ragnvaldsson@gmail.com", "Anton", "bd50f363001990ee1fe5d798702b1d5b", "070-633579" },
                    { "811008-5301", "sigpet", "Pettersson", "sigrid.pettersson@gmail.com", "Sigrid", "0f70d19c41c092696766a57abe1b4266", "073-1536205" },
                    { "820624-3075", "andhan", "Hansson", "anders.hansson@hotmail.com", "Anders", "f82e0b0c45c7babe84db897066335590", "073-3519746" },
                    { "851126-2068", "elivan", "Vång", "elisabeth.vang@hotmail.com", "Elisabeth", "ecd058faafa18f55f81d730b142f8fd3", "073-1423995" },
                    { "940406-2734", "sighal", "Hall", "sigfrid.hall@gmail.com", "Sigfrid", "20bb93fcb37c7ec9be51cf792d5c9609", "0701-8841184" },
                    { "880706-3713", "felber", "Berglund", "felix.berglund@telia.se", "Felix", "3e016029eeb9a92852a656f33fbf1dc6", "0701-608431" },
                    { "890701-1480", "felber", "Bertilsson", "felicia.bertilsson@yahoo.com", "Felicia", "03cafe742c11ddc94bff251c842b7f67", "0702-82374" },
                    { "910806-1370", "petmol", "Möller", "petter.moller@yahoo.com", "Petter", "9ef248df74556f4768271660f5ef5f7b", "073-3383188" },
                    { "921005-4598", "karlun", "Lundberg", "kare.lundberg@yahoo.com", "Kåre", "e26ebd564a492f55c8ceed4d97c5fedb", "0702-5836648" },
                    { "921110-8377", "edvalf", "Alfsson", "edvin.alfsson@yahoo.com", "Edvin", "9d4e5ea4418508b6a23445e3089f4898", "073-3922225" },
                    { "720524-3728", "svesol", "Solberg", "svea.solberg@hotmail.com", "Svea", "47551f847eb553f2600d124fdfd03730", "0702-5177172" },
                    { "950527-6317", "artbjo", "Björk", "arthur.bjork@telia.se", "Arthur", "5b2b2d2bd0cd2c7a7019d2c2a7c6307a", "073-4539000" },
                    { "970602-8733", "petlju", "Ljungstrand", "peter.ljungstrand@hotmail.com", "Peter", "9323f21f2098b7288267c785458548b2", "0702-4432102" },
                    { "971220-1939", "gorpat", "Patriksson", "goran.patriksson@hotmail.com", "Göran", "fc14f949c1baf821079b6e2b9b22f553", "0702-7294060" },
                    { "980128-9944", "careng", "Engström", "caroline.engstrom@yahoo.com", "Caroline", "6a5889bb0190d0211a991f47bb19a777", "070-8674341" },
                    { "861110-5749", "rakalb", "Albertsson", "rakel.albertsson@yahoo.com", "Rakel", "df132656c11853d6118fe9d36eaba5e1", "070-7753662" },
                    { "690206-8769", "solbor", "Borg", "solvig.borg@hotmail.com", "Solvig", "d6cb41a908909feead800375f0e96b04", "0702-1110436" },
                    { "630309-2528", "virlju", "Ljungman", "virginia.ljungman@hotmail.com", "Virginia", "72cd11da65daac3c9e75ee19f93eb0dd", "073-9485514" },
                    { "640913-5335", "trumat", "Matsson", "truls.matsson@hotmail.com", "Truls", "195d221c982e47eb58347e5d06ce3180", "073-5454387" },
                    { "500603-4268", "johlen", "Lennartsson", "johanna.lennartsson@gmail.com", "Johanna", "422cf6c6f212dde0fa96c532de240104", "070-9428041" }
                });

            migrationBuilder.InsertData(
                table: "Kunder",
                columns: new[] { "ID", "Användarnamn", "Efternamn", "Epost", "Förnamn", "Lösenord", "Telefonnummer" },
                values: new object[,]
                {
                    { "500607-6521", "catknu", "Knutson", "catharina.knutson@yahoo.com", "Catharina", "c5aa65949d20f6b20e1a922c13d974e7", "0702-3351252" },
                    { "530407-7989", "ullalv", "Alvarsson", "ulla.alvarsson@hotmail.com", "Ulla", "4fec58181bb416f09f8ef0f69433584f", "070-9922357" },
                    { "530720-7675", "alvlin", "Lindholm", "alvin.lindholm@gmail.com", "Alvin", "2194506fc6ef7a2048f03a0f4ee7c641", "0701-6100069" },
                    { "540430-4887", "milalb", "Albertsson", "milla.albertsson@gmail.com", "Milla", "3047ee053d45323e65192012176a2a1c", "0702-4265981" },
                    { "550930-7164", "mymard", "Mårdh", "my.mardh@yahoo.com", "My", "3587f76616df673c64f36e1d8babc2e7", "0701-7763403" },
                    { "561108-3389", "vilmat", "Matsson", "vilhelmina.matsson@hotmail.com", "Vilhelmina", "aa426df08f79c27a95d70a496a69759c", "0701-8262655" },
                    { "570501-4924", "monsol", "Solberg", "mona.solberg@yahoo.com", "Mona", "c1de2111b16e6b21b794451fe54ef86f", "070-9254810" },
                    { "571110-3843", "frieri", "Ericson", "frida.ericson@hotmail.com", "Frida", "7a981e17886344fb031e3735a7284b8c", "0702-8579941" },
                    { "580802-4175", "sigpet", "Pethrus", "sigge.pethrus@gmail.com", "Sigge", "67b48cc32ab9f04633bd50656a4a26fc", "073-1923116" },
                    { "680820-7946", "chasor", "Sörensen", "charlotte.sorensen@yahoo.com", "Charlotte", "0bc22e1c47f26addd1907b4931e507b1", "070-6751319" },
                    { "591007-1584", "henblo", "Blomgren", "henrietta.blomgren@hotmail.com", "Henrietta", "0dd81a42714c6fe8bd670804643b458d", "0702-140965" },
                    { "600309-7687", "gunmik", "Mikaelsson", "gunnel.mikaelsson@hotmail.com", "Gunnel", "07c09ba3a403585b6c93f73d03983079", "073-5093738" },
                    { "601103-7655", "bjowal", "Waltersson", "bjoern.waltersson@gmail.com", "Bjoern", "7e9a21b78e3723bde67627aa095f98fd", "073-7811105" },
                    { "620925-4245", "annber", "Bergfalk", "annette.bergfalk@telia.se", "Annette", "2c3339f366a420eb04c6b6c21b7746bf", "0702-7855547" },
                    { "630129-6936", "valgra", "Grahn", "valdemar.grahn@gmail.com", "Valdemar", "6c01156a337cb1e4748f3567bdeff63c", "070-1531320" },
                    { "630303-4894", "sigpet", "Petersson", "sigfrid.petersson@yahoo.com", "Sigfrid", "1bf3fa859c48493f5f2606ccaaa0f20e", "0701-9399564" },
                    { "981003-1947", "ketber", "Bergfalk", "kettil.bergfalk@yahoo.com", "Kettil", "90918c5b8c17f80e32d5b155a7bf6197", "070-2076573" },
                    { "630611-7069", "hjowan", "Wang", "hjordis.wang@hotmail.com", "Hjördis", "bb31bb1b1b3b1900fa619d1a7e3ebb92", "073-8899553" },
                    { "630912-1175", "vigsor", "Sorenson", "viggo.sorenson@gmail.com", "Viggo", "741adf496ee8c2d3e8c864e9567211af", "0701-1921858" },
                    { "630929-1879", "bensve", "Svenson", "bengt.svenson@yahoo.com", "Bengt", "06af2e43797e629c5a4c7bfe58a105c3", "073-8906035" },
                    { "640912-6799", "ebbwes", "Westerberg", "ebbe.westerberg@gmail.com", "Ebbe", "436c26abd464041efd354bc550f76482", "0701-1931783" },
                    { "591026-6645", "jancla", "Claesson", "jannike.claesson@telia.se", "Jannike", "3e53ae683f8e8c84221db763b30fe907", "0701-4033966" },
                    { "990130-1619", "lenoma", "Öman", "lennart.oman@yahoo.com", "Lennart", "744878fbdd26871c594f57ca61733e09", "070-6672001" }
                });

            migrationBuilder.InsertData(
                table: "Böcker",
                columns: new[] { "ISBN13", "FörlagID", "Pris", "Språk", "Titel", "Utgivningsdatum" },
                values: new object[,]
                {
                    { "9789127168169", 9, 229m, "Svenska", "Myllymäkis menyer : vår, sommar, höst, vinter", new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "9789127158672", 9, 289m, "Svenska", "Soppa, potage & buljong", new DateTime(2018, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "9789100186364", 7, 49m, "Svenska", "Ödesmark", new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "9780751564822", 6, 139m, "Engelska", "The Endless Beach", new DateTime(2018, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "9789179710125", 8, 239m, "Svenska", "Silvervägen (lättläst)", new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "9789113096803", 4, 49m, "Svenska", "Julafton på den lilla ön i havet", new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "9780395647806", 3, 229m, "Engelska", "Cry of the Kalahari", new DateTime(1993, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "9781472154668", 2, 169m, "Engelska", "Where the Crawdads Sing", new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "9789137154831", 1, 149m, "Svenska", "Där kräftorna sjunger", new DateTime(2020, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "9789176910986", 5, 95m, "Svenska", "Jul i det lilla bageriet på strandpromenaden", new DateTime(2017, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Ordrar",
                columns: new[] { "ID", "Adress", "ButikID", "Datum", "Fraktavgift", "FörsäljarId", "KundID", "Land", "Postnummer", "Region", "Stad" },
                values: new object[,]
                {
                    { 31, "Ringvägen 3", 4, new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "6", "770422-8188", "Sverige", "44223", "Gotlands län", "Göteborg" },
                    { 34, "Järnvägsgatan 3", 6, new DateTime(2020, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "811008-5301", "Sverige", "32145", "Dalarnas län", "Stockholm" },
                    { 33, "Granvägen 3", 3, new DateTime(2020, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "3", "801022-4516", "Sverige", "32145", "Jönköpings län", "Alfta" },
                    { 63, "Björkvägen 3", 6, new DateTime(2020, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "800512-6752", "Sverige", "32145", "Blekinge län", "Arboga" },
                    { 32, "Björkvägen 3", 3, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "2", "800512-6752", "Sverige", "21345", "Blekinge län", "Arboga" },
                    { 30, "Järnvägsgatan 3", 3, new DateTime(2020, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "9", "751123-9724", "Sverige", "12345", "Dalarnas län", "Stockholm" },
                    { 26, "Parkvägen 3", 3, new DateTime(2020, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "4", "720524-3728", "Sverige", "44223", "Stockholms län", "Gnosjö" },
                    { 29, "Björkvägen 3", 1, new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "8", "750210-6008", "Sverige", "44223", "Blekinge län", "Arboga" },
                    { 28, "Skolvägen 3", 3, new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "2", "741109-2058", "Sverige", "21345", "Uppsala län", "Grästorp" },
                    { 27, "Strandvägen 3", 4, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "5", "731012-9018", "Sverige", "32145", "Södermanlands län", "Grums" },
                    { 35, "Björkvägen 3", 5, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.0, "webborder", "820624-3075", "Sverige", "32145", "Blekinge län", "Stockholm" },
                    { 61, "Björkvägen 3", 2, new DateTime(2020, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "690206-8769", "Sverige", "32145", "Blekinge län", "Arboga" },
                    { 62, "Björkvägen 3", 3, new DateTime(2020, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "750210-6008", "Sverige", "32145", "Blekinge län", "Arboga" },
                    { 36, "Järnvägsgatan 3", 5, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, "webborder", "841204-3830", "Sverige", "21345", "Dalarnas län", "Göteborg" },
                    { 65, "Björkvägen 3", 1, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "880706-3713", "Sverige", "32145", "Blekinge län", "Arboga" },
                    { 38, "Skolgatan 3", 4, new DateTime(2020, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.0, "webborder", "861110-5749", "Sverige", "12345", "Gävleborgs län", "Uppsala" },
                    { 39, "Skogsvägen 3", 6, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.0, "webborder", "880706-3713", "Sverige", "44223", "Hallands län", "Västerås" },
                    { 64, "Björkvägen 3", 5, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "880706-3713", "Sverige", "32145", "Blekinge län", "Arboga" },
                    { 25, "Industrigatan 3", 6, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "3", "690206-8769", "Sverige", "12345", "Skåne län", "Garphyttan" },
                    { 40, "Nygatan 3", 2, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, "webborder", "890701-1480", "Sverige", "21345", "Jämtlands län", "Alfta" },
                    { 41, "Granvägen 3", 3, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, "webborder", "910806-1370", "Sverige", "32145", "Jönköpings län", "Arjeplog" },
                    { 42, "Idrottsvägen 3", 2, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.0, "webborder", "921005-4598", "Sverige", "12345", "Kalmar län", "Arlöv" },
                    { 43, "Storgatan 3", 2, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, "webborder", "921110-8377", "Sverige", "32145", "Kronobergs län", "Färjestaden" },
                    { 44, "Kyrkvägen 3", 4, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, "webborder", "940406-2734", "Sverige", "12345", "Norrbottens län", "Garphyttan" },
                    { 45, "Industrigatan 3", 4, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, "webborder", "950527-6317", "Sverige", "44223", "Skåne län", "Gnosjö" },
                    { 46, "Parkvägen 3", 2, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, "webborder", "970602-8733", "Sverige", "21345", "Stockholms län", "Grums" },
                    { 47, "Strandvägen 3", 2, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.0, "webborder", "971220-1939", "Sverige", "44223", "Södermanlands län", "Grästorp" },
                    { 48, "Skolvägen 3", 4, new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.0, "webborder", "980128-9944", "Sverige", "12345", "Uppsala län", "Grästorp" },
                    { 37, "Ringvägen 3", 6, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.0, "webborder", "851126-2068", "Sverige", "44223", "Gotlands län", "Malmö" },
                    { 24, "Kyrkvägen 3", 1, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "4", "680820-7946", "Sverige", "21345", "Norrbottens län", "Färjestaden" },
                    { 20, "Nygatan 3", 2, new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "9", "630912-1175", "Sverige", "44223", "Jämtlands län", "Västerås" }
                });

            migrationBuilder.InsertData(
                table: "Ordrar",
                columns: new[] { "ID", "Adress", "ButikID", "Datum", "Fraktavgift", "FörsäljarId", "KundID", "Land", "Postnummer", "Region", "Stad" },
                values: new object[,]
                {
                    { 60, "Björkvägen 3", 5, new DateTime(2020, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "640912-6799", "Sverige", "32145", "Blekinge län", "Arboga" },
                    { 1, "Björkvägen 3", 3, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "500603-4268", "Sverige", "32145", "Blekinge län", "Arboga" },
                    { 54, "Björkvägen 3", 6, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "500603-4268", "Sverige", "32145", "Blekinge län", "Arboga" },
                    { 55, "Björkvägen 3", 2, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "500603-4268", "Sverige", "32145", "Blekinge län", "Arboga" },
                    { 2, "Järnvägsgatan 3", 3, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "2", "500607-6521", "Sverige", "21345", "Dalarnas län", "Stockholm" },
                    { 3, "Ringvägen 3", 2, new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "3", "530407-7989", "Sverige", "44223", "Gotlands län", "Göteborg" },
                    { 4, "Skolgatan 3", 5, new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "530720-7675", "Sverige", "12345", "Gävleborgs län", "Malmö" },
                    { 56, "Björkvägen 3", 4, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "530720-7675", "Sverige", "32145", "Blekinge län", "Arboga" },
                    { 5, "Skogsvägen 3", 6, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "9", "540430-4887", "Sverige", "44223", "Hallands län", "Uppsala" },
                    { 6, "Nygatan 3", 4, new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "8", "550930-7164", "Sverige", "21345", "Jämtlands län", "Västerås" },
                    { 7, "Granvägen 3", 3, new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "4", "561108-3389", "Sverige", "32145", "Jönköpings län", "Alfta" },
                    { 8, "Idrottsvägen 3", 4, new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "6", "570501-4924", "Sverige", "12345", "Kalmar län", "Arjeplog" },
                    { 9, "Storgatan 3", 3, new DateTime(2020, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "5", "571110-3843", "Sverige", "32145", "Kronobergs län", "Arlöv" },
                    { 10, "Kyrkvägen 3", 1, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "7", "580802-4175", "Sverige", "12345", "Norrbottens län", "Färjestaden" },
                    { 23, "Storgatan 3", 3, new DateTime(2020, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "7", "640913-5335", "Sverige", "21345", "Kronobergs län", "Arlöv" },
                    { 57, "Björkvägen 3", 1, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "580802-4175", "Sverige", "32145", "Blekinge län", "Arboga" },
                    { 12, "Parkvägen 3", 3, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "9", "591026-6645", "Sverige", "21345", "Stockholms län", "Gnosjö" },
                    { 13, "Strandvägen 3", 2, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "4", "600309-7687", "Sverige", "44223", "Södermanlands län", "Grums" },
                    { 14, "Skolvägen 3", 3, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "8", "601103-7655", "Sverige", "12345", "Uppsala län", "Grästorp" },
                    { 15, "Björkvägen 3", 4, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "620925-4245", "Sverige", "44223", "Blekinge län", "Arboga" },
                    { 58, "Björkvägen 3", 1, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "620925-4245", "Sverige", "32145", "Blekinge län", "Arboga" },
                    { 16, "Järnvägsgatan 3", 4, new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "2", "630129-6936", "Sverige", "12345", "Dalarnas län", "Stockholm" },
                    { 17, "Ringvägen 3", 3, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "3", "630303-4894", "Sverige", "21345", "Gotlands län", "Göteborg" },
                    { 18, "Skolgatan 3", 1, new DateTime(2020, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "2", "630309-2528", "Sverige", "44223", "Gävleborgs län", "Malmö" },
                    { 59, "Björkvägen 3", 6, new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", "630309-2528", "Sverige", "32145", "Blekinge län", "Arboga" },
                    { 19, "Skogsvägen 3", 2, new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "9", "630611-7069", "Sverige", "12345", "Hallands län", "Uppsala" },
                    { 49, "Björkvägen 3", 5, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.0, "webborder", "981003-1947", "Sverige", "44223", "Blekinge län", "Arboga" },
                    { 21, "Granvägen 3", 5, new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "8", "630929-1879", "Sverige", "32145", "Jönköpings län", "Alfta" },
                    { 22, "Idrottsvägen 3", 1, new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "5", "640912-6799", "Sverige", "12345", "Kalmar län", "Arjeplog" },
                    { 11, "Industrigatan 3", 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "3", "591007-1584", "Sverige", "44223", "Skåne län", "Garphyttan" },
                    { 50, "Järnvägsgatan 3", 5, new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 109.0, "webborder", "990130-1619", "Sverige", "12345", "Dalarnas län", "Stockholm" }
                });

            migrationBuilder.InsertData(
                table: "FörfattareBöcker_Junction",
                columns: new[] { "BokID", "FörfattareID" },
                values: new object[,]
                {
                    { "9789176910986", 2 },
                    { "9789100186364", 3 },
                    { "9789113096803", 2 },
                    { "9789179710125", 3 },
                    { "9780395647806", 4 },
                    { "9780395647806", 1 },
                    { "9780751564822", 2 },
                    { "9789127158672", 4 },
                    { "9781472154668", 1 },
                    { "9780751564822", 1 },
                    { "9789137154831", 1 },
                    { "9789127168169", 4 },
                });

            migrationBuilder.InsertData(
                table: "LagerSaldo",
                columns: new[] { "ButikID", "ISBN", "Antal" },
                values: new object[,]
                {
                    { 4, "9789100186364", 19 },
                    { 3, "9789100186364", 23 },
                    { 2, "9789100186364", 2 },
                    { 1, "9789100186364", 12 },
                    { 6, "9780751564822", 11 },
                    { 5, "9780751564822", 11 },
                    { 4, "9780751564822", 28 },
                    { 3, "9780751564822", 11 },
                    { 2, "9780751564822", 34 },
                    { 1, "9780751564822", 32 },
                    { 5, "9789100186364", 8 },
                    { 6, "9789127158672", 8 },
                    { 6, "9789127168169", 10 },
                    { 1, "9789179710125", 19 },
                    { 5, "9789127168169", 0 },
                    { 4, "9789127168169", 1 },
                    { 2, "9789179710125", 0 },
                    { 3, "9789127168169", 2 },
                    { 4, "9789179710125", 33 },
                    { 5, "9789179710125", 0 },
                    { 6, "9789179710125", 12 },
                    { 2, "9789127168169", 0 },
                    { 1, "9789127158672", 0 },
                    { 2, "9789127158672", 2 },
                    { 3, "9789127158672", 7 },
                    { 4, "9789127158672", 22 }
                });

            migrationBuilder.InsertData(
                table: "LagerSaldo",
                columns: new[] { "ButikID", "ISBN", "Antal" },
                values: new object[,]
                {
                    { 5, "9789127158672", 6 },
                    { 6, "9789100186364", 27 },
                    { 3, "9789179710125", 1 },
                    { 1, "9789127168169", 4 },
                    { 5, "9789176910986", 6 },
                    { 3, "9781472154668", 1 },
                    { 2, "9781472154668", 0 },
                    { 1, "9781472154668", 2 },
                    { 6, "9789137154831", 27 },
                    { 5, "9789137154831", 23 },
                    { 4, "9789137154831", 0 },
                    { 3, "9789137154831", 2 },
                    { 2, "9789137154831", 23 },
                    { 1, "9789137154831", 43 },
                    { 6, "9789176910986", 8 },
                    { 4, "9781472154668", 23 },
                    { 5, "9781472154668", 0 },
                    { 1, "9780395647806", 13 },
                    { 4, "9789176910986", 54 },
                    { 2, "9789176910986", 12 },
                    { 1, "9789176910986", 24 },
                    { 6, "9789113096803", 54 },
                    { 6, "9781472154668", 63 },
                    { 5, "9789113096803", 35 },
                    { 4, "9789113096803", 140 },
                    { 3, "9789113096803", 24 },
                    { 2, "9789113096803", 76 },
                    { 1, "9789113096803", 120 },
                    { 6, "9780395647806", 1 },
                    { 5, "9780395647806", 15 },
                    { 4, "9780395647806", 54 },
                    { 3, "9780395647806", 10 },
                    { 2, "9780395647806", 26 },
                    { 3, "9789176910986", 6 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetaljer",
                columns: new[] { "OrderID", "ProduktId", "ProduktAntal", "ProduktPris", "ProduktRabattProcent" },
                values: new object[,]
                {
                    { 33, "9780395647806", 1, 229.0, 0.0 },
                    { 35, "9789127168169", 1, 139.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetaljer",
                columns: new[] { "OrderID", "ProduktId", "ProduktAntal", "ProduktPris", "ProduktRabattProcent" },
                values: new object[,]
                {
                    { 35, "9789127158672", 1, 289.0, 0.0 },
                    { 63, "9789179710125", 1, 139.0, 0.0 },
                    { 34, "9780395647806", 5, 229.0, 0.20000000000000001 },
                    { 32, "9789176910986", 1, 95.0, 0.0 },
                    { 26, "9789137154831", 1, 149.0, 0.0 },
                    { 30, "9789100186364", 1, 49.0, 0.0 },
                    { 62, "9781472154668", 1, 139.0, 0.0 },
                    { 29, "9780751564822", 1, 139.0, 0.0 },
                    { 28, "9780395647806", 1, 229.0, 0.0 },
                    { 27, "9789179710125", 1, 239.0, 0.0 },
                    { 61, "9789179710125", 1, 139.0, 0.0 },
                    { 31, "9789176910986", 1, 95.0, 0.0 },
                    { 36, "9789100186364", 1, 49.0, 0.0 },
                    { 40, "9789127168169", 4, 229.0, 0.0 },
                    { 38, "9789137154831", 1, 149.0, 0.0 },
                    { 48, "9789179710125", 1, 239.0, 0.089999999999999997 },
                    { 25, "9780395647806", 1, 229.0, 0.20000000000000001 },
                    { 48, "9789127158672", 1, 139.0, 0.0 },
                    { 47, "9781472154668", 1, 169.0, 0.0 },
                    { 46, "9789127168169", 1, 229.0, 0.0 },
                    { 45, "9789127168169", 2, 229.0, 0.0 },
                    { 44, "9789127168169", 1, 229.0, 0.089999999999999997 },
                    { 43, "9789100186364", 1, 49.0, 0.0 },
                    { 42, "9789127158672", 1, 289.0, 0.0 },
                    { 41, "9789127168169", 1, 229.0, 0.0 },
                    { 65, "9789179710125", 1, 139.0, 0.0 },
                    { 65, "9780395647806", 1, 139.0, 0.0 },
                    { 64, "9789179710125", 1, 139.0, 0.0 },
                    { 64, "9780395647806", 1, 139.0, 0.0 },
                    { 39, "9780751564822", 1, 139.0, 0.0 },
                    { 37, "9789100186364", 1, 49.0, 0.0 },
                    { 24, "9789127158672", 1, 289.0, 0.0 },
                    { 11, "9789100186364", 2, 49.0, 0.0 },
                    { 60, "9789179710125", 1, 139.0, 0.0 },
                    { 8, "9781472154668", 1, 169.0, 0.0 },
                    { 7, "9780751564822", 1, 139.0, 0.0 },
                    { 6, "9780395647806", 1, 229.0, 0.0 },
                    { 5, "9789127168169", 1, 229.0, 0.0 },
                    { 56, "9789137154831", 1, 139.0, 0.0 },
                    { 56, "9789127158672", 1, 139.0, 0.0 },
                    { 8, "9789137154831", 1, 139.0, 0.0 },
                    { 4, "9789100186364", 1, 139.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetaljer",
                columns: new[] { "OrderID", "ProduktId", "ProduktAntal", "ProduktPris", "ProduktRabattProcent" },
                values: new object[,]
                {
                    { 3, "9789100186364", 1, 49.0, 0.0 },
                    { 2, "9789137154831", 2, 149.0, 0.0 },
                    { 55, "9789113096803", 1, 139.0, 0.0 },
                    { 54, "9789100186364", 1, 139.0, 0.0 },
                    { 1, "9780395647806", 1, 229.0, 0.0 },
                    { 49, "9781472154668", 1, 169.0, 0.0 },
                    { 4, "9780751564822", 1, 139.0, 0.0 },
                    { 9, "9789137154831", 1, 149.0, 0.0 },
                    { 10, "9789100186364", 2, 49.0, 0.0 },
                    { 57, "9789127168169", 1, 139.0, 0.0 },
                    { 22, "9789179710125", 1, 139.0, 0.0 },
                    { 22, "9780751564822", 1, 139.0, 0.20000000000000001 },
                    { 21, "9780751564822", 1, 139.0, 0.0 },
                    { 20, "9789127158672", 1, 289.0, 0.0 },
                    { 19, "9780751564822", 1, 139.0, 0.0 },
                    { 59, "9789176910986", 1, 139.0, 0.0 },
                    { 18, "9780395647806", 1, 229.0, 0.0 },
                    { 17, "9789100186364", 1, 49.0, 0.0 },
                    { 16, "9789113096803", 1, 49.0, 0.0 },
                    { 58, "9789137154831", 1, 139.0, 0.0 },
                    { 15, "9789137154831", 1, 149.0, 0.0 },
                    { 15, "9789113096803", 1, 139.0, 0.0 },
                    { 14, "9789113096803", 1, 49.0, 0.0 },
                    { 13, "9789137154831", 1, 149.0, 0.0 },
                    { 12, "9789179710125", 1, 239.0, 0.20000000000000001 },
                    { 23, "9780395647806", 1, 229.0, 0.0 },
                    { 50, "9780395647806", 1, 229.0, 0.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DeleteData(
                table: "FörfattareBöcker_Junction",
                keyColumns: new[] { "BokID", "FörfattareID" },
                keyValues: new object[] { "9780395647806", 1 });

            migrationBuilder.DeleteData(
                table: "FörfattareBöcker_Junction",
                keyColumns: new[] { "BokID", "FörfattareID" },
                keyValues: new object[] { "9780751564822", 1 });

            migrationBuilder.DeleteData(
                table: "FörfattareBöcker_Junction",
                keyColumns: new[] { "BokID", "FörfattareID" },
                keyValues: new object[] { "9781472154668", 1 });

            migrationBuilder.DeleteData(
                table: "FörfattareBöcker_Junction",
                keyColumns: new[] { "BokID", "FörfattareID" },
                keyValues: new object[] { "9789137154831", 1 });


            migrationBuilder.DeleteData(
                table: "FörfattareBöcker_Junction",
                keyColumns: new[] { "BokID", "FörfattareID" },
                keyValues: new object[] { "9780751564822", 2 });

            migrationBuilder.DeleteData(
                table: "FörfattareBöcker_Junction",
                keyColumns: new[] { "BokID", "FörfattareID" },
                keyValues: new object[] { "9789113096803", 2 });

            migrationBuilder.DeleteData(
                table: "FörfattareBöcker_Junction",
                keyColumns: new[] { "BokID", "FörfattareID" },
                keyValues: new object[] { "9789176910986", 2 });

            migrationBuilder.DeleteData(
                table: "FörfattareBöcker_Junction",
                keyColumns: new[] { "BokID", "FörfattareID" },
                keyValues: new object[] { "9789100186364", 3 });

            migrationBuilder.DeleteData(
                table: "FörfattareBöcker_Junction",
                keyColumns: new[] { "BokID", "FörfattareID" },
                keyValues: new object[] { "9789179710125", 3 });

            migrationBuilder.DeleteData(
                table: "FörfattareBöcker_Junction",
                keyColumns: new[] { "BokID", "FörfattareID" },
                keyValues: new object[] { "9780395647806", 4 });

            migrationBuilder.DeleteData(
                table: "FörfattareBöcker_Junction",
                keyColumns: new[] { "BokID", "FörfattareID" },
                keyValues: new object[] { "9789127158672", 4 });

            migrationBuilder.DeleteData(
                table: "FörfattareBöcker_Junction",
                keyColumns: new[] { "BokID", "FörfattareID" },
                keyValues: new object[] { "9789127168169", 4 });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 1, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 1, "9780751564822" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 1, "9781472154668" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 1, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 1, "9789113096803" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 1, "9789127158672" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 1, "9789127168169" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 1, "9789137154831" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 1, "9789176910986" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 1, "9789179710125" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 2, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 2, "9780751564822" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 2, "9781472154668" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 2, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 2, "9789113096803" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 2, "9789127158672" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 2, "9789127168169" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 2, "9789137154831" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 2, "9789176910986" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 2, "9789179710125" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 3, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 3, "9780751564822" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 3, "9781472154668" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 3, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 3, "9789113096803" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 3, "9789127158672" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 3, "9789127168169" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 3, "9789137154831" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 3, "9789176910986" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 3, "9789179710125" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 4, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 4, "9780751564822" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 4, "9781472154668" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 4, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 4, "9789113096803" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 4, "9789127158672" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 4, "9789127168169" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 4, "9789137154831" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 4, "9789176910986" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 4, "9789179710125" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 5, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 5, "9780751564822" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 5, "9781472154668" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 5, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 5, "9789113096803" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 5, "9789127158672" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 5, "9789127168169" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 5, "9789137154831" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 5, "9789176910986" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 5, "9789179710125" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 6, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 6, "9780751564822" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 6, "9781472154668" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 6, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 6, "9789113096803" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 6, "9789127158672" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 6, "9789127168169" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 6, "9789137154831" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 6, "9789176910986" });

            migrationBuilder.DeleteData(
                table: "LagerSaldo",
                keyColumns: new[] { "ButikID", "ISBN" },
                keyValues: new object[] { 6, "9789179710125" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 1, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 6, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 18, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 23, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 25, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 28, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 33, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 34, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 50, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 64, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 65, "9780395647806" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 4, "9780751564822" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 7, "9780751564822" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 19, "9780751564822" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 21, "9780751564822" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 22, "9780751564822" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 29, "9780751564822" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 39, "9780751564822" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 8, "9781472154668" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 47, "9781472154668" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 49, "9781472154668" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 62, "9781472154668" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 3, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 4, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 10, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 11, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 17, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 30, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 36, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 37, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 43, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 54, "9789100186364" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 14, "9789113096803" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 15, "9789113096803" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 16, "9789113096803" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 55, "9789113096803" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 20, "9789127158672" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 24, "9789127158672" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 35, "9789127158672" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 42, "9789127158672" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 48, "9789127158672" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 56, "9789127158672" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 5, "9789127168169" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 35, "9789127168169" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 40, "9789127168169" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 41, "9789127168169" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 44, "9789127168169" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 45, "9789127168169" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 46, "9789127168169" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 57, "9789127168169" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 2, "9789137154831" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 8, "9789137154831" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 9, "9789137154831" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 13, "9789137154831" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 15, "9789137154831" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 26, "9789137154831" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 38, "9789137154831" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 56, "9789137154831" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 58, "9789137154831" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 31, "9789176910986" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 32, "9789176910986" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 59, "9789176910986" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 12, "9789179710125" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 22, "9789179710125" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 27, "9789179710125" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 48, "9789179710125" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 60, "9789179710125" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 61, "9789179710125" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 63, "9789179710125" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 64, "9789179710125" });

            migrationBuilder.DeleteData(
                table: "OrderDetaljer",
                keyColumns: new[] { "OrderID", "ProduktId" },
                keyValues: new object[] { 65, "9789179710125" });

            migrationBuilder.DeleteData(
                table: "Böcker",
                keyColumn: "ISBN13",
                keyValue: "9780395647806");

            migrationBuilder.DeleteData(
                table: "Böcker",
                keyColumn: "ISBN13",
                keyValue: "9780751564822");

            migrationBuilder.DeleteData(
                table: "Böcker",
                keyColumn: "ISBN13",
                keyValue: "9781472154668");

            migrationBuilder.DeleteData(
                table: "Böcker",
                keyColumn: "ISBN13",
                keyValue: "9789100186364");

            migrationBuilder.DeleteData(
                table: "Böcker",
                keyColumn: "ISBN13",
                keyValue: "9789113096803");

            migrationBuilder.DeleteData(
                table: "Böcker",
                keyColumn: "ISBN13",
                keyValue: "9789127158672");

            migrationBuilder.DeleteData(
                table: "Böcker",
                keyColumn: "ISBN13",
                keyValue: "9789127168169");

            migrationBuilder.DeleteData(
                table: "Böcker",
                keyColumn: "ISBN13",
                keyValue: "9789137154831");

            migrationBuilder.DeleteData(
                table: "Böcker",
                keyColumn: "ISBN13",
                keyValue: "9789176910986");

            migrationBuilder.DeleteData(
                table: "Böcker",
                keyColumn: "ISBN13",
                keyValue: "9789179710125");

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Butiker",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Butiker",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Butiker",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Butiker",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Butiker",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Butiker",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Förlag",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Förlag",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Förlag",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Förlag",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Förlag",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Förlag",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Förlag",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Förlag",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Förlag",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "500603-4268");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "500607-6521");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "530407-7989");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "530720-7675");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "540430-4887");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "550930-7164");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "561108-3389");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "570501-4924");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "571110-3843");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "580802-4175");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "591007-1584");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "591026-6645");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "600309-7687");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "601103-7655");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "620925-4245");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "630129-6936");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "630303-4894");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "630309-2528");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "630611-7069");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "630912-1175");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "630929-1879");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "640912-6799");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "640913-5335");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "680820-7946");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "690206-8769");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "720524-3728");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "731012-9018");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "741109-2058");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "750210-6008");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "751123-9724");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "770422-8188");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "800512-6752");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "801022-4516");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "811008-5301");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "820624-3075");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "841204-3830");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "851126-2068");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "861110-5749");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "880706-3713");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "890701-1480");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "910806-1370");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "921005-4598");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "921110-8377");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "940406-2734");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "950527-6317");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "970602-8733");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "971220-1939");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "980128-9944");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "981003-1947");

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "ID",
                keyValue: "990130-1619");
        }
    }
}
