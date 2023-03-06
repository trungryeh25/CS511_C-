
namespace Doulingo
{
    partial class Doulingo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doulingo));
            this.caiDat = new System.Windows.Forms.TextBox();
            this.playG = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Music_On = new System.Windows.Forms.Button();
            this.Music_Off = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // caiDat
            // 
            this.caiDat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.caiDat.BackColor = System.Drawing.Color.GreenYellow;
            this.caiDat.Enabled = false;
            this.caiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.caiDat.ForeColor = System.Drawing.Color.White;
            this.caiDat.HideSelection = false;
            this.caiDat.Location = new System.Drawing.Point(346, 390);
            this.caiDat.Name = "caiDat";
            this.caiDat.ReadOnly = true;
            this.caiDat.Size = new System.Drawing.Size(102, 26);
            this.caiDat.TabIndex = 1;
            this.caiDat.TabStop = false;
            this.caiDat.Text = "Ranking";
            this.caiDat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playG
            // 
            this.playG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playG.BackColor = System.Drawing.Color.GreenYellow;
            this.playG.Font = new System.Drawing.Font("ROG Fonts", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playG.ForeColor = System.Drawing.Color.White;
            this.playG.HideSelection = false;
            this.playG.Location = new System.Drawing.Point(345, 83);
            this.playG.Name = "playG";
            this.playG.Size = new System.Drawing.Size(99, 40);
            this.playG.TabIndex = 2;
            this.playG.TabStop = false;
            this.playG.Text = "Play";
            this.playG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playG.Click += new System.EventHandler(this.textBox1_TextChanged_1);
            this.playG.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(301, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 135);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(345, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 45);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Music_On
            // 
            this.Music_On.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Music_On.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Music_On.BackgroundImage")));
            this.Music_On.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Music_On.Location = new System.Drawing.Point(709, 404);
            this.Music_On.Name = "Music_On";
            this.Music_On.Size = new System.Drawing.Size(43, 44);
            this.Music_On.TabIndex = 7;
            this.Music_On.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Music_On.UseVisualStyleBackColor = true;
            this.Music_On.Click += new System.EventHandler(this.Music_On_Click);
            // 
            // Music_Off
            // 
            this.Music_Off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Music_Off.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Music_Off.BackgroundImage")));
            this.Music_Off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Music_Off.Location = new System.Drawing.Point(758, 404);
            this.Music_Off.Name = "Music_Off";
            this.Music_Off.Size = new System.Drawing.Size(43, 44);
            this.Music_Off.TabIndex = 8;
            this.Music_Off.UseVisualStyleBackColor = true;
            this.Music_Off.Click += new System.EventHandler(this.Music_Off_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox3.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(346, 307);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 77);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(1, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(800, 457);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.GreenYellow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(341, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Guide";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Doulingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.caiDat);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.playG);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Music_On);
            this.Controls.Add(this.Music_Off);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Doulingo";
            this.Text = "Doulingo";
            this.Load += new System.EventHandler(this.Doulingo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox caiDat;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox playG;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Music_On;
        private System.Windows.Forms.Button Music_Off;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button3;
    }
}

