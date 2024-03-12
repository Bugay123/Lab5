namespace Lab5_PicView_2
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
            pictureBoxPhoto = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBoxPhotos = new ListBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Location = new Point(20, 20);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(160, 160);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto.TabIndex = 0;
            pictureBoxPhoto.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(20, 190);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Prev";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(100, 190);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(60, 220);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Select";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBoxPhotos
            // 
            listBoxPhotos.FormattingEnabled = true;
            listBoxPhotos.ItemHeight = 15;
            listBoxPhotos.Location = new Point(186, 20);
            listBoxPhotos.Name = "listBoxPhotos";
            listBoxPhotos.Size = new Size(120, 94);
            listBoxPhotos.TabIndex = 4;
            listBoxPhotos.SelectedIndexChanged += listBoxPhotos_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Location = new Point(227, 120);
            button4.Name = "button4";
            button4.Size = new Size(40, 40);
            button4.TabIndex = 5;
            button4.Text = "90";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 270);
            Controls.Add(button4);
            Controls.Add(listBoxPhotos);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBoxPhoto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxPhoto;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBoxPhotos;
        private Button button4;
    }
}
