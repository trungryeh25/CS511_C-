
namespace Doulingo
{
    partial class Form4
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Music_On = new System.Windows.Forms.Button();
            this.Music_Off = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 458);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBox1.ForeColor = System.Drawing.Color.Maroon;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "",
            "  Animals\t  cat\t\tcon mèo",
            "  Animals\t  dog\t\tcon chó",
            "  Animals\t  monkey\t\tcon khỉ",
            "  Animals\t  chicken\t\tcon gà",
            "  Animals\t  lion\t\tcon sư tử",
            "  Animals\t  eagle\t\tcon đại bàng",
            "  Animals\t  horse\t\tcon ngựa",
            "  Animals\t  owls\t\tcú mèo",
            "  Animals\t  elephant\t\tcon voi",
            "  Animals\t  rabbit\t\tcon thỏ",
            "  Animals\t  giraffe\t\thươu cao cổ",
            "  Animals\t  duck\t\tcon vịt",
            "  Fruits\t  mango\t\tquả xoài",
            "  Fruits\t  lemon\t\tquả chanh",
            "  Fruits\t  peach\t\tquả đào",
            "  Fruits\t  grapes\t\tquả nho",
            "  Fruits\t  papaya\t\tquả đu đủ",
            "  Fruits\t  coconut\t\tquả dừa",
            "  Fruits\t  banana\t\tquả chuối",
            "  Fruits\t  watermelon\tquả dưa hấu",
            "  Fruits\t  apple\t\tquả táo",
            "  Fruits\t  orange\t\tquả cam",
            "  Fruits\t  strawberry\tquả dâu tây",
            "  Fruits\t  pineapple\tquả khóm",
            "  Objects\t  pen\t\tbút mực",
            "  Objects\t  pencil\t\tbút chì",
            "  Objects\t  bag\t\tcặp sách",
            "  Objects\t  ruler\t\tthước kẻ",
            "  Objects\t  notebook\ttập vở",
            "  Objects\t  book\t\tcuốn sách",
            "  Objects\t  eraser\t\tcục tẩy",
            "  Objects\t  board\t\tcái bảng",
            "  Objects\t  paper\t\tgiấy",
            "  Objects\t  watercolor\tmàu nước",
            "  Objects\t  glue stick\tkeo dán hồ",
            "  Objects\t  globe\t\tquả địa cầu"});
            this.listBox1.Location = new System.Drawing.Point(99, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(594, 360);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 41);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.BackColor = System.Drawing.Color.GreenYellow;
            this.listBox2.Enabled = false;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBox2.ForeColor = System.Drawing.Color.DimGray;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Items.AddRange(new object[] {
            "Topics\tEN\t            VN"});
            this.listBox2.Location = new System.Drawing.Point(99, 91);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(596, 28);
            this.listBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("ROG Fonts", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(99, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(596, 100);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Vocabulary";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Music_On
            // 
            this.Music_On.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Music_On.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Music_On.BackgroundImage")));
            this.Music_On.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Music_On.Location = new System.Drawing.Point(699, 407);
            this.Music_On.Name = "Music_On";
            this.Music_On.Size = new System.Drawing.Size(43, 44);
            this.Music_On.TabIndex = 9;
            this.Music_On.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Music_On.UseVisualStyleBackColor = true;
            this.Music_On.Click += new System.EventHandler(this.Music_On_Click);
            // 
            // Music_Off
            // 
            this.Music_Off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Music_Off.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Music_Off.BackgroundImage")));
            this.Music_Off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Music_Off.Location = new System.Drawing.Point(748, 407);
            this.Music_Off.Name = "Music_Off";
            this.Music_Off.Size = new System.Drawing.Size(43, 44);
            this.Music_Off.TabIndex = 10;
            this.Music_Off.UseVisualStyleBackColor = true;
            this.Music_Off.Click += new System.EventHandler(this.Music_Off_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.Music_On);
            this.Controls.Add(this.Music_Off);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Music_On;
        private System.Windows.Forms.Button Music_Off;
    }
}