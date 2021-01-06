using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Collections.Generic;
using System.Text;
using ITHS.NET.Peter.Palosaari.Databas.Lab3.CustomEventArgs;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
    class PresenterDetails
    {
        private readonly IViewMain viewMain;
        private readonly IViewBookstores viewBookstores;
        private readonly IViewDetails viewDetails;

        public PresenterDetails(IViewMain viewMain, IViewBookstores viewBookstores, IViewDetails viewDetails)
        {
            this.viewMain = viewMain;
            this.viewBookstores = viewBookstores;
            this.viewDetails = viewDetails;

            this.viewDetails._DGVDetailsBookstore_SelectionChanged += ViewDetails__DGVDetailsBookstore_SelectionChanged;
            this.viewDetails._DGVDetailsBook_SelectionChanged += ViewDetails__DGVDetailsBook_SelectionChanged;
            this.viewBookstores._TreeViewBookstores_AfterSelect += ViewBookstores__TreeViewBookstores_AfterSelect;
            this.viewDetails.Load += ViewDetails_Load;

            viewDetails.DGVDetailsBook.AllowUserToAddRows = false;
            CreateDGVDetailBookstore();
            CreateDGVDetailBook();
        }

        private void ViewDetails_Load(object sender, EventArgs e)
        {
            viewDetails._DGVDetailsBookstore_CellValueChanged += ViewDetails__DGVDetailsBookstore_CellValueChanged;
            viewDetails._DGVDetailsBook_CellValueChanged += ViewDetails__DGVDetailsBook_CellValueChanged;
            //viewDetails.DGVDetailsBookstore.EditingControlShowing += DGVDetailsBookstore_EditingControlShowing;
        }

        //private void DGVDetailsBookstore_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
        //    if (viewDetails.DGVDetailsBookstore.CurrentCell.ColumnIndex == 1 && viewDetails.DGVDetailsBookstore.CurrentCell.RowIndex == 3)
        //    {
        //        TextBox tb = e.Control as TextBox;
        //        if (tb != null) tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
        //    }
        //}

        //private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        //}

        private void ViewDetails__DGVDetailsBook_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (userNavigating) return;
            using var db = new Bokhandel_Lab2Context();
            if (db.Database.CanConnect())
            {
                switch (e.RowIndex)
                {
                    case 0:
                        break;
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
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
                }
            }
            else Debug.WriteLine("Could not connect to database to read values.");
        }

        private void ViewDetails__DGVDetailsBookstore_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (userNavigating) return;
            using var db = new Bokhandel_Lab2Context();
            if (db.Database.CanConnect())
            {
                int.TryParse(viewDetails.DGVDetailsBookstore[1, 0].Value.ToString(), out int bookID);
                var butiker = db.Butiker.FirstOrDefault(b => b.Id == bookID);
                switch (e.RowIndex)
                {
                    case 0:
                        break;
                    case 1:
                        butiker.Namn = viewDetails.DGVDetailsBookstore[1, 1].Value.ToString();
                        break;
                    case 2:
                        butiker.Adress = viewDetails.DGVDetailsBookstore[1, 2].Value.ToString();
                        break;
                    case 3:
                        int.TryParse(viewDetails.DGVDetailsBookstore[1, 3].Value.ToString(), out int postalNr);
                        butiker.Postnummer = postalNr;
                        break;
                    case 4:
                        butiker.Stad = viewDetails.DGVDetailsBookstore[1, 4].Value.ToString();
                        break;
                    case 5:
                        butiker.Land = viewDetails.DGVDetailsBookstore[1, 5].Value.ToString();
                        break;
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
                }
            }
            else Debug.WriteLine("Could not connect to database to set values.");
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

        private void ViewBookstores__TreeViewBookstores_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            userNavigating = true;

            if (e.Node.Tag is Butiker selectedOrder)
            {
                ClearBook();
                viewDetails.DGVDetailsBook.Enabled = false;
                UpdateBookstore(selectedOrder);
            }
            else if (e.Node.Tag is LagerSaldo lagerSaldo)
            {
                if (e.Node.Parent.Tag is Butiker parentOrder)
                {
                    viewDetails.DGVDetailsBook.Enabled = true;
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
            var tmp = viewDetails.DGVDetailsBook.Columns[1];
            viewDetails.DGVDetailsBook.Columns.Remove(viewDetails.DGVDetailsBook.Columns[1]);
            viewDetails.DGVDetailsBook.Columns.Insert(1, tmp);
        }

        private void UpdateBookstore(Butiker butik)
        {
            viewDetails.DGVDetailsBookstore[1, 0].Value = butik.Id; 
            viewDetails.DGVDetailsBookstore[1, 1].Value = butik.Namn;
            viewDetails.DGVDetailsBookstore[1, 2].Value = butik.Adress;
            viewDetails.DGVDetailsBookstore[1, 3].Value = butik.Postnummer;
            viewDetails.DGVDetailsBookstore[1, 4].Value = butik.Stad;
            viewDetails.DGVDetailsBookstore[1, 5].Value = butik.Land;
        }

        private void UpdateBook(LagerSaldo lagerSaldo)
        {
            viewDetails.DGVDetailsBook[1, 0].Value = lagerSaldo.Isbn;
            viewDetails.DGVDetailsBook[1, 1].Value = lagerSaldo.IsbnNavigation.Titel;
            viewDetails.DGVDetailsBook[1, 2].Value = lagerSaldo.Antal;
            viewDetails.DGVDetailsBook[1, 3].Value = lagerSaldo.IsbnNavigation.Språk;
            viewDetails.DGVDetailsBook[1, 4].Value = lagerSaldo.IsbnNavigation.Pris;
            viewDetails.DGVDetailsBook[1, 5].Value = lagerSaldo.IsbnNavigation.Utgivningsdatum;
            viewDetails.DGVDetailsBook[1, 6].Value = lagerSaldo.IsbnNavigation.FörlagId;
            viewDetails.DGVDetailsBook[1, 7].Value = lagerSaldo.IsbnNavigation.Förlag.Namn;
            viewDetails.DGVDetailsBook[1, 8].Value = lagerSaldo.IsbnNavigation.Förlag.Beskrivning;
            viewDetails.DGVDetailsBook[1, 9].Value = lagerSaldo.IsbnNavigation.Förlag.Telefonnummer;
            viewDetails.DGVDetailsBook[1, 10].Value = lagerSaldo.IsbnNavigation.Förlag.Epost;
        }

        void ClearBookAuthors()
        {
            int count = viewDetails.DGVDetailsBook.Rows.Count;
            
            for (int i = count-1; i > 10; i--)
            {
                viewDetails.DGVDetailsBook.Rows.RemoveAt(i);
            }
        }

        void CreateBookAuthors(LagerSaldo lagerSaldo)
        {
            int i = 0;
            foreach (var item in lagerSaldo.IsbnNavigation.FörfattareBöckerJunction)
            {
                viewDetails.DGVDetailsBook.Rows.Add(4);
                viewDetails.DGVDetailsBook[0, 11 + (i * 4)].Value = "Author Id:";
                viewDetails.DGVDetailsBook[0, 12 + (i * 4)].Value = "Author First Name:";
                viewDetails.DGVDetailsBook[0, 13 + (i * 4)].Value = "Author Last Name:";
                viewDetails.DGVDetailsBook[0, 14 + (i * 4)].Value = "Author Date of Birth";
                viewDetails.DGVDetailsBook[1, 11 + (i * 4)].Value = item.FörfattareId;
                viewDetails.DGVDetailsBook[1, 11 + (i * 4)].ReadOnly = true;
                viewDetails.DGVDetailsBook[1, 12 + (i * 4)].Value = item.Författare.Förnamn;
                viewDetails.DGVDetailsBook[1, 13 + (i * 4)].Value = item.Författare.Efternamn;
                viewDetails.DGVDetailsBook[1, 14 + (i * 4)].Value = item.Författare.Födelsedatum;
                i++;
            }
        }

        private void CreateDGVDetailBookstore()
        {
            viewDetails.DGVDetailsBookstore.Rows.Add(5);
            viewDetails.DGVDetailsBookstore[0, 0].Value = "Id:";
            viewDetails.DGVDetailsBookstore[0, 1].Value = "Name:";
            viewDetails.DGVDetailsBookstore[0, 2].Value = "Address:";
            viewDetails.DGVDetailsBookstore[0, 3].Value = "Postal Number:";
            viewDetails.DGVDetailsBookstore[0, 4].Value = "City:";
            viewDetails.DGVDetailsBookstore[0, 5].Value = "Country:";
        }

        private void CreateDGVDetailBook()
        {
            viewDetails.DGVDetailsBook.Rows.Add(15);
            viewDetails.DGVDetailsBook[0, 0].Value = "Isbn:";
            viewDetails.DGVDetailsBook[0, 1].Value = "Title:";
            viewDetails.DGVDetailsBook[0, 2].Value = "Amount:";
            viewDetails.DGVDetailsBook[0, 3].Value = "Language";
            viewDetails.DGVDetailsBook[0, 4].Value = "Price";
            viewDetails.DGVDetailsBook[0, 5].Value = "Release Date:";
            viewDetails.DGVDetailsBook[0, 6].Value = "Publisher Id:";
            viewDetails.DGVDetailsBook[0, 7].Value = "Publisher Name:";
            viewDetails.DGVDetailsBook[0, 8].Value = "Publisher Description:";
            viewDetails.DGVDetailsBook[0, 9].Value = "Publisher Phone Number:";
            viewDetails.DGVDetailsBook[0, 10].Value = "Publisher Email:";
            viewDetails.DGVDetailsBook[0, 11].Value = "Author Id:";
            viewDetails.DGVDetailsBook[0, 12].Value = "Author First Name:";
            viewDetails.DGVDetailsBook[0, 13].Value = "Author Last Name:";
            viewDetails.DGVDetailsBook[0, 14].Value = "Author Date of Birth";
        }

        void SetReadOnlyCells()
        {
            viewDetails.DGVDetailsBookstore[1, 0].ReadOnly = true;  //id
            viewDetails.DGVDetailsBook[1, 0].ReadOnly = true;       //isbn
            viewDetails.DGVDetailsBook[1, 6].ReadOnly = true;       //publisher id
            viewDetails.DGVDetailsBook[1, 11].ReadOnly = true;      //author id
        }

        private void ViewDetails__DGVDetailsBook_SelectionChanged(object sender, EventArgs e)
        {
            if (viewDetails.DGVDetailsBook.CurrentCell.ColumnIndex == 0) viewDetails.DGVDetailsBook.CurrentCell.Selected = false;
        }

        private void ViewDetails__DGVDetailsBookstore_SelectionChanged(object sender, EventArgs e)
        {
            if (viewDetails.DGVDetailsBookstore.CurrentCell.ColumnIndex == 0) viewDetails.DGVDetailsBookstore.CurrentCell.Selected = false;
        }
    }
}
