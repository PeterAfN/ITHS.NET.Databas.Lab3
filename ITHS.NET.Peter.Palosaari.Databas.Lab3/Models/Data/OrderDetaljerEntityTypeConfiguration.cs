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
        }
    }
}
