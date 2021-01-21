using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public class FörfattareBöckerJunctionEntityTypeConfiguration : IEntityTypeConfiguration<FörfattareBöckerJunction>
    {
        public void Configure(EntityTypeBuilder<FörfattareBöckerJunction> builder)
        {
            builder.HasKey(e => new { e.FörfattareId, e.BokId });

            builder.ToTable("FörfattareBöcker_Junction");

            builder.Property(e => e.FörfattareId).HasColumnName("FörfattareID");

            builder.Property(e => e.BokId)
                .HasMaxLength(13)
                .HasColumnName("BokID");

            builder.HasOne(d => d.Böcker)
                .WithMany(p => p.FörfattareBöckerJunctions)
                .HasForeignKey(d => d.BokId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FörfattareBöcker_Junction_Böcker");

            builder.HasOne(d => d.Författare)
                .WithMany(p => p.FörfattareBöckerJunctions)
                .HasForeignKey(d => d.FörfattareId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FörfattareBöcker_Junction_Författare");
        }
    }
}
