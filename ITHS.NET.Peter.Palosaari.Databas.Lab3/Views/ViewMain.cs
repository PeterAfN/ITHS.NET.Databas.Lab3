using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class ViewMain : Form, IViewMain
    {
        private ViewBookstores viewBookstores;
        private ViewDetails viewDetails;

        public ViewMain(ViewBookstores viewBookstores, ViewDetails viewDetails)
        {
            InitializeComponent();

            this.viewBookstores = viewBookstores;
            this.viewDetails = viewDetails;
        }

        public void AddControls()
        {
            splitContainerMain.Panel1.Controls.Add(viewBookstores);
            splitContainerMain.Panel2.Controls.Add(viewDetails);
        }

        public void AddNodesToTreeview(ICollection<Butiker> bookstores)
        {
            foreach (Butiker bookstore in bookstores)
            {
                TreeNode bookstoreNode = new TreeNode($"{bookstore.Namn}");

                foreach (LagerSaldo lagerSaldo in bookstore.LagerSaldon)
                {
                    TreeNode lagerSaldoNode = 
                        new TreeNode($"\"{lagerSaldo.IsbnNavigation.Titel}\" x {lagerSaldo.Antal} st.");
                    bookstoreNode.Nodes.Add(lagerSaldoNode);
                }
                viewBookstores.TreeViewBookstores.Nodes.Add(bookstoreNode);
            }
        }
    }
}
