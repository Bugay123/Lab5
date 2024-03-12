using System.Drawing;

namespace Lab5_PicView_2
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
            // Отримуємо список усіх файлів з розширенням .png у вказаній папці
            string folderPath = @"C:\Users\user\Documents\Visual Studio 2022\repos\OOP_WinForm\Lab5\Lab5_PicView_2\pic\"; // Шлях до папки із зображеннями
            imageFiles = Directory.GetFiles(folderPath, "*.png");

            // Додаємо файли у список ListBox
            foreach (string file in imageFiles)
            {
                listBoxPhotos.Items.Add(Path.GetFileName(file));
            }
        }

        private void listBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибрано елемент у ListBox
            if (listBoxPhotos.SelectedIndex != -1)
            {
                // Відображаємо вибране зображення у PictureBox
                string selectedFile = imageFiles[listBoxPhotos.SelectedIndex];
                pictureBoxPhoto.ImageLocation = selectedFile;
                currentIndex = listBoxPhotos.SelectedIndex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи є попереднє зображення для відображення
            if (currentIndex > 0)
            {
                currentIndex--;
                listBoxPhotos.SelectedIndex = currentIndex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи є наступне зображення для відображення
            if (currentIndex < imageFiles.Length - 1)
            {
                currentIndex++;
                listBoxPhotos.SelectedIndex = currentIndex;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog.SelectedPath;
                    imageFiles = Directory.GetFiles(folderPath, "*.png");

                    // Очищаємо ListBox перед додаванням нових елементів
                    listBoxPhotos.Items.Clear();

                    // Додаємо файли у список ListBox
                    foreach (string file in imageFiles)
                    {
                        listBoxPhotos.Items.Add(Path.GetFileName(file));
                    }

                    // Скидаємо вибір у ListBox та PictureBox
                    listBoxPhotos.SelectedIndex = -1;
                    pictureBoxPhoto.ImageLocation = null;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RotateImage();
        }


        private void RotateImage()
        {
            if (pictureBoxPhoto.Image != null)
            {
               // pictureBoxPhoto.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBoxPhoto.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                pictureBoxPhoto.Refresh();
            }
        }
    }
}