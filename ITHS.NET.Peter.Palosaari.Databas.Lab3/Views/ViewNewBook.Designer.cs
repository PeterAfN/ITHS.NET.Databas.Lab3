
namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    partial class ViewNewBook
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelLog = new System.Windows.Forms.Panel();
            this.labelLog = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.dgvNewBook = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panelTop.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(639, 33);
            this.panelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please add information. The book will be available in all bookstores. Author info" +
    "rmation is optional.";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Controls.Add(this.buttonClose);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 361);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(639, 46);
            this.panelButtons.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(548, 11);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(467, 11);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // panelLog
            // 
            this.panelLog.Controls.Add(this.labelLog);
            this.panelLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLog.Location = new System.Drawing.Point(0, 351);
            this.panelLog.MaximumSize = new System.Drawing.Size(0, 10);
            this.panelLog.MinimumSize = new System.Drawing.Size(0, 10);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(639, 10);
            this.panelLog.TabIndex = 11;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelLog.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLog.Location = new System.Drawing.Point(212, 0);
            this.labelLog.Name = "labelLog";
            this.labelLog.Padding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.labelLog.Size = new System.Drawing.Size(427, 12);
            this.labelLog.TabIndex = 0;
            this.labelLog.Text = "The book has been added to the SQL database successfully. This window can be clos" +
    "ed now.";
            // 
            // panelData
            // 
            this.panelData.AutoSize = true;
            this.panelData.Controls.Add(this.dgvNewBook);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 33);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(639, 318);
            this.panelData.TabIndex = 13;
            // 
            // dgvNewBook
            // 
            this.dgvNewBook.AllowUserToAddRows = false;
            this.dgvNewBook.AllowUserToDeleteRows = false;
            this.dgvNewBook.AllowUserToResizeColumns = false;
            this.dgvNewBook.AllowUserToResizeRows = false;
            this.dgvNewBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNewBook.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNewBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewBook.ColumnHeadersVisible = false;
            this.dgvNewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNewBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNewBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNewBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvNewBook.Location = new System.Drawing.Point(0, 0);
            this.dgvNewBook.Margin = new System.Windows.Forms.Padding(3, 3, 3, 70);
            this.dgvNewBook.Name = "dgvNewBook";
            this.dgvNewBook.RowHeadersVisible = false;
            this.dgvNewBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNewBook.RowTemplate.Height = 25;
            this.dgvNewBook.Size = new System.Drawing.Size(639, 318);
            this.dgvNewBook.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 150;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 12.01083F;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.HeaderText = "Column3";
            this.Column3.LinkColor = System.Drawing.Color.Black;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 52;
            // 
            // ViewNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 418);
            this.ControlBox = false;
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(254, 206);
            this.Name = "ViewNewBook";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new book to all bookstores";
            this.TopMost = true;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dgvNewBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn Column3;
    }
}