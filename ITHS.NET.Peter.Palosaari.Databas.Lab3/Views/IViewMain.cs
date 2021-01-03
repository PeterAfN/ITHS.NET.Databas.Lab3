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

        void AddControls();
    }
}
