using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class ViewMain : Form, IViewMain
    {
        private ViewTreeView viewBookstores;
        private ViewDetails viewDetails;
        private ViewNewBook viewNewBook;
        private ViewNewAuthor viewNewAuthor;
        private ViewDeleteAuthor viewDeleteAuthor;

        public ViewMain(ViewTreeView viewBookstores, 
            ViewDetails viewDetails,
            ViewNewBook viewNewBook,
            ViewNewAuthor viewNewAuthor,
            ViewDeleteAuthor viewDeleteAuthor
            )
        {
            InitializeComponent();

            this.viewBookstores = viewBookstores;
            this.viewDetails = viewDetails;
            this.viewNewBook = viewNewBook;
            this.viewNewAuthor = viewNewAuthor;
            this.viewDeleteAuthor = viewDeleteAuthor;

            AddControls();
        }

        public void AddControls()
        {
            splitContainerMain.Panel1.Controls.Add(viewBookstores);
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

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
    }
}
