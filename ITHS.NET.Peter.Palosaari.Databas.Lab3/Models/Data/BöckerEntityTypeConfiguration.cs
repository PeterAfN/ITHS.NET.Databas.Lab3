using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
        }
    }
}
