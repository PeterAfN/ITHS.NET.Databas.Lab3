using System;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewDeleteAuthor
    {

        Button ButtonDelete { get; set; }
        Button ButtonClose { get; set; }
        Label LabelLog { get; set; }
        ComboBox ComboBoxDeleteAuthor { get; set; }

        void Hide();

        DialogResult ShowDialog();

        event EventHandler<EventArgs> AuthorDeletedFromDatabase;
        void TriggerEventAuthorDeletedFromDatabase(object sender, EventArgs e);
    }
}
