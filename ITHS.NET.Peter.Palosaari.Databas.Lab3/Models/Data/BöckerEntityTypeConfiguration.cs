using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public class BöckerEntityTypeConfiguration : IEntityTypeConfiguration<Böcker>
    {
        public void Configure(EntityTypeBuilder<Böcker> builder)
        {
            builder.HasKey(e => e.Isbn13);

            builder.ToTable("Böcker");

            builder.Property(e => e.Isbn13)
                .HasMaxLength(13)
                .HasColumnName("ISBN13");

            builder.Property(e => e.FörlagId).HasColumnName("FörlagID");

            builder.Property(e => e.Pris).HasColumnType("decimal(9, 2)");

            builder.Property(e => e.Språk).HasMaxLength(20);

            builder.Property(e => e.Titel).HasMaxLength(100);

            builder.Property(e => e.Utgivningsdatum)
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.HasOne(d => d.Förlag)
                .WithMany(p => p.Böcker)
                .HasForeignKey(d => d.FörlagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Böcker_Förlag");

            builder.HasData(
                new Böcker() { Isbn13 = "9780395647806", Titel = "Cry of the Kalahari", Språk = "Engelska", Pris = Convert.ToDecimal(229.00), Utgivningsdatum = DateTime.Parse("1993-06-01 00:00:00"), FörlagId = 3 },
                new Böcker() { Isbn13 = "9780751564822", Titel = "The Endless Beach", Språk = "Engelska", Pris = Convert.ToDecimal(139.00), Utgivningsdatum = DateTime.Parse("2018-01-11 00:00:00"), FörlagId = 6 },
                new Böcker() { Isbn13 = "9781472154668", Titel = "Where the Crawdads Sing", Språk = "Engelska", Pris = Convert.ToDecimal(169.00), Utgivningsdatum = DateTime.Parse("2019-12-12 00:00:00"), FörlagId = 2 },
                new Böcker() { Isbn13 = "9789100186364", Titel = "Ödesmark", Språk = "Svenska", Pris = Convert.ToDecimal(49.00), Utgivningsdatum = DateTime.Parse("2020-12-01 00:00:00"), FörlagId = 7 },
                new Böcker() { Isbn13 = "9789113096803", Titel = "Julafton på den lilla ön i havet", Språk = "Svenska", Pris = Convert.ToDecimal(49.00), Utgivningsdatum = DateTime.Parse("2020-10-14 00:00:00"), FörlagId = 4 },
                new Böcker() { Isbn13 = "9789127158672", Titel = "Soppa, potage & buljong", Språk = "Svenska", Pris = Convert.ToDecimal(289.00), Utgivningsdatum = DateTime.Parse("2018-09-22 00:00:00"), FörlagId = 9 },
                new Böcker() { Isbn13 = "9789127168169", Titel = "Myllymäkis menyer : vår, sommar, höst, vinter", Språk = "Svenska", Pris = Convert.ToDecimal(229.00), Utgivningsdatum = DateTime.Parse("2020-11-06 00:00:00"), FörlagId = 9 },
                new Böcker() { Isbn13 = "9789137154831", Titel = "Där kräftorna sjunger", Språk = "Svenska", Pris = Convert.ToDecimal(149.00), Utgivningsdatum = DateTime.Parse("2020-04-29 00:00:00"), FörlagId = 1 },
                new Böcker() { Isbn13 = "9789176910986", Titel = "Jul i det lilla bageriet på strandpromenaden", Språk = "Svenska", Pris = Convert.ToDecimal(95.00), Utgivningsdatum = DateTime.Parse("2017-10-18 00:00:00"), FörlagId = 5 },
                new Böcker() { Isbn13 = "9789179710125", Titel = "Silvervägen (lättläst)", Språk = "Svenska", Pris = Convert.ToDecimal(239.00), Utgivningsdatum = DateTime.Parse("2020-08-12 00:00:00"), FörlagId = 8 }
            );
        }
    }
}
