
namespace Social_App
{
    partial class EditPost
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.picPost = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.rtxtContentPost = new System.Windows.Forms.RichTextBox();
            this.picUser1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPost);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 73);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit Post";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.LightGray;
            this.btnPost.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnPost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(674, 11);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(112, 48);
            this.btnPost.TabIndex = 0;
            this.btnPost.Text = "Save";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            this.btnPost.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPost_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(4, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 48);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChooseImage);
            this.panel2.Controls.Add(this.picPost);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.rtxtContentPost);
            this.panel2.Controls.Add(this.picUser1);
            this.panel2.Location = new System.Drawing.Point(6, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 702);
            this.panel2.TabIndex = 3;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(452, 487);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(119, 32);
            this.btnChooseImage.TabIndex = 5;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // picPost
            // 
            this.picPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPost.Location = new System.Drawing.Point(20, 475);
            this.picPost.Name = "picPost";
            this.picPost.Size = new System.Drawing.Size(385, 214);
            this.picPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPost.TabIndex = 4;
            this.picPost.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(173, 30);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(593, 36);
            this.lbName.TabIndex = 2;
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtxtContentPost
            // 
            this.rtxtContentPost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtContentPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtContentPost.Location = new System.Drawing.Point(20, 134);
            this.rtxtContentPost.Name = "rtxtContentPost";
            this.rtxtContentPost.Size = new System.Drawing.Size(746, 335);
            this.rtxtContentPost.TabIndex = 1;
            this.rtxtContentPost.Text = "";
            this.rtxtContentPost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtContentPost_KeyPress);
            // 
            // picUser1
            // 
            this.picUser1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUser1.Location = new System.Drawing.Point(20, 13);
            this.picUser1.Name = "picUser1";
            this.picUser1.Size = new System.Drawing.Size(131, 115);
            this.picUser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser1.TabIndex = 0;
            this.picUser1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EditPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 785);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPost";
            this.Load += new System.EventHandler(this.EditPost_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.PictureBox picPost;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.RichTextBox rtxtContentPost;
        private System.Windows.Forms.PictureBox picUser1;
        private System.Windows.Forms.Timer timer1;
    }
}