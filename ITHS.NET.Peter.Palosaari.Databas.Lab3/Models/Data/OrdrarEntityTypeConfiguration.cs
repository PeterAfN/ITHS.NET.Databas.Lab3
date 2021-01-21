using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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

            builder.HasData(
                new Ordrar() { Id = 1, ButikId = 3, KundId = "500603-4268", Datum = DateTime.Parse("2020-11-01 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 2, ButikId = 3, KundId = "500607-6521", Datum = DateTime.Parse("2020-11-01 00:00:00"), FörsäljarId = "2", Fraktavgift = 0, Adress = "Järnvägsgatan 3", Stad = "Stockholm", Region = "Dalarnas län", Postnummer = "21345", Land = "Sverige" },
                new Ordrar() { Id = 3, ButikId = 2, KundId = "530407-7989", Datum = DateTime.Parse("2020-11-04 00:00:00"), FörsäljarId = "3", Fraktavgift = 0, Adress = "Ringvägen 3", Stad = "Göteborg", Region = "Gotlands län", Postnummer = "44223", Land = "Sverige" },
                new Ordrar() { Id = 4, ButikId = 5, KundId = "530720-7675", Datum = DateTime.Parse("2020-11-04 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Skolgatan 3", Stad = "Malmö", Region = "Gävleborgs län", Postnummer = "12345", Land = "Sverige" },
                new Ordrar() { Id = 5, ButikId = 6, KundId = "540430-4887", Datum = DateTime.Parse("2020-11-05 00:00:00"), FörsäljarId = "9", Fraktavgift = 0, Adress = "Skogsvägen 3", Stad = "Uppsala", Region = "Hallands län", Postnummer = "44223", Land = "Sverige" },
                new Ordrar() { Id = 6, ButikId = 4, KundId = "550930-7164", Datum = DateTime.Parse("2020-11-06 00:00:00"), FörsäljarId = "8", Fraktavgift = 0, Adress = "Nygatan 3", Stad = "Västerås", Region = "Jämtlands län", Postnummer = "21345", Land = "Sverige" },
                new Ordrar() { Id = 7, ButikId = 3, KundId = "561108-3389", Datum = DateTime.Parse("2020-11-07 00:00:00"), FörsäljarId = "4", Fraktavgift = 0, Adress = "Granvägen 3", Stad = "Alfta", Region = "Jönköpings län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 8, ButikId = 4, KundId = "570501-4924", Datum = DateTime.Parse("2020-11-08 00:00:00"), FörsäljarId = "6", Fraktavgift = 0, Adress = "Idrottsvägen 3", Stad = "Arjeplog", Region = "Kalmar län", Postnummer = "12345", Land = "Sverige" },
                new Ordrar() { Id = 9, ButikId = 3, KundId = "571110-3843", Datum = DateTime.Parse("2020-11-09 00:00:00"), FörsäljarId = "5", Fraktavgift = 0, Adress = "Storgatan 3", Stad = "Arlöv", Region = "Kronobergs län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 10, ButikId = 1, KundId = "580802-4175", Datum = DateTime.Parse("2020-11-10 00:00:00"), FörsäljarId = "7", Fraktavgift = 0, Adress = "Kyrkvägen 3", Stad = "Färjestaden", Region = "Norrbottens län", Postnummer = "12345", Land = "Sverige" },
                new Ordrar() { Id = 11, ButikId = 1, KundId = "591007-1584", Datum = DateTime.Parse("2020-11-01 00:00:00"), FörsäljarId = "3", Fraktavgift = 0, Adress = "Industrigatan 3", Stad = "Garphyttan", Region = "Skåne län", Postnummer = "44223", Land = "Sverige" },
                new Ordrar() { Id = 12, ButikId = 3, KundId = "591026-6645", Datum = DateTime.Parse("2020-11-01 00:00:00"), FörsäljarId = "9", Fraktavgift = 0, Adress = "Parkvägen 3", Stad = "Gnosjö", Region = "Stockholms län", Postnummer = "21345", Land = "Sverige" },
                new Ordrar() { Id = 13, ButikId = 2, KundId = "600309-7687", Datum = DateTime.Parse("2020-11-01 00:00:00"), FörsäljarId = "4", Fraktavgift = 0, Adress = "Strandvägen 3", Stad = "Grums", Region = "Södermanlands län", Postnummer = "44223", Land = "Sverige" },
                new Ordrar() { Id = 14, ButikId = 3, KundId = "601103-7655", Datum = DateTime.Parse("2020-11-01 00:00:00"), FörsäljarId = "8", Fraktavgift = 0, Adress = "Skolvägen 3", Stad = "Grästorp", Region = "Uppsala län", Postnummer = "12345", Land = "Sverige" },
                new Ordrar() { Id = 15, ButikId = 4, KundId = "620925-4245", Datum = DateTime.Parse("2020-11-02 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "44223", Land = "Sverige" },
                new Ordrar() { Id = 16, ButikId = 4, KundId = "630129-6936", Datum = DateTime.Parse("2020-11-24 00:00:00"), FörsäljarId = "2", Fraktavgift = 0, Adress = "Järnvägsgatan 3", Stad = "Stockholm", Region = "Dalarnas län", Postnummer = "12345", Land = "Sverige" },
                new Ordrar() { Id = 17, ButikId = 3, KundId = "630303-4894", Datum = DateTime.Parse("2020-11-05 00:00:00"), FörsäljarId = "3", Fraktavgift = 0, Adress = "Ringvägen 3", Stad = "Göteborg", Region = "Gotlands län", Postnummer = "21345", Land = "Sverige" },
                new Ordrar() { Id = 18, ButikId = 1, KundId = "630309-2528", Datum = DateTime.Parse("2020-11-23 00:00:00"), FörsäljarId = "2", Fraktavgift = 0, Adress = "Skolgatan 3", Stad = "Malmö", Region = "Gävleborgs län", Postnummer = "44223", Land = "Sverige" },
                new Ordrar() { Id = 19, ButikId = 2, KundId = "630611-7069", Datum = DateTime.Parse("2020-11-07 00:00:00"), FörsäljarId = "9", Fraktavgift = 0, Adress = "Skogsvägen 3", Stad = "Uppsala", Region = "Hallands län", Postnummer = "12345", Land = "Sverige" },
                new Ordrar() { Id = 20, ButikId = 2, KundId = "630912-1175", Datum = DateTime.Parse("2020-11-07 00:00:00"), FörsäljarId = "9", Fraktavgift = 0, Adress = "Nygatan 3", Stad = "Västerås", Region = "Jämtlands län", Postnummer = "44223", Land = "Sverige" },
                new Ordrar() { Id = 21, ButikId = 5, KundId = "630929-1879", Datum = DateTime.Parse("2020-11-08 00:00:00"), FörsäljarId = "8", Fraktavgift = 0, Adress = "Granvägen 3", Stad = "Alfta", Region = "Jönköpings län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 22, ButikId = 1, KundId = "640912-6799", Datum = DateTime.Parse("2020-11-08 00:00:00"), FörsäljarId = "5", Fraktavgift = 0, Adress = "Idrottsvägen 3", Stad = "Arjeplog", Region = "Kalmar län", Postnummer = "12345", Land = "Sverige" },
                new Ordrar() { Id = 23, ButikId = 3, KundId = "640913-5335", Datum = DateTime.Parse("2020-11-09 00:00:00"), FörsäljarId = "7", Fraktavgift = 0, Adress = "Storgatan 3", Stad = "Arlöv", Region = "Kronobergs län", Postnummer = "21345", Land = "Sverige" },
                new Ordrar() { Id = 24, ButikId = 1, KundId = "680820-7946", Datum = DateTime.Parse("2020-11-10 00:00:00"), FörsäljarId = "4", Fraktavgift = 0, Adress = "Kyrkvägen 3", Stad = "Färjestaden", Region = "Norrbottens län", Postnummer = "21345", Land = "Sverige" },
                new Ordrar() { Id = 25, ButikId = 6, KundId = "690206-8769", Datum = DateTime.Parse("2020-11-10 00:00:00"), FörsäljarId = "3", Fraktavgift = 0, Adress = "Industrigatan 3", Stad = "Garphyttan", Region = "Skåne län", Postnummer = "12345", Land = "Sverige" },
                new Ordrar() { Id = 26, ButikId = 3, KundId = "720524-3728", Datum = DateTime.Parse("2020-11-11 00:00:00"), FörsäljarId = "4", Fraktavgift = 0, Adress = "Parkvägen 3", Stad = "Gnosjö", Region = "Stockholms län", Postnummer = "44223", Land = "Sverige" },
                new Ordrar() { Id = 27, ButikId = 4, KundId = "731012-9018", Datum = DateTime.Parse("2020-11-12 00:00:00"), FörsäljarId = "5", Fraktavgift = 0, Adress = "Strandvägen 3", Stad = "Grums", Region = "Södermanlands län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 28, ButikId = 3, KundId = "741109-2058", Datum = DateTime.Parse("2020-11-17 00:00:00"), FörsäljarId = "2", Fraktavgift = 0, Adress = "Skolvägen 3", Stad = "Grästorp", Region = "Uppsala län", Postnummer = "21345", Land = "Sverige" },
                new Ordrar() { Id = 29, ButikId = 1, KundId = "750210-6008", Datum = DateTime.Parse("2020-11-19 00:00:00"), FörsäljarId = "8", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "44223", Land = "Sverige" },
                new Ordrar() { Id = 30, ButikId = 3, KundId = "751123-9724", Datum = DateTime.Parse("2020-11-22 00:00:00"), FörsäljarId = "9", Fraktavgift = 0, Adress = "Järnvägsgatan 3", Stad = "Stockholm", Region = "Dalarnas län", Postnummer = "12345", Land = "Sverige" },
                new Ordrar() { Id = 31, ButikId = 4, KundId = "770422-8188", Datum = DateTime.Parse("2020-11-24 00:00:00"), FörsäljarId = "6", Fraktavgift = 0, Adress = "Ringvägen 3", Stad = "Göteborg", Region = "Gotlands län", Postnummer = "44223", Land = "Sverige" },
                new Ordrar() { Id = 32, ButikId = 3, KundId = "800512-6752", Datum = DateTime.Parse("2020-11-26 00:00:00"), FörsäljarId = "2", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "21345", Land = "Sverige" },
                new Ordrar() { Id = 33, ButikId = 3, KundId = "801022-4516", Datum = DateTime.Parse("2020-11-27 00:00:00"), FörsäljarId = "3", Fraktavgift = 0, Adress = "Granvägen 3", Stad = "Alfta", Region = "Jönköpings län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 34, ButikId = 6, KundId = "811008-5301", Datum = DateTime.Parse("2020-11-27 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Järnvägsgatan 3", Stad = "Stockholm", Region = "Dalarnas län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 35, ButikId = 5, KundId = "820624-3075", Datum = DateTime.Parse("2020-11-01 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 19, Adress = "Björkvägen 3", Stad = "Stockholm", Region = "Blekinge län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 36, ButikId = 5, KundId = "841204-3830", Datum = DateTime.Parse("2020-11-02 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 39, Adress = "Järnvägsgatan 3", Stad = "Göteborg", Region = "Dalarnas län", Postnummer = "21345", Land = "Sverige" },
                new Ordrar() { Id = 37, ButikId = 6, KundId = "851126-2068", Datum = DateTime.Parse("2020-11-03 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 49, Adress = "Ringvägen 3", Stad = "Malmö", Region = "Gotlands län", Postnummer = "44223", Land = "Sverige" },
                new Ordrar() { Id = 38, ButikId = 4, KundId = "861110-5749", Datum = DateTime.Parse("2020-11-14 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 69, Adress = "Skolgatan 3", Stad = "Uppsala", Region = "Gävleborgs län", Postnummer = "12345", Land = "Sverige" },
                new Ordrar() { Id = 39, ButikId = 6, KundId = "880706-3713", Datum = DateTime.Parse("2020-11-01 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 19, Adress = "Skogsvägen 3", Stad = "Västerås", Region = "Hallands län", Postnummer = "44223", Land = "Sverige" },
                new Ordrar() { Id = 40, ButikId = 2, KundId = "890701-1480", Datum = DateTime.Parse("2020-11-02 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 39, Adress = "Nygatan 3", Stad = "Alfta", Region = "Jämtlands län", Postnummer = "21345", Land = "Sverige" },
                new Ordrar() { Id = 41, ButikId = 3, KundId = "910806-1370", Datum = DateTime.Parse("2020-11-02 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 39, Adress = "Granvägen 3", Stad = "Arjeplog", Region = "Jönköpings län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 42, ButikId = 2, KundId = "921005-4598", Datum = DateTime.Parse("2020-01-02 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 69, Adress = "Idrottsvägen 3", Stad = "Arlöv", Region = "Kalmar län", Postnummer = "12345", Land = "Sverige" },
                new Ordrar() { Id = 43, ButikId = 2, KundId = "921110-8377", Datum = DateTime.Parse("2020-11-02 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 39, Adress = "Storgatan 3", Stad = "Färjestaden", Region = "Kronobergs län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 44, ButikId = 4, KundId = "940406-2734", Datum = DateTime.Parse("2020-11-02 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 39, Adress = "Kyrkvägen 3", Stad = "Garphyttan", Region = "Norrbottens län", Postnummer = "12345", Land = "Sverige" },
                new Ordrar() { Id = 45, ButikId = 4, KundId = "950527-6317", Datum = DateTime.Parse("2020-11-02 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 39, Adress = "Industrigatan 3", Stad = "Gnosjö", Region = "Skåne län", Postnummer = "44223", Land = "Sverige" },
                new Ordrar() { Id = 46, ButikId = 2, KundId = "970602-8733", Datum = DateTime.Parse("2020-11-02 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 39, Adress = "Parkvägen 3", Stad = "Grums", Region = "Stockholms län", Postnummer = "21345", Land = "Sverige" },
                new Ordrar() { Id = 47, ButikId = 2, KundId = "971220-1939", Datum = DateTime.Parse("2020-11-03 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 49, Adress = "Strandvägen 3", Stad = "Grästorp", Region = "Södermanlands län", Postnummer = "44223", Land = "Sverige" },
                new Ordrar() { Id = 48, ButikId = 4, KundId = "980128-9944", Datum = DateTime.Parse("2020-01-23 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 69, Adress = "Skolvägen 3", Stad = "Grästorp", Region = "Uppsala län", Postnummer = "12345", Land = "Sverige" },
                new Ordrar() { Id = 49, ButikId = 5, KundId = "981003-1947", Datum = DateTime.Parse("2020-11-03 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 49, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "44223", Land = "Sverige" },
                new Ordrar() { Id = 50, ButikId = 5, KundId = "990130-1619", Datum = DateTime.Parse("2020-11-30 00:00:00"), FörsäljarId = "webborder", Fraktavgift = 109, Adress = "Järnvägsgatan 3", Stad = "Stockholm", Region = "Dalarnas län", Postnummer = "12345", Land = "Sverige" },
                new Ordrar() { Id = 54, ButikId = 6, KundId = "500603-4268", Datum = DateTime.Parse("2020-11-01 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 55, ButikId = 2, KundId = "500603-4268", Datum = DateTime.Parse("2020-11-01 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 56, ButikId = 4, KundId = "530720-7675", Datum = DateTime.Parse("2020-11-01 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 57, ButikId = 1, KundId = "580802-4175", Datum = DateTime.Parse("2020-11-03 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 58, ButikId = 1, KundId = "620925-4245", Datum = DateTime.Parse("2020-11-05 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 59, ButikId = 6, KundId = "630309-2528", Datum = DateTime.Parse("2020-11-07 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 60, ButikId = 5, KundId = "640912-6799", Datum = DateTime.Parse("2020-11-09 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 61, ButikId = 2, KundId = "690206-8769", Datum = DateTime.Parse("2020-11-11 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 62, ButikId = 3, KundId = "750210-6008", Datum = DateTime.Parse("2020-11-21 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 63, ButikId = 6, KundId = "800512-6752", Datum = DateTime.Parse("2020-11-23 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 64, ButikId = 5, KundId = "880706-3713", Datum = DateTime.Parse("2020-11-26 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "32145", Land = "Sverige" },
                new Ordrar() { Id = 65, ButikId = 1, KundId = "880706-3713", Datum = DateTime.Parse("2020-11-26 00:00:00"), FörsäljarId = "1", Fraktavgift = 0, Adress = "Björkvägen 3", Stad = "Arboga", Region = "Blekinge län", Postnummer = "32145", Land = "Sverige" }
            );
        }
    }
}
