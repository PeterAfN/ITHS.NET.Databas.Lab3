using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
   public  class PresenterNewAuthor
    {
        private readonly ICollection<string> bookIDs = new List<string>();
        private readonly IViewMain viewMain;
        private readonly IViewTreeView viewTreeView;
        private readonly IViewDetails viewDetails;
        private readonly IViewNewAuthor viewNewAuthor;

        public PresenterNewAuthor(IViewMain viewMain, IViewTreeView viewTreeView, ViewDetails viewDetails, IViewNewAuthor viewNewAuthor)
        {
            this.viewMain = viewMain;
            this.viewTreeView = viewTreeView;
            this.viewDetails = viewDetails;
            this.viewNewAuthor = viewNewAuthor;

            viewMain.ToolStripMenuItemAddAuthor.Click += ToolStripMenuItemAddAuthor_Click;
            viewNewAuthor.DGVNewAuthor.EditingControlShowing += DGVNewAuthor_EditingControlShowing;
            viewNewAuthor.DGVNewAuthor.CellClick += DGVNewAuthor_CellClick;
            viewNewAuthor.DGVNewAuthor.CellContentClick += DGVNewAuthor_CellContentClick;
            viewNewAuthor.DGVNewAuthor.SelectionChanged += DGVNewAuthor_SelectionChanged;
            viewNewAuthor.DGVNewAuthor.DataError += DGVNewAuthor_DataError;
            viewNewAuthor.ButtonAdd.Click += ButtonAdd_Click;
            viewNewAuthor.ButtonClose.Click += ButtonClose_Click;
            viewNewAuthor.LabelLog.Text = string.Empty;
        }

        private void ToolStripMenuItemAddAuthor_Click(object sender, EventArgs e)
        {
            if (viewNewAuthor.DGVNewAuthor.Rows.Count == 0)
            {
                viewNewAuthor.DGVNewAuthor.Rows.Add(4);
                viewNewAuthor.DGVNewAuthor[0, 0].Value = "First name:";
                viewNewAuthor.DGVNewAuthor[0, 1].Value = "Last name:";
                viewNewAuthor.DGVNewAuthor[0, 2].Value = "Date of Birth:";
                viewNewAuthor.DGVNewAuthor[0, 3].Value = "Book:";
                viewNewAuthor.DGVNewAuthor[1, 3].Value = "Optional: Click here to add a book";
                viewNewAuthor.DGVNewAuthor.CurrentCell = viewNewAuthor.DGVNewAuthor.Rows[0].Cells[1];
            }
            using (Form form = new Form())
            {
                viewNewAuthor.ShowDialog();
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            viewNewAuthor.Hide();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            using (var db = new Bokhandel_Lab2Context())
            {
                using (var dbContextTransaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var author = new Författare
                        {
                            Förnamn = viewNewAuthor.DGVNewAuthor[1, 0].Value.ToString(),
                            Efternamn = viewNewAuthor.DGVNewAuthor[1, 1].Value.ToString(),
                            Födelsedatum = viewNewAuthor.DGVNewAuthor[1, 2].Value.ToString(),
                        };
                        db.Författare.Add(author);
                        db.SaveChanges(); 

                        int authorID = db.Författare.OrderBy(t => t.Id).LastOrDefault(
                            b => b.Förnamn == author.Förnamn && b.Efternamn == author.Efternamn && b.Födelsedatum == author.Födelsedatum).Id;

                        foreach (var bookID in bookIDs)
                        {
                            var FörfattareBöckerJunction = new FörfattareBöckerJunction
                            {
                                BokId = bookID,
                                FörfattareId = authorID,
                            };
                            db.FörfattareBöckerJunction.Add(FörfattareBöckerJunction);
                        }

                        db.SaveChanges();
                        dbContextTransaction.Commit();
                        viewNewAuthor.TriggerEventNewAuthorSavedToDatabase(sender, e);
                        string logText = "The author has been successfully added to the SQL database.";
                        _ = ShowLogTextAsync(logText, Color.Green, 5000);
                    }
                    catch (Exception)
                    {
                        dbContextTransaction.Rollback(); //not needed but good practice
                        string logText = "Error saving to the SQL database! Please verify the inserted data and the functionality of the SQL server.";
                        _ = ShowLogTextAsync(logText, Color.Red, 5000);
                    }
                }
            }
        }

        private async Task ShowLogTextAsync(string infoText, Color color, int showTime)
        {
            viewNewAuthor.LabelLog.Text = infoText;
            viewNewAuthor.LabelLog.ForeColor = color;
            viewNewAuthor.LabelLog.Visible = true;
            await Task.Delay(showTime);
            viewNewAuthor.LabelLog.Visible = false;
        }

        private void DGVNewAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2) return;

            if (viewNewAuthor.DGVNewAuthor[2, viewNewAuthor.DGVNewAuthor.CurrentRow.Index].Value.ToString() == "remove")
            {
                string authorId =
                    GetIndexFromString(viewNewAuthor.DGVNewAuthor[1, viewNewAuthor.DGVNewAuthor.CurrentRow.Index].Value.ToString());

                if (bookIDs.Contains(authorId))
                    if (bookIDs.Remove(authorId))
                    {
                        viewNewAuthor.DGVNewAuthor.Rows.RemoveAt(e.RowIndex);
                        if (viewNewAuthor.DGVNewAuthor[1, viewNewAuthor.DGVNewAuthor.RowCount - 1].Value.ToString() != "Click here to add a book")
                            AddRowActivateClickEvent(viewNewAuthor.DGVNewAuthor.RowCount);
                    }
            }
        }

        private void DGVNewAuthor_SelectionChanged(object sender, EventArgs e)
        {
            if (viewNewAuthor?.DGVNewAuthor?.CurrentCell?.ColumnIndex == 0 || viewNewAuthor?.DGVNewAuthor?.CurrentCell?.ColumnIndex == 2)
                viewNewAuthor.DGVNewAuthor.CurrentCell.Selected = false;
        }

        private void DGVNewAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (viewNewAuthor.DGVNewAuthor.CurrentCell.ColumnIndex == 1 &&
                viewNewAuthor.DGVNewAuthor.RowCount == viewNewAuthor.DGVNewAuthor.CurrentCell.RowIndex + 1)
            {
                viewNewAuthor.DGVNewAuthor.Columns[2].Visible = false;
                AddBookCell(viewNewAuthor.DGVNewAuthor.CurrentCell.RowIndex);
            }
        }

        private readonly DataGridViewComboBoxCell cBBooks = new DataGridViewComboBoxCell();

        private void AddBookCell(int rowIndexNewCell)
        {
            cBBooks.Items.Clear();
            var books = GetBooksFromDatabase();

            foreach (Böcker b in books)
            {
                if (!bookIDs.Contains(b.Isbn13))
                    cBBooks.Items.Add($"Id: {b.Isbn13} - {b.Titel} - {b.Språk}");
            }

            viewNewAuthor.DGVNewAuthor.Rows[rowIndexNewCell].Cells[1] = cBBooks;
            viewNewAuthor.DGVNewAuthor.CurrentCell = viewNewAuthor.DGVNewAuthor.Rows[1].Cells[1];               //only way to update cell
            viewNewAuthor.DGVNewAuthor.CurrentCell = viewNewAuthor.DGVNewAuthor.Rows[rowIndexNewCell].Cells[1]; //only way to update cell
            viewNewAuthor.DGVNewAuthor.CellClick -= DGVNewAuthor_CellClick;
        }

        private void BookSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBBooks.Items.Count > 1) AddRowActivateClickEvent(viewNewAuthor.DGVNewAuthor.CurrentRow.Index + 1);
            DataGridViewComboBoxEditingControl dGVCB = sender as DataGridViewComboBoxEditingControl;
            viewNewAuthor.DGVNewAuthor.Rows[viewNewAuthor.DGVNewAuthor.CurrentRow.Index].Cells[1] = new DataGridViewTextBoxCell();
            viewNewAuthor.DGVNewAuthor[2, viewNewAuthor.DGVNewAuthor.CurrentRow.Index].Value = "remove";
            viewNewAuthor.DGVNewAuthor[1, viewNewAuthor.DGVNewAuthor.CurrentRow.Index].Value = dGVCB.SelectedItem.ToString();
            EnableCell(viewNewAuthor.DGVNewAuthor[1, viewNewAuthor.DGVNewAuthor.CurrentRow.Index], false);

            string selectedCBIndex = GetIndexFromString(dGVCB.SelectedItem.ToString());
            if (!bookIDs.Contains(selectedCBIndex)) bookIDs.Add(selectedCBIndex);

            viewNewAuthor.DGVNewAuthor.Columns[2].Visible = true;
        }

        void AddRowActivateClickEvent(int newRowIndex)
        {
            viewNewAuthor.DGVNewAuthor.Rows.Add(1);
            viewNewAuthor.DGVNewAuthor.FirstDisplayedScrollingRowIndex = viewNewAuthor.DGVNewAuthor.RowCount - 1; //scroll to bottom.
            viewNewAuthor.DGVNewAuthor.CellClick -= DGVNewAuthor_CellClick;
            viewNewAuthor.DGVNewAuthor.CellClick += DGVNewAuthor_CellClick;
            viewNewAuthor.DGVNewAuthor[0, newRowIndex].Value = "Book:";
            viewNewAuthor.DGVNewAuthor[1, newRowIndex].Value = "Click here to add a book";
        }

        string GetIndexFromString(string str)
        {
            return new string(str.SkipWhile(c => !char.IsDigit(c)).TakeWhile(c => char.IsDigit(c)).ToArray());
        }

        ComboBox comboBoxBooks = new ComboBox();

        private void DGVNewAuthor_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (viewNewAuthor.DGVNewAuthor.CurrentCell.ColumnIndex == 1 &&
                viewNewAuthor.DGVNewAuthor.RowCount == viewNewAuthor.DGVNewAuthor.CurrentCell.RowIndex + 1 &&
                e.Control is ComboBox)
            {
                comboBoxBooks = e.Control as ComboBox;
                comboBoxBooks.SelectedIndexChanged -= BookSelectedIndexChanged;
                comboBoxBooks.SelectedIndexChanged += BookSelectedIndexChanged;
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

        //todo: create generic class for getting data from database.
        private void DGVNewAuthor_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private ICollection<Böcker> GetBooksFromDatabase()
        {
            using var db = new Bokhandel_Lab2Context();
            {
                if (db.Database.CanConnect())
                {
                    ICollection<Böcker> output = new List<Böcker>();
                    foreach (Böcker f in db.Böcker)
                    {
                        output.Add(f);
                    }
                    return output;
                }
                else return null;
            }
        }

    }
}
