
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
            this.groupBoxBookstore = new System.Windows.Forms.GroupBox();
            this.dgvBookstore = new System.Windows.Forms.DataGridView();
            this.dgvTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelDetails = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxBook = new System.Windows.Forms.GroupBox();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.dgvDetailsBookColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetailsBookColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNotEditableCells = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditableCells = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxBookstore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookstore)).BeginInit();
            this.tableLayoutPanelDetails.SuspendLayout();
            this.groupBoxBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBookstore
            // 
            this.groupBoxBookstore.AutoSize = true;
            this.groupBoxBookstore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxBookstore.Controls.Add(this.dgvBookstore);
            this.groupBoxBookstore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBookstore.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBookstore.Name = "groupBoxBookstore";
            this.groupBoxBookstore.Padding = new System.Windows.Forms.Padding(11);
            this.groupBoxBookstore.Size = new System.Drawing.Size(835, 208);
            this.groupBoxBookstore.TabIndex = 4;
            this.groupBoxBookstore.TabStop = false;
            this.groupBoxBookstore.Text = "Details Bookstore [click cell to edit information]";
            // 
            // dgvBookstore
            // 
            this.dgvBookstore.AllowUserToAddRows = false;
            this.dgvBookstore.AllowUserToDeleteRows = false;
            this.dgvBookstore.AllowUserToResizeRows = false;
            this.dgvBookstore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookstore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBookstore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBookstore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookstore.ColumnHeadersVisible = false;
            this.dgvBookstore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTextBoxColumn1,
            this.dgvTextBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookstore.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookstore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookstore.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvBookstore.Location = new System.Drawing.Point(11, 27);
            this.dgvBookstore.Name = "dgvBookstore";
            this.dgvBookstore.RowHeadersVisible = false;
            this.dgvBookstore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBookstore.RowTemplate.Height = 25;
            this.dgvBookstore.Size = new System.Drawing.Size(813, 170);
            this.dgvBookstore.TabIndex = 1;
            // 
            // dgvTextBoxColumn1
            // 
            this.dgvTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTextBoxColumn1.Frozen = true;
            this.dgvTextBoxColumn1.HeaderText = "ColumnNotEditableCells";
            this.dgvTextBoxColumn1.MinimumWidth = 100;
            this.dgvTextBoxColumn1.Name = "dgvTextBoxColumn1";
            this.dgvTextBoxColumn1.ReadOnly = true;
            this.dgvTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTextBoxColumn2
            // 
            this.dgvTextBoxColumn2.FillWeight = 78.17259F;
            this.dgvTextBoxColumn2.HeaderText = "ColumnEditableCells";
            this.dgvTextBoxColumn2.MinimumWidth = 370;
            this.dgvTextBoxColumn2.Name = "dgvTextBoxColumn2";
            // 
            // tableLayoutPanelDetails
            // 
            this.tableLayoutPanelDetails.ColumnCount = 1;
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDetails.Controls.Add(this.groupBoxBookstore, 0, 0);
            this.tableLayoutPanelDetails.Controls.Add(this.groupBoxBook, 0, 1);
            this.tableLayoutPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDetails.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDetails.Name = "tableLayoutPanelDetails";
            this.tableLayoutPanelDetails.RowCount = 2;
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanelDetails.Size = new System.Drawing.Size(841, 671);
            this.tableLayoutPanelDetails.TabIndex = 1;
            // 
            // groupBoxBook
            // 
            this.groupBoxBook.AutoSize = true;
            this.groupBoxBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxBook.Controls.Add(this.dgvBook);
            this.groupBoxBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBook.Location = new System.Drawing.Point(3, 217);
            this.groupBoxBook.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBoxBook.Name = "groupBoxBook";
            this.groupBoxBook.Padding = new System.Windows.Forms.Padding(11, 14, 11, 11);
            this.groupBoxBook.Size = new System.Drawing.Size(835, 454);
            this.groupBoxBook.TabIndex = 5;
            this.groupBoxBook.TabStop = false;
            this.groupBoxBook.Text = "Details Book [click cell to edit information]";
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToResizeRows = false;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.ColumnHeadersVisible = false;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDetailsBookColumn1,
            this.dgvDetailsBookColumn2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvBook.Location = new System.Drawing.Point(11, 30);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBook.RowTemplate.Height = 25;
            this.dgvBook.Size = new System.Drawing.Size(813, 413);
            this.dgvBook.TabIndex = 0;
            // 
            // dgvDetailsBookColumn1
            // 
            this.dgvDetailsBookColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDetailsBookColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetailsBookColumn1.Frozen = true;
            this.dgvDetailsBookColumn1.HeaderText = "Column1";
            this.dgvDetailsBookColumn1.MinimumWidth = 150;
            this.dgvDetailsBookColumn1.Name = "dgvDetailsBookColumn1";
            this.dgvDetailsBookColumn1.ReadOnly = true;
            this.dgvDetailsBookColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetailsBookColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvDetailsBookColumn1.Width = 150;
            // 
            // dgvDetailsBookColumn2
            // 
            this.dgvDetailsBookColumn2.HeaderText = "Column2";
            this.dgvDetailsBookColumn2.Name = "dgvDetailsBookColumn2";
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
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Name = "ViewDetails";
            this.Size = new System.Drawing.Size(841, 671);
            this.groupBoxBookstore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookstore)).EndInit();
            this.tableLayoutPanelDetails.ResumeLayout(false);
            this.tableLayoutPanelDetails.PerformLayout();
            this.groupBoxBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBookstore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDetails;
        private System.Windows.Forms.GroupBox groupBoxBook;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.DataGridView dgvBookstore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNotEditableCells;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEditableCells;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetailsBookColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetailsBookColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextBoxColumn2;
    }
}
