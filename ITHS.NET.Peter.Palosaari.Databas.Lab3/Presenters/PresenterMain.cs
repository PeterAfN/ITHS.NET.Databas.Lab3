using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
    class PresenterMain
    {
        private readonly IViewMain viewMain;
        private readonly IViewTreeView viewBookstores;
        private readonly IViewDetails viewDetails;


        public PresenterMain(IViewMain viewMain, IViewTreeView viewBookstores, IViewDetails viewDetails)
        {
            this.viewMain = viewMain;
            this.viewBookstores = viewBookstores;
            this.viewDetails = viewDetails;

            this.viewMain.ToolStripMenuItemExit.Click += ToolStripMenuItemExit_Click;
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to exit the program?", "Demo Sql Server Client", MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);

            if (result == DialogResult.Yes) Application.Exit();

            viewMain.Activate();
        }
    }
}
