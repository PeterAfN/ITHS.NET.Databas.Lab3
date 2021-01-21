using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
        }
    }
}
