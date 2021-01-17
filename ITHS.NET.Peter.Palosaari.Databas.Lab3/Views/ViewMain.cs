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

        public ViewMain(ViewTreeView viewBookstores, 
            ViewDetails viewDetails,
            ViewNewBook viewNewBook,
            ViewNewAuthor viewNewAuthor)
        {
            InitializeComponent();

            this.viewBookstores = viewBookstores;
            this.viewDetails = viewDetails;
            this.viewNewBook = viewNewBook;
            this.viewNewAuthor = viewNewAuthor;

            AddControls();
        }

        public void AddControls()
        {
            splitContainerMain.Panel1.Controls.Add(viewBookstores);
            splitContainerMain.Panel2.Controls.Add(viewDetails);
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

        private void ViewMain_Load(object sender, System.EventArgs e)
        {

        }

        private void toolStripMenuItemAddBook_Click(object sender, System.EventArgs e)
        {

        }
    }
}
