using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewDetails
    {
        DataGridView DGVDetailsBookstore { get; set; }
        DataGridView DGVDetailsBook { get; set; }

        event EventHandler Load;
        event EventHandler _DGVDetailsBook_SelectionChanged;
        event EventHandler _DGVDetailsBookstore_SelectionChanged;
        event DataGridViewCellEventHandler _DGVDetailsBook_CellValueChanged;
        event DataGridViewCellEventHandler _DGVDetailsBookstore_CellValueChanged;
    }
}

