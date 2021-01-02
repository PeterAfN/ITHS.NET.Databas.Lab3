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

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3
{
    public partial class ViewMain : Form, IViewMain
    {
        public ViewMain()
        {
            InitializeComponent();

            using ( var db = new Bokhandel_Lab2Context())
            {
                if (db.Database.CanConnect())
                {
                    Debug.WriteLine("Connection to database succeeded.");
                    var böcker = db.Böcker.ToList();

                }
                else Debug.WriteLine("Could not connect to database.");
            }
        }

    }
}
