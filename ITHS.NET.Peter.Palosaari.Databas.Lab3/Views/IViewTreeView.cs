using System;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewTreeView
    {
        TreeView TreeView { get; set; }

        event EventHandler Load;
        event TreeViewEventHandler _TreeView_AfterSelect;

        bool PreventEvent { get; set; }
    }
}
