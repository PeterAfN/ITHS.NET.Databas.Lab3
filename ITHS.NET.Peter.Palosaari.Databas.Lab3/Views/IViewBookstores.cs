using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewBookstores
    {
        System.Windows.Forms.TreeView TreeViewBookstores { get; set; }

        event EventHandler Load;
    }
}
