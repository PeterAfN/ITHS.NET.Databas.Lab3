using System.Collections.Generic;
using System.Linq;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public class SqlData
    {
        public ICollection<Butiker> Butiker { get; set; }
        public ICollection<Böcker> Böcker { get; set; }
        public ICollection<LagerSaldo> LagerSaldo { get; set; }
        public ICollection<FörfattareBöckerJunction> FörfattareBöckerJunction { get; set; }
        public ICollection<Författare> Författare { get; set; }
        public ICollection<Förlag> Förlag { get; set; }

        public void Update()
        {
            using var db = new Bokhandel_Lab2Context();
            if (db.Database.CanConnect())
            {
                Böcker = db.Böcker.ToList();
                Butiker = db.Butiker.ToList();
                LagerSaldo = db.LagerSaldon.ToList();
                FörfattareBöckerJunction = db.FörfattareBöckerJunction.ToList();
                Författare = db.Författare.ToList();
                Förlag = db.Förlag.ToList();
                db.ChangeTracker.Clear();
            }
        }
    }
}
