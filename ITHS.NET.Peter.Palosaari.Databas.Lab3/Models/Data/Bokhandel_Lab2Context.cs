using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class Bokhandel_Lab2Context : DbContext
    {
        public Bokhandel_Lab2Context() { }

        public Bokhandel_Lab2Context(DbContextOptions<Bokhandel_Lab2Context> options) : base(options) { }

        public virtual DbSet<Butiker> Butiker { get; set; }
        public virtual DbSet<Böcker> Böcker { get; set; }
        public virtual DbSet<Författare> Författare { get; set; }
        public virtual DbSet<FörfattareBöckerJunction> FörfattareBöckerJunction { get; set; }
        public virtual DbSet<Förlag> Förlag { get; set; }
        public virtual DbSet<Kunder> Kunder { get; set; }
        public virtual DbSet<LagerSaldo> LagerSaldon { get; set; }
        public virtual DbSet<OrderDetaljer> OrderDetaljer { get; set; }
        public virtual DbSet<Ordrar> Ordrar { get; set; }


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

            new FörfattareEntityTypeConfiguration().Configure(modelBuilder.Entity<Författare>());
            new OrdrarEntityTypeConfiguration().Configure(modelBuilder.Entity<Ordrar>());
            new OrderDetaljerEntityTypeConfiguration().Configure(modelBuilder.Entity<OrderDetaljer>());

            new BöckerEntityTypeConfiguration().Configure(modelBuilder.Entity<Böcker>());
            new ButikerEntityTypeConfiguration().Configure(modelBuilder.Entity<Butiker>());
            new LagerSaldoEntityTypeConfiguration().Configure(modelBuilder.Entity<LagerSaldo>());

            new FörfattareBöckerJunctionEntityTypeConfiguration().Configure(modelBuilder.Entity<FörfattareBöckerJunction>());
            new FörlagEntityTypeConfiguration().Configure(modelBuilder.Entity<Förlag>());
            new KunderEntityTypeConfiguration().Configure(modelBuilder.Entity<Kunder>());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
