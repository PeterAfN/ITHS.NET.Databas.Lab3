using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public class ButikerEntityTypeConfiguration : IEntityTypeConfiguration<Butiker>
    {
        public void Configure(EntityTypeBuilder<Butiker> builder)
        {
            builder.ToTable("Butiker");

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.Adress).HasMaxLength(40);

            builder.Property(e => e.Land)
                .HasMaxLength(40)
                .HasDefaultValueSql("('Sverige')");

            builder.Property(e => e.Namn).HasMaxLength(60);

            builder.Property(e => e.Stad).HasMaxLength(40);
        }
    }
}
