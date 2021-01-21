using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public class KunderEntityTypeConfiguration : IEntityTypeConfiguration<Kunder>
    {
        public void Configure(EntityTypeBuilder<Kunder> builder)
        {
            builder.ToTable("Kunder");

            builder.Property(e => e.Id)
                .HasMaxLength(11)
                .HasColumnName("ID");

            builder.Property(e => e.Användarnamn).HasMaxLength(6);

            builder.Property(e => e.Efternamn).HasMaxLength(20);

            builder.Property(e => e.Epost).HasMaxLength(100);

            builder.Property(e => e.Förnamn).HasMaxLength(20);

            builder.Property(e => e.Lösenord).HasMaxLength(100);

            builder.Property(e => e.Telefonnummer).HasMaxLength(20);

            builder.HasData(
            new Kunder() { Id = "500603-4268", Användarnamn = "johlen", Lösenord = "422cf6c6f212dde0fa96c532de240104", Förnamn = "Johanna", Efternamn = "Lennartsson", Epost = "johanna.lennartsson@gmail.com", Telefonnummer = "070-9428041" },
            new Kunder() { Id = "500607-6521", Användarnamn = "catknu", Lösenord = "c5aa65949d20f6b20e1a922c13d974e7", Förnamn = "Catharina", Efternamn = "Knutson", Epost = "catharina.knutson@yahoo.com", Telefonnummer = "0702-3351252" },
            new Kunder() { Id = "530407-7989", Användarnamn = "ullalv", Lösenord = "4fec58181bb416f09f8ef0f69433584f", Förnamn = "Ulla", Efternamn = "Alvarsson", Epost = "ulla.alvarsson@hotmail.com", Telefonnummer = "070-9922357" },
            new Kunder() { Id = "530720-7675", Användarnamn = "alvlin", Lösenord = "2194506fc6ef7a2048f03a0f4ee7c641", Förnamn = "Alvin", Efternamn = "Lindholm", Epost = "alvin.lindholm@gmail.com", Telefonnummer = "0701-6100069" },
            new Kunder() { Id = "540430-4887", Användarnamn = "milalb", Lösenord = "3047ee053d45323e65192012176a2a1c", Förnamn = "Milla", Efternamn = "Albertsson", Epost = "milla.albertsson@gmail.com", Telefonnummer = "0702-4265981" },
            new Kunder() { Id = "550930-7164", Användarnamn = "mymard", Lösenord = "3587f76616df673c64f36e1d8babc2e7", Förnamn = "My", Efternamn = "Mårdh", Epost = "my.mardh@yahoo.com", Telefonnummer = "0701-7763403" },
            new Kunder() { Id = "561108-3389", Användarnamn = "vilmat", Lösenord = "aa426df08f79c27a95d70a496a69759c", Förnamn = "Vilhelmina", Efternamn = "Matsson", Epost = "vilhelmina.matsson@hotmail.com", Telefonnummer = "0701-8262655" },
            new Kunder() { Id = "570501-4924", Användarnamn = "monsol", Lösenord = "c1de2111b16e6b21b794451fe54ef86f", Förnamn = "Mona", Efternamn = "Solberg", Epost = "mona.solberg@yahoo.com", Telefonnummer = "070-9254810" },
            new Kunder() { Id = "571110-3843", Användarnamn = "frieri", Lösenord = "7a981e17886344fb031e3735a7284b8c", Förnamn = "Frida", Efternamn = "Ericson", Epost = "frida.ericson@hotmail.com", Telefonnummer = "0702-8579941" },
            new Kunder() { Id = "580802-4175", Användarnamn = "sigpet", Lösenord = "67b48cc32ab9f04633bd50656a4a26fc", Förnamn = "Sigge", Efternamn = "Pethrus", Epost = "sigge.pethrus@gmail.com", Telefonnummer = "073-1923116" },
            new Kunder() { Id = "591007-1584", Användarnamn = "henblo", Lösenord = "0dd81a42714c6fe8bd670804643b458d", Förnamn = "Henrietta", Efternamn = "Blomgren", Epost = "henrietta.blomgren@hotmail.com", Telefonnummer = "0702-140965" },
            new Kunder() { Id = "591026-6645", Användarnamn = "jancla", Lösenord = "3e53ae683f8e8c84221db763b30fe907", Förnamn = "Jannike", Efternamn = "Claesson", Epost = "jannike.claesson@telia.se", Telefonnummer = "0701-4033966" },
            new Kunder() { Id = "600309-7687", Användarnamn = "gunmik", Lösenord = "07c09ba3a403585b6c93f73d03983079", Förnamn = "Gunnel", Efternamn = "Mikaelsson", Epost = "gunnel.mikaelsson@hotmail.com", Telefonnummer = "073-5093738" },
            new Kunder() { Id = "601103-7655", Användarnamn = "bjowal", Lösenord = "7e9a21b78e3723bde67627aa095f98fd", Förnamn = "Bjoern", Efternamn = "Waltersson", Epost = "bjoern.waltersson@gmail.com", Telefonnummer = "073-7811105" },
            new Kunder() { Id = "620925-4245", Användarnamn = "annber", Lösenord = "2c3339f366a420eb04c6b6c21b7746bf", Förnamn = "Annette", Efternamn = "Bergfalk", Epost = "annette.bergfalk@telia.se", Telefonnummer = "0702-7855547" },
            new Kunder() { Id = "630129-6936", Användarnamn = "valgra", Lösenord = "6c01156a337cb1e4748f3567bdeff63c", Förnamn = "Valdemar", Efternamn = "Grahn", Epost = "valdemar.grahn@gmail.com", Telefonnummer = "070-1531320" },
            new Kunder() { Id = "630303-4894", Användarnamn = "sigpet", Lösenord = "1bf3fa859c48493f5f2606ccaaa0f20e", Förnamn = "Sigfrid", Efternamn = "Petersson", Epost = "sigfrid.petersson@yahoo.com", Telefonnummer = "0701-9399564" },
            new Kunder() { Id = "630309-2528", Användarnamn = "virlju", Lösenord = "72cd11da65daac3c9e75ee19f93eb0dd", Förnamn = "Virginia", Efternamn = "Ljungman", Epost = "virginia.ljungman@hotmail.com", Telefonnummer = "073-9485514" },
            new Kunder() { Id = "630611-7069", Användarnamn = "hjowan", Lösenord = "bb31bb1b1b3b1900fa619d1a7e3ebb92", Förnamn = "Hjördis", Efternamn = "Wang", Epost = "hjordis.wang@hotmail.com", Telefonnummer = "073-8899553" },
            new Kunder() { Id = "630912-1175", Användarnamn = "vigsor", Lösenord = "741adf496ee8c2d3e8c864e9567211af", Förnamn = "Viggo", Efternamn = "Sorenson", Epost = "viggo.sorenson@gmail.com", Telefonnummer = "0701-1921858" },
            new Kunder() { Id = "630929-1879", Användarnamn = "bensve", Lösenord = "06af2e43797e629c5a4c7bfe58a105c3", Förnamn = "Bengt", Efternamn = "Svenson", Epost = "bengt.svenson@yahoo.com", Telefonnummer = "073-8906035" },
            new Kunder() { Id = "640912-6799", Användarnamn = "ebbwes", Lösenord = "436c26abd464041efd354bc550f76482", Förnamn = "Ebbe", Efternamn = "Westerberg", Epost = "ebbe.westerberg@gmail.com", Telefonnummer = "0701-1931783" },
            new Kunder() { Id = "640913-5335", Användarnamn = "trumat", Lösenord = "195d221c982e47eb58347e5d06ce3180", Förnamn = "Truls", Efternamn = "Matsson", Epost = "truls.matsson@hotmail.com", Telefonnummer = "073-5454387" },
            new Kunder() { Id = "680820-7946", Användarnamn = "chasor", Lösenord = "0bc22e1c47f26addd1907b4931e507b1", Förnamn = "Charlotte", Efternamn = "Sörensen", Epost = "charlotte.sorensen@yahoo.com", Telefonnummer = "070-6751319" },
            new Kunder() { Id = "690206-8769", Användarnamn = "solbor", Lösenord = "d6cb41a908909feead800375f0e96b04", Förnamn = "Solvig", Efternamn = "Borg", Epost = "solvig.borg@hotmail.com", Telefonnummer = "0702-1110436" },
            new Kunder() { Id = "720524-3728", Användarnamn = "svesol", Lösenord = "47551f847eb553f2600d124fdfd03730", Förnamn = "Svea", Efternamn = "Solberg", Epost = "svea.solberg@hotmail.com", Telefonnummer = "0702-5177172" },
            new Kunder() { Id = "731012-9018", Användarnamn = "gusber", Lösenord = "bbc595e205a865a6afd9a8584f319f3b", Förnamn = "Gustav", Efternamn = "Berg", Epost = "gustav.berg@hotmail.com", Telefonnummer = "0701-1998079" },
            new Kunder() { Id = "741109-2058", Användarnamn = "aledah", Lösenord = "425e618ba6834cdff3e5235a648d7a49", Förnamn = "Alexander", Efternamn = "Dahl", Epost = "alexander.dahl@telia.se", Telefonnummer = "073-2172719" },
            new Kunder() { Id = "750210-6008", Användarnamn = "beamol", Lösenord = "85267d349a5e647ff0a9edcb5ffd1e02", Förnamn = "Beata", Efternamn = "Möller", Epost = "beata.moller@hotmail.com", Telefonnummer = "070-3737944" },
            new Kunder() { Id = "751123-9724", Användarnamn = "annake", Lösenord = "ebf12cb74e96e67e63783d93c534ef27", Förnamn = "Anne", Efternamn = "Åkerman", Epost = "anne.akerman@hotmail.com", Telefonnummer = "073-2485110" },
            new Kunder() { Id = "770422-8188", Användarnamn = "maliek", Lösenord = "0866b954204f6576dcf4c59af968f2eb", Förnamn = "Malin", Efternamn = "Ek", Epost = "malin.ek@telia.se", Telefonnummer = "0701-1212603" },
            new Kunder() { Id = "800512-6752", Användarnamn = "raneri", Lösenord = "5128811422870279d063413608e0bc4b", Förnamn = "Randi", Efternamn = "Eriksson", Epost = "randi.eriksson@gmail.com", Telefonnummer = "0702-8501636" },
            new Kunder() { Id = "801022-4516", Användarnamn = "antrag", Lösenord = "bd50f363001990ee1fe5d798702b1d5b", Förnamn = "Anton", Efternamn = "Ragnvaldsson", Epost = "anton.ragnvaldsson@gmail.com", Telefonnummer = "070-633579" },
            new Kunder() { Id = "811008-5301", Användarnamn = "sigpet", Lösenord = "0f70d19c41c092696766a57abe1b4266", Förnamn = "Sigrid", Efternamn = "Pettersson", Epost = "sigrid.pettersson@gmail.com", Telefonnummer = "073-1536205" },
            new Kunder() { Id = "820624-3075", Användarnamn = "andhan", Lösenord = "f82e0b0c45c7babe84db897066335590", Förnamn = "Anders", Efternamn = "Hansson", Epost = "anders.hansson@hotmail.com", Telefonnummer = "073-3519746" },
            new Kunder() { Id = "841204-3830", Användarnamn = "kajing", Lösenord = "7a0c99ef914f596a9d745df32a9c84dd", Förnamn = "Kaj", Efternamn = "Ingesson", Epost = "kaj.ingesson@gmail.com", Telefonnummer = "073-8740881" },
            new Kunder() { Id = "851126-2068", Användarnamn = "elivan", Lösenord = "ecd058faafa18f55f81d730b142f8fd3", Förnamn = "Elisabeth", Efternamn = "Vång", Epost = "elisabeth.vang@hotmail.com", Telefonnummer = "073-1423995" },
            new Kunder() { Id = "861110-5749", Användarnamn = "rakalb", Lösenord = "df132656c11853d6118fe9d36eaba5e1", Förnamn = "Rakel", Efternamn = "Albertsson", Epost = "rakel.albertsson@yahoo.com", Telefonnummer = "070-7753662" },
            new Kunder() { Id = "880706-3713", Användarnamn = "felber", Lösenord = "3e016029eeb9a92852a656f33fbf1dc6", Förnamn = "Felix", Efternamn = "Berglund", Epost = "felix.berglund@telia.se", Telefonnummer = "0701-608431" },
            new Kunder() { Id = "890701-1480", Användarnamn = "felber", Lösenord = "03cafe742c11ddc94bff251c842b7f67", Förnamn = "Felicia", Efternamn = "Bertilsson", Epost = "felicia.bertilsson@yahoo.com", Telefonnummer = "0702-82374" },
            new Kunder() { Id = "910806-1370", Användarnamn = "petmol", Lösenord = "9ef248df74556f4768271660f5ef5f7b", Förnamn = "Petter", Efternamn = "Möller", Epost = "petter.moller@yahoo.com", Telefonnummer = "073-3383188" },
            new Kunder() { Id = "921005-4598", Användarnamn = "karlun", Lösenord = "e26ebd564a492f55c8ceed4d97c5fedb", Förnamn = "Kåre", Efternamn = "Lundberg", Epost = "kare.lundberg@yahoo.com", Telefonnummer = "0702-5836648" },
            new Kunder() { Id = "921110-8377", Användarnamn = "edvalf", Lösenord = "9d4e5ea4418508b6a23445e3089f4898", Förnamn = "Edvin", Efternamn = "Alfsson", Epost = "edvin.alfsson@yahoo.com", Telefonnummer = "073-3922225" },
            new Kunder() { Id = "940406-2734", Användarnamn = "sighal", Lösenord = "20bb93fcb37c7ec9be51cf792d5c9609", Förnamn = "Sigfrid", Efternamn = "Hall", Epost = "sigfrid.hall@gmail.com", Telefonnummer = "0701-8841184" },
            new Kunder() { Id = "950527-6317", Användarnamn = "artbjo", Lösenord = "5b2b2d2bd0cd2c7a7019d2c2a7c6307a", Förnamn = "Arthur", Efternamn = "Björk", Epost = "arthur.bjork@telia.se", Telefonnummer = "073-4539000" },
            new Kunder() { Id = "970602-8733", Användarnamn = "petlju", Lösenord = "9323f21f2098b7288267c785458548b2", Förnamn = "Peter", Efternamn = "Ljungstrand", Epost = "peter.ljungstrand@hotmail.com", Telefonnummer = "0702-4432102" },
            new Kunder() { Id = "971220-1939", Användarnamn = "gorpat", Lösenord = "fc14f949c1baf821079b6e2b9b22f553", Förnamn = "Göran", Efternamn = "Patriksson", Epost = "goran.patriksson@hotmail.com", Telefonnummer = "0702-7294060" },
            new Kunder() { Id = "980128-9944", Användarnamn = "careng", Lösenord = "6a5889bb0190d0211a991f47bb19a777", Förnamn = "Caroline", Efternamn = "Engström", Epost = "caroline.engstrom@yahoo.com", Telefonnummer = "070-8674341" },
            new Kunder() { Id = "981003-1947", Användarnamn = "ketber", Lösenord = "90918c5b8c17f80e32d5b155a7bf6197", Förnamn = "Kettil", Efternamn = "Bergfalk", Epost = "kettil.bergfalk@yahoo.com", Telefonnummer = "070-2076573" },
            new Kunder() { Id = "990130-1619", Användarnamn = "lenoma", Lösenord = "744878fbdd26871c594f57ca61733e09", Förnamn = "Lennart", Efternamn = "Öman", Epost = "lennart.oman@yahoo.com", Telefonnummer = "070-6672001" }
            );

        }
    }
}
