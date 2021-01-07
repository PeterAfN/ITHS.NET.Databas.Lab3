#nullable disable

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class FörfattareBöckerJunction
    {
        public int FörfattareId { get; set; }
        public string BokId { get; set; }

        public virtual Böcker Böcker { get; set; }
        public virtual Författare Författare { get; set; }
    }
}
