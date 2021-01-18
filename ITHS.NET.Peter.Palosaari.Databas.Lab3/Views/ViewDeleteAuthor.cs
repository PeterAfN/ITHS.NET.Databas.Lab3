using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public partial class ViewDeleteAuthor : Form, IViewDeleteAuthor
    {
        public ViewDeleteAuthor()
        {
            InitializeComponent();
        }

        public Button ButtonDelete
        {
            get { return buttonDelete; }
            set { buttonDelete = value; }
        }

        public Button ButtonClose
        {
            get { return buttonClose; }
            set { buttonClose = value; }
        }

        public Label LabelLog
        {
            get { return labelLog; }
            set { labelLog = value; }
        }

        public ComboBox ComboBoxDeleteAuthor
        {
            get { return comboBoxDeleteAuthor; }
            set { comboBoxDeleteAuthor = value; }
        }

        public event EventHandler<EventArgs> AuthorDeletedFromDatabase;

        /// <summary>
        /// This event is triggered after a user has successfully saved a book to the sql server database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TriggerEventAuthorDeletedFromDatabase(object sender, EventArgs e)
        {
            AuthorDeletedFromDatabase.Invoke(this, e);
        }
    }
}
