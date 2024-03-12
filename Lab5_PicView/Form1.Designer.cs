namespace Lab5_PicView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxPhotos = new ListBox();
            pictureBoxPhoto = new PictureBox();
            btnNext = new Button();
            btnPrevious = new Button();
            btnSelectFolder = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            SuspendLayout();
            // 
            // listBoxPhotos
            // 
            listBoxPhotos.FormattingEnabled = true;
            listBoxPhotos.ItemHeight = 15;
            listBoxPhotos.Location = new Point(230, 12);
            listBoxPhotos.Name = "listBoxPhotos";
            listBoxPhotos.Size = new Size(120, 169);
            listBoxPhotos.TabIndex = 0;
            listBoxPhotos.SelectedIndexChanged += listBoxPhotos_SelectedIndexChanged;
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Location = new Point(12, 12);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(200, 180);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto.TabIndex = 1;
            pictureBoxPhoto.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(137, 198);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(12, 198);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 4;
            btnPrevious.Text = "Prev";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Location = new Point(76, 227);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(75, 23);
            btnSelectFolder.TabIndex = 5;
            btnSelectFolder.Text = "Choose";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 261);
            Controls.Add(btnSelectFolder);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(pictureBoxPhoto);
            Controls.Add(listBoxPhotos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            ResumeLayout(false);
            Load += Form1_Load;
        }

        #endregion

        private ListBox listBoxPhotos;
        private PictureBox pictureBoxPhoto;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnSelectFolder;
    }
}
