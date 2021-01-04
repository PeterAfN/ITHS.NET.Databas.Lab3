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


        public DataGridView DataGridViewDetailsBookstore
        {
            get { return dataGridViewDetailsBookstore; }
            set { dataGridViewDetailsBookstore = value; }
        }

        public DataGridView DataGridViewDetailsBook
        {
            get { return dataGridViewDetailsBook; }
            set { dataGridViewDetailsBook = value; }
        }


        private void CreateEvents()
        {
            dataGridViewDetailsBookstore.SelectionChanged += DataGridViewDetailsBookstore_SelectionChanged;
            DataGridViewDetailsBook.SelectionChanged += DataGridViewDetailsBook_SelectionChanged;
        }


        public event EventHandler _DataGridViewDetailsBook_SelectionChanged;

        private void DataGridViewDetailsBook_SelectionChanged(object sender, EventArgs e)
        {
            _DataGridViewDetailsBook_SelectionChanged?.Invoke(DataGridViewDetailsBook, e);
        }

        public event EventHandler _DataGridViewDetailsBookstore_SelectionChanged;

        private void DataGridViewDetailsBookstore_SelectionChanged(object sender, EventArgs e)
        {
            _DataGridViewDetailsBookstore_SelectionChanged?.Invoke(DataGridViewDetailsBookstore, e);
        }
    }
}
