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

        public DataGridView DGVBookstore
        {
            get { return dgvBookstore; }
            set { dgvBookstore = value; }
        }

        public DataGridView DGVBook
        {
            get { return dgvBook; }
            set { dgvBook = value; }
        }

        public event EventHandler<DetailsChangedEventArgs> DataGridViewUpdated;

        /// <summary>
        /// This event is triggered after a user has updated a datagrid cell value 
        /// and after the value has been saved to the sql server database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TriggerEventDataGridViewUpdated(object sender, DetailsChangedEventArgs e)
        {
            DataGridViewUpdated.Invoke(this, e);
        }
    }
}
