using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
    class PresenterBookstores
    {
        private readonly IViewMain viewMain;
        private readonly IViewBookstores viewBookstores;
        private readonly IViewDetails viewDetails;

        public PresenterBookstores(IViewMain viewMain, IViewBookstores viewBookstores, IViewDetails viewDetails)
        {
            this.viewMain = viewMain;
            this.viewBookstores = viewBookstores;
            this.viewDetails = viewDetails;

            this.viewBookstores.Load += ViewBookstores_Load;
        }

        private void ViewBookstores_Load(object sender, EventArgs e)
        {

            viewBookstores.TreeViewBookstores.ExpandAll();
            viewBookstores.TreeViewBookstores.SelectedNode = viewBookstores.TreeViewBookstores.Nodes[0];
            viewBookstores.TreeViewBookstores.SelectedNode.EnsureVisible();

            viewBookstores.TreeViewBookstores.Focus();
            //treeView.Nodes[0].FirstNode.Collapse();
            //treeView.Nodes[4].FirstNode.Collapse();
        }
    }
}
