using System;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewNewBook
    {
        event EventHandler Load;

        void Hide();
        void Initialize();

        DialogResult ShowDialog();

        DataGridView DGVNewBook { get; set; }
        Label LabelLog { get; set; }
        Button ButtonAdd { get; set; }
        Button ButtonClose { get; set; }

        event EventHandler<EventArgs> NewBookSavedToDatabase;
        void TriggerEventNewBookSavedToDatabase(object sender, EventArgs e);
    }
}
