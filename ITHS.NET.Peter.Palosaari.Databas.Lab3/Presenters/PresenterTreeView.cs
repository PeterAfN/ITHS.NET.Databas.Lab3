﻿using ITHS.NET.Peter.Palosaari.Databas.Lab3.CustomEventArgs;
using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
    class PresenterTreeView
    {
        private readonly IViewMain viewMain;
        private readonly IViewTreeView viewTreeView;
        private readonly IViewDetails viewDetails;
        private readonly IViewNewBook viewNewBook;
        private readonly IViewDeleteAuthor viewDeleteAuthor;
        private readonly SqlData sqlData;

        public PresenterTreeView(IViewMain viewMain,
            IViewTreeView viewTreeView,
            IViewDetails viewDetails,
            IViewNewBook viewNewBook,
            IViewDeleteAuthor viewDeleteAuthor)
        {
            this.viewMain = viewMain;
            this.viewTreeView = viewTreeView;
            this.viewDetails = viewDetails;
            this.viewNewBook = viewNewBook;
            this.viewDeleteAuthor = viewDeleteAuthor;

            this.viewTreeView.Load += ViewBookstores_Load;

            sqlData = new SqlData();
        }

        private string IDCurrentSelectedBook { get; set; }

        private void ViewBookstores_Load(object sender, EventArgs e)
        {
            sqlData.Update();
            AddNodesToTreeview(sqlData.Butiker);
            viewMain.AddControls();
            SelectTreeviewNode(0);
            viewDetails.DataGridViewUpdated += ViewDetails_DataGridViewUpdated;
            viewTreeView.TreeView.MouseUp += TreeView_MouseUp;
            viewTreeView.TreeView.MouseDown += TreeView_MouseDown;
            viewNewBook.NewBookSavedToDatabase += ViewNewBook_NewBookSavedToDatabase;
            viewTreeView.ContextMenuStripTreeView.ItemClicked += ContextMenuStripTreeView_ItemClicked;
            viewTreeView.TreeViewAfterSelect += ViewTreeView__TreeView_AfterSelect;
            viewDeleteAuthor.AuthorDeletedFromDatabase += ViewDeleteAuthor_AuthorDeletedFromDatabase;
            viewTreeView.TreeView.BeforeCollapse += TreeView_BeforeCollapse;
        }

        private void TreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e) => e.Cancel = true;

        private void ViewDeleteAuthor_AuthorDeletedFromDatabase(object sender, EventArgs e)
        {
            DetailsChangedEventArgs args = new DetailsChangedEventArgs();

            if (viewTreeView.TreeView.SelectedNode.Parent == null)
                args.IndexSelectedParentNode = viewTreeView.TreeView.SelectedNode.Index;
            else
            {
                args.IndexSelectedChildNode = viewTreeView.TreeView.SelectedNode.Index;
                args.IndexSelectedParentNode = viewTreeView.TreeView.SelectedNode.Parent.Index;
            }
            UpdateTreeviewWithNewData(sender, args);
        }

        private void ViewTreeView__TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (viewTreeView.TreeView?.SelectedNode?.Parent != null)
                if (e.Node.Tag is LagerSaldo selectedLagerSaldo)
                    IDCurrentSelectedBook = selectedLagerSaldo.Isbn.ToString();
        }

        private void ContextMenuStripTreeView_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() != "Delete Book") return;

            var bookTitle = from Match match in Regex.Matches(viewTreeView.TreeView.SelectedNode.Text, "\".*?\"")
                            select match.ToString();
            viewTreeView.ContextMenuStripTreeView.Close();
            DialogResult resultQuestion =
                MessageBox.Show($"Do you want to delete the book {bookTitle.FirstOrDefault()} ? \n\n" +
                $"(The book will be removed from all bookstores)",
                "Delete confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (resultQuestion == DialogResult.OK)
            {
                using var db = new Bokhandel_Lab2Context();
                using var dbContextTransaction = db.Database.BeginTransaction();
                try
                {
                    db.Database.ExecuteSqlInterpolated($"DELETE FROM dbo.LagerSaldo WHERE ISBN = ({IDCurrentSelectedBook})");               // 1. delete book from table 'LagerSaldo'
                    db.SaveChanges();

                    db.Database.ExecuteSqlInterpolated($"DELETE FROM FörfattareBöcker_Junction WHERE BokID = ({IDCurrentSelectedBook})");   // 2. delete book from table 'FörfattareBöcker_Junction'
                    db.SaveChanges();

                    db.Database.ExecuteSqlInterpolated($"DELETE FROM OrderDetaljer WHERE ProduktId = ({IDCurrentSelectedBook})");           // 3. delete book from table 'OrderDetaljer'
                    db.SaveChanges();

                    var böcker = db.Böcker.FirstOrDefault(b => b.Isbn13 == IDCurrentSelectedBook);
                    db.Böcker.Remove(böcker);                                                                                               // 4. delete book from table 'böcker'
                    db.SaveChanges();
                    dbContextTransaction.Commit();

                    ViewNewBook_NewBookSavedToDatabase(this, EventArgs.Empty);
                    string logText = "Save ok.";
                    _ = ShowLogTextAsync(logText, Color.Green, 5000);
                }
                catch (Exception)
                {
                    string logText = "Error while saving.";
                    _ = ShowLogTextAsync(logText, Color.Red, 5000);
                }
            }
        }

        private async Task ShowLogTextAsync(string infoText, Color color, int showTime)
        {
            viewMain.LabelLog.Text = infoText;
            viewMain.LabelLog.ForeColor = color;
            viewMain.LabelLog.Visible = true;
            await Task.Delay(showTime);
            viewMain.LabelLog.Visible = false;
        }

        private void ViewNewBook_NewBookSavedToDatabase(object sender, EventArgs e)
        {
            DetailsChangedEventArgs args = new DetailsChangedEventArgs();

            if (viewTreeView.TreeView.SelectedNode.Parent == null)
                args.IndexSelectedParentNode = viewTreeView.TreeView.SelectedNode.Index;
            else
            {
                args.IndexSelectedChildNode = viewTreeView.TreeView.SelectedNode.Index;
                args.IndexSelectedParentNode = viewTreeView.TreeView.SelectedNode.Parent.Index;
            }
            UpdateTreeviewWithNewData(sender, args);
        }

        private void TreeView_MouseDown(object sender, MouseEventArgs e)
        {
            viewTreeView.TreeView.MouseDown += (sender, args) =>
                viewTreeView.TreeView.SelectedNode =
                viewTreeView.TreeView.GetNodeAt(args.X, args.Y);
        }

        private void TreeView_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    if (viewTreeView.TreeView.SelectedNode.Parent == null)
                        viewTreeView.ContextMenuStripTreeView.Items[0].Enabled = false;
                    else viewTreeView.ContextMenuStripTreeView.Items[0].Enabled = true;
                    viewTreeView.ContextMenuStripTreeView.Show(
                        new Point(Control.MousePosition.X + 25, Control.MousePosition.Y + 20));
                    break;
            }
        }

        void SelectTreeviewNode(int parentNode, int childNode = -1)
        {
            viewTreeView.TreeView.ExpandAll();
            if (childNode == -1)
            {
                viewTreeView.TreeView.SelectedNode = viewTreeView.TreeView.Nodes[parentNode];
                viewTreeView.TreeView?.SelectedNode?.EnsureVisible();
                viewTreeView.TreeView?.Focus();
            }
            else if (viewTreeView?.TreeView?.Nodes[parentNode]?.Nodes.Count != 0)
            {
                if (childNode < viewTreeView?.TreeView?.Nodes[parentNode]?.Nodes.Count)
                    viewTreeView.TreeView.SelectedNode = viewTreeView?.TreeView?.Nodes[parentNode]?.Nodes[childNode];
            }
        }

        private void ViewDetails_DataGridViewUpdated(object sender, DetailsChangedEventArgs e)
        {
            UpdateTreeviewWithNewData(sender, e);
        }

        private void UpdateTreeviewWithNewData(object sender, DetailsChangedEventArgs e)
        {
            viewTreeView.TreeView.BeginUpdate();

            Point ScrollPos = GetTreeViewScrollPos(viewTreeView.TreeView);
            viewTreeView.PreventEvent = true;
            sqlData.Update();
            AddNodesToTreeview(sqlData.Butiker);
            SelectTreeviewNode(e.IndexSelectedParentNode, e.IndexSelectedChildNode);
            viewTreeView.PreventEvent = false;
            SetTreeViewScrollPos(viewTreeView.TreeView, ScrollPos);

            viewTreeView.TreeView.EndUpdate();
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
    }
}
