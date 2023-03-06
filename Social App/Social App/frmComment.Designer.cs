
namespace Social_App
{
    partial class frmComment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPost = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtxtCmt = new System.Windows.Forms.RichTextBox();
            this.picMe1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpnCmt = new System.Windows.Forms.FlowLayoutPanel();
            this.pnPost = new System.Windows.Forms.Panel();
            this.picPost = new System.Windows.Forms.PictureBox();
            this.rtxtCaption = new System.Windows.Forms.RichTextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.picFriend1 = new System.Windows.Forms.PictureBox();
            this.lbMe = new System.Windows.Forms.Label();
            this.lbHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMe1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFriend1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lbPost);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 52);
            this.panel1.TabIndex = 0;
            // 
            // lbPost
            // 
            this.lbPost.AutoSize = true;
            this.lbPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPost.Location = new System.Drawing.Point(354, 3);
            this.lbPost.Name = "lbPost";
            this.lbPost.Size = new System.Drawing.Size(201, 48);
            this.lbPost.TabIndex = 1;
            this.lbPost.Text = "Comment";
            this.lbPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(884, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.picFriend1);
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 715);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbMe);
            this.panel4.Controls.Add(this.btnSend);
            this.panel4.Controls.Add(this.rtxtCmt);
            this.panel4.Controls.Add(this.picMe1);
            this.panel4.Location = new System.Drawing.Point(4, 632);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(909, 80);
            this.panel4.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(822, 14);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 58);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtxtCmt
            // 
            this.rtxtCmt.Location = new System.Drawing.Point(102, 35);
            this.rtxtCmt.Name = "rtxtCmt";
            this.rtxtCmt.Size = new System.Drawing.Size(713, 37);
            this.rtxtCmt.TabIndex = 1;
            this.rtxtCmt.Text = "";
            this.rtxtCmt.TextChanged += new System.EventHandler(this.rtxtCmt_TextChanged);
            this.rtxtCmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtCmt_KeyPress);
            // 
            // picMe1
            // 
            this.picMe1.Location = new System.Drawing.Point(9, 4);
            this.picMe1.Name = "picMe1";
            this.picMe1.Size = new System.Drawing.Size(87, 73);
            this.picMe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMe1.TabIndex = 0;
            this.picMe1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.flpnCmt);
            this.panel3.Controls.Add(this.pnPost);
            this.panel3.Location = new System.Drawing.Point(3, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 491);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(528, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "  All comment";
            // 
            // flpnCmt
            // 
            this.flpnCmt.AutoScroll = true;
            this.flpnCmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpnCmt.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnCmt.Location = new System.Drawing.Point(528, 39);
            this.flpnCmt.Name = "flpnCmt";
            this.flpnCmt.Size = new System.Drawing.Size(378, 447);
            this.flpnCmt.TabIndex = 1;
            this.flpnCmt.WrapContents = false;
            // 
            // pnPost
            // 
            this.pnPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPost.Controls.Add(this.lbHeader);
            this.pnPost.Controls.Add(this.picPost);
            this.pnPost.Controls.Add(this.rtxtCaption);
            this.pnPost.Location = new System.Drawing.Point(3, 4);
            this.pnPost.Name = "pnPost";
            this.pnPost.Size = new System.Drawing.Size(519, 482);
            this.pnPost.TabIndex = 0;
            // 
            // picPost
            // 
            this.picPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPost.Location = new System.Drawing.Point(6, 175);
            this.picPost.Name = "picPost";
            this.picPost.Size = new System.Drawing.Size(510, 304);
            this.picPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPost.TabIndex = 1;
            this.picPost.TabStop = false;
            // 
            // rtxtCaption
            // 
            this.rtxtCaption.Location = new System.Drawing.Point(6, 34);
            this.rtxtCaption.Name = "rtxtCaption";
            this.rtxtCaption.ReadOnly = true;
            this.rtxtCaption.Size = new System.Drawing.Size(510, 134);
            this.rtxtCaption.TabIndex = 0;
            this.rtxtCaption.Text = "";
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(142, 68);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(771, 23);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "label2";
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(140, 18);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(770, 32);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label1";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picFriend1
            // 
            this.picFriend1.Location = new System.Drawing.Point(3, 3);
            this.picFriend1.Name = "picFriend1";
            this.picFriend1.Size = new System.Drawing.Size(131, 125);
            this.picFriend1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFriend1.TabIndex = 0;
            this.picFriend1.TabStop = false;
            // 
            // lbMe
            // 
            this.lbMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMe.Location = new System.Drawing.Point(102, 4);
            this.lbMe.Name = "lbMe";
            this.lbMe.Size = new System.Drawing.Size(713, 23);
            this.lbMe.TabIndex = 3;
            this.lbMe.Text = "label2";
            this.lbMe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbHeader
            // 
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(6, 3);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(508, 31);
            this.lbHeader.TabIndex = 2;
            this.lbHeader.Text = "label2";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 774);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCommetn";
            this.Load += new System.EventHandler(this.frmComment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMe1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnPost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFriend1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbPost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picFriend1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rtxtCmt;
        private System.Windows.Forms.PictureBox picMe1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.FlowLayoutPanel flpnCmt;
        private System.Windows.Forms.Panel pnPost;
        private System.Windows.Forms.PictureBox picPost;
        private System.Windows.Forms.RichTextBox rtxtCaption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMe;
        private System.Windows.Forms.Label lbHeader;
    }
}