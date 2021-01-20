using System;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.CustomEventArgs
{
    public class DetailsChangedEventArgs : EventArgs
    {
        public int IndexSelectedChildNode { get; set; } = -1; //-1 = no childnode is selected.
        public int IndexSelectedParentNode { get; set; }
    }
}
