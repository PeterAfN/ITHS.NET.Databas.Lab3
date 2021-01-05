using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using ITHS.NET.Peter.Palosaari.Databas.Lab3.CustomEventArgs;

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
            //this.viewBookstores._TreeViewBookstores_AfterSelect += ViewBookstores__TreeViewBookstores_AfterSelect;
        }

        //public event EventHandler<BookstoreEventArgs> OrderSelected;
        //public event EventHandler<BookstoreEventArgs> OrderDeleted;

        //private void ViewBookstores__TreeViewBookstores_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    Butiker butiker = null;

        //    if (e.Node.Tag is Butiker selectedOrder)
        //    {
        //        butiker = selectedOrder;
        //    }
        //    else if (e.Node.Tag is LagerSaldo)
        //    {
        //        if (e.Node.Parent.Tag is Butiker parentOrder)
        //        {
        //            butiker = parentOrder;
        //        }
        //    }

        //    if (butiker != null)
        //    {
        //        OrderSelected?.Invoke(this, new BookstoreEventArgs(butiker));
        //    }
        //}

        public ICollection<Butiker> Butiker { get; set; }
        public ICollection<Böcker> Böcker { get; set; }
        public ICollection<LagerSaldo> LagerSaldo { get; set; }
        public ICollection<FörfattareBöckerJunction> FörfattareBöckerJunction { get; set; }
        public ICollection<Författare> Författare { get; set; }
        public ICollection<Förlag> Förlag { get; set; }
        

        private void ViewBookstores_Load(object sender, EventArgs e)
        {
            GetDataFromDatabase();
            AddNodesToTreeview(Butiker);
            viewMain.AddControls();

            viewBookstores.TreeViewBookstores.ExpandAll();
            viewBookstores.TreeViewBookstores.SelectedNode = viewBookstores.TreeViewBookstores.Nodes[0];
            viewBookstores.TreeViewBookstores.SelectedNode.EnsureVisible();
            viewBookstores.TreeViewBookstores.Focus();
        }

        private void GetDataFromDatabase()
        {
            using (var db = new Bokhandel_Lab2Context())
            {
                if (db.Database.CanConnect())
                {
                    Debug.WriteLine("Connected to database.");
                    Böcker = db.Böcker.ToList();
                    Butiker = db.Butiker.ToList();
                    LagerSaldo = db.LagerSaldon.ToList();
                    FörfattareBöckerJunction = db.FörfattareBöckerJunction.ToList();
                    Författare = db.Författare.ToList();
                    Förlag = db.Förlag.ToList();
                }
                else Debug.WriteLine("Could not connect to database.");
            }
        }

        public void AddNodesToTreeview(ICollection<Butiker> bookstores)
        {
            foreach (Butiker bookstore in bookstores)
            {
                TreeNode bookstoreNode = new TreeNode()
                {
                    Text = $"{bookstore.Namn}",
                    Tag = bookstore
                };

                foreach (LagerSaldo lagerSaldo in bookstore.LagerSaldon)
                {
                    TreeNode lagerSaldoNode = new TreeNode()
                    {
                        Text = $"\"{lagerSaldo.IsbnNavigation.Titel}\" {lagerSaldo.Antal} st.",
                        Tag = lagerSaldo
                    };
                    bookstoreNode.Nodes.Add(lagerSaldoNode);
                }
                viewBookstores.TreeViewBookstores.Nodes.Add(bookstoreNode);
            }
        }
    }
}
