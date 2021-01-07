using System.Collections.Generic;

#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class Förlag
    {
        public Förlag()
        {
            Böcker = new HashSet<Böcker>();
        }

        public int Id { get; set; }
        public string Namn { get; set; }
        public string Beskrivning { get; set; }
        public string Telefonnummer { get; set; }
        public string Epost { get; set; }

        public virtual ICollection<Böcker> Böcker { get; set; }
    }
}
