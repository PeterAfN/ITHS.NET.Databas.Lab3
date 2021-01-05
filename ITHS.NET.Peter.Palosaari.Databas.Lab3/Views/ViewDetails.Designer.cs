
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDetailsBookstore = new System.Windows.Forms.GroupBox();
            this.dataGridViewDetailsBookstore = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelDetails = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxDetailsBook = new System.Windows.Forms.GroupBox();
            this.dataGridViewDetailsBook = new System.Windows.Forms.DataGridView();
            this.dataGridViewDetailsBookColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDetailsBookColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNotEditableCells = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditableCells = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDetailsBookstore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailsBookstore)).BeginInit();
            this.tableLayoutPanelDetails.SuspendLayout();
            this.groupBoxDetailsBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailsBook)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDetailsBookstore
            // 
            this.groupBoxDetailsBookstore.AutoSize = true;
            this.groupBoxDetailsBookstore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxDetailsBookstore.Controls.Add(this.dataGridViewDetailsBookstore);
            this.groupBoxDetailsBookstore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetailsBookstore.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDetailsBookstore.Name = "groupBoxDetailsBookstore";
            this.groupBoxDetailsBookstore.Padding = new System.Windows.Forms.Padding(11, 14, 11, 11);
            this.groupBoxDetailsBookstore.Size = new System.Drawing.Size(835, 208);
            this.groupBoxDetailsBookstore.TabIndex = 4;
            this.groupBoxDetailsBookstore.TabStop = false;
            this.groupBoxDetailsBookstore.Text = "Details Bookstore [click cell to edit information]";
            // 
            // dataGridViewDetailsBookstore
            // 
            this.dataGridViewDetailsBookstore.AllowUserToResizeRows = false;
            this.dataGridViewDetailsBookstore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetailsBookstore.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDetailsBookstore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDetailsBookstore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetailsBookstore.ColumnHeadersVisible = false;
            this.dataGridViewDetailsBookstore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDetailsBookstore.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDetailsBookstore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetailsBookstore.Location = new System.Drawing.Point(11, 30);
            this.dataGridViewDetailsBookstore.Name = "dataGridViewDetailsBookstore";
            this.dataGridViewDetailsBookstore.RowHeadersVisible = false;
            this.dataGridViewDetailsBookstore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDetailsBookstore.RowTemplate.Height = 25;
            this.dataGridViewDetailsBookstore.Size = new System.Drawing.Size(813, 167);
            this.dataGridViewDetailsBookstore.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "ColumnNotEditableCells";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 78.17259F;
            this.dataGridViewTextBoxColumn2.HeaderText = "ColumnEditableCells";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 370;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tableLayoutPanelDetails
            // 
            this.tableLayoutPanelDetails.ColumnCount = 1;
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDetails.Controls.Add(this.groupBoxDetailsBookstore, 0, 0);
            this.tableLayoutPanelDetails.Controls.Add(this.groupBoxDetailsBook, 0, 1);
            this.tableLayoutPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDetails.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDetails.Name = "tableLayoutPanelDetails";
            this.tableLayoutPanelDetails.RowCount = 2;
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanelDetails.Size = new System.Drawing.Size(841, 671);
            this.tableLayoutPanelDetails.TabIndex = 1;
            // 
            // groupBoxDetailsBook
            // 
            this.groupBoxDetailsBook.AutoSize = true;
            this.groupBoxDetailsBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxDetailsBook.Controls.Add(this.dataGridViewDetailsBook);
            this.groupBoxDetailsBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetailsBook.Location = new System.Drawing.Point(3, 217);
            this.groupBoxDetailsBook.Name = "groupBoxDetailsBook";
            this.groupBoxDetailsBook.Padding = new System.Windows.Forms.Padding(11, 14, 11, 11);
            this.groupBoxDetailsBook.Size = new System.Drawing.Size(835, 451);
            this.groupBoxDetailsBook.TabIndex = 5;
            this.groupBoxDetailsBook.TabStop = false;
            this.groupBoxDetailsBook.Text = "Details Book [click cell to edit information]";
            // 
            // dataGridViewDetailsBook
            // 
            this.dataGridViewDetailsBook.AllowUserToResizeRows = false;
            this.dataGridViewDetailsBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetailsBook.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDetailsBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDetailsBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetailsBook.ColumnHeadersVisible = false;
            this.dataGridViewDetailsBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewDetailsBookColumn1,
            this.dataGridViewDetailsBookColumn2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDetailsBook.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDetailsBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetailsBook.Location = new System.Drawing.Point(11, 30);
            this.dataGridViewDetailsBook.Name = "dataGridViewDetailsBook";
            this.dataGridViewDetailsBook.RowHeadersVisible = false;
            this.dataGridViewDetailsBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDetailsBook.RowTemplate.Height = 25;
            this.dataGridViewDetailsBook.Size = new System.Drawing.Size(813, 410);
            this.dataGridViewDetailsBook.TabIndex = 0;
            // 
            // dataGridViewDetailsBookColumn1
            // 
            this.dataGridViewDetailsBookColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewDetailsBookColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDetailsBookColumn1.Frozen = true;
            this.dataGridViewDetailsBookColumn1.HeaderText = "Column1";
            this.dataGridViewDetailsBookColumn1.MinimumWidth = 150;
            this.dataGridViewDetailsBookColumn1.Name = "dataGridViewDetailsBookColumn1";
            this.dataGridViewDetailsBookColumn1.ReadOnly = true;
            this.dataGridViewDetailsBookColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDetailsBookColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewDetailsBookColumn1.Width = 150;
            // 
            // dataGridViewDetailsBookColumn2
            // 
            this.dataGridViewDetailsBookColumn2.HeaderText = "Column2";
            this.dataGridViewDetailsBookColumn2.Name = "dataGridViewDetailsBookColumn2";
            // 
            // ColumnNotEditableCells
            // 
            this.ColumnNotEditableCells.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnNotEditableCells.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnNotEditableCells.FillWeight = 121.8274F;
            this.ColumnNotEditableCells.HeaderText = "ColumnNotEditableCells";
            this.ColumnNotEditableCells.MinimumWidth = 165;
            this.ColumnNotEditableCells.Name = "ColumnNotEditableCells";
            this.ColumnNotEditableCells.ReadOnly = true;
            this.ColumnNotEditableCells.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnNotEditableCells.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnEditableCells
            // 
            this.ColumnEditableCells.FillWeight = 78.17259F;
            this.ColumnEditableCells.HeaderText = "ColumnEditableCells";
            this.ColumnEditableCells.MinimumWidth = 370;
            this.ColumnEditableCells.Name = "ColumnEditableCells";
            this.ColumnEditableCells.Width = 645;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 150;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ViewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelDetails);
            this.DoubleBuffered = true;
            this.Name = "ViewDetails";
            this.Size = new System.Drawing.Size(841, 671);
            this.groupBoxDetailsBookstore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailsBookstore)).EndInit();
            this.tableLayoutPanelDetails.ResumeLayout(false);
            this.tableLayoutPanelDetails.PerformLayout();
            this.groupBoxDetailsBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailsBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDetailsBookstore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDetails;
        private System.Windows.Forms.GroupBox groupBoxDetailsBook;
        private System.Windows.Forms.DataGridView dataGridViewDetailsBook;
        private System.Windows.Forms.DataGridView dataGridViewDetailsBookstore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNotEditableCells;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEditableCells;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewDetailsBookColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewDetailsBookColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
