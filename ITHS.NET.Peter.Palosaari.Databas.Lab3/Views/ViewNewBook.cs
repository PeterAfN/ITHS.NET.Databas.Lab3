using System;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public partial class ViewNewBook : Form, IViewNewBook
    {
        public ViewNewBook()
        {
            Initialize();
        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public DataGridView DGVNewBook
        {
            get { return dgvNewBook; }
            set { dgvNewBook = value; }
        }

        public Label LabelLog
        {
            get { return labelLog; }
            set { labelLog = value; }
        }

        public Button ButtonAdd
        {
            get { return buttonAdd; }
            set { buttonAdd = value; }
        }

        public Button ButtonClose
        {
            get { return buttonClose; }
            set { buttonClose = value; }
        }

        public event EventHandler<EventArgs> NewBookSavedToDatabase;

        /// <summary>
        /// This event is triggered after a user has been successfully saved a book to the sql server database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TriggerEventNewBookSavedToDatabase(object sender, EventArgs e)
        {
            NewBookSavedToDatabase.Invoke(this, e);
        }
    }
}
