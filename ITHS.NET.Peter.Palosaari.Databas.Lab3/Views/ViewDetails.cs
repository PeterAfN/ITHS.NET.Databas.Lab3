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

        }

        public DataGridView DataGridView
        {
            get { return dataGridView1; }
            set { dataGridView1 = value; }
        }


    }
}
