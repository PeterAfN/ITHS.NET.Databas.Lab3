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

            builder.HasData(
                new LagerSaldo() { ButikId = 1, Isbn = "9780395647806", Antal = 13 },
                new LagerSaldo() { ButikId = 1, Isbn = "9780751564822", Antal = 32 },
                new LagerSaldo() { ButikId = 1, Isbn = "9781472154668", Antal = 2 },
                new LagerSaldo() { ButikId = 1, Isbn = "9789100186364", Antal = 12 },
                new LagerSaldo() { ButikId = 1, Isbn = "9789113096803", Antal = 120 },
                new LagerSaldo() { ButikId = 1, Isbn = "9789127158672", Antal = 0 },
                new LagerSaldo() { ButikId = 1, Isbn = "9789127168169", Antal = 4 },
                new LagerSaldo() { ButikId = 1, Isbn = "9789137154831", Antal = 43 },
                new LagerSaldo() { ButikId = 1, Isbn = "9789176910986", Antal = 24 },
                new LagerSaldo() { ButikId = 1, Isbn = "9789179710125", Antal = 19 },
                new LagerSaldo() { ButikId = 2, Isbn = "9780395647806", Antal = 26 },
                new LagerSaldo() { ButikId = 2, Isbn = "9780751564822", Antal = 34 },
                new LagerSaldo() { ButikId = 2, Isbn = "9781472154668", Antal = 0 },
                new LagerSaldo() { ButikId = 2, Isbn = "9789100186364", Antal = 2 },
                new LagerSaldo() { ButikId = 2, Isbn = "9789113096803", Antal = 76 },
                new LagerSaldo() { ButikId = 2, Isbn = "9789127158672", Antal = 2 },
                new LagerSaldo() { ButikId = 2, Isbn = "9789127168169", Antal = 0 },
                new LagerSaldo() { ButikId = 2, Isbn = "9789137154831", Antal = 23 },
                new LagerSaldo() { ButikId = 2, Isbn = "9789176910986", Antal = 12 },
                new LagerSaldo() { ButikId = 2, Isbn = "9789179710125", Antal = 0 },
                new LagerSaldo() { ButikId = 3, Isbn = "9780395647806", Antal = 10 },
                new LagerSaldo() { ButikId = 3, Isbn = "9780751564822", Antal = 11 },
                new LagerSaldo() { ButikId = 3, Isbn = "9781472154668", Antal = 1 },
                new LagerSaldo() { ButikId = 3, Isbn = "9789100186364", Antal = 23 },
                new LagerSaldo() { ButikId = 3, Isbn = "9789113096803", Antal = 24 },
                new LagerSaldo() { ButikId = 3, Isbn = "9789127158672", Antal = 7 },
                new LagerSaldo() { ButikId = 3, Isbn = "9789127168169", Antal = 2 },
                new LagerSaldo() { ButikId = 3, Isbn = "9789137154831", Antal = 2 },
                new LagerSaldo() { ButikId = 3, Isbn = "9789176910986", Antal = 6 },
                new LagerSaldo() { ButikId = 3, Isbn = "9789179710125", Antal = 1 },
                new LagerSaldo() { ButikId = 4, Isbn = "9780395647806", Antal = 54 },
                new LagerSaldo() { ButikId = 4, Isbn = "9780751564822", Antal = 28 },
                new LagerSaldo() { ButikId = 4, Isbn = "9781472154668", Antal = 23 },
                new LagerSaldo() { ButikId = 4, Isbn = "9789100186364", Antal = 19 },
                new LagerSaldo() { ButikId = 4, Isbn = "9789113096803", Antal = 140 },
                new LagerSaldo() { ButikId = 4, Isbn = "9789127158672", Antal = 22 },
                new LagerSaldo() { ButikId = 4, Isbn = "9789127168169", Antal = 1 },
                new LagerSaldo() { ButikId = 4, Isbn = "9789137154831", Antal = 0 },
                new LagerSaldo() { ButikId = 4, Isbn = "9789176910986", Antal = 54 },
                new LagerSaldo() { ButikId = 4, Isbn = "9789179710125", Antal = 33 },
                new LagerSaldo() { ButikId = 5, Isbn = "9780395647806", Antal = 15 },
                new LagerSaldo() { ButikId = 5, Isbn = "9780751564822", Antal = 11 },
                new LagerSaldo() { ButikId = 5, Isbn = "9781472154668", Antal = 0 },
                new LagerSaldo() { ButikId = 5, Isbn = "9789100186364", Antal = 8 },
                new LagerSaldo() { ButikId = 5, Isbn = "9789113096803", Antal = 35 },
                new LagerSaldo() { ButikId = 5, Isbn = "9789127158672", Antal = 6 },
                new LagerSaldo() { ButikId = 5, Isbn = "9789127168169", Antal = 0 },
                new LagerSaldo() { ButikId = 5, Isbn = "9789137154831", Antal = 23 },
                new LagerSaldo() { ButikId = 5, Isbn = "9789176910986", Antal = 6 },
                new LagerSaldo() { ButikId = 5, Isbn = "9789179710125", Antal = 0 },
                new LagerSaldo() { ButikId = 6, Isbn = "9780395647806", Antal = 1 },
                new LagerSaldo() { ButikId = 6, Isbn = "9780751564822", Antal = 11 },
                new LagerSaldo() { ButikId = 6, Isbn = "9781472154668", Antal = 63 },
                new LagerSaldo() { ButikId = 6, Isbn = "9789100186364", Antal = 27 },
                new LagerSaldo() { ButikId = 6, Isbn = "9789113096803", Antal = 54 },
                new LagerSaldo() { ButikId = 6, Isbn = "9789127158672", Antal = 8 },
                new LagerSaldo() { ButikId = 6, Isbn = "9789127168169", Antal = 10 },
                new LagerSaldo() { ButikId = 6, Isbn = "9789137154831", Antal = 27 },
                new LagerSaldo() { ButikId = 6, Isbn = "9789176910986", Antal = 8 },
                new LagerSaldo() { ButikId = 6, Isbn = "9789179710125", Antal = 12 }
            );

        }
    }
}
