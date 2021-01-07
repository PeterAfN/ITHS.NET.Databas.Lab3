using System.Collections.Generic;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class Författare
    {
        public Författare()
        {
            FörfattareBöckerJunctions = new HashSet<FörfattareBöckerJunction>();
        }

        public int Id { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Födelsedatum { get; set; }

        public virtual ICollection<FörfattareBöckerJunction> FörfattareBöckerJunctions { get; set; }
    }
}
