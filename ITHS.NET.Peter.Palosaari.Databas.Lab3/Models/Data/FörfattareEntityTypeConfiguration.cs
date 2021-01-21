using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public class FörfattareEntityTypeConfiguration : IEntityTypeConfiguration<Författare>
    {
        public void Configure(EntityTypeBuilder<Författare> builder)
        {
            builder.ToTable("Författare");

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.Efternamn).HasMaxLength(25);

            builder.Property(e => e.Födelsedatum)
                    .HasMaxLength(10)
                    .IsUnicode(false);

            builder.Property(e => e.Förnamn).HasMaxLength(25);

            builder.HasData(
                new Författare() { Id = 1, Förnamn = "Delia", Efternamn = "Owens", Födelsedatum = DateTime.Parse("1949-04-04 00:00:00") },
                new Författare() { Id = 2, Förnamn = "Jenny", Efternamn = "Colgan", Födelsedatum = DateTime.Parse("1972-09-14 00:00:00") },
                new Författare() { Id = 3, Förnamn = "Stina", Efternamn = "Jackson", Födelsedatum = DateTime.Parse("1983-06-28 00:00:00") },
                new Författare() { Id = 4, Förnamn = "Tommy", Efternamn = "Myllymäki", Födelsedatum = DateTime.Parse("1978-07-31 00:00:00") }
            );
        }
    }
}
