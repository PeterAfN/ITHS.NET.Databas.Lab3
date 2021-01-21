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

        public ICollection<Författare> GetAuthorsFromDatabase()
        {
            using var db = new Bokhandel_Lab2Context();
            {
                if (db.Database.CanConnect())
                {
                    ICollection<Författare> output = new List<Författare>();
                    foreach (Författare f in db.Författare)
                    {
                        output.Add(f);
                    }
                    return output;
                }
                else return null;
            }
        }

        public ICollection<FörfattareBöckerJunction> GetAuthorBookJunctionFromDatabase()
        {
            using var db = new Bokhandel_Lab2Context();
            {
                if (db.Database.CanConnect())
                {
                    ICollection<FörfattareBöckerJunction> output = new List<FörfattareBöckerJunction>();
                    foreach (FörfattareBöckerJunction f in db.FörfattareBöckerJunction)
                    {
                        output.Add(f);
                    }
                    return output;
                }
                else return null;
            }
        }

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
