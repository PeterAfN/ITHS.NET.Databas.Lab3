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
            CreateEvents();
        }

        private void CreateEvents()
        {
            treeViewBookstores.AfterSelect += TreeViewBookstores_AfterSelect;
        }


        public event TreeViewEventHandler _TreeViewBookstores_AfterSelect;

        private void TreeViewBookstores_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _TreeViewBookstores_AfterSelect?.Invoke(TreeViewBookstores, e);
        }


        public TreeView TreeViewBookstores
        {
            get { return treeViewBookstores; }
            set { treeViewBookstores = value; }
        }
    }
}
