using System.Collections.Generic;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class Kunder
    {
        public Kunder()
        {
            Ordrar = new HashSet<Ordrar>();
        }

        public string Id { get; set; }
        public string Användarnamn { get; set; }
        public string Lösenord { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Epost { get; set; }
        public string Telefonnummer { get; set; }

        public virtual ICollection<Ordrar> Ordrar { get; set; }
    }
}
