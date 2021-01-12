
namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    partial class ViewTreeView
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxBookstores = new System.Windows.Forms.GroupBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.contextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddBookstore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteBookstore = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxBookstores.SuspendLayout();
            this.contextMenuStripTreeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBookstores
            // 
            this.groupBoxBookstores.Controls.Add(this.treeView);
            this.groupBoxBookstores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBookstores.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBookstores.Name = "groupBoxBookstores";
            this.groupBoxBookstores.Padding = new System.Windows.Forms.Padding(11, 14, 11, 11);
            this.groupBoxBookstores.Size = new System.Drawing.Size(421, 545);
            this.groupBoxBookstores.TabIndex = 1;
            this.groupBoxBookstores.TabStop = false;
            this.groupBoxBookstores.Text = "Stock balance for bookstores [rightclick for options]";
            // 
            // treeView
            // 
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.HideSelection = false;
            this.treeView.Location = new System.Drawing.Point(11, 30);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(399, 504);
            this.treeView.TabIndex = 0;
            // 
            // contextMenuStripTreeView
            // 
            this.contextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddBook,
            this.toolStripMenuItemAddBookstore,
            this.toolStripMenuItemDeleteBook,
            this.toolStripMenuItemDeleteBookstore});
            this.contextMenuStripTreeView.Name = "contextMenuStripTreeView";
            this.contextMenuStripTreeView.Size = new System.Drawing.Size(216, 92);
            // 
            // toolStripMenuItemAddBook
            // 
            this.toolStripMenuItemAddBook.Name = "toolStripMenuItemAddBook";
            this.toolStripMenuItemAddBook.Size = new System.Drawing.Size(215, 22);
            this.toolStripMenuItemAddBook.Text = "Add new book to all stores";
            // 
            // toolStripMenuItemAddBookstore
            // 
            this.toolStripMenuItemAddBookstore.Name = "toolStripMenuItemAddBookstore";
            this.toolStripMenuItemAddBookstore.Size = new System.Drawing.Size(215, 22);
            this.toolStripMenuItemAddBookstore.Text = "Add new bookstore";
            // 
            // toolStripMenuItemDeleteBook
            // 
            this.toolStripMenuItemDeleteBook.Name = "toolStripMenuItemDeleteBook";
            this.toolStripMenuItemDeleteBook.Size = new System.Drawing.Size(215, 22);
            this.toolStripMenuItemDeleteBook.Text = "Delete Book from all stores";
            // 
            // toolStripMenuItemDeleteBookstore
            // 
            this.toolStripMenuItemDeleteBookstore.Name = "toolStripMenuItemDeleteBookstore";
            this.toolStripMenuItemDeleteBookstore.Size = new System.Drawing.Size(215, 22);
            this.toolStripMenuItemDeleteBookstore.Text = "Delete Bookstore";
            // 
            // ViewTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxBookstores);
            this.DoubleBuffered = true;
            this.Name = "ViewTreeView";
            this.Size = new System.Drawing.Size(421, 545);
            this.groupBoxBookstores.ResumeLayout(false);
            this.contextMenuStripTreeView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxBookstores;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddBookstore;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddBook;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteBookstore;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteBook;
    }
}
