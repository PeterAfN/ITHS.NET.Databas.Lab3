
namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    partial class ViewBookstores
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
            this.groupBoxBookstores = new System.Windows.Forms.GroupBox();
            this.treeViewBookstores = new System.Windows.Forms.TreeView();
            this.groupBoxBookstores.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBookstores
            // 
            this.groupBoxBookstores.Controls.Add(this.treeViewBookstores);
            this.groupBoxBookstores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBookstores.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBookstores.Name = "groupBoxBookstores";
            this.groupBoxBookstores.Padding = new System.Windows.Forms.Padding(11, 14, 11, 11);
            this.groupBoxBookstores.Size = new System.Drawing.Size(421, 545);
            this.groupBoxBookstores.TabIndex = 1;
            this.groupBoxBookstores.TabStop = false;
            this.groupBoxBookstores.Text = "Bookstore - Stock Balance [rightclick for options]";
            // 
            // treeViewBookstores
            // 
            this.treeViewBookstores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewBookstores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewBookstores.Location = new System.Drawing.Point(11, 30);
            this.treeViewBookstores.Name = "treeViewBookstores";
            this.treeViewBookstores.Size = new System.Drawing.Size(399, 504);
            this.treeViewBookstores.TabIndex = 0;
            // 
            // ViewBookstores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxBookstores);
            this.DoubleBuffered = true;
            this.Name = "ViewBookstores";
            this.Size = new System.Drawing.Size(421, 545);
            this.groupBoxBookstores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxBookstores;
        private System.Windows.Forms.TreeView treeViewBookstores;
    }
}
