using System;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewMain
    {
        event EventHandler Load;

        void AddControls();

        ToolStripMenuItem ToolStripMenuItemAddBook { get; set; }
        ToolStripMenuItem ToolStripMenuItemAddAuthor { get; set; }
        ToolStripMenuItem ToolStripMenuItemDeleteAuthor { get; set; }
        ToolStripMenuItem ToolStripMenuItemExit { get; set; }
        Label LabelLog { get; set; }

        void Activate();
    }
}
