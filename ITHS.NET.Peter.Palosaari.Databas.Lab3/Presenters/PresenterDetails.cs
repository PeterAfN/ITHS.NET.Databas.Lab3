using ITHS.NET.Peter.Palosaari.Databas.Lab3.CustomEventArgs;
using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
    class PresenterDetails
    {
        private readonly IViewMain viewMain;
        private readonly IViewTreeView viewTreeView;
        private readonly IViewDetails viewDetails;

        public PresenterDetails(
            IViewMain viewMain,
            IViewTreeView viewBookstores, 
            IViewDetails viewDetails)
        {
            this.viewMain = viewMain;
            this.viewTreeView = viewBookstores;
            this.viewDetails = viewDetails;

            this.viewDetails.DGVBook.SelectionChanged += DGVBook_SelectionChanged;
            this.viewDetails.DGVBookstore.SelectionChanged += DGVBookstore_SelectionChanged;
            this.viewTreeView._TreeView_AfterSelect += ViewTreeView_AfterSelect;
            this.viewDetails.Load += ViewDetails_Load;

            viewDetails.DGVBook.AllowUserToAddRows = false;
            CreateDGVBookstore();
            CreateDGVBook();
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
            CellValueBeforeEdit = viewDetails.DGVBook.CurrentCell.Value.ToString();
        }

        private void DGVBookstore_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            CellValueBeforeEdit = viewDetails.DGVBookstore.CurrentCell.Value.ToString();
        }

        private void DGVBook_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (userNavigating) return;
            if (viewDetails.DGVBook.CurrentCell.Value == null)
            {
                RestoreCellValue();
                return;
            }

            using var db = new Bokhandel_Lab2Context();
            if (db.Database.CanConnect())
            {
                int.TryParse(viewDetails.DGVBookstore[1, 0].Value.ToString(), out int butikID);
                var stock = db.LagerSaldon.FirstOrDefault(
                    b => b.ButikId == butikID && b.Isbn == viewDetails.DGVBook[1, 0].Value.ToString());
                var books = db.Böcker.FirstOrDefault(
                    b => b.Isbn13 == viewDetails.DGVBook[1, 0].Value.ToString());
                int.TryParse(viewDetails.DGVBook[1, 6].Value.ToString(), out int _publisher);
                var publisher = db.Förlag.FirstOrDefault(b => b.Id == _publisher);
                DetailsChangedEventArgs args = new DetailsChangedEventArgs();

                switch (e.RowIndex)
                {
                    case 1:
                        books.Titel = viewDetails.DGVBook[1, 1].Value.ToString();
                        args = new DetailsChangedEventArgs(); break;
                    case 2:
                        int.TryParse(viewDetails.DGVBook[1, 2].Value.ToString(), out int amount);
                        stock.Antal = amount;
                        args = new DetailsChangedEventArgs(); break;
                    case 3:
                        books.Språk = viewDetails.DGVBook[1, 3].Value.ToString();
                        args = new DetailsChangedEventArgs(); break;
                    case 4:
                        decimal.TryParse(viewDetails.DGVBook[1, 4].Value.ToString(), out decimal price);
                        books.Pris = price;
                        args = new DetailsChangedEventArgs(); break;
                    case 5: //todo: when sql database is changed to date instead this must be changed also to date
                        books.Utgivningsdatum = viewDetails.DGVBook[1, 5].Value.ToString();
                        args = new DetailsChangedEventArgs(); break;
                    case 7:
                        publisher.Namn = viewDetails.DGVBook[1, 7].Value.ToString();
                        args = new DetailsChangedEventArgs(); break;
                    case 8:
                        publisher.Beskrivning = viewDetails.DGVBook[1, 8].Value.ToString();
                        args = new DetailsChangedEventArgs(); break;
                    case 9:
                        publisher.Telefonnummer = viewDetails.DGVBook[1, 9].Value.ToString();
                        args = new DetailsChangedEventArgs(); break;
                    case 10:
                        publisher.Epost = viewDetails.DGVBook[1, 10].Value.ToString();
                        args = new DetailsChangedEventArgs(); break;
                    default:
                        CellAuthor(sender, e);
                        return;
                }

                try
                {
                    db.SavedChanges += Db_SavedChanges;
                    db.SaveChangesFailed += Db_SaveChangesFailed;
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    db.Dispose();
                    RestoreCellValue();
                    return;
                }
                TriggerEvent(sender, args);
            }
            else Debug.WriteLine("Could not connect to database to read values.");
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
            if (!db.Database.CanConnect()) return;
           
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
            DetailsChangedEventArgs args = new DetailsChangedEventArgs();

            try
            {
                db.SavedChanges += Db_SavedChanges;
                db.SaveChangesFailed += Db_SaveChangesFailed;
                db.SaveChanges();
            }
            catch (Exception)
            {
                db.Dispose();
                RestoreCellValue();
                return;
            }
            TriggerEvent(sender, args);
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
                try
                {
                    db.SavedChanges += Db_SavedChanges;
                    db.SaveChangesFailed += Db_SaveChangesFailed;
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    db.Dispose();
                    RestoreCellValue();
                    return;
                }

                DetailsChangedEventArgs args = new DetailsChangedEventArgs();
                TriggerEvent(sender, args);
            }
            else Debug.WriteLine("Could not connect to database to set values.");
        }


        private void RestoreCellValue()
        {
            viewDetails.DGVBookstore.CellValueChanged -= DGVBookstore_CellValueChanged;
            viewDetails.DGVBookstore.CurrentCell.Value = CellValueBeforeEdit;
            viewDetails.DGVBookstore.CellValueChanged += DGVBookstore_CellValueChanged;
        }

        private void Db_SaveChangesFailed(object sender, SaveChangesFailedEventArgs e)
        {
            Debug.WriteLine("save failed!");
        }

        private void Db_SavedChanges(object sender, SavedChangesEventArgs e)
        {
            Debug.WriteLine("save succeeded!");
        }

        bool userNavigating = false;

        private void ViewTreeView_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            userNavigating = true;

            if (e.Node.Tag is Butiker selectedOrder)
            {
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
                    ClearBookAuthors();
                    CreateBookAuthors(lagerSaldo);
                }
            }
            SetReadOnlyCells();
            userNavigating = false;
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

        void ClearBookAuthors()
        {
            int count = viewDetails.DGVBook.Rows.Count;

            for (int i = count - 1; i > 10; i--)
            {
                viewDetails.DGVBook.Rows.RemoveAt(i);
            }
        }

        void CreateBookAuthors(LagerSaldo lagerSaldo)
        {
            int i = 0;
            foreach (var item in lagerSaldo.IsbnNavigation.FörfattareBöckerJunction)
            {
                viewDetails.DGVBook.Rows.Add(4);
                viewDetails.DGVBook[0, 11 + (i * 4)].Value = "Author Id:";
                viewDetails.DGVBook[0, 12 + (i * 4)].Value = "Author First Name:";
                viewDetails.DGVBook[0, 13 + (i * 4)].Value = "Author Last Name:";
                viewDetails.DGVBook[0, 14 + (i * 4)].Value = "Author Date of Birth";
                viewDetails.DGVBook[1, 11 + (i * 4)].Value = item.FörfattareId;
                viewDetails.DGVBook[1, 11 + (i * 4)].ReadOnly = true;
                viewDetails.DGVBook[1, 12 + (i * 4)].Value = item.Författare.Förnamn;
                viewDetails.DGVBook[1, 13 + (i * 4)].Value = item.Författare.Efternamn;
                viewDetails.DGVBook[1, 14 + (i * 4)].Value = item.Författare.Födelsedatum;
                i++;
            }
        }

        private void CreateDGVBookstore()
        {
            viewDetails.DGVBookstore.Rows.Add(6);
            viewDetails.DGVBookstore[0, 0].Value = "Id:";
            viewDetails.DGVBookstore[0, 1].Value = "Name:";
            viewDetails.DGVBookstore[0, 2].Value = "Address:";
            viewDetails.DGVBookstore[0, 3].Value = "Postal Number:";
            viewDetails.DGVBookstore[0, 4].Value = "City:";
            viewDetails.DGVBookstore[0, 5].Value = "Country:";
        }

        private void CreateDGVBook()
        {
            viewDetails.DGVBook.Rows.Add(15);
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
            viewDetails.DGVBook[0, 11].Value = "Author Id:";
            viewDetails.DGVBook[0, 12].Value = "Author First Name:";
            viewDetails.DGVBook[0, 13].Value = "Author Last Name:";
            viewDetails.DGVBook[0, 14].Value = "Author Date of Birth";
        }

        void SetReadOnlyCells()
        {
            viewDetails.DGVBookstore[1, 0].ReadOnly = true;  //id
            viewDetails.DGVBook[1, 0].ReadOnly = true;       //isbn
            viewDetails.DGVBook[1, 6].ReadOnly = true;       //publisher id
            viewDetails.DGVBook[1, 11].ReadOnly = true;      //author id
        }
    }
}
