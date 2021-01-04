using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Collections.Generic;
using System.Text;

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

            CreateDatagridviewDetailBookstore();
            CreateDatagridviewDetailBook();
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
            this.viewDetails.DataGridViewDetailsBookstore.Rows.Add(5);
            this.viewDetails.DataGridViewDetailsBookstore[0, 0].Value = "Id:";
            this.viewDetails.DataGridViewDetailsBookstore[0, 1].Value = "Name:";
            this.viewDetails.DataGridViewDetailsBookstore[0, 2].Value = "Address:";
            this.viewDetails.DataGridViewDetailsBookstore[0, 3].Value = "Postal Number:";
            this.viewDetails.DataGridViewDetailsBookstore[0, 4].Value = "City:";
            this.viewDetails.DataGridViewDetailsBookstore[0, 5].Value = "Country:";
        }

        private void CreateDatagridviewDetailBook()
        {
            this.viewDetails.DataGridViewDetailsBook.Rows.Add(14);
            this.viewDetails.DataGridViewDetailsBook[0, 0].Value = "Isbn:";
            this.viewDetails.DataGridViewDetailsBook[0, 1].Value = "Title:";
            this.viewDetails.DataGridViewDetailsBook[0, 2].Value = "Amount:";
            this.viewDetails.DataGridViewDetailsBook[0, 3].Value = "Language";
            this.viewDetails.DataGridViewDetailsBook[0, 4].Value = "Price";
            this.viewDetails.DataGridViewDetailsBook[0, 5].Value = "Release Date:";
            this.viewDetails.DataGridViewDetailsBook[0, 6].Value = "Author Id:";
            this.viewDetails.DataGridViewDetailsBook[0, 7].Value = "Author First Name:";
            this.viewDetails.DataGridViewDetailsBook[0, 8].Value = "Author Last Name:";
            this.viewDetails.DataGridViewDetailsBook[0, 9].Value = "Author Date of Birth";
            this.viewDetails.DataGridViewDetailsBook[0, 10].Value = "Publisher Id:";
            this.viewDetails.DataGridViewDetailsBook[0, 11].Value = "Publisher Name:";
            this.viewDetails.DataGridViewDetailsBook[0, 12].Value = "Publisher Description:";
            this.viewDetails.DataGridViewDetailsBook[0, 13].Value = "Publisher Phone Number:";
            this.viewDetails.DataGridViewDetailsBook[0, 14].Value = "Publisher Phone Email:";
        }


    }
}
