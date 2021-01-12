using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
    public class PresenterNewBook
    {
        DataGridViewComboBoxCell ComboBoxAuthorsCell = new DataGridViewComboBoxCell();
        List<int> comboBoxAuthorIDs = new List<int>();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; } //change to date when database is changed

        private readonly IViewMain viewMain;
        private readonly IViewTreeView viewTreeView;
        private readonly IViewDetails viewDetails;
        private readonly IViewNewBook viewNewBook;

        public PresenterNewBook(IViewMain viewMain, IViewTreeView viewTreeView, IViewDetails viewDetails, IViewNewBook viewNewBook)
        {
            this.viewMain = viewMain;
            this.viewTreeView = viewTreeView;
            this.viewDetails = viewDetails;
            this.viewNewBook = viewNewBook;

            viewTreeView.ContextMenuStripTreeView.ItemClicked += ContextMenuStripTreeView_ItemClicked;
            viewNewBook.DGVNewBook.EditingControlShowing += DGVNewBook_EditingControlShowing;
        }

        private void ContextMenuStripTreeView_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            viewNewBook.DGVNewBook.Rows.Add(11);
            viewNewBook.DGVNewBook[0, 0].Value = "Isbn [Required, 13 digits]:";
            viewNewBook.DGVNewBook[0, 1].Value = "Title:";
            viewNewBook.DGVNewBook[0, 2].Value = "Language";
            viewNewBook.DGVNewBook[0, 3].Value = "Price";
            viewNewBook.DGVNewBook[0, 4].Value = "Release Date:";
            viewNewBook.DGVNewBook[0, 5].Value = "Publisher Id:";
            viewNewBook.DGVNewBook[0, 6].Value = "Publisher Name:";
            viewNewBook.DGVNewBook[0, 7].Value = "Publisher Description:";
            viewNewBook.DGVNewBook[0, 8].Value = "Publisher Phone Number:";
            viewNewBook.DGVNewBook[0, 9].Value = "Publisher Email:";
            viewNewBook.DGVNewBook.CurrentCell = viewNewBook.DGVNewBook.Rows[0].Cells[1];
            viewNewBook.DGVNewBook.BeginEdit(true);
            //viewNewBook.DGVNewBook[2, 10].Value = "Add author";
            viewNewBook.DGVNewBook.CellContentClick += DGVNewBook_CellContentClick;
            CreateAuthorCellWithComboBox();
            viewNewBook.Show();
        }

        private void DGVNewBook_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //when new cell gets focus.
            if (viewNewBook.DGVNewBook.CurrentCell.ColumnIndex == 1 && 
                viewNewBook.DGVNewBook.CurrentCell.RowIndex == 10 &&
                e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                int index = comboBox.SelectedIndex;
                comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }

        private void DGVNewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Add author link clicked            
            if (e.ColumnIndex == 2 && 
                viewNewBook.DGVNewBook[2, viewNewBook.DGVNewBook.CurrentCell.RowIndex].Value.ToString() == "Add author")
            {
                viewNewBook.DGVNewBook[0, 10].Value = "Author:";
                CreateAuthorCellWithComboBox();
            }
            else if (e.ColumnIndex == 2 &&
                viewNewBook.DGVNewBook[2, viewNewBook.DGVNewBook.CurrentCell.RowIndex].Value.ToString() == "Remove author")
            {
                //viewNewBook.DGVNewBook.Rows.RemoveAt(viewNewBook.DGVNewBook.CurrentCell.RowIndex);
                //viewNewBook.DGVNewBook.Rows.Add(1);
                //ComboBoxAuthorsCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

                viewNewBook.DGVNewBook[0, viewNewBook.DGVNewBook.CurrentCell.RowIndex].Value = "";
                //viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.CurrentCell.RowIndex].Value = "";
                ComboBoxAuthorsCell.Value = "Please select an author:";
                viewNewBook.DGVNewBook[2, viewNewBook.DGVNewBook.CurrentCell.RowIndex].Value = "Add author";
            }
        }

        private void CreateAuthorCellWithComboBox()
        {
            ComboBoxAuthorsCell.Items.Clear();
            ComboBoxAuthorsCell.Items.Add("Please click here to add an author.");
            ComboBoxAuthorsCell.Value = "Please click here to add an author.";
            var författare = GetDataFromDatabase();
            foreach (Författare f in författare)
            {
                ComboBoxAuthorsCell.Items.Add($"Id: {f.Id} - {f.Förnamn} {f.Efternamn} - BirthDate: {f.Födelsedatum}");
            }
            ComboBoxAuthorsCell.Items.Add("+add a new author");
            //ComboBoxAuthorsCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            viewNewBook.DGVNewBook.Rows[10].Cells[1] = ComboBoxAuthorsCell;
        }

        private ICollection<Författare> GetDataFromDatabase()
        {
            using var db = new Bokhandel_Lab2Context();
            if (db.Database.CanConnect())
            {
                Debug.WriteLine("Connected to database.");

                ICollection<Författare> output = new List<Författare>();
                comboBoxAuthorIDs.Clear();
                foreach (Författare f in db.Författare)
                {
                    comboBoxAuthorIDs.Add(f.Id);
                    output.Add(f);
                }
                return output;
            }
            else
            {
                Debug.WriteLine("Could not connect to database");
                return null;
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewComboBoxEditingControl dataGridViewComboBoxEditingControl = sender as DataGridViewComboBoxEditingControl;
            object value = dataGridViewComboBoxEditingControl.SelectedValue;
            int index = dataGridViewComboBoxEditingControl.SelectedIndex;
            if (index == (dataGridViewComboBoxEditingControl.Items.Count-1))    //create new author selected
            {

            }
            else if (index > 0)                                                 //existing author selected
            {
                ExtendCellExistingAuthor();
                viewNewBook.DGVNewBook[2, viewNewBook.DGVNewBook.CurrentCell.RowIndex].Value = "Remove author";
            }

        }

        void ExtendCellExistingAuthor()
        {
            //viewNewBook.DGVNewBook.Rows.Add(2);
            viewNewBook.DGVNewBook[0, 10].Value = "Author:";
            //viewNewBook.DGVNewBook[0, 11].Value = "Author Last Name:";
            //viewNewBook.DGVNewBook[0, 12].Value = "Author Date of Birth";
        }

    }
}
