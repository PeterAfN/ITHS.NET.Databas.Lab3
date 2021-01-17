using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewNewAuthor
    {
        event EventHandler Load;

        void Hide();
        void Initialize();

        DialogResult ShowDialog();

        DataGridView DGVNewAuthor { get; set; }
        Label LabelLog { get; set; }
        Button ButtonAdd { get; set; }
        Button ButtonClose { get; set; }

        event EventHandler<EventArgs> NewAuthorSavedToDatabase;
        void TriggerEventNewAuthorSavedToDatabase(object sender, EventArgs e);
    }
}
