using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewMain
    {

        void AddNodesToTreeview(ICollection<Butiker> bookstores);

        event EventHandler Load;

        //Views.ViewBookstores ViewBookstores { get; set; }

        //public SplitContainer SplitContainerMain { get; set; }

        //void AddTreeview(ViewBookstores viewBookstores);

        void AddControls();
    }
}
