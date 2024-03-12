namespace Lab5_DirView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PopulateTreeView(string directoryPath)
        {
            treeView1.Nodes.Clear();
            var directoryInfo = new DirectoryInfo(directoryPath);
            treeView1.Nodes.Add(CreateDirectoryNode(directoryInfo));
        }

        private TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }
            foreach (var file in directoryInfo.GetFiles())
            {
                directoryNode.Nodes.Add(file.Name);
            }
            return directoryNode;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    PopulateTreeView(folderBrowserDialog.SelectedPath);
                }
            }
        }
    }
}
