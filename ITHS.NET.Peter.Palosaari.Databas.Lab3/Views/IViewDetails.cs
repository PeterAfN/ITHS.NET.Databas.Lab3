using ITHS.NET.Peter.Palosaari.Databas.Lab3.CustomEventArgs;
using System;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewDetails
    {
        DataGridView DGVBookstore { get; set; }
        DataGridView DGVBook { get; set; }

        event EventHandler Load;
        event EventHandler<DetailsChangedEventArgs> DataGridViewUpdated;

        void TriggerEventDataGridViewUpdated(object sender, DetailsChangedEventArgs e);
    }
}

