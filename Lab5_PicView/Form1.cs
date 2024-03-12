namespace Lab5_PicView
{
    public partial class Form1 : Form
    {
        private string[] imageFiles;
        private int currentIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // �������� ������ ��� ����� � ����������� .png � ������� �����
            string folderPath = @"C:\Users\user\Documents\Visual Studio 2022\repos\OOP_WinForm\Lab5\Lab5_PicView\pic\"; // ���� �� ����� �� ������������
            imageFiles = Directory.GetFiles(folderPath, "*.png");

            // ������ ����� � ������ ListBox
            foreach (string file in imageFiles)
            {
                listBoxPhotos.Items.Add(Path.GetFileName(file));
            }
        }

        private void listBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ����������, �� ������� ������� � ListBox
            if (listBoxPhotos.SelectedIndex != -1)
            {
                // ³��������� ������� ���������� � PictureBox
                string selectedFile = imageFiles[listBoxPhotos.SelectedIndex];
                pictureBoxPhoto.ImageLocation = selectedFile;
                currentIndex = listBoxPhotos.SelectedIndex;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // ����������, �� � �������� ���������� ��� �����������
            if (currentIndex > 0)
            {
                currentIndex--;
                listBoxPhotos.SelectedIndex = currentIndex;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // ����������, �� � �������� ���������� ��� �����������
            if (currentIndex < imageFiles.Length - 1)
            {
                currentIndex++;
                listBoxPhotos.SelectedIndex = currentIndex;
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog.SelectedPath;
                    imageFiles = Directory.GetFiles(folderPath, "*.png");

                    // ������� ListBox ����� ���������� ����� ��������
                    listBoxPhotos.Items.Clear();

                    // ������ ����� � ������ ListBox
                    foreach (string file in imageFiles)
                    {
                        listBoxPhotos.Items.Add(Path.GetFileName(file));
                    }

                    // ������� ���� � ListBox �� PictureBox
                    listBoxPhotos.SelectedIndex = -1;
                    pictureBoxPhoto.ImageLocation = null;
                }
            }
        }
    }
}
