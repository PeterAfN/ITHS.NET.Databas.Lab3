#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class LagerSaldo
    {
        public int ButikId { get; set; }
        public string Isbn { get; set; }
        public int? Antal { get; set; }

        public virtual Butiker Butiker { get; set; }
        public virtual Böcker IsbnNavigation { get; set; }
    }
}
