using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
    public class PresenterDeleteAuthor
    {
        public long CurrentlySelectedAuthorID { get; set; }

        private readonly IViewMain viewMain;
        private readonly IViewTreeView viewTreeView;
        private readonly IViewDetails viewDetails;
        private readonly IViewDeleteAuthor viewDeleteAuthor;

        public PresenterDeleteAuthor(IViewMain viewMain, 
            IViewTreeView viewBookstores, 
            IViewDetails viewDetails,
            IViewDeleteAuthor viewDeleteAuthor)
        {
            this.viewMain = viewMain;
            this.viewTreeView = viewBookstores;
            this.viewDetails = viewDetails;
            this.viewDeleteAuthor = viewDeleteAuthor;

            viewMain.ToolStripMenuItemDeleteAuthor.Click += ToolStripMenuItemDeleteAuthor_Click;
            this.viewDeleteAuthor.ButtonClose.Click += ButtonClose_Click;
            this.viewDeleteAuthor.ButtonDelete.Click += ButtonDelete_Click;
            this.viewDeleteAuthor.ComboBoxDeleteAuthor.SelectedIndexChanged += ComboBoxDeleteAuthor_SelectedIndexChanged;
        }

        private void ComboBoxDeleteAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {           
            CurrentlySelectedAuthorID = GetIndexFromString(viewDeleteAuthor.ComboBoxDeleteAuthor.SelectedItem.ToString());
        }

        long GetIndexFromString(string str)
        {
            str = new string(str.SkipWhile(c => !char.IsDigit(c)).TakeWhile(c => char.IsDigit(c)).ToArray());
            long.TryParse(str, out long index);
            return index;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            using var db = new Bokhandel_Lab2Context();
            {
                if (db.Database.CanConnect())
                {
                    using var dbContextTransaction = db.Database.BeginTransaction();
                    try
                    {
                        db.Database.ExecuteSqlInterpolated(
                            $"DELETE FROM dbo.FörfattareBöcker_Junction WHERE FörfattareID = ({CurrentlySelectedAuthorID})");
                        db.SaveChanges();

                        db.Database.ExecuteSqlInterpolated(
                            $"DELETE FROM dbo.Författare WHERE ID = ({CurrentlySelectedAuthorID})");
                        db.SaveChanges();

                        dbContextTransaction.Commit();
                        viewDeleteAuthor.TriggerEventAuthorDeletedFromDatabase(sender, e);
                        string logText = "Save ok.";
                        UpdateItemsCombobox();
                        _ = ShowLogTextAsync(logText, Color.Green, 5000);
                    }
                    catch (Exception)
                    {
                        dbContextTransaction.Rollback(); //not needed but good practice
                        string logText = "Error while saving.";
                        _ = ShowLogTextAsync(logText, Color.Red, 5000);
                    }
                }
                else
                {
                    string logText = "Error while connecting to the SQL database.";
                    _ = ShowLogTextAsync(logText, Color.Red, 5000);
                }
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            viewDeleteAuthor.Hide();
        }

        private void ToolStripMenuItemDeleteAuthor_Click(object sender, EventArgs e)
        {
            UpdateItemsCombobox();

            using (Form form = new Form())
            {
                viewDeleteAuthor.ShowDialog();
            }
        }

        void UpdateItemsCombobox()
        {
            var authors = GetAuthorsFromDatabase();
            viewDeleteAuthor.ComboBoxDeleteAuthor.Items.Clear();

            foreach (Författare f in authors)
            {
                viewDeleteAuthor.ComboBoxDeleteAuthor.Items.Add($"Id:{f.Id} - {f.Förnamn} {f.Efternamn} - {f.Födelsedatum}");
            }
        }

        private ICollection<Författare> GetAuthorsFromDatabase()
        {
            using var db = new Bokhandel_Lab2Context();
            {
                if (db.Database.CanConnect())
                {
                    ICollection<Författare> output = new List<Författare>();
                    foreach (Författare f in db.Författare)
                    {
                        output.Add(f);
                    }
                    return output;
                }
                else
                {
                    string logText = "Could not connect to the SQL Server database.";
                    _ = ShowLogTextAsync(logText, Color.Red, 5000);
                    return null;
                }
            }
        }

        private async Task ShowLogTextAsync(string infoText, Color color, int showTime)
        {
            viewDeleteAuthor.LabelLog.Text = infoText;
            viewDeleteAuthor.LabelLog.ForeColor = color;
            viewDeleteAuthor.LabelLog.Visible = true;
            await Task.Delay(showTime);
            viewDeleteAuthor.LabelLog.Visible = false;
        }
    }
}
