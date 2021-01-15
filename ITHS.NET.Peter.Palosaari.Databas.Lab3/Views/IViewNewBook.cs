using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewNewBook
    {

        event EventHandler Load;
        void Show();

        DataGridView DGVNewBook { get; set; }
        Label LabelLog { get; set; }
        Button ButtonAdd { get; set; }
        Button ButtonClose { get; set; }

    }
}
