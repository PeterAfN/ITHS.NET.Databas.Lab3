using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public class OrderDetaljerEntityTypeConfiguration : IEntityTypeConfiguration<OrderDetaljer>
    {
        public void Configure(EntityTypeBuilder<OrderDetaljer> builder)
        {
            builder.HasKey(e => new { e.ProduktId, e.OrderId });

            builder.ToTable("OrderDetaljer");

            builder.Property(e => e.ProduktId).HasMaxLength(13);

            builder.Property(e => e.OrderId).HasColumnName("OrderID");

            builder.HasOne(d => d.Ordrar)
                .WithMany(p => p.OrderDetaljer)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetaljer_Ordrar");

            builder.HasOne(d => d.ISBN)
                .WithMany(p => p.OrderDetaljer)
                .HasForeignKey(d => d.ProduktId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetaljer_Böcker");

            builder.HasData(
                new OrderDetaljer() { ProduktId = "9780395647806", OrderId = 1, ProduktPris = 229, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9780395647806", OrderId = 6, ProduktPris = 229, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9780395647806", OrderId = 18, ProduktPris = 229, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9780395647806", OrderId = 23, ProduktPris = 229, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9780395647806", OrderId = 25, ProduktPris = 229, ProduktAntal = 1, ProduktRabattProcent = 0.2 },
                new OrderDetaljer() { ProduktId = "9780395647806", OrderId = 28, ProduktPris = 229, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9780395647806", OrderId = 33, ProduktPris = 229, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9780395647806", OrderId = 34, ProduktPris = 229, ProduktAntal = 5, ProduktRabattProcent = 0.2 },
                new OrderDetaljer() { ProduktId = "9780395647806", OrderId = 50, ProduktPris = 229, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9780395647806", OrderId = 64, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9780395647806", OrderId = 65, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9780751564822", OrderId = 4, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9780751564822", OrderId = 7, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9780751564822", OrderId = 19, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9780751564822", OrderId = 21, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9780751564822", OrderId = 22, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0.2 },
                new OrderDetaljer() { ProduktId = "9780751564822", OrderId = 29, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9780751564822", OrderId = 39, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9781472154668", OrderId = 8, ProduktPris = 169, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9781472154668", OrderId = 47, ProduktPris = 169, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9781472154668", OrderId = 49, ProduktPris = 169, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9781472154668", OrderId = 62, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789100186364", OrderId = 3, ProduktPris = 49, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789100186364", OrderId = 4, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789100186364", OrderId = 10, ProduktPris = 49, ProduktAntal = 2, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789100186364", OrderId = 11, ProduktPris = 49, ProduktAntal = 2, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789100186364", OrderId = 17, ProduktPris = 49, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789100186364", OrderId = 30, ProduktPris = 49, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789100186364", OrderId = 36, ProduktPris = 49, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789100186364", OrderId = 37, ProduktPris = 49, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789100186364", OrderId = 43, ProduktPris = 49, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789100186364", OrderId = 54, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789113096803", OrderId = 14, ProduktPris = 49, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789113096803", OrderId = 15, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789113096803", OrderId = 16, ProduktPris = 49, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789113096803", OrderId = 55, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789127158672", OrderId = 20, ProduktPris = 289, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789127158672", OrderId = 24, ProduktPris = 289, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789127158672", OrderId = 35, ProduktPris = 289, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789127158672", OrderId = 42, ProduktPris = 289, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789127158672", OrderId = 48, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789127158672", OrderId = 56, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789127168169", OrderId = 5, ProduktPris = 229, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789127168169", OrderId = 35, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789127168169", OrderId = 40, ProduktPris = 229, ProduktAntal = 4, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789127168169", OrderId = 41, ProduktPris = 229, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789127168169", OrderId = 44, ProduktPris = 229, ProduktAntal = 1, ProduktRabattProcent = 0.09 },
                new OrderDetaljer() { ProduktId = "9789127168169", OrderId = 45, ProduktPris = 229, ProduktAntal = 2, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789127168169", OrderId = 46, ProduktPris = 229, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789127168169", OrderId = 57, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789137154831", OrderId = 2, ProduktPris = 149, ProduktAntal = 2, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789137154831", OrderId = 8, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789137154831", OrderId = 9, ProduktPris = 149, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789137154831", OrderId = 13, ProduktPris = 149, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789137154831", OrderId = 15, ProduktPris = 149, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789137154831", OrderId = 26, ProduktPris = 149, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789137154831", OrderId = 38, ProduktPris = 149, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789137154831", OrderId = 56, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789137154831", OrderId = 58, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789176910986", OrderId = 31, ProduktPris = 95, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789176910986", OrderId = 32, ProduktPris = 95, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789176910986", OrderId = 59, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789179710125", OrderId = 12, ProduktPris = 239, ProduktAntal = 1, ProduktRabattProcent = 0.2 },
                new OrderDetaljer() { ProduktId = "9789179710125", OrderId = 22, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789179710125", OrderId = 27, ProduktPris = 239, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789179710125", OrderId = 48, ProduktPris = 239, ProduktAntal = 1, ProduktRabattProcent = 0.09 },
                new OrderDetaljer() { ProduktId = "9789179710125", OrderId = 60, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789179710125", OrderId = 61, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789179710125", OrderId = 63, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789179710125", OrderId = 64, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 },
                new OrderDetaljer() { ProduktId = "9789179710125", OrderId = 65, ProduktPris = 139, ProduktAntal = 1, ProduktRabattProcent = 0 }
            );
        }
    }
}
