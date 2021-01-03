
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
            this.groupBoxDetailsBook = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBoxDetailsBook
            // 
            this.groupBoxDetailsBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetailsBook.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDetailsBook.Name = "groupBoxDetailsBook";
            this.groupBoxDetailsBook.Padding = new System.Windows.Forms.Padding(11, 14, 11, 11);
            this.groupBoxDetailsBook.Size = new System.Drawing.Size(580, 539);
            this.groupBoxDetailsBook.TabIndex = 1;
            this.groupBoxDetailsBook.TabStop = false;
            this.groupBoxDetailsBook.Text = "Details - Book [click to edit]";
            // 
            // ViewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxDetailsBook);
            this.DoubleBuffered = true;
            this.Name = "ViewDetails";
            this.Size = new System.Drawing.Size(580, 539);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDetailsBook;
    }
}
