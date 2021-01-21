using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class ViewMain : Form, IViewMain
    {
        private readonly ViewTreeView viewTreeView;
        private readonly ViewDetails viewDetails;

        public ViewMain(ViewTreeView viewTreeView, ViewDetails viewDetails)
        {
            InitializeComponent();

            this.viewTreeView = viewTreeView;
            this.viewDetails = viewDetails;

            AddControls();
        }

        public void AddControls()
        {
            splitContainerMain.Panel1.Controls.Add(viewTreeView);
            splitContainerMain.Panel2.Controls.Add(viewDetails);
            viewDetails.BringToFront();
        }

        public ToolStripMenuItem ToolStripMenuItemAddBook
        {
            get { return toolStripMenuItemAddBook; }
            set { toolStripMenuItemAddBook = value; }
        }

        public ToolStripMenuItem ToolStripMenuItemAddAuthor
        {
            get { return toolStripMenuItemAddAuthor; }
            set { toolStripMenuItemAddAuthor = value; }
        }

        public ToolStripMenuItem ToolStripMenuItemDeleteAuthor
        {
            get { return toolStripMenuItemDeleteAuthor; }
            set { toolStripMenuItemDeleteAuthor = value; }
        }

        public ToolStripMenuItem ToolStripMenuItemExit
        {
            get { return toolStripMenuItemExit; }
            set { toolStripMenuItemExit = value; }
        }

        public Label LabelLog
        {
            get { return labelLog; }
            set { labelLog = value; }
        }
    }
}
