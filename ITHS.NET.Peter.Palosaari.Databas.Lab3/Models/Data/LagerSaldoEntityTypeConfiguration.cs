using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public class LagerSaldoEntityTypeConfiguration : IEntityTypeConfiguration<LagerSaldo>
    {
        public void Configure(EntityTypeBuilder<LagerSaldo> builder)
        {
            builder.HasKey(e => new { e.ButikId, e.Isbn });

            builder.ToTable("LagerSaldo");

            builder.Property(e => e.ButikId).HasColumnName("ButikID");

            builder.Property(e => e.Isbn)
                .HasMaxLength(13)
                .HasColumnName("ISBN");

            builder.HasOne(d => d.Butiker)
                .WithMany(p => p.LagerSaldon)
                .HasForeignKey(d => d.ButikId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LagerSaldo_Butiker");

            builder.HasOne(d => d.IsbnNavigation)
                .WithMany(p => p.LagerSaldon)
                .HasForeignKey(d => d.Isbn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LagerSaldo_Böcker");
        }
    }
}
