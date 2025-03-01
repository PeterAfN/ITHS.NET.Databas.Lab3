﻿using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
    class PresenterMain
    {
        private readonly IViewMain viewMain;

        public PresenterMain(IViewMain viewMain)
        {
            this.viewMain = viewMain;

            viewMain.Load += ViewMain_Load;
        }

        private void ViewMain_Load(object sender, EventArgs e)
        {
            viewMain.ToolStripMenuItemExit.Click += ToolStripMenuItemExit_Click;
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Do you want to exit the program?", "Sql Server Demo Client", MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else viewMain.Activate(); // <--bring mainForm in front.
        }
    }
}
