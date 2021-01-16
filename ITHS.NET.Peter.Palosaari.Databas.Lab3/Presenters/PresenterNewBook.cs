using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
    public class PresenterNewBook
    {
        private Queue<DataGridViewComboBoxCell> cb = new Queue<DataGridViewComboBoxCell>(200);
        private ICollection<int> authorIDs = new List<int>();
        private int publisherIDs = -1;

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

            viewMain.ToolStripMenuItemAddBook.Click += ToolStripMenuItemAddBook_Click;
            viewNewBook.DGVNewBook.EditingControlShowing += DGVNewBook_EditingControlShowing;
            viewNewBook.DGVNewBook.CellClick += DGVNewBook_CellClick;
            viewNewBook.DGVNewBook.CellContentClick += DGVNewBook_CellContentClick;
            viewNewBook.DGVNewBook.SelectionChanged += DGVNewBook_SelectionChanged;
            viewNewBook.DGVNewBook.DataError += DGVNewBook_DataError;
            viewNewBook.ButtonAdd.Click += ButtonAdd_Click;
            viewNewBook.ButtonClose.Click += ButtonClose_Click;
            viewNewBook.LabelLog.Text = string.Empty;
        }

        private void ToolStripMenuItemAddBook_Click(object sender, EventArgs e)
        {
            if (viewNewBook.DGVNewBook.Rows.Count == 0)
            {

                viewNewBook.DGVNewBook.Rows.Add(6);
                viewNewBook.DGVNewBook[0, 0].Value = "Isbn [Required, 13 digits]:";
                viewNewBook.DGVNewBook[0, 1].Value = "Title:";
                viewNewBook.DGVNewBook[0, 2].Value = "Language";
                viewNewBook.DGVNewBook[0, 3].Value = "Price";
                viewNewBook.DGVNewBook[0, 4].Value = "Release Date:";
                viewNewBook.DGVNewBook[0, 5].Value = "Publisher:";
                AddListOfPublishersToComboBox(5);
                viewNewBook.DGVNewBook.CurrentCell = viewNewBook.DGVNewBook.Rows[0].Cells[1];
                viewNewBook.DGVNewBook.Rows.Add(1);
                viewNewBook.DGVNewBook[0, 6].Value = "Author:";
                viewNewBook.DGVNewBook[1, 6].Value = "Optional: Click here to add an author";
            }
            using (Form form = new Form())
            {
                viewNewBook.ShowDialog();
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            viewNewBook.Hide();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            using (var db = new Bokhandel_Lab2Context())
            {
                using (var dbContextTransaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        //1.save book to table 'Böcker'

                        decimal.TryParse(viewNewBook.DGVNewBook[1, 3].Value.ToString(), out decimal price);
                        var böcker = new Böcker
                        {
                            Isbn13 = viewNewBook.DGVNewBook[1, 0].Value.ToString(),
                            Titel = viewNewBook.DGVNewBook[1, 1].Value.ToString(),
                            Språk = viewNewBook.DGVNewBook[1, 2].Value.ToString(),
                            Pris = price,
                            Utgivningsdatum = viewNewBook.DGVNewBook[1, 4].Value.ToString(),
                            FörlagId = publisherIDs,
                        };
                        db.Böcker.Add(böcker);

                        // 2. save book and author(s) to table 'FörfattareBöcker_Junction'

                        foreach (var authorID in authorIDs)
                        {
                            var FörfattareBöckerJunction = new FörfattareBöckerJunction
                            {
                                BokId = viewNewBook.DGVNewBook[1, 0].Value.ToString(),
                                FörfattareId = authorID
                            };
                            db.FörfattareBöckerJunction.Add(FörfattareBöckerJunction);
                        }

                        // 3. save book to table 'LagerSaldo'

                        var stores = GetStoresFromDatabase();
                        foreach (Butiker s in stores)
                        {
                            var lagerSaldo = new LagerSaldo
                            {
                                ButikId = s.Id,
                                Isbn = viewNewBook.DGVNewBook[1, 0].Value.ToString(),
                                Antal = 0,
                            };
                            db.LagerSaldon.Add(lagerSaldo);
                        }

                        db.SaveChanges();
                        dbContextTransaction.Commit();
                        string logText = "The book has been successfully added to the SQL database.";
                        _ = ShowLogTextAsync(logText, Color.Green, 5000);
                        viewNewBook.TriggerEventNewBookSavedToDatabase(sender, e);
                    }
                    catch (Exception)
                    {
                        string logText = "Error saving to the SQL database! Please verify the inserted data and the functionality of the SQL server.";
                        _ = ShowLogTextAsync(logText, Color.Red, 5000);
                        dbContextTransaction.Rollback(); //not needed but good practice
                    }
                }
            }
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
            if (e.ColumnIndex != 2) return;

            if (viewNewBook.DGVNewBook[2, viewNewBook.DGVNewBook.CurrentRow.Index].Value.ToString() == "remove")
            {
                int authorId = 
                    GetIndexFromString(viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.CurrentRow.Index].Value.ToString());

                if (authorIDs.Contains(authorId)) 
                    if (authorIDs.Remove(authorId)) 
                    {
                        viewNewBook.DGVNewBook.Rows.RemoveAt(e.RowIndex);
                        if (viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.RowCount - 1].Value.ToString() != "Click here to add an author")
                            AddRowActivateClickEvent(viewNewBook.DGVNewBook.RowCount);
                    }
            }
            else if (viewNewBook.DGVNewBook[2, viewNewBook.DGVNewBook.CurrentRow.Index].Value.ToString() == "reselect")
            {
                AddListOfPublishersToComboBox(viewNewBook.DGVNewBook.CurrentRow.Index);
                EnableCell(viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.CurrentRow.Index], true);
            }
        }

        private void DGVNewBook_SelectionChanged(object sender, EventArgs e)
        {
            if (viewNewBook?.DGVNewBook?.CurrentCell?.ColumnIndex == 0 || viewNewBook?.DGVNewBook?.CurrentCell?.ColumnIndex == 2)
                viewNewBook.DGVNewBook.CurrentCell.Selected = false;
        }

        DataGridViewComboBoxCell cBPublishers = new DataGridViewComboBoxCell();

        private void AddListOfPublishersToComboBox(int rowIndex)
        {
            var publishers = GetPublishersFromDatabase();
            cBPublishers.Items.Clear();

            foreach (Förlag p in publishers)
            {
                cBPublishers.Items.Add($"Id: {p.Id} - {p.Namn}");
            }

            viewNewBook.DGVNewBook.Rows[rowIndex].Cells[1] = cBPublishers;
        }

        private void ComboBoxPublishers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewComboBoxEditingControl dGVCB = sender as DataGridViewComboBoxEditingControl;
            publisherIDs = GetIndexFromString(dGVCB.SelectedItem.ToString());

            viewNewBook.DGVNewBook.Rows[viewNewBook.DGVNewBook.CurrentRow.Index].Cells[1] = new DataGridViewTextBoxCell();
            viewNewBook.DGVNewBook[2, viewNewBook.DGVNewBook.CurrentRow.Index].Value = "reselect";
            viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.CurrentRow.Index].Value = dGVCB.SelectedItem.ToString();
            EnableCell(viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.CurrentRow.Index], false);
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

        DataGridViewComboBoxCell cBAuthors = new DataGridViewComboBoxCell();

        private void AddAuthorCell(int rowIndexNewCell)
        {
            cBAuthors.Items.Clear();
            var författare = GetAuthorsFromDatabase();

            foreach (Författare f in författare)
            {
                if (!authorIDs.Contains(f.Id))
                    cBAuthors.Items.Add($"Id: {f.Id} - {f.Förnamn} {f.Efternamn} - BirthDate: {f.Födelsedatum}");
            }

            viewNewBook.DGVNewBook.Rows[rowIndexNewCell].Cells[1] = cBAuthors;
            viewNewBook.DGVNewBook.CurrentCell = viewNewBook.DGVNewBook.Rows[1].Cells[1];               //only way to update cell
            viewNewBook.DGVNewBook.CurrentCell = viewNewBook.DGVNewBook.Rows[rowIndexNewCell].Cells[1]; //only way to update cell
            viewNewBook.DGVNewBook.CellClick -= DGVNewBook_CellClick;
        }

        private void AuthorSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBAuthors.Items.Count > 1) AddRowActivateClickEvent(viewNewBook.DGVNewBook.CurrentRow.Index + 1);
            DataGridViewComboBoxEditingControl dGVCB = sender as DataGridViewComboBoxEditingControl;          
            viewNewBook.DGVNewBook.Rows[viewNewBook.DGVNewBook.CurrentRow.Index].Cells[1] = new DataGridViewTextBoxCell();
            viewNewBook.DGVNewBook[2, viewNewBook.DGVNewBook.CurrentRow.Index].Value = "remove";
            viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.CurrentRow.Index].Value = dGVCB.SelectedItem.ToString();
            EnableCell(viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.CurrentRow.Index], false);

            int selectedCBIndex = GetIndexFromString(dGVCB.SelectedItem.ToString());
            if (!authorIDs.Contains(selectedCBIndex)) authorIDs.Add(selectedCBIndex);

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

        ComboBox comboBoxAuthors = new ComboBox();
        ComboBox comboBoxPublishers = new ComboBox();

        private void DGVNewBook_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (viewNewBook.DGVNewBook.CurrentCell.ColumnIndex == 1 &&
                viewNewBook.DGVNewBook.RowCount == viewNewBook.DGVNewBook.CurrentCell.RowIndex + 1 &&
                e.Control is ComboBox)
            {
                comboBoxAuthors = e.Control as ComboBox;
                comboBoxAuthors.SelectedIndexChanged -= AuthorSelectedIndexChanged;
                comboBoxAuthors.SelectedIndexChanged += AuthorSelectedIndexChanged;
            }
            else if (viewNewBook.DGVNewBook.CurrentCell.ColumnIndex == 1 &&
                viewNewBook.DGVNewBook.CurrentCell.RowIndex == 5 &&
                e.Control is ComboBox)
            {
                comboBoxPublishers = e.Control as ComboBox;
                comboBoxPublishers.SelectedIndexChanged -= ComboBoxPublishers_SelectedIndexChanged;
                comboBoxPublishers.SelectedIndexChanged += ComboBoxPublishers_SelectedIndexChanged;
                comboBoxAuthors = e.Control as ComboBox;
                comboBoxAuthors.SelectedIndexChanged -= AuthorSelectedIndexChanged;
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
        private void DGVNewBook_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private ICollection<Författare> GetAuthorsFromDatabase()
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

        private ICollection<Förlag> GetPublishersFromDatabase()
        {
            using var db = new Bokhandel_Lab2Context();
            {
                if (db.Database.CanConnect())
                {
                    ICollection<Förlag> output = new List<Förlag>();
                    foreach (Förlag f in db.Förlag)
                    {
                        output.Add(f);
                    }
                    return output;
                }
                else return null;
            }
        }

        private ICollection<Butiker> GetStoresFromDatabase()
        {
            using var db = new Bokhandel_Lab2Context();
            {
                if (db.Database.CanConnect())
                {
                    ICollection<Butiker> output = new List<Butiker>();
                    foreach (Butiker f in db.Butiker)
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