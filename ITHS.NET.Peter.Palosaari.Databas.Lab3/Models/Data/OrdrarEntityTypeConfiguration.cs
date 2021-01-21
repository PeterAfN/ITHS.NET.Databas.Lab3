using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public class OrdrarEntityTypeConfiguration : IEntityTypeConfiguration<Ordrar>
    {
        public void Configure(EntityTypeBuilder<Ordrar> builder)
        {
            builder.ToTable("Ordrar");

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.Adress).HasMaxLength(100);

            builder.Property(e => e.ButikId).HasColumnName("ButikID");

            builder.Property(e => e.Datum)
                .HasMaxLength(10)
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.FörsäljarId).HasMaxLength(20);

            builder.Property(e => e.KundId)
                .IsRequired()
                .HasMaxLength(11)
                .HasColumnName("KundID");

            builder.Property(e => e.Land).HasMaxLength(50);

            builder.Property(e => e.Postnummer).HasMaxLength(20);

            builder.Property(e => e.Region).HasMaxLength(50);

            builder.Property(e => e.Stad).HasMaxLength(50);

            builder.HasOne(d => d.Butiker)
                .WithMany(p => p.Ordrar)
                .HasForeignKey(d => d.ButikId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ordrar_Butiker");

            builder.HasOne(d => d.Kunder)
                .WithMany(p => p.Ordrar)
                .HasForeignKey(d => d.KundId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ordrar_Kunder");
        }
    }
}
