using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Collections.Generic;
using System.Text;
using ITHS.NET.Peter.Palosaari.Databas.Lab3.CustomEventArgs;

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

            this.viewDetails._DataGridViewDetailsBookstore_SelectionChanged += ViewDetails__DataGridViewDetailsBookstore_SelectionChanged;
            this.viewDetails._DataGridViewDetailsBook_SelectionChanged += ViewDetails__DataGridViewDetailsBook_SelectionChanged;
            this.viewBookstores._TreeViewBookstores_AfterSelect += ViewBookstores__TreeViewBookstores_AfterSelect;

            CreateDatagridviewDetailBookstore();
            CreateDatagridviewDetailBook();
        }

        public event EventHandler<BookstoreEventArgs> OrderSelected;
        public event EventHandler<BookstoreEventArgs> OrderDeleted;

        private void ViewBookstores__TreeViewBookstores_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            Butiker butiker = null;

            if (e.Node.Tag is Butiker selectedOrder)
            {
                butiker = selectedOrder;
                UpdateBookstore(butiker);
            }
            else if (e.Node.Tag is LagerSaldo lagerSaldo)
            {
                if (e.Node.Parent.Tag is Butiker parentOrder)
                {
                    butiker = parentOrder;
                    UpdateBook(lagerSaldo);
                }
            }

            if (butiker != null)
            {
                OrderSelected?.Invoke(this, new BookstoreEventArgs(butiker));
            }
        }


        private void UpdateBookstore(Butiker butik)
        {
        }

        private void UpdateBook(LagerSaldo lagerSaldo)
        {
            viewDetails.DataGridViewDetailsBook[1, 0].Value = lagerSaldo.Isbn;
            viewDetails.DataGridViewDetailsBook[1, 1].Value = lagerSaldo.IsbnNavigation.Titel;
            viewDetails.DataGridViewDetailsBook[1, 2].Value = lagerSaldo.Antal;
            viewDetails.DataGridViewDetailsBook[1, 3].Value = lagerSaldo.IsbnNavigation.Språk;
            viewDetails.DataGridViewDetailsBook[1, 4].Value = lagerSaldo.IsbnNavigation.Pris;
            viewDetails.DataGridViewDetailsBook[1, 5].Value = lagerSaldo.IsbnNavigation.Utgivningsdatum;
            viewDetails.DataGridViewDetailsBook[1, 6].Value = lagerSaldo.IsbnNavigation.FörlagId;
            viewDetails.DataGridViewDetailsBook[1, 7].Value = lagerSaldo.IsbnNavigation.Förlag.Namn;
            viewDetails.DataGridViewDetailsBook[1, 8].Value = lagerSaldo.IsbnNavigation.Förlag.Beskrivning;
            viewDetails.DataGridViewDetailsBook[1, 9].Value = lagerSaldo.IsbnNavigation.Förlag.Telefonnummer;
            viewDetails.DataGridViewDetailsBook[1, 10].Value = lagerSaldo.IsbnNavigation.Förlag.Epost;

            ClearBookAuthors(lagerSaldo);
            CreateBookAuthors(lagerSaldo);
        }

        void ClearBookAuthors(LagerSaldo lagerSaldo)
        {
            viewDetails.DataGridViewDetailsBook.AllowUserToAddRows = false;
            int count = viewDetails.DataGridViewDetailsBook.Rows.Count;

            
            for (int i = count-1; i > 10; i--)
            {
                viewDetails.DataGridViewDetailsBook.Rows.RemoveAt(i);
            }
            //viewDetails.DataGridViewDetailsBook.AllowUserToAddRows = true;
        }

        void CreateBookAuthors(LagerSaldo lagerSaldo)
        {
            //int count = lagerSaldo.IsbnNavigation.FörfattareBöckerJunction.Count;
            //for (int i = 0; i < count; i++)
            //{
            int i = 0;
            foreach (var item in lagerSaldo.IsbnNavigation.FörfattareBöckerJunction)
            {
                viewDetails.DataGridViewDetailsBook.Rows.Add(4);
                viewDetails.DataGridViewDetailsBook[0, 11 + (i * 4)].Value = "Author Id:";
                viewDetails.DataGridViewDetailsBook[0, 12 + (i * 4)].Value = "Author First Name:";
                viewDetails.DataGridViewDetailsBook[0, 13 + (i * 4)].Value = "Author Last Name:";
                viewDetails.DataGridViewDetailsBook[0, 14 + (i * 4)].Value = "Author Date of Birth";
                viewDetails.DataGridViewDetailsBook[1, 11 + (i * 4)].Value = item.FörfattareId;
                viewDetails.DataGridViewDetailsBook[1, 12 + (i * 4)].Value = item.Författare.Förnamn;
                viewDetails.DataGridViewDetailsBook[1, 13 + (i * 4)].Value = item.Författare.Efternamn;
                viewDetails.DataGridViewDetailsBook[1, 14 + (i * 4)].Value = item.Författare.Födelsedatum;
                i++;
            }
            //}
        }

        private void ViewDetails__DataGridViewDetailsBook_SelectionChanged(object sender, EventArgs e)
        {
            if (viewDetails.DataGridViewDetailsBook.CurrentCell.ColumnIndex == 0)
                viewDetails.DataGridViewDetailsBook.CurrentCell.Selected = false;
        }

        private void ViewDetails__DataGridViewDetailsBookstore_SelectionChanged(object sender, EventArgs e)
        {
            if (viewDetails.DataGridViewDetailsBookstore.CurrentCell.ColumnIndex == 0)
                viewDetails.DataGridViewDetailsBookstore.CurrentCell.Selected = false;
        }


        private void CreateDatagridviewDetailBookstore()
        {
            viewDetails.DataGridViewDetailsBookstore.Rows.Add(5);
            viewDetails.DataGridViewDetailsBookstore[0, 0].Value = "Id:";
            viewDetails.DataGridViewDetailsBookstore[0, 1].Value = "Name:";
            viewDetails.DataGridViewDetailsBookstore[0, 2].Value = "Address:";
            viewDetails.DataGridViewDetailsBookstore[0, 3].Value = "Postal Number:";
            viewDetails.DataGridViewDetailsBookstore[0, 4].Value = "City:";
            viewDetails.DataGridViewDetailsBookstore[0, 5].Value = "Country:";
        }

        private void CreateDatagridviewDetailBook()
        {
            viewDetails.DataGridViewDetailsBook.Rows.Add(14);
            viewDetails.DataGridViewDetailsBook[0, 0].Value = "Isbn:";
            viewDetails.DataGridViewDetailsBook[0, 1].Value = "Title:";
            viewDetails.DataGridViewDetailsBook[0, 2].Value = "Amount:";
            viewDetails.DataGridViewDetailsBook[0, 3].Value = "Language";
            viewDetails.DataGridViewDetailsBook[0, 4].Value = "Price";
            viewDetails.DataGridViewDetailsBook[0, 5].Value = "Release Date:";
            viewDetails.DataGridViewDetailsBook[0, 6].Value = "Publisher Id:";
            viewDetails.DataGridViewDetailsBook[0, 7].Value = "Publisher Name:";
            viewDetails.DataGridViewDetailsBook[0, 8].Value = "Publisher Description:";
            viewDetails.DataGridViewDetailsBook[0, 9].Value = "Publisher Phone Number:";
            viewDetails.DataGridViewDetailsBook[0, 10].Value = "Publisher Email:";
            viewDetails.DataGridViewDetailsBook[0, 11].Value = "Author Id:";
            viewDetails.DataGridViewDetailsBook[0, 12].Value = "Author First Name:";
            viewDetails.DataGridViewDetailsBook[0, 13].Value = "Author Last Name:";
            viewDetails.DataGridViewDetailsBook[0, 14].Value = "Author Date of Birth";
        }
    }
}
