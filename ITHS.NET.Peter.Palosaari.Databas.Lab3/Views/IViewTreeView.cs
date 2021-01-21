using System;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewTreeView
    {
        TreeView TreeView { get; set; }

        ContextMenuStrip ContextMenuStripTreeView { get; set; }

        event EventHandler Load;
        event TreeViewEventHandler TreeViewAfterSelect;

        bool PreventEvent { get; set; }
    }
}
