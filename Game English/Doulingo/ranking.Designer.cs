
namespace Doulingo
{
    partial class Ranking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ranking));
            this.bagr_pB = new System.Windows.Forms.PictureBox();
            this.back_pB = new System.Windows.Forms.PictureBox();
            this.Music_On = new System.Windows.Forms.Button();
            this.Music_Off = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bagr_pB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_pB)).BeginInit();
            this.SuspendLayout();
            // 
            // bagr_pB
            // 
            this.bagr_pB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bagr_pB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bagr_pB.BackgroundImage")));
            this.bagr_pB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bagr_pB.Location = new System.Drawing.Point(1, -3);
            this.bagr_pB.Name = "bagr_pB";
            this.bagr_pB.Size = new System.Drawing.Size(801, 450);
            this.bagr_pB.TabIndex = 0;
            this.bagr_pB.TabStop = false;
            // 
            // back_pB
            // 
            this.back_pB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_pB.BackgroundImage")));
            this.back_pB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_pB.Location = new System.Drawing.Point(5, 2);
            this.back_pB.Name = "back_pB";
            this.back_pB.Size = new System.Drawing.Size(43, 40);
            this.back_pB.TabIndex = 1;
            this.back_pB.TabStop = false;
            this.back_pB.Click += new System.EventHandler(this.back_pB_Click);
            // 
            // Music_On
            // 
            this.Music_On.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Music_On.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Music_On.BackgroundImage")));
            this.Music_On.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Music_On.Location = new System.Drawing.Point(708, 403);
            this.Music_On.Name = "Music_On";
            this.Music_On.Size = new System.Drawing.Size(43, 44);
            this.Music_On.TabIndex = 12;
            this.Music_On.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Music_On.UseVisualStyleBackColor = true;
            this.Music_On.Click += new System.EventHandler(this.Music_On_Click);
            // 
            // Music_Off
            // 
            this.Music_Off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Music_Off.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Music_Off.BackgroundImage")));
            this.Music_Off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Music_Off.Location = new System.Drawing.Point(757, 403);
            this.Music_Off.Name = "Music_Off";
            this.Music_Off.Size = new System.Drawing.Size(43, 44);
            this.Music_Off.TabIndex = 13;
            this.Music_Off.UseVisualStyleBackColor = true;
            this.Music_Off.Click += new System.EventHandler(this.Music_Off_Click);
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox6.BackColor = System.Drawing.Color.PaleGreen;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("ROG Fonts", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox6.Location = new System.Drawing.Point(291, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(228, 49);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "RANKING";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBox1.ForeColor = System.Drawing.Color.Gray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(293, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 244);
            this.listBox1.TabIndex = 15;
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Music_On);
            this.Controls.Add(this.Music_Off);
            this.Controls.Add(this.back_pB);
            this.Controls.Add(this.bagr_pB);
            this.Name = "Ranking";
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.Ranking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bagr_pB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_pB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bagr_pB;
        private System.Windows.Forms.PictureBox back_pB;
        private System.Windows.Forms.Button Music_On;
        private System.Windows.Forms.Button Music_Off;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ListBox listBox1;
    }
}