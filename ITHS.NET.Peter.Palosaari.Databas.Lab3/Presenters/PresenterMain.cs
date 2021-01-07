using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
    class PresenterMain
    {
        private readonly IViewMain viewMain;
        private readonly IViewBookstores viewBookstores;
        private readonly IViewDetails viewDetails;


        public PresenterMain(IViewMain viewMain, IViewBookstores viewBookstores, IViewDetails viewDetails)
        {
            this.viewMain = viewMain;
            this.viewBookstores = viewBookstores;
            this.viewDetails = viewDetails;

            viewMain.Load += ViewMain_Load;
        }


        private void ViewMain_Load(object sender, EventArgs e)
        {
        }
    }
}
