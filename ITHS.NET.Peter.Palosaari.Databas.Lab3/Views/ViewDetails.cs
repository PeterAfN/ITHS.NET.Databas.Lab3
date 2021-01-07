using ITHS.NET.Peter.Palosaari.Databas.Lab3.CustomEventArgs;
using System;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public partial class ViewDetails : UserControl, IViewDetails
    {
        public ViewDetails()
        {
            InitializeComponent();
        }


        public DataGridView DGVDetailsBookstore
        {
            get { return dgvDetailsBookstore; }
            set { dgvDetailsBookstore = value; }
        }

        public DataGridView DGVDetailsBook
        {
            get { return dgvDetailsBook; }
            set { dgvDetailsBook = value; }
        }


        public event EventHandler<BookstoreEventArgs> BookstoreDatabaseUpdated;

        /// <summary>
        /// This event is triggered after a user has updated a datagrid cell value 
        /// and after the value has been saved to the sql server database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TriggerEventBookstoreDatabaseUpdated(object sender, BookstoreEventArgs e)
        {
            BookstoreDatabaseUpdated.Invoke(this, e);
        }

        public event EventHandler<BookEventArgs> BookDatabaseUpdated;

        public void TriggerEventBookDatabaseUpdated(object sender, BookEventArgs e)
        {
            BookDatabaseUpdated.Invoke(this, e);
        }

        private void dgvDetailsBookstore_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDetailsBookstore_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }
    }
}
