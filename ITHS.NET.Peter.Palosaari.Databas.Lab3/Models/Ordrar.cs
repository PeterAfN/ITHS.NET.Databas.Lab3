using System;
using System.Collections.Generic;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class Ordrar
    {
        public Ordrar()
        {
            OrderDetaljer = new HashSet<OrderDetaljer>();
        }

        public int Id { get; set; }
        public int ButikId { get; set; }
        public string KundId { get; set; }
        public string Datum { get; set; }
        public string FörsäljarId { get; set; }
        public double? Fraktavgift { get; set; }
        public string Adress { get; set; }
        public string Stad { get; set; }
        public string Region { get; set; }
        public string Postnummer { get; set; }
        public string Land { get; set; }

        public virtual Butiker Butiker { get; set; }
        public virtual Kunder Kunder { get; set; }
        public virtual ICollection<OrderDetaljer> OrderDetaljer { get; set; }
    }
}
