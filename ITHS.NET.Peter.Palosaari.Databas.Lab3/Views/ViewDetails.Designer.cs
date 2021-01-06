
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
            this.dgvDetailsBookstore = new System.Windows.Forms.DataGridView();
            this.dgvTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelDetails = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxDetailsBook = new System.Windows.Forms.GroupBox();
            this.dgvDetailsBook = new System.Windows.Forms.DataGridView();
            this.dgvDetailsBookColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetailsBookColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNotEditableCells = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditableCells = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDetailsBookstore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsBookstore)).BeginInit();
            this.tableLayoutPanelDetails.SuspendLayout();
            this.groupBoxDetailsBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsBook)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDetailsBookstore
            // 
            this.groupBoxDetailsBookstore.AutoSize = true;
            this.groupBoxDetailsBookstore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxDetailsBookstore.Controls.Add(this.dgvDetailsBookstore);
            this.groupBoxDetailsBookstore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetailsBookstore.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDetailsBookstore.Name = "groupBoxDetailsBookstore";
            this.groupBoxDetailsBookstore.Padding = new System.Windows.Forms.Padding(11, 14, 11, 11);
            this.groupBoxDetailsBookstore.Size = new System.Drawing.Size(835, 208);
            this.groupBoxDetailsBookstore.TabIndex = 4;
            this.groupBoxDetailsBookstore.TabStop = false;
            this.groupBoxDetailsBookstore.Text = "Details Bookstore [click cell to edit information]";
            // 
            // dgvDetailsBookstore
            // 
            this.dgvDetailsBookstore.AllowUserToResizeRows = false;
            this.dgvDetailsBookstore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailsBookstore.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetailsBookstore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetailsBookstore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailsBookstore.ColumnHeadersVisible = false;
            this.dgvDetailsBookstore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTextBoxColumn1,
            this.dgvTextBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetailsBookstore.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetailsBookstore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetailsBookstore.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDetailsBookstore.Location = new System.Drawing.Point(11, 30);
            this.dgvDetailsBookstore.Name = "dgvDetailsBookstore";
            this.dgvDetailsBookstore.RowHeadersVisible = false;
            this.dgvDetailsBookstore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetailsBookstore.RowTemplate.Height = 25;
            this.dgvDetailsBookstore.Size = new System.Drawing.Size(813, 167);
            this.dgvDetailsBookstore.TabIndex = 1;
            //this.dgvDetailsBookstore.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDetailsBookstore_CellValidating);
            //this.dgvDetailsBookstore.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDetailsBookstore_EditingControlShowing);
            //this.dgvDetailsBookstore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDetailsBookstore_KeyPress);
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
            this.groupBoxDetailsBook.Controls.Add(this.dgvDetailsBook);
            this.groupBoxDetailsBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetailsBook.Location = new System.Drawing.Point(3, 217);
            this.groupBoxDetailsBook.Name = "groupBoxDetailsBook";
            this.groupBoxDetailsBook.Padding = new System.Windows.Forms.Padding(11, 14, 11, 11);
            this.groupBoxDetailsBook.Size = new System.Drawing.Size(835, 451);
            this.groupBoxDetailsBook.TabIndex = 5;
            this.groupBoxDetailsBook.TabStop = false;
            this.groupBoxDetailsBook.Text = "Details Book [click cell to edit information]";
            // 
            // dgvDetailsBook
            // 
            this.dgvDetailsBook.AllowUserToResizeRows = false;
            this.dgvDetailsBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailsBook.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetailsBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetailsBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailsBook.ColumnHeadersVisible = false;
            this.dgvDetailsBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDetailsBookColumn1,
            this.dgvDetailsBookColumn2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetailsBook.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetailsBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetailsBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDetailsBook.Location = new System.Drawing.Point(11, 30);
            this.dgvDetailsBook.Name = "dgvDetailsBook";
            this.dgvDetailsBook.RowHeadersVisible = false;
            this.dgvDetailsBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetailsBook.RowTemplate.Height = 25;
            this.dgvDetailsBook.Size = new System.Drawing.Size(813, 410);
            this.dgvDetailsBook.TabIndex = 0;
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
            this.Name = "ViewDetails";
            this.Size = new System.Drawing.Size(841, 671);
            this.groupBoxDetailsBookstore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsBookstore)).EndInit();
            this.tableLayoutPanelDetails.ResumeLayout(false);
            this.tableLayoutPanelDetails.PerformLayout();
            this.groupBoxDetailsBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDetailsBookstore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDetails;
        private System.Windows.Forms.GroupBox groupBoxDetailsBook;
        private System.Windows.Forms.DataGridView dgvDetailsBook;
        private System.Windows.Forms.DataGridView dgvDetailsBookstore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNotEditableCells;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEditableCells;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetailsBookColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetailsBookColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextBoxColumn2;
    }
}
