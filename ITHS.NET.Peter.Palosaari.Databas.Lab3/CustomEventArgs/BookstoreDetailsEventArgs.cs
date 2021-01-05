using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.CustomEventArgs
{
    class BookstoreDetailsEventArgs
    {
        public LagerSaldo LagerSaldo { get; set; }

        public BookstoreDetailsEventArgs(LagerSaldo LagerSaldo)
        {
            this.LagerSaldo = LagerSaldo;
        }
    }
}
