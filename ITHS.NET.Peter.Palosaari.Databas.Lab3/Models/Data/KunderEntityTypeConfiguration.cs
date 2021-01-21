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
        }
    }
}
