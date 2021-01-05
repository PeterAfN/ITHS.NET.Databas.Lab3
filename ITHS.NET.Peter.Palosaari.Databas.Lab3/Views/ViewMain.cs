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
        private ViewBookstores viewBookstores;
        private ViewDetails viewDetails;

        public ViewMain(ViewBookstores viewBookstores, ViewDetails viewDetails)
        {
            InitializeComponent();

            this.viewBookstores = viewBookstores;
            this.viewDetails = viewDetails;

            AddControls();
        }

        public void AddControls()
        {
            splitContainerMain.Panel1.Controls.Add(viewBookstores);
            splitContainerMain.Panel2.Controls.Add(viewDetails);
        }
    }
}
