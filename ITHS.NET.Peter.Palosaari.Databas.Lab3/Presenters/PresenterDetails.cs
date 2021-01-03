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

            // for days column (1st column)
            this.viewDetails.DataGridView.Rows.Add(11);
            this.viewDetails.DataGridView[0, 0].Value = "Isbn:";
            this.viewDetails.DataGridView[0, 1].Value = "Name:";
            this.viewDetails.DataGridView[0, 2].Value = "Language";
            this.viewDetails.DataGridView[0, 3].Value = "Price";
            this.viewDetails.DataGridView[0, 4].Value = "Release Date:";
            this.viewDetails.DataGridView[0, 5].Value = "Publisher Name:";
            this.viewDetails.DataGridView[0, 6].Value = "Publisher Description:";
            this.viewDetails.DataGridView[0, 7].Value = "Publisher Phone Number:";
            this.viewDetails.DataGridView[0, 8].Value = "Publisher Phone Email:";
            this.viewDetails.DataGridView[0, 9].Value = "Author First Name:";
            this.viewDetails.DataGridView[0, 10].Value = "Author Last Name:";
            this.viewDetails.DataGridView[0, 11].Value = "Author Date of Birth";
            //this.viewDetails.DataGridView.column
            //this.viewDetails.DataGridView[1, 3].Value = "Tuesday";
            //this.viewDetails.DataGridView[1, 6].Value = "Wednesday";

        }
    }
}
