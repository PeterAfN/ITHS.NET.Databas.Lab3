using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Views         
            var viewBookstores = new ViewBookstores() { Dock = DockStyle.Fill };
            var viewDetails = new ViewDetails() { Dock = DockStyle.Fill };
            var viewMain = new ViewMain(viewBookstores, viewDetails);

            //Presenters
            var PresenterMain = new PresenterMain(viewMain, viewBookstores,viewDetails);
            var PresenterDetails = new PresenterDetails(viewMain, viewBookstores, viewDetails);
            var PresenterBookstores = new PresenterBookstores(viewMain, viewBookstores, viewDetails);

            Application.Run(viewMain);
        }
    }
}
