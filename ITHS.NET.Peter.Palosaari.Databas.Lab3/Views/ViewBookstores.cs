using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public partial class ViewBookstores : UserControl, IViewBookstores
    {
        public ViewBookstores()
        {
            InitializeComponent();

            //var treeview = new CustomerOrdersTree() { Dock = DockStyle.Fill };
            //splitContainer1.Panel1.Controls.Add(treeview);
        }

        public TreeView TreeViewBookstores
        {
            get { return treeViewBookstores; }
            set { treeViewBookstores = value; }
        }
    }
}
