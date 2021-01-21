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
        }
    }
}
