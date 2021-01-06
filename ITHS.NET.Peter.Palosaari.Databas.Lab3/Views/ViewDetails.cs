using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public partial class ViewDetails : UserControl, IViewDetails
    {
        public ViewDetails()
        {
            InitializeComponent();
            CreateEvents();
        }


        public DataGridView DGVDetailsBookstore
        {
            get { return dgvDetailsBookstore; }
            set { dgvDetailsBookstore = value; }
        }

        public DataGridView DGVDetailsBook
        {
            get { return dgvDetailsBook; }
            set { dgvDetailsBook = value; }
        }


        private void CreateEvents()
        {
            DGVDetailsBookstore.SelectionChanged += DGVDetailsBookstore_SelectionChanged;
            DGVDetailsBook.SelectionChanged += DGVDetailsBook_SelectionChanged;
            DGVDetailsBookstore.CellValueChanged += DGVDetailsBookstore_CellValueChanged;
            DGVDetailsBook.CellValueChanged += DGVDetailsBook_CellValueChanged;
        }

        public event DataGridViewCellEventHandler _DGVDetailsBook_CellValueChanged;

        private void DGVDetailsBook_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _DGVDetailsBook_CellValueChanged?.Invoke(DGVDetailsBook, e);
        }

        public event DataGridViewCellEventHandler _DGVDetailsBookstore_CellValueChanged;

        private void DGVDetailsBookstore_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _DGVDetailsBookstore_CellValueChanged?.Invoke(DGVDetailsBookstore, e);
        }

        public event EventHandler _DGVDetailsBook_SelectionChanged;

        private void DGVDetailsBook_SelectionChanged(object sender, EventArgs e)
        {
            _DGVDetailsBook_SelectionChanged?.Invoke(DGVDetailsBook, e);
        }

        public event EventHandler _DGVDetailsBookstore_SelectionChanged;

        private void DGVDetailsBookstore_SelectionChanged(object sender, EventArgs e)
        {
            _DGVDetailsBookstore_SelectionChanged?.Invoke(DGVDetailsBookstore, e);
        }
    }
}
