using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public partial class ViewNewAuthor : Form, IViewNewAuthor
    {
        public ViewNewAuthor()
        {
            Initialize();
        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public DataGridView DGVNewAuthor
        {
            get { return dgvNewAuthor; }
            set { dgvNewAuthor = value; }
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

        public event EventHandler<EventArgs> NewAuthorSavedToDatabase;

        /// <summary>
        /// This event is triggered after a user has successfully saved an author to the sql server database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TriggerEventNewAuthorSavedToDatabase(object sender, EventArgs e)
        {
            NewAuthorSavedToDatabase?.Invoke(this, e);
        }
    }
}
