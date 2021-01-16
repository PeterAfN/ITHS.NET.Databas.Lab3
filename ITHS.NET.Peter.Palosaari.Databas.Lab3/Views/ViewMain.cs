using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class ViewMain : Form, IViewMain
    {
        private ViewTreeView viewBookstores;
        private ViewDetails viewDetails;
        private ViewNewBook viewNewBook;

        public ViewMain(ViewTreeView viewBookstores, 
            ViewDetails viewDetails,
            ViewNewBook viewNewBook)
        {
            InitializeComponent();

            this.viewBookstores = viewBookstores;
            this.viewDetails = viewDetails;
            this.viewNewBook = viewNewBook;

            AddControls();
        }

        public void AddControls()
        {
            splitContainerMain.Panel1.Controls.Add(viewBookstores);
            splitContainerMain.Panel2.Controls.Add(viewDetails);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
