using System;
using System.Collections.Generic;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class OrderDetaljer
    {
        public string ProduktId { get; set; }
        public int OrderId { get; set; }
        public double? ProduktPris { get; set; }
        public int? ProduktAntal { get; set; }
        public double? ProduktRabattProcent { get; set; }

        public virtual Ordrar Ordrar { get; set; }
        public virtual Böcker ISBN { get; set; }
    }
}
