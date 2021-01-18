using ITHS.NET.Peter.Palosaari.Databas.Lab3.CustomEventArgs;
using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
    class PresenterDetails
    {
        private readonly IViewMain viewMain;
        private readonly IViewTreeView viewTreeView;
        private readonly IViewDetails viewDetails;

        public PresenterDetails(IViewMain viewMain, IViewTreeView viewTreeView, IViewDetails viewDetails)
        {
            this.viewMain = viewMain;
            this.viewTreeView = viewTreeView;
            this.viewDetails = viewDetails;

            this.viewDetails.DGVBook.SelectionChanged += DGVBook_SelectionChanged;
            this.viewDetails.DGVBook.CellContentClick += DGVBook_CellContentClick;
            this.viewDetails.DGVBookstore.SelectionChanged += DGVBookstore_SelectionChanged;
            this.viewTreeView._TreeView_AfterSelect += ViewTreeView_AfterSelect;
            this.viewDetails.Load += ViewDetails_Load;

            viewDetails.DGVBook.AllowUserToAddRows = false;
            AddNewDGVBookstoreCells();
            AddDGVBookCells();
        }

        private async Task ShowLogTextAsync(string infoText, Color color, int showTime)
        {
            viewMain.LabelLog.Text = infoText;
            viewMain.LabelLog.ForeColor = color;
            viewMain.LabelLog.Visible = true;
            await Task.Delay(showTime);
            viewMain.LabelLog.Visible = false;
        }

        private string CellValueBeforeEdit { get; set; }

        private void DGVBookstore_SelectionChanged(object sender, EventArgs e)
        {
            if (viewDetails.DGVBookstore.CurrentCell.ColumnIndex == 0) 
                viewDetails.DGVBookstore.CurrentCell.Selected = false;
        }

        private void DGVBook_SelectionChanged(object sender, EventArgs e)
        {
            if (viewDetails.DGVBook.CurrentCell.ColumnIndex == 0) 
                viewDetails.DGVBook.CurrentCell.Selected = false;
        }

        private void ViewDetails_Load(object sender, EventArgs e)
        {
            viewDetails.DGVBookstore.CellValueChanged += DGVBookstore_CellValueChanged;
            viewDetails.DGVBook.CellValueChanged += DGVBook_CellValueChanged;
            viewDetails.DGVBookstore.CellBeginEdit += DGVBookstore_CellBeginEdit;
            viewDetails.DGVBook.CellBeginEdit += DGVBook_CellBeginEdit;
        }

        private void DGVBook_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            CellValueBeforeEdit = viewDetails.DGVBook.CurrentCell?.Value?.ToString();
        }

        private void DGVBookstore_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            CellValueBeforeEdit = viewDetails.DGVBookstore.CurrentCell?.Value?.ToString();
        }

        private void DGVBook_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) return;
            if (userNavigating) return;
            if (viewDetails.DGVBook.CurrentCell.Value == null)
            {
                RestoreCellValue();
                return;
            }

            using var db = new Bokhandel_Lab2Context();
            if (db.Database.CanConnect())
            {
                try
                {
                    int.TryParse(viewDetails.DGVBookstore[1, 0].Value.ToString(), out int butikID);
                    var stock = db.LagerSaldon.FirstOrDefault(
                        b => b.ButikId == butikID && b.Isbn == viewDetails.DGVBook[1, 0].Value.ToString());
                    var books = db.Böcker.FirstOrDefault(
                        b => b.Isbn13 == viewDetails.DGVBook[1, 0].Value.ToString());
                    int.TryParse(viewDetails.DGVBook[1, 6].Value.ToString(), out int _publisher);
                    var publisher = db.Förlag.FirstOrDefault(b => b.Id == _publisher);
                    switch (e.RowIndex)
                    {
                        case 1:
                            books.Titel = viewDetails.DGVBook[1, 1].Value.ToString(); break;
                        case 2:
                            int.TryParse(viewDetails.DGVBook[1, 2].Value.ToString(), out int amount);
                            stock.Antal = amount; break;
                        case 3:
                            books.Språk = viewDetails.DGVBook[1, 3].Value.ToString();  break;
                        case 4:
                            decimal.TryParse(viewDetails.DGVBook[1, 4].Value.ToString(), out decimal price);
                            books.Pris = price; break;
                        case 5:
                            books.Utgivningsdatum = viewDetails.DGVBook[1, 5].Value.ToString(); break;
                        case 7:
                            publisher.Namn = viewDetails.DGVBook[1, 7].Value.ToString(); break;
                        case 8:
                            publisher.Beskrivning = viewDetails.DGVBook[1, 8].Value.ToString(); break;
                        case 9:
                            publisher.Telefonnummer = viewDetails.DGVBook[1, 9].Value.ToString(); break;
                        case 10:
                            publisher.Epost = viewDetails.DGVBook[1, 10].Value.ToString();  break;
                        default:
                            CellAuthor(sender, e); return;
                    }
                    db.SaveChanges();
                    string logText = "The value has been successfully changed in the SQL Server database.";
                    _ = ShowLogTextAsync(logText, Color.Green, 3000);
                }
                catch (Exception)
                {
                    string logText = "Error while changing the value in the SQL Server database. Please verify the functionality of the SQL server and the inserted data.";
                    _ = ShowLogTextAsync(logText, Color.Red, 3000);
                    db.Dispose();
                    RestoreCellValue();
                    return;
                }
                DetailsChangedEventArgs args = new DetailsChangedEventArgs();
                TriggerEvent(sender, args);
            }
            else
            {
                string logText = "Could not connect to the SQL Server database. Please verify the functionality of the SQL server.";
                _ = ShowLogTextAsync(logText, Color.Red, 3000);
            }
        }

        void TriggerEvent(object sender, DetailsChangedEventArgs args)
        {
            if (viewTreeView.TreeView.SelectedNode.Parent == null)
                args.IndexSelectedParentNode = viewTreeView.TreeView.SelectedNode.Index;
            else
            {
                args.IndexSelectedChildNode = viewTreeView.TreeView.SelectedNode.Index;
                args.IndexSelectedParentNode = viewTreeView.TreeView.SelectedNode.Parent.Index;
            }
            viewDetails.TriggerEventDataGridViewUpdated(sender, args);
        }

        void CellAuthor(object sender, DataGridViewCellEventArgs e)
        {
            using var db = new Bokhandel_Lab2Context();
            if (db.Database.CanConnect()) 
            {
                try
                {
                    int authorCellId = e.RowIndex - (e.RowIndex - 11) % 4;
                    int.TryParse(viewDetails.DGVBook[1, authorCellId].Value.ToString(), out int value);
                    var author = db.Författare.FirstOrDefault(b => b.Id == value);

                    switch (e.RowIndex % 4)
                    {
                        case 0:     //row 12, 16, 20, 24, 28...
                            author.Förnamn = viewDetails.DGVBook[1, e.RowIndex].Value.ToString();
                            break;
                        case 1:     //row 13, 17, 21, 25, 29...
                            author.Efternamn = viewDetails.DGVBook[1, e.RowIndex].Value.ToString();
                            break;
                        case 2:     //row 14, 18, 22, 26, 30...
                            author.Födelsedatum = viewDetails.DGVBook[1, e.RowIndex].Value.ToString();
                            break;
                    }

                    db.SaveChanges();
                    string logText = "The value has been successfully changed in the SQL Server database.";
                    _ = ShowLogTextAsync(logText, Color.Green, 3000);
                }
                catch (Exception)
                {
                    string logText = "Error while changing the value in the SQL Server database. Please verify the functionality of the SQL server and the inserted data.";
                    _ = ShowLogTextAsync(logText, Color.Red, 3000);
                    db.Dispose();
                    RestoreCellValue();
                    return;
                }
                DetailsChangedEventArgs args = new DetailsChangedEventArgs();
                TriggerEvent(sender, args);
            }
            else
            {
                string logText = "Could not connect to the SQL Server database. Please verify the functionality of the SQL server.";
                _ = ShowLogTextAsync(logText, Color.Red, 3000);
                return;
            }
        }


        private void DGVBookstore_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (userNavigating) return;
            if (viewDetails.DGVBookstore.CurrentCell.Value == null)
            {
                RestoreCellValue();
                return;
            }
            using var db = new Bokhandel_Lab2Context();
            if (db.Database.CanConnect())
            {
                try
                {
                    int.TryParse(viewDetails.DGVBookstore[1, 0].Value.ToString(), out int bookID);
                    var butiker = db.Butiker.FirstOrDefault(b => b.Id == bookID);
                    switch (e.RowIndex)
                    {
                        case 1:
                            butiker.Namn = viewDetails.DGVBookstore[1, 1].Value.ToString(); break;
                        case 2:
                            butiker.Adress = viewDetails.DGVBookstore[1, 2].Value.ToString(); break;
                        case 3:
                            int.TryParse(viewDetails.DGVBookstore[1, 3].Value.ToString(), out int postalNr);
                            butiker.Postnummer = postalNr; break;
                        case 4:
                            butiker.Stad = viewDetails.DGVBookstore[1, 4].Value.ToString(); break;
                        case 5:
                            butiker.Land = viewDetails.DGVBookstore[1, 5].Value.ToString(); break;
                    }
                    db.SaveChanges();
                    string logText = "The value has been successfully changed in the SQL Server database.";
                    _ = ShowLogTextAsync(logText, Color.Green, 3000);
                }
                catch (Exception)
                {
                    string logText = "Error while changing the value in the SQL Server database. Please verify the functionality of the SQL server and the inserted data.";
                    _ = ShowLogTextAsync(logText, Color.Red, 3000);
                    db.Dispose();
                    RestoreCellValue();
                    return;
                }
                DetailsChangedEventArgs args = new DetailsChangedEventArgs();
                TriggerEvent(sender, args);
            }
            else
            {
                string logText = "Could not connect to the SQL Server database. Please verify the functionality of the SQL server.";
                _ = ShowLogTextAsync(logText, Color.Red, 3000);
            }
        }


        private void RestoreCellValue()
        {
            viewDetails.DGVBookstore.CellValueChanged -= DGVBookstore_CellValueChanged;
            viewDetails.DGVBookstore.CurrentCell.Value = CellValueBeforeEdit;
            viewDetails.DGVBookstore.CellValueChanged += DGVBookstore_CellValueChanged;
        }

        private void ClearDeleteLinks()
        {
            int count = viewDetails.DGVBook.Rows.Count;

            for (int i = count - 1; i > 10; i--)
            {
                viewDetails.DGVBook[2, i].Value = "";
            }
        }

        void ClearBook()
        {
            var tmp = viewDetails.DGVBook.Columns[1];
            viewDetails.DGVBook.Columns.Remove(viewDetails.DGVBook.Columns[1]);
            viewDetails.DGVBook.Columns.Insert(1, tmp);
        }

        private void UpdateBookstore(Butiker butik)
        {
            viewDetails.DGVBookstore[1, 0].Value = butik.Id;
            viewDetails.DGVBookstore[1, 1].Value = butik.Namn;
            viewDetails.DGVBookstore[1, 2].Value = butik.Adress;
            viewDetails.DGVBookstore[1, 3].Value = butik.Postnummer;
            viewDetails.DGVBookstore[1, 4].Value = butik.Stad;
            viewDetails.DGVBookstore[1, 5].Value = butik.Land;
        }

        private void UpdateBook(LagerSaldo lagerSaldo)
        {
            viewDetails.DGVBook[1, 0].Value = lagerSaldo.Isbn;
            viewDetails.DGVBook[1, 1].Value = lagerSaldo.IsbnNavigation.Titel;
            viewDetails.DGVBook[1, 2].Value = lagerSaldo.Antal;
            viewDetails.DGVBook[1, 3].Value = lagerSaldo.IsbnNavigation.Språk;
            viewDetails.DGVBook[1, 4].Value = lagerSaldo.IsbnNavigation.Pris;
            viewDetails.DGVBook[1, 5].Value = lagerSaldo.IsbnNavigation.Utgivningsdatum;
            viewDetails.DGVBook[1, 6].Value = lagerSaldo.IsbnNavigation.FörlagId;
            viewDetails.DGVBook[1, 7].Value = lagerSaldo.IsbnNavigation.Förlag.Namn;
            viewDetails.DGVBook[1, 8].Value = lagerSaldo.IsbnNavigation.Förlag.Beskrivning;
            viewDetails.DGVBook[1, 9].Value = lagerSaldo.IsbnNavigation.Förlag.Telefonnummer;
            viewDetails.DGVBook[1, 10].Value = lagerSaldo.IsbnNavigation.Förlag.Epost;
        }

        void ClearDataFromAllBookAuthorCells()
        {
            int count = viewDetails.DGVBook.Rows.Count;

            for (int i = count - 1; i > 10; i--)
            {
                viewDetails.DGVBook.Rows.RemoveAt(i);
            }
        }

        private void AddNewDGVBookstoreCells()
        {
            viewDetails.DGVBookstore.Rows.Add(6);
            viewDetails.DGVBookstore[0, 0].Value = "Id:";
            viewDetails.DGVBookstore[0, 1].Value = "Name:";
            viewDetails.DGVBookstore[0, 2].Value = "Address:";
            viewDetails.DGVBookstore[0, 3].Value = "Postal Number:";
            viewDetails.DGVBookstore[0, 4].Value = "City:";
            viewDetails.DGVBookstore[0, 5].Value = "Country:";
        }

        private void AddDGVBookCells()
        {
            viewDetails.DGVBook.Rows.Add(11);
            viewDetails.DGVBook[0, 0].Value = "Isbn:";
            viewDetails.DGVBook[0, 1].Value = "Title:";
            viewDetails.DGVBook[0, 2].Value = "Amount:";
            viewDetails.DGVBook[0, 3].Value = "Language";
            viewDetails.DGVBook[0, 4].Value = "Price";
            viewDetails.DGVBook[0, 5].Value = "Release Date:";
            viewDetails.DGVBook[0, 6].Value = "Publisher Id:";
            viewDetails.DGVBook[0, 7].Value = "Publisher Name:";
            viewDetails.DGVBook[0, 8].Value = "Publisher Description:";
            viewDetails.DGVBook[0, 9].Value = "Publisher Phone Number:";
            viewDetails.DGVBook[0, 10].Value = "Publisher Email:";
        }
        
        void SetDGVCellsReadOnly()
        {
            viewDetails.DGVBookstore[1, 0].ReadOnly = true;                                         //id
            viewDetails.DGVBook[1, 0].ReadOnly = true;                                              //isbn
            viewDetails.DGVBook[1, 6].ReadOnly = true;                                              //publisher id
        }

        //**********************************************************************************************************************************
        //**********************************************************************************************************************************
        //**********************************************************************************************************************************
        //**********************************************************************************************************************************

        bool userNavigating = false;

        private void ViewTreeView_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            userNavigating = true;

            if (e.Node.Tag is Butiker selectedOrder)
            {
                ClearDeleteLinks();
                ClearBook();
                viewDetails.DGVBook.Enabled = false;
                UpdateBookstore(selectedOrder);
            }
            else if (e.Node.Tag is LagerSaldo lagerSaldo)
            {
                if (e.Node.Parent.Tag is Butiker parentOrder)
                {
                    viewDetails.DGVBook.Enabled = true;
                    UpdateBookstore(parentOrder);
                    UpdateBook(lagerSaldo);
                    ClearDataFromAllBookAuthorCells();
                    ExtendDGVWithNewAuthorCells(lagerSaldo);
                    AddAuthorCell(viewDetails.DGVBook.RowCount);
                }
            }
            SetDGVCellsReadOnly();
            userNavigating = false;
        }

        void ExtendDGVWithNewAuthorCells(LagerSaldo lagerSaldo)
        {
            authorIDs.Clear();
            int i = 0;
            foreach (var item in lagerSaldo.IsbnNavigation.FörfattareBöckerJunction)
            {
                viewDetails.DGVBook.Rows.Add(4);
                viewDetails.DGVBook[0, 11 + (i * 4)].Value = "Author Id:";
                viewDetails.DGVBook[0, 12 + (i * 4)].Value = "Author First Name:";
                viewDetails.DGVBook[0, 13 + (i * 4)].Value = "Author Last Name:";
                viewDetails.DGVBook[0, 14 + (i * 4)].Value = "Author Date of Birth";
                viewDetails.DGVBook[1, 11 + (i * 4)].Value = item.FörfattareId;
                authorIDs.Add(item.FörfattareId);
                viewDetails.DGVBook[2, 11 + (i * 4)].Value = "remove";
                viewDetails.DGVBook[1, 11 + (i * 4)].ReadOnly = true;
                viewDetails.DGVBook[1, 12 + (i * 4)].Value = item.Författare.Förnamn;
                viewDetails.DGVBook[1, 13 + (i * 4)].Value = item.Författare.Efternamn;
                viewDetails.DGVBook[1, 14 + (i * 4)].Value = item.Författare.Födelsedatum;
                i++;
            }
        }



        //NEW
        //**********************************************************************************************************************************
        //**********************************************************************************************************************************
        //**********************************************************************************************************************************

        private ICollection<Författare> authors = new List<Författare>();
        private readonly ICollection<int> authorIDs = new List<int>();

        //1. add author row (no combobox)
        void AddAuthorCell(int newRowIndex)
        {
            authors = GetAuthorsFromDatabase();
            if (authors.Count() == authorIDs.Count()) return;

            viewDetails.DGVBook.Rows.Add(1);
            viewDetails.DGVBook.FirstDisplayedScrollingRowIndex = viewDetails.DGVBook.RowCount - 1; //scroll to bottom.
            viewDetails.DGVBook.CellClick -= DGVBook_CellClick;
            viewDetails.DGVBook.CellClick += DGVBook_CellClick;
            viewDetails.DGVBook[0, newRowIndex].Value = "Author:";
            viewDetails.DGVBook[1, newRowIndex].Value = "Click here to add an author";
        }

        DataGridViewComboBoxCell cBAuthors;

        //2. add combobox to the author row.
        private void AddComboboxToAuthorCell(int rowIndexNewCell)
        {
            cBAuthors = null;
            cBAuthors = new DataGridViewComboBoxCell();
            cBAuthors.Items.Clear();

            foreach (Författare a in authors)
            {
                if (!authorIDs.Contains(a.Id))
                    cBAuthors.Items.Add($"Id: {a.Id} - {a.Förnamn} {a.Efternamn} - BirthDate: {a.Födelsedatum}");
            }

            viewDetails.DGVBook.Rows[rowIndexNewCell].Cells[1] = cBAuthors;
            viewDetails.DGVBook.CurrentCell = viewDetails.DGVBook.Rows[1].Cells[1];               //only way to update cell
            viewDetails.DGVBook.CurrentCell = viewDetails.DGVBook.Rows[rowIndexNewCell].Cells[1]; //only way to update cell
            viewDetails.DGVBook.CellClick -= DGVBook_CellClick;
        }

        //handle clicks on the author cell (when user decides to add an author to book)
        private void DGVBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (viewDetails.DGVBook.CurrentCell.ColumnIndex == 1 &&
                viewDetails.DGVBook.RowCount == viewDetails.DGVBook.CurrentCell.RowIndex + 1)
            {
                viewDetails.DGVBook.Columns[2].Visible = false;
                AddComboboxToAuthorCell(viewDetails.DGVBook.CurrentCell.RowIndex);
            }
        }

        //handle 'remove' clicks
        private void DGVBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2) return;

            using var db = new Bokhandel_Lab2Context();
            if (db.Database.CanConnect())
            {
                try
                {
                    int.TryParse(viewDetails.DGVBook[1, e.RowIndex].Value.ToString(), out int författareId);
                    var JunctionFörfattareBöcker = db.FörfattareBöckerJunction.FirstOrDefault(
                    b => b.FörfattareId == författareId && b.BokId == viewDetails.DGVBook[1, 0].Value.ToString());
                    db.FörfattareBöckerJunction.Remove(JunctionFörfattareBöcker);
                    db.SaveChanges();

                    viewDetails.DGVBook.Rows.RemoveAt(e.RowIndex + 3);
                    viewDetails.DGVBook.Rows.RemoveAt(e.RowIndex + 2);
                    viewDetails.DGVBook.Rows.RemoveAt(e.RowIndex + 1);
                    viewDetails.DGVBook.Rows.RemoveAt(e.RowIndex);
                    DetailsChangedEventArgs args = new DetailsChangedEventArgs();
                    TriggerEvent(sender, args);
                    string logText = "The author has been successfully disassociated from the book in the SQL Server database.";
                    _ = ShowLogTextAsync(logText, Color.Green, 3000);
                }
                catch (Exception)
                {
                    string logText = "Error while disassociating the author from the book in the SQL Server database. Please verify the functionality of the SQL server.";
                    _ = ShowLogTextAsync(logText, Color.Red, 3000);
                }
            }
            else
            {
                string logText = "Could not connect to the SQL Server database. Please verify the functionality of the SQL server.";
                _ = ShowLogTextAsync(logText, Color.Red, 3000);
            }         
        }

        private void DGVNewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (viewNewBook.DGVNewBook[2, viewNewBook.DGVNewBook.CurrentRow.Index].Value.ToString() == "remove")
            //{
            //    int authorId =
            //        GetIndexFromString(viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.CurrentRow.Index].Value.ToString());

            //    if (authorIDs.Contains(authorId))
            //        if (authorIDs.Remove(authorId))
            //        {
            //            viewNewBook.DGVNewBook.Rows.RemoveAt(e.RowIndex);
            //            if (viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.RowCount - 1].Value.ToString() != "Click here to add an author")
            //                AddRowActivateClickEvent(viewNewBook.DGVNewBook.RowCount);
            //        }
            //}
        }

        private void AuthorSelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cBAuthors.Items.Count > 1) AddRowActivateClickEvent(viewNewBook.DGVNewBook.CurrentRow.Index + 1);
            //DataGridViewComboBoxEditingControl dGVCB = sender as DataGridViewComboBoxEditingControl;
            //viewNewBook.DGVNewBook.Rows[viewNewBook.DGVNewBook.CurrentRow.Index].Cells[1] = new DataGridViewTextBoxCell();
            //viewNewBook.DGVNewBook[2, viewNewBook.DGVNewBook.CurrentRow.Index].Value = "remove";
            //viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.CurrentRow.Index].Value = dGVCB.SelectedItem.ToString();
            //EnableCell(viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.CurrentRow.Index], false);

            //int selectedCBIndex = GetIndexFromString(dGVCB.SelectedItem.ToString());
            //if (!authorIDs.Contains(selectedCBIndex)) authorIDs.Add(selectedCBIndex);

            //viewNewBook.DGVNewBook.Columns[2].Visible = true;
        }

        int GetIndexFromString(string str)
        {
            str = new string(str.SkipWhile(c => !char.IsDigit(c)).TakeWhile(c => char.IsDigit(c)).ToArray());
            int.TryParse(str, out int index);
            return index;
        }

        ComboBox comboBoxAuthors = new ComboBox();


        private void DGVNewBook_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //if (viewNewBook.DGVNewBook.CurrentCell.ColumnIndex == 1 &&
            //    viewNewBook.DGVNewBook.RowCount == viewNewBook.DGVNewBook.CurrentCell.RowIndex + 1 &&
            //    e.Control is ComboBox)
            //{
            //    comboBoxAuthors = e.Control as ComboBox;
            //    comboBoxAuthors.SelectedIndexChanged -= AuthorSelectedIndexChanged;
            //    comboBoxAuthors.SelectedIndexChanged += AuthorSelectedIndexChanged;
            //}
        }

        private void EnableCell(DataGridViewCell dc, bool enabled)
        {
            //dc.ReadOnly = !enabled;
            //if (enabled)
            //{
            //    dc.Style.BackColor = dc.OwningColumn.DefaultCellStyle.BackColor;
            //    dc.Style.ForeColor = dc.OwningColumn.DefaultCellStyle.ForeColor;
            //}
            //else
            //{
            //    dc.Style.BackColor = Color.LightGray;
            //    dc.Style.ForeColor = Color.DarkGray;
            //}
        }

        private void DGVNewAuthor_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

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
                else return null;
            }
        }
    }
}
