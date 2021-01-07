using ITHS.NET.Peter.Palosaari.Databas.Lab3.CustomEventArgs;
using System;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewDetails
    {
        DataGridView DGVDetailsBookstore { get; set; }
        DataGridView DGVDetailsBook { get; set; }

        event EventHandler Load;
        event EventHandler<BookstoreEventArgs> BookstoreDatabaseUpdated;
        event EventHandler<BookEventArgs> BookDatabaseUpdated;

        void TriggerEventBookstoreDatabaseUpdated(object sender, BookstoreEventArgs e);
        void TriggerEventBookDatabaseUpdated(object sender, BookEventArgs e);
    }
}

