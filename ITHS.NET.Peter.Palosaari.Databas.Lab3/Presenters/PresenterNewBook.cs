using ITHS.NET.Peter.Palosaari.Databas.Lab3.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Drawing;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Presenters
{
    public class PresenterNewBook
    {
        Queue<DataGridViewComboBoxCell> cb = new Queue<DataGridViewComboBoxCell>(200);
        Dictionary<int, int> storedIDs = new Dictionary<int, int>();

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
            viewNewBook.DGVNewBook.CellClick += DGVNewBook_CellClick;
        }


        private void ContextMenuStripTreeView_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            viewNewBook.DGVNewBook.Rows.Add(10);
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

            viewNewBook.Show();
            viewNewBook.DGVNewBook.Rows.Add(1);
            AuthorCellCreate();
        }

        private void AuthorCellCreate()
        {          
            viewNewBook.DGVNewBook[1, 10].Value = "Please click here to add an author";
        }

        private void DGVNewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (viewNewBook.DGVNewBook.CurrentCell.ColumnIndex == 1 && 
                viewNewBook.DGVNewBook.RowCount == viewNewBook.DGVNewBook.CurrentCell.RowIndex + 1)
            {
                AddAuthorCell(viewNewBook.DGVNewBook.CurrentCell.RowIndex);
            }
        }

        DataGridViewComboBoxCell cB = new DataGridViewComboBoxCell();

        private void AddAuthorCell(int rowIndexNewCell)
        {
            cB.Items.Clear();
            var författare = GetDataFromDatabase();

            foreach (Författare f in författare)
            {
                if (!storedIDs.ContainsKey(f.Id))
                    cB.Items.Add($"Id: {f.Id} - {f.Förnamn} {f.Efternamn} - BirthDate: {f.Födelsedatum}");
            }

            viewNewBook.DGVNewBook.Rows[rowIndexNewCell].Cells[1] = cB;
            viewNewBook.DGVNewBook.CurrentCell = viewNewBook.DGVNewBook.Rows[1].Cells[1];
            viewNewBook.DGVNewBook.CurrentCell = viewNewBook.DGVNewBook.Rows[rowIndexNewCell].Cells[1];
            viewNewBook.DGVNewBook.CellClick -= DGVNewBook_CellClick;
        }

        private void CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("ComboBox_SelectedIndexChanged");
            DataGridViewComboBoxEditingControl dataGridViewB = sender as DataGridViewComboBoxEditingControl;
            Debug.WriteLine("dataGridViewB.SelectedIndex=" + dataGridViewB.SelectedIndex);
            Debug.WriteLine("dataGridViewB.SelectedItem=" + dataGridViewB.SelectedItem.ToString());
            
            viewNewBook.DGVNewBook.Rows[viewNewBook.DGVNewBook.CurrentRow.Index].Cells[1] = new DataGridViewTextBoxCell();
            viewNewBook.DGVNewBook[0, viewNewBook.DGVNewBook.CurrentRow.Index].Value = "Author:";
            viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.CurrentRow.Index].Value = dataGridViewB.SelectedItem.ToString();
            EnableCell(viewNewBook.DGVNewBook[1, viewNewBook.DGVNewBook.CurrentRow.Index], false);

            if (cB.Items.Count > 1)
            {
                viewNewBook.DGVNewBook.Rows.Add(1);
                viewNewBook.DGVNewBook.FirstDisplayedScrollingRowIndex = viewNewBook.DGVNewBook.RowCount - 1; //scroll to bottom.
                viewNewBook.DGVNewBook.CellClick += DGVNewBook_CellClick;
            }

            string Index = new string(dataGridViewB.SelectedItem.ToString().
                SkipWhile(c => !char.IsDigit(c)).TakeWhile(c => char.IsDigit(c)).ToArray());
            int.TryParse(Index, out int selectedCBIndex);

            if (!storedIDs.ContainsKey(selectedCBIndex)) storedIDs.Add(selectedCBIndex, -1);
        }

        ComboBox comboBox = new ComboBox();

        private void DGVNewBook_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (viewNewBook.DGVNewBook.CurrentCell.ColumnIndex == 1 &&
                viewNewBook.DGVNewBook.RowCount == viewNewBook.DGVNewBook.CurrentCell.RowIndex + 1 && //must be cell with highest row index
                e.Control is ComboBox)
                if (e.Control is ComboBox)
                {
                    comboBox = e.Control as ComboBox;
                    comboBox.SelectedIndexChanged -= CB_SelectedIndexChanged;
                    comboBox.SelectedIndexChanged += CB_SelectedIndexChanged;
                }
        }

        private void EnableCell(DataGridViewCell dc, bool enabled)
        {
            dc.ReadOnly = !enabled;
            if (enabled)
            {
                dc.Style.BackColor = dc.OwningColumn.DefaultCellStyle.BackColor;
                dc.Style.ForeColor = dc.OwningColumn.DefaultCellStyle.ForeColor;
            }
            else
            {
                dc.Style.BackColor = Color.LightGray;
                dc.Style.ForeColor = Color.DarkGray;
            }
        }


        private ICollection<Författare> GetDataFromDatabase()
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
                else  return null;
            }
        }
    }
}
