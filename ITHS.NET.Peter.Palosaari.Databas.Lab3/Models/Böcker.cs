using System;
using System.Collections.Generic;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class Böcker
    {
        public Böcker()
        {
            FörfattareBöckerJunctions = new HashSet<FörfattareBöckerJunction>();
            LagerSaldos = new HashSet<LagerSaldo>();
            OrderDetaljers = new HashSet<OrderDetaljer>();
        }

        public string Isbn13 { get; set; }
        public string Titel { get; set; }
        public string Språk { get; set; }
        public decimal? Pris { get; set; }
        public DateTime? Utgivningsdatum { get; set; }
        public int FörlagId { get; set; }

        public virtual Förlag Förlag { get; set; }
        public virtual ICollection<FörfattareBöckerJunction> FörfattareBöckerJunctions { get; set; }
        public virtual ICollection<LagerSaldo> LagerSaldos { get; set; }
        public virtual ICollection<OrderDetaljer> OrderDetaljers { get; set; }
    }
}
