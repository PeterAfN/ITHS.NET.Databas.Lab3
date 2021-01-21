using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public partial class ViewTreeView : UserControl, IViewTreeView
    {
        public ViewTreeView()
        {
            InitializeComponent();
            CreateEvents();
        }


        private void CreateEvents()
        {
            treeView.AfterSelect += TreeView_AfterSelect;
        }

        public bool PreventEvent { get; set; }

        public event TreeViewEventHandler TreeViewAfterSelect;

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!PreventEvent) TreeViewAfterSelect?.Invoke(TreeView, e);
        }


        public TreeView TreeView
        {
            get { return treeView; }
            set { treeView = value; }
        }


        public ContextMenuStrip ContextMenuStripTreeView
        {
            get { return contextMenuStripTreeView; }
            set { contextMenuStripTreeView = value; }
        }

    }
}
