using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public class FörlagEntityTypeConfiguration : IEntityTypeConfiguration<Förlag>
    {
        public void Configure(EntityTypeBuilder<Förlag> builder)
        {
            builder.ToTable("Förlag");

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.Beskrivning).HasMaxLength(200);

            builder.Property(e => e.Epost).HasMaxLength(50);

            builder.Property(e => e.Namn).HasMaxLength(30);

            builder.Property(e => e.Telefonnummer).HasMaxLength(20);

            builder.HasData(
            new Förlag() { Id = 1, Namn = "Bokförlaget Forum", Beskrivning = "Bokförlaget Forum (Swedish: Forum bokförlag) is a Swedish publishing company and a member of Bonnierförlagen, a publishing house within Bonnier Books Nordic.", Telefonnummer = "08-696 84 40", Epost = "info@forum.se" },
            new Förlag() { Id = 2, Namn = "Little, Brown & Company", Beskrivning = "Little, Brown and Company is an American publisher founded in 1837 by Charles Coffin Little and his partner, James Brown.", Telefonnummer = "001617-227-0730", Epost = "na@na" },
            new Förlag() { Id = 3, Namn = "Houghton Mifflin (Trade)", Beskrivning = "Little, Brown and Company is an American publisher founded in 1837 by Charles Coffin Little and his partner, James Brown.", Telefonnummer = "-", Epost = "leah.petrakis@hmhco.com" },
            new Förlag() { Id = 4, Namn = "Norstedts Förlag", Beskrivning = "Norstedts Förlagsgrupp AB är en svensk koncern av bokförlag. Norstedts förlag är Sveriges äldsta ännu verksamma bokförlag och ett av Sveriges största.", Telefonnummer = "08-769 89 00", Epost = "order@norstedts.se" },
            new Förlag() { Id = 5, Namn = "Massolit Förlag", Beskrivning = "Massolit förlag är ett svenskt bokförlag som grundades 2010 av Stefan Tegenfalk och Johannes Källström. Massolit ingår i Norstedts Förlagsgrupp.", Telefonnummer = "08-769 89 00", Epost = "order@norstedts.se" },
            new Förlag() { Id = 6, Namn = "Hachette Book Group UK", Beskrivning = "Hachette Book Group (HBG) is a publishing company owned by Hachette Livre, the largest publishing company in France.", Telefonnummer = "001800-759-0190", Epost = "customer.service@hbgusa.com" },
            new Förlag() { Id = 7, Namn = "Albert Bonniers Förlag", Beskrivning = "Albert Bonniers Förlag, ibland omnämnt som Bonniers,[1] grundades 1837 av Albert Bonnier (1820–1900). Det är ett av de äldsta förlagen i Sverige.", Telefonnummer = "08 696 86 20", Epost = "info@albertbonniers.se" },
            new Förlag() { Id = 8, Namn = "Bokförlaget Hedvig", Beskrivning = "Hedvig vill vara läsarens bästa vän. Därför ger vi ut läsvänliga böcker för barn och vuxna som har lässvårigheter.", Telefonnummer = "08-696 80 00", Epost = "hej@bokforlagethedvig.se" },
            new Förlag() { Id = 9, Namn = "Natur & Kultur", Beskrivning = "Natur & Kultur (NoK) är ett svenskt bokförlag grundat 1922. Förlaget har en omfattande utgivning av läromedel och allmänlitteratur.", Telefonnummer = "08-453 86 00", Epost = " info@nok.se" }
            );

        }
    }
}
