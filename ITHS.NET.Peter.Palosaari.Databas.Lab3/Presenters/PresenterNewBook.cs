using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
    public class PresenterNewBook
    {
        Queue<DataGridViewComboBoxCell> cb = new Queue<DataGridViewComboBoxCell>(200);
        Dictionary<int, int> storedIDs = new Dictionary<int, int>();

        private readonly IViewMain viewMain;
        private readonly IViewTreeView viewTreeView;
        private readonly IViewDetails viewDetails;
        private readonly IViewNewBook viewNewBook;

        public PresenterNewBook(IViewMain viewMain, IViewTreeView viewTreeView, IViewDetails viewDetails, IViewNewBook viewNewBook)
        {
            this.viewMain = viewMain;
            this.viewTreeView = viewTreeView;
            this.viewDetails = viewDetails;
            this.viewNewBook = viewNewBook;

            viewTreeView.ContextMenuStripTreeView.ItemClicked += ContextMenuStripTreeView_ItemClicked;
            viewNewBook.DGVNewBook.EditingControlShowing += DGVNewBook_EditingControlShowing;
            viewNewBook.DGVNewBook.CellClick += DGVNewBook_CellClick;
            viewNewBook.DGVNewBook.CellContentClick += DGVNewBook_CellContentClick;
            viewNewBook.DGVNewBook.SelectionChanged += DGVNewBook_SelectionChanged;
            viewNewBook.DGVNewBook.DataError += DGVNewBook_DataError;
            viewNewBook.ButtonAdd.Click += ButtonAdd_Click;
            viewNewBook.ButtonClose.Click += ButtonClose_Click;
            viewNewBook.LabelLog.Text = string.Empty;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //using (var db2 = new Bokhandel_Lab2Context())
            //{
            //    using (var dbContextTransaction = db2.Database.BeginTransaction())
            //    {
            //        viewNewBook.DGVNewBook[0, 0].Value = "Isbn [Required, 13 digits]:";
            //        viewNewBook.DGVNewBook[0, 1].Value = "Title:";
            //        viewNewBook.DGVNewBook[0, 2].Value = "Language";
            //        viewNewBook.DGVNewBook[0, 3].Value = "Price";
            //        viewNewBook.DGVNewBook[0, 4].Value = "Release Date:";
            //        viewNewBook.DGVNewBook[0, 5].Value = "Publisher Id:";
            //        viewNewBook.DGVNewBook[0, 6].Value = "Publisher Name:";
            //        viewNewBook.DGVNewBook[0, 7].Value = "Publisher Description:";
            //        viewNewBook.DGVNewBook[0, 8].Value = "Publisher Phone Number:";
            //        viewNewBook.DGVNewBook[0, 9].Value = "Publisher Email:";

            //        // 1. save book to 'Böcker'

            //        var böcker = new Böcker { 
            //            Isbn13 = "William", 
            //            Titel = "Shakespeare",
            //            Språk
            //            Pris
            //            Utgivningsdatum
            //            FörlagId




            //        };


            //        // 2. save book and aouthors to FörfattareBöcker_Junction




            //        var JunctionFörfattareBöcker = db2.FörfattareBöckerJunction.FirstOrDefault(
            //        b => b.FörfattareId == författareId && b.BokId == viewDetails.DGVBook[1, 0].Value.ToString());

            //        db2.FörfattareBöckerJunction.Add(JunctionFörfattareBöcker);

            //        //context.Database. ExecuteSqlCommand(
            //        //    @"UPDATE Blogs SET Rating = 5" +
            //        //        " WHERE Name LIKE '%Entity Framework%'"
            //        //    );

            //        //var query = context.Posts.Where(p => p.Blog.Rating >= 5);
            //        //foreach (var post in query)
            //        //{
            //        //    post.Title += "[Cool Blog]";
            //        //}

            //        db2.SaveChanges();

            //        dbContextTransaction.Commit();
            //    }
            //}


            //using var db = new Bokhandel_Lab2Context();
            //if (db.Database.CanConnect())
            //{
            //    int.TryParse(viewDetails.DGVBook[1, e.RowIndex].Value.ToString(), out int författareId);
            //    var JunctionFörfattareBöcker = db.FörfattareBöckerJunction.FirstOrDefault(
            //    b => b.FörfattareId == författareId && b.BokId == viewDetails.DGVBook[1, 0].Value.ToString());
            //    db.FörfattareBöckerJunction.Remove(JunctionFörfattareBöcker);
            //    db.SavedChanges += Db_SavedChanges;
            //    db.SaveChangesFailed += Db_SaveChangesFailed;
            //    db.SaveChanges();

            //    viewDetails.DGVBook.Rows.RemoveAt(e.RowIndex + 3);
            //    viewDetails.DGVBook.Rows.RemoveAt(e.RowIndex + 2);
            //    viewDetails.DGVBook.Rows.RemoveAt(e.RowIndex + 1);
            //    viewDetails.DGVBook.Rows.RemoveAt(e.RowIndex);
            //    DetailsChangedEventArgs args = new DetailsChangedEventArgs();
            //    TriggerEvent(sender, args);
            //}

            //string logText = "The book has been added to the SQL database successfully. This window can be closed now.";
            //_ = ShowLogTextAsync(logText, Color.Green, 10000);
        }

        private async Task ShowLogTextAsync(string infoText, Color color, int showTime)
        {
            viewNewBook.LabelLog.Text = infoText;
            viewNewBook.LabelLog.ForeColor = color;
            viewNewBook.LabelLog.Visible = true;
            await Task.Delay(showTime);
            viewNewBook.LabelLog.Visible = false;
        }

        private void DGVNewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int authorId = 
                    GetIndexFromString(viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.CurrentRow.Index].Value.ToString());

                if (storedIDs.ContainsKey(authorId)) 
                    if (storedIDs.Remove(authorId)) 
                    {
                        viewNewBook.DGVNewBook.Rows.RemoveAt(e.RowIndex);
                        if (viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.RowCount - 1].Value.ToString() != "Click here to add an author")
                            AddRowActivateClickEvent(viewNewBook.DGVNewBook.RowCount);
                    }

                using var db = new Bokhandel_Lab2Context();
                if (db.Database.CanConnect())
                {
                    //int.TryParse(viewDetails.DGVBook[1, e.RowIndex].Value.ToString(), out int författareId);
                    //var JunctionFörfattareBöcker = db.FörfattareBöckerJunction.FirstOrDefault(
                    //b => b.FörfattareId == författareId && b.BokId == viewDetails.DGVBook[1, 0].Value.ToString());
                    //db.FörfattareBöckerJunction.Remove(JunctionFörfattareBöcker);
                    //db.SavedChanges += Db_SavedChanges;
                    //db.SaveChangesFailed += Db_SaveChangesFailed;
                    //db.SaveChanges();

                    //viewDetails.DGVBook.Rows.RemoveAt(e.RowIndex + 3);
                    //viewDetails.DGVBook.Rows.RemoveAt(e.RowIndex + 2);
                    //viewDetails.DGVBook.Rows.RemoveAt(e.RowIndex + 1);
                    //viewDetails.DGVBook.Rows.RemoveAt(e.RowIndex);
                    //DetailsChangedEventArgs args = new DetailsChangedEventArgs();
                    //TriggerEvent(sender, args);
                }
            }
        }

        private void DGVNewBook_SelectionChanged(object sender, EventArgs e)
        {
            if (viewNewBook?.DGVNewBook?.CurrentCell?.ColumnIndex == 0 || viewNewBook?.DGVNewBook?.CurrentCell?.ColumnIndex == 2)
                viewNewBook.DGVNewBook.CurrentCell.Selected = false;
        }

        private void ContextMenuStripTreeView_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            viewNewBook.DGVNewBook.Rows.Add(10);
            viewNewBook.DGVNewBook[0, 0].Value = "Isbn [Required, 13 digits]:";
            viewNewBook.DGVNewBook[0, 1].Value = "Title:";
            viewNewBook.DGVNewBook[0, 2].Value = "Language";
            viewNewBook.DGVNewBook[0, 3].Value = "Price";
            viewNewBook.DGVNewBook[0, 4].Value = "Release Date:";
            viewNewBook.DGVNewBook[0, 5].Value = "Publisher Id:";
            viewNewBook.DGVNewBook[0, 6].Value = "Publisher Name:";
            viewNewBook.DGVNewBook[0, 7].Value = "Publisher Description:";
            viewNewBook.DGVNewBook[0, 8].Value = "Publisher Phone Number:";
            viewNewBook.DGVNewBook[0, 9].Value = "Publisher Email:";
            viewNewBook.DGVNewBook.CurrentCell = viewNewBook.DGVNewBook.Rows[0].Cells[1];

            viewNewBook.DGVNewBook.Rows.Add(1);
            viewNewBook.DGVNewBook[0, 10].Value = "Author:";
            viewNewBook.DGVNewBook[1, 10].Value = "Optional: Click here to add an author";
            viewNewBook.Show();
        }

        private void DGVNewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (viewNewBook.DGVNewBook.CurrentCell.ColumnIndex == 1 && 
                viewNewBook.DGVNewBook.RowCount == viewNewBook.DGVNewBook.CurrentCell.RowIndex + 1)
            {
                viewNewBook.DGVNewBook.Columns[2].Visible = false;
                AddAuthorCell(viewNewBook.DGVNewBook.CurrentCell.RowIndex);
            }
        }

        DataGridViewComboBoxCell cB = new DataGridViewComboBoxCell();

        private void AddAuthorCell(int rowIndexNewCell)
        {
            cB.Items.Clear();
            var författare = GetDataFromDatabase();

            foreach (Författare f in författare)
            {
                if (!storedIDs.ContainsKey(f.Id))
                    cB.Items.Add($"Id: {f.Id} - {f.Förnamn} {f.Efternamn} - BirthDate: {f.Födelsedatum}");
            }

            viewNewBook.DGVNewBook.Rows[rowIndexNewCell].Cells[1] = cB;
            viewNewBook.DGVNewBook.CurrentCell = viewNewBook.DGVNewBook.Rows[1].Cells[1];               //only way to update cell
            viewNewBook.DGVNewBook.CurrentCell = viewNewBook.DGVNewBook.Rows[rowIndexNewCell].Cells[1]; //only way to update cell
            viewNewBook.DGVNewBook.CellClick -= DGVNewBook_CellClick;
        }

        private void CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB.Items.Count > 1) AddRowActivateClickEvent(viewNewBook.DGVNewBook.CurrentRow.Index + 1);

            Debug.WriteLine("ComboBox_SelectedIndexChanged");
            DataGridViewComboBoxEditingControl dGVCB = sender as DataGridViewComboBoxEditingControl;
            Debug.WriteLine("dataGridViewB.SelectedIndex=" + dGVCB.SelectedIndex);
            Debug.WriteLine("dataGridViewB.SelectedItem=" + dGVCB.SelectedItem.ToString());
            
            viewNewBook.DGVNewBook.Rows[viewNewBook.DGVNewBook.CurrentRow.Index].Cells[1] = new DataGridViewTextBoxCell();
            viewNewBook.DGVNewBook[2, viewNewBook.DGVNewBook.CurrentRow.Index].Value = "remove";
            viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.CurrentRow.Index].Value = dGVCB.SelectedItem.ToString();
            EnableCell(viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.CurrentRow.Index], false);

            int selectedCBIndex = GetIndexFromString(dGVCB.SelectedItem.ToString());
            if (!storedIDs.ContainsKey(selectedCBIndex)) storedIDs.Add(selectedCBIndex, -1);

            viewNewBook.DGVNewBook.Columns[2].Visible = true;
        }

        void AddRowActivateClickEvent(int newRowIndex)
        {
            viewNewBook.DGVNewBook.Rows.Add(1);
            viewNewBook.DGVNewBook.FirstDisplayedScrollingRowIndex = viewNewBook.DGVNewBook.RowCount - 1; //scroll to bottom.
            viewNewBook.DGVNewBook.CellClick -= DGVNewBook_CellClick;
            viewNewBook.DGVNewBook.CellClick += DGVNewBook_CellClick;
            viewNewBook.DGVNewBook[0, newRowIndex].Value = "Author:";
            viewNewBook.DGVNewBook[1, newRowIndex].Value = "Click here to add an author";
        }

        int GetIndexFromString(string str)
        {
            str = new string(str.SkipWhile(c => !char.IsDigit(c)).TakeWhile(c => char.IsDigit(c)).ToArray());
            int.TryParse(str, out int index);
            return index;
        }

        ComboBox comboBox = new ComboBox();

        private void DGVNewBook_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (viewNewBook.DGVNewBook.CurrentCell.ColumnIndex == 1 &&
                viewNewBook.DGVNewBook.RowCount == viewNewBook.DGVNewBook.CurrentCell.RowIndex + 1 &&
                e.Control is ComboBox)
                if (e.Control is ComboBox)
                {
                    comboBox = e.Control as ComboBox;
                    comboBox.SelectedIndexChanged -= CB_SelectedIndexChanged;
                    comboBox.SelectedIndexChanged += CB_SelectedIndexChanged;
                }
        }

        private void EnableCell(DataGridViewCell dc, bool enabled)
        {
            dc.ReadOnly = !enabled;
            if (enabled)
            {
                dc.Style.BackColor = dc.OwningColumn.DefaultCellStyle.BackColor;
                dc.Style.ForeColor = dc.OwningColumn.DefaultCellStyle.ForeColor;
            }
            else
            {
                dc.Style.BackColor = Color.LightGray;
                dc.Style.ForeColor = Color.DarkGray;
            }
        }

        private void DGVNewBook_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private ICollection<Författare> GetDataFromDatabase()
        {
            using var db = new Bokhandel_Lab2Context();
            {
                if (db.Database.CanConnect())
                {
                    ICollection<Författare> output = new List<Författare>();
                    foreach (Författare f in db.Författare)
                    {
                        output.Add(f);
                    }
                    return output;
                }
                else  return null;
            }
        }
    }
}
