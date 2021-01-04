using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewDetails
    {
        DataGridView DataGridViewDetailsBookstore { get; set; }
        DataGridView DataGridViewDetailsBook { get; set; }

        event EventHandler _DataGridViewDetailsBook_SelectionChanged;
        event EventHandler _DataGridViewDetailsBookstore_SelectionChanged;
    }
}

