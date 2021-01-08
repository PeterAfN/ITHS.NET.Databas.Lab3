using ITHS.NET.Peter.Palosaari.Databas.Lab3.CustomEventArgs;
using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
    class PresenterTreeView
    {
        #region Native Methods - Win32
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetScrollPos(IntPtr hWnd, int nBar);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int SetScrollPos(IntPtr hWnd, int nBar, int nPos, bool bRedraw);

        private const int SB_HORZ = 0x0;
        private const int SB_VERT = 0x1;

        private Point GetTreeViewScrollPos(TreeView treeView)
        {
            return new Point(
                GetScrollPos(treeView.Handle, SB_HORZ),
                GetScrollPos(treeView.Handle, SB_VERT));
        }

        private void SetTreeViewScrollPos(TreeView treeView, Point scrollPosition)
        {
            SetScrollPos((IntPtr)treeView.Handle, SB_HORZ, scrollPosition.X, true);
            SetScrollPos((IntPtr)treeView.Handle, SB_VERT, scrollPosition.Y, true);
        }
        #endregion Native Methods - Win32

        private readonly IViewMain viewMain;
        private readonly IViewTreeView viewTreeView;
        private readonly IViewDetails viewDetails;

        public PresenterTreeView(IViewMain viewMain, IViewTreeView viewBookstores, IViewDetails viewDetails)
        {
            this.viewMain = viewMain;
            this.viewTreeView = viewBookstores;
            this.viewDetails = viewDetails;
            this.viewTreeView.Load += ViewBookstores_Load;
        }


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
            SelectTreeviewNode(0);
            viewDetails.DataGridViewUpdated += ViewDetails_DataGridViewUpdated;
        }

        void SelectTreeviewNode(int parentNode, int childNode = -1)
        {
            viewTreeView.TreeView.ExpandAll();
            if (childNode == -1)
                viewTreeView.TreeView.SelectedNode = viewTreeView.TreeView.Nodes[parentNode];
            else
                viewTreeView.TreeView.SelectedNode = viewTreeView.TreeView.Nodes[parentNode].Nodes[childNode];
            viewTreeView.TreeView.SelectedNode.EnsureVisible();
            viewTreeView.TreeView.Focus();
        }

        private void ViewDetails_DataGridViewUpdated(object sender, DetailsChangedEventArgs e)
        {
            viewTreeView.TreeView.BeginUpdate();
            Point ScrollPos = GetTreeViewScrollPos(viewTreeView.TreeView);

            viewTreeView.PreventEvent = true;
            GetDataFromDatabase();
            AddNodesToTreeview(Butiker);
            SelectTreeviewNode(e.IndexSelectedParentNode, e.IndexSelectedChildNode);
            viewTreeView.PreventEvent = false;

            SetTreeViewScrollPos(viewTreeView.TreeView, ScrollPos);
            viewTreeView.TreeView.EndUpdate();
        }

        private void GetDataFromDatabase()
        {
            using var db = new Bokhandel_Lab2Context();
            if (db.Database.CanConnect())
            {
                Debug.WriteLine("Connected to database.");
                Böcker = db.Böcker.ToList();
                Butiker = db.Butiker.ToList();
                LagerSaldo = db.LagerSaldon.ToList();
                FörfattareBöckerJunction = db.FörfattareBöckerJunction.ToList();
                Författare = db.Författare.ToList();
                Förlag = db.Förlag.ToList();
                db.ChangeTracker.Clear();
            }
            else Debug.WriteLine("Could not connect to database to read values");
        }

        public void AddNodesToTreeview(ICollection<Butiker> bookstores)
        {
            viewTreeView.TreeView.Nodes.Clear();
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
                viewTreeView.TreeView.Nodes.Add(bookstoreNode);
            }
        }
    }
}
