
namespace Social_App
{
    partial class frmMyPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyPost));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.picUser1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.picLogo1 = new System.Windows.Forms.PictureBox();
            this.flPanelPost = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.picUser1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.picLogo1);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(438, 8);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(64, 25);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "label1";
            // 
            // picUser1
            // 
            this.picUser1.Location = new System.Drawing.Point(292, 4);
            this.picUser1.Name = "picUser1";
            this.picUser1.Size = new System.Drawing.Size(140, 93);
            this.picUser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser1.TabIndex = 2;
            this.picUser1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1024, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picLogo1
            // 
            this.picLogo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo1.BackgroundImage")));
            this.picLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo1.Location = new System.Drawing.Point(3, 0);
            this.picLogo1.Name = "picLogo1";
            this.picLogo1.Size = new System.Drawing.Size(244, 97);
            this.picLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo1.TabIndex = 0;
            this.picLogo1.TabStop = false;
            // 
            // flPanelPost
            // 
            this.flPanelPost.AutoScroll = true;
            this.flPanelPost.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanelPost.Location = new System.Drawing.Point(12, 107);
            this.flPanelPost.Name = "flPanelPost";
            this.flPanelPost.Size = new System.Drawing.Size(1051, 665);
            this.flPanelPost.TabIndex = 1;
            this.flPanelPost.WrapContents = false;
            // 
            // frmMyPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 784);
            this.Controls.Add(this.flPanelPost);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMyPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMyPost";
            this.Load += new System.EventHandler(this.frmMyPost_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picLogo1;
        private System.Windows.Forms.FlowLayoutPanel flPanelPost;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox picUser1;
    }
}