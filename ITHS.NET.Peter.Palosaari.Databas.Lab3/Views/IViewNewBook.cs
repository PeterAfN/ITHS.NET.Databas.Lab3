using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewNewBook
    {
        event EventHandler Load;

        void Hide();

        DialogResult ShowDialog();

        void Initialize();

        DataGridView DGVNewBook { get; set; }
        Label LabelLog { get; set; }
        Button ButtonAdd { get; set; }
        Button ButtonClose { get; set; }

        event EventHandler<EventArgs> NewBookSavedToDatabase;

        void TriggerEventNewBookSavedToDatabase(object sender, EventArgs e);
    }
}
