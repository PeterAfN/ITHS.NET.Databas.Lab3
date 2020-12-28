using System;
using System.Collections.Generic;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class Butiker
    {
        public Butiker()
        {
            LagerSaldon = new HashSet<LagerSaldo>();
            Ordrar = new HashSet<Ordrar>();
        }

        public int Id { get; set; }
        public string Namn { get; set; }
        public string Adress { get; set; }
        public int? Postnummer { get; set; }
        public string Stad { get; set; }
        public string Land { get; set; }

        public virtual ICollection<LagerSaldo> LagerSaldon { get; set; }
        public virtual ICollection<Ordrar> Ordrar { get; set; }
    }
}
