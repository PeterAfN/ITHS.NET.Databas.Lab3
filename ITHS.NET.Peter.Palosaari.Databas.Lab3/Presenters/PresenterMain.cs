using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
    class PresenterMain
    {
        private readonly IViewMain viewMain;
        private readonly IViewBookstores viewBookstores;
        private readonly IViewDetails viewDetails;

        public ICollection<Butiker> Butiker { get; set; }
        public ICollection<Böcker> Böcker { get; set; }
        public ICollection<LagerSaldo> LagerSaldo { get; set; }

        public PresenterMain(IViewMain viewMain, IViewBookstores viewBookstores, IViewDetails viewDetails)
        {
            this.viewMain = viewMain;
            this.viewBookstores = viewBookstores;
            this.viewDetails = viewDetails;

            viewMain.Load += ViewMain_Load;
        }

        private void ViewMain_Load(object sender, EventArgs e)
        {
            GetDataFromDatabase();
            viewMain.AddNodesToTreeview(Butiker/*, Böcker, LagerSaldo*/);
            viewMain.AddControls();
        }

        private void GetDataFromDatabase()
        {
            using (var db = new Bokhandel_Lab2Context())
            {
                if (db.Database.CanConnect())
                {
                    Debug.WriteLine("Connection to database succeeded.");
                    Böcker = db.Böcker.ToList();
                    Butiker = db.Butiker.ToList();
                    LagerSaldo = db.LagerSaldon.ToList();
                }
                else Debug.WriteLine("Could not connect to database.");
            }
        }

    }
}
