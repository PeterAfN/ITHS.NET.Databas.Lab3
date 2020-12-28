using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ITHS.NET.Peter.Palosaari.Databas.Lab3.Data;
//using ITHS.NET.Peter.Palosaari.Databas.Lab3.Models;

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
            //using (var db = new NetDemoContext())
            //{
            //    var regions = db.Countries.ToList();

            //    foreach (Country region in regions)
            //    {
            //        Debug.WriteLine(region.Region);
            //    }
            //}



            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



        }
    }
}
