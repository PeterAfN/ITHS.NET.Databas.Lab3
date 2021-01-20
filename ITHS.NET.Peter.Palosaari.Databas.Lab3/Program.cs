using ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters;
using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
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
            var viewTreeView = new ViewTreeView() { Dock = DockStyle.Fill };
            var viewDetails = new ViewDetails() { Dock = DockStyle.Fill };
            var viewNewBook = new ViewNewBook() { Dock = DockStyle.Fill };
            var viewNewAuthor = new ViewNewAuthor() { Dock = DockStyle.Fill };
            var viewDeleteAuthor = new ViewDeleteAuthor() { Dock = DockStyle.Fill };
            var viewMain = new ViewMain(viewTreeView, viewDetails, viewNewBook, viewNewAuthor, viewDeleteAuthor);


            //Presenters
            _ = new PresenterMain(viewMain, viewTreeView, viewDetails);
            _ = new PresenterDetails(viewMain, viewTreeView, viewDetails, viewNewAuthor);
            _ = new PresenterTreeView(viewMain, viewTreeView, viewDetails, viewNewBook, viewDeleteAuthor, viewNewAuthor);
            _ = new PresenterNewBook(viewMain, viewTreeView, viewDetails, viewNewBook);
            _ = new PresenterNewAuthor(viewMain, viewTreeView, viewDetails, viewNewAuthor);
            _ = new PresenterDeleteAuthor(viewMain, viewTreeView, viewDetails, viewDeleteAuthor);

            Application.Run(viewMain);
        }
    }
}
