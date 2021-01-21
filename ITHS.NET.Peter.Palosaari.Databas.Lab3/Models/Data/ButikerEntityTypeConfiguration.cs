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

            builder.HasData(
                new Butiker() { Id = 1, Namn = "Akademibokhandeln Alingsås", Adress = "Stora Torget 2", Postnummer = 44130, Stad = "Alingsås", Land = "Sverige" },
                new Butiker() { Id = 2, Namn = "Akademibokhandeln Nordstan", Adress = "Norra Hamngatan 26", Postnummer = 41106, Stad = "Göteborg", Land = "Sverige" },
                new Butiker() { Id = 3, Namn = "Akademibokhandeln Kalmar", Adress = "Norra Långgatan 26", Postnummer = 39232, Stad = "Kalmar", Land = "Sverige" },
                new Butiker() { Id = 4, Namn = "Akademibokhandeln Huddinge Centrum", Adress = "Forelltorget 6", Postnummer = 14147, Stad = "Huddinge", Land = "Sverige" },
                new Butiker() { Id = 5, Namn = "Akademibokhandeln Stockholm Skrapan", Adress = "Götgatan 78", Postnummer = 11830, Stad = "Stockholm", Land = "Sverige" },
                new Butiker() { Id = 6, Namn = "Akademibokhandeln Sundsvall Storgatan", Adress = "Storgatan 22", Postnummer = 85230, Stad = "Sundsvall", Land = "Sverige" }
            );
        }
    }
}
