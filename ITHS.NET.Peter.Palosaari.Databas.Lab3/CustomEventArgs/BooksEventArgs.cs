using System;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.CustomEventArgs
{
    public class BookEventArgs : EventArgs
    {
        //public LagerSaldo LagerSaldo { get; set; }

        public object TableType { get; set; }

        public int IndexSelectedChildNode { get; set; } = -1; //value of -1 means no childnode is selected.
        public int IndexSelectedParentNode { get; set; }

        public BookEventArgs(object TableType)
        {
            this.TableType = TableType;
        }
    }
}
