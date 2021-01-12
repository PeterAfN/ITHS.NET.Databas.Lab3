using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public partial class ViewNewBook : Form, IViewNewBook
    {
        public ViewNewBook()
        {
            InitializeComponent();        
        }

        public DataGridView DGVNewBook
        {
            get { return dgvNewBook; }
            set { dgvNewBook = value; }
        }

    }
}
