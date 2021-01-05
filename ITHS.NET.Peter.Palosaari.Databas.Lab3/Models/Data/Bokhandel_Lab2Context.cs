using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class Bokhandel_Lab2Context : DbContext
    {
        public Bokhandel_Lab2Context() {}

        public Bokhandel_Lab2Context(DbContextOptions<Bokhandel_Lab2Context> options) : base(options) {}

        public virtual DbSet<Butiker> Butiker { get; set; }
        public virtual DbSet<Böcker> Böcker { get; set; }
        public virtual DbSet<Författare> Författare { get; set; }
        public virtual DbSet<FörfattareBöckerJunction> FörfattareBöckerJunction { get; set; }
        public virtual DbSet<Förlag> Förlag { get; set; }
        public virtual DbSet<FörsäljningsstatistikButikerÅr2020> FörsäljningsstatistikButikerÅr2020 { get; set; }
        public virtual DbSet<Kunder> Kunder { get; set; }
        public virtual DbSet<LagerSaldo> LagerSaldon { get; set; }
        public virtual DbSet<OrderDetaljer> OrderDetaljer { get; set; }
        public virtual DbSet<Ordrar> Ordrar { get; set; }
        public virtual DbSet<TitlarPerFörfattare> TitlarPerFörfattare { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Bokhandel_Lab2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Butiker>(entity =>
            {
                entity.ToTable("Butiker");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adress).HasMaxLength(40);

                entity.Property(e => e.Land)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('Sverige')");

                entity.Property(e => e.Namn).HasMaxLength(60);

                entity.Property(e => e.Stad).HasMaxLength(40);
            });

            modelBuilder.Entity<Böcker>(entity =>
            {
                entity.HasKey(e => e.Isbn13);

                entity.ToTable("Böcker");

                entity.Property(e => e.Isbn13)
                    .HasMaxLength(13)
                    .HasColumnName("ISBN13");

                entity.Property(e => e.FörlagId).HasColumnName("FörlagID");

                entity.Property(e => e.Pris).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Språk).HasMaxLength(20);

                entity.Property(e => e.Titel).HasMaxLength(100);

                entity.Property(e => e.Utgivningsdatum)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Förlag)
                    .WithMany(p => p.Böcker)
                    .HasForeignKey(d => d.FörlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Böcker_Förlag");
            });

            modelBuilder.Entity<Författare>(entity =>
            {
                entity.ToTable("Författare");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Efternamn).HasMaxLength(25);

                entity.Property(e => e.Födelsedatum)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Förnamn).HasMaxLength(25);
            });

            modelBuilder.Entity<FörfattareBöckerJunction>(entity =>
            {
                entity.HasKey(e => new { e.FörfattareId, e.BokId });

                entity.ToTable("FörfattareBöcker_Junction");

                entity.Property(e => e.FörfattareId).HasColumnName("FörfattareID");

                entity.Property(e => e.BokId)
                    .HasMaxLength(13)
                    .HasColumnName("BokID");

                entity.HasOne(d => d.Böcker)
                    .WithMany(p => p.FörfattareBöckerJunction)
                    .HasForeignKey(d => d.BokId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FörfattareBöcker_Junction_Böcker");

                entity.HasOne(d => d.Författare)
                    .WithMany(p => p.FörfattareBöckerJunctions)
                    .HasForeignKey(d => d.FörfattareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FörfattareBöcker_Junction_Författare");
            });

            modelBuilder.Entity<Förlag>(entity =>
            {
                entity.ToTable("Förlag");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Beskrivning).HasMaxLength(200);

                entity.Property(e => e.Epost).HasMaxLength(50);

                entity.Property(e => e.Namn).HasMaxLength(30);

                entity.Property(e => e.Telefonnummer).HasMaxLength(20);
            });

            modelBuilder.Entity<FörsäljningsstatistikButikerÅr2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Försäljningsstatistik_Butiker_År_2020");

                entity.Property(e => e.AntalBöcker)
                    .HasMaxLength(34)
                    .IsUnicode(false)
                    .HasColumnName("Antal böcker");

                entity.Property(e => e.AntalOrdrarExklusiveWebb)
                    .HasMaxLength(34)
                    .IsUnicode(false)
                    .HasColumnName("Antal ordrar [exklusive webb]");

                entity.Property(e => e.FörsäljningsmedelvärdePerOrder)
                    .HasMaxLength(4000)
                    .HasColumnName("Försäljningsmedelvärde per Order");

                entity.Property(e => e.Namn).HasMaxLength(60);

                entity.Property(e => e.TotalFörsäljningsvärdeFörÅr2020)
                    .HasMaxLength(4000)
                    .HasColumnName("Total Försäljningsvärde för år 2020");
            });

            modelBuilder.Entity<Kunder>(entity =>
            {
                entity.ToTable("Kunder");

                entity.Property(e => e.Id)
                    .HasMaxLength(11)
                    .HasColumnName("ID");

                entity.Property(e => e.Användarnamn).HasMaxLength(6);

                entity.Property(e => e.Efternamn).HasMaxLength(20);

                entity.Property(e => e.Epost).HasMaxLength(100);

                entity.Property(e => e.Förnamn).HasMaxLength(20);

                entity.Property(e => e.Lösenord).HasMaxLength(100);

                entity.Property(e => e.Telefonnummer).HasMaxLength(20);
            });

            modelBuilder.Entity<LagerSaldo>(entity =>
            {
                entity.HasKey(e => new { e.ButikId, e.Isbn });

                entity.ToTable("LagerSaldo");

                entity.Property(e => e.ButikId).HasColumnName("ButikID");

                entity.Property(e => e.Isbn)
                    .HasMaxLength(13)
                    .HasColumnName("ISBN");

                entity.HasOne(d => d.Butiker)
                    .WithMany(p => p.LagerSaldon)
                    .HasForeignKey(d => d.ButikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LagerSaldo_Butiker");

                entity.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.LagerSaldon)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LagerSaldo_Böcker");
            });

            modelBuilder.Entity<OrderDetaljer>(entity =>
            {
                entity.HasKey(e => new { e.ProduktId, e.OrderId });

                entity.ToTable("OrderDetaljer");

                entity.Property(e => e.ProduktId).HasMaxLength(13);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.HasOne(d => d.Ordrar)
                    .WithMany(p => p.OrderDetaljer)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetaljer_Ordrar");

                entity.HasOne(d => d.ISBN)
                    .WithMany(p => p.OrderDetaljer)
                    .HasForeignKey(d => d.ProduktId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetaljer_Böcker");
            });

            modelBuilder.Entity<Ordrar>(entity =>
            {
                entity.ToTable("Ordrar");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adress).HasMaxLength(100);

                entity.Property(e => e.ButikId).HasColumnName("ButikID");

                entity.Property(e => e.Datum)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FörsäljarId).HasMaxLength(20);

                entity.Property(e => e.KundId)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("KundID");

                entity.Property(e => e.Land).HasMaxLength(50);

                entity.Property(e => e.Postnummer).HasMaxLength(20);

                entity.Property(e => e.Region).HasMaxLength(50);

                entity.Property(e => e.Stad).HasMaxLength(50);

                entity.HasOne(d => d.Butiker)
                    .WithMany(p => p.Ordrar)
                    .HasForeignKey(d => d.ButikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ordrar_Butiker");

                entity.HasOne(d => d.Kunder)
                    .WithMany(p => p.Ordrar)
                    .HasForeignKey(d => d.KundId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ordrar_Kunder");
            });

            modelBuilder.Entity<TitlarPerFörfattare>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TitlarPerFörfattare");

                entity.Property(e => e.Lagervärde)
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.Namn).HasMaxLength(51);

                entity.Property(e => e.Titlar)
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.Ålder)
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
