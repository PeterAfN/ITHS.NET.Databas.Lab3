
namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    partial class ViewDetails
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDetailsBook = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNotEditableCells = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditableCells = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDetailsBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDetailsBook
            // 
            this.groupBoxDetailsBook.Controls.Add(this.dataGridView1);
            this.groupBoxDetailsBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetailsBook.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDetailsBook.Name = "groupBoxDetailsBook";
            this.groupBoxDetailsBook.Padding = new System.Windows.Forms.Padding(11, 14, 11, 11);
            this.groupBoxDetailsBook.Size = new System.Drawing.Size(580, 539);
            this.groupBoxDetailsBook.TabIndex = 1;
            this.groupBoxDetailsBook.TabStop = false;
            this.groupBoxDetailsBook.Text = "Details - Book [click to edit]";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNotEditableCells,
            this.ColumnEditableCells});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(11, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(558, 498);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnNotEditableCells
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnNotEditableCells.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnNotEditableCells.FillWeight = 121.8274F;
            this.ColumnNotEditableCells.HeaderText = "ColumnNotEditableCells";
            this.ColumnNotEditableCells.MinimumWidth = 165;
            this.ColumnNotEditableCells.Name = "ColumnNotEditableCells";
            this.ColumnNotEditableCells.ReadOnly = true;
            this.ColumnNotEditableCells.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnEditableCells
            // 
            this.ColumnEditableCells.FillWeight = 78.17259F;
            this.ColumnEditableCells.HeaderText = "ColumnEditableCells";
            this.ColumnEditableCells.MinimumWidth = 370;
            this.ColumnEditableCells.Name = "ColumnEditableCells";
            // 
            // ViewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxDetailsBook);
            this.DoubleBuffered = true;
            this.Name = "ViewDetails";
            this.Size = new System.Drawing.Size(580, 539);
            this.groupBoxDetailsBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDetailsBook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNotEditableCells;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEditableCells;
    }
}
