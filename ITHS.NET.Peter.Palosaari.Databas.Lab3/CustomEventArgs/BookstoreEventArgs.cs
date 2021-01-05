using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.CustomEventArgs
{
    class BookstoreEventArgs
    {
        public Butiker Butik { get; set; }

        public BookstoreEventArgs(Butiker Butik)
        {
            this.Butik = Butik;
        }
    }
}
