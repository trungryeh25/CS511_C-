
namespace Social_App
{
    partial class frmChat
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbActiveNow = new System.Windows.Forms.Label();
            this.lbNameFriend = new System.Windows.Forms.Label();
            this.picFriend1 = new System.Windows.Forms.PictureBox();
            this.pnExit = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.flpnChat = new System.Windows.Forms.FlowLayoutPanel();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.btnChat = new System.Windows.Forms.Button();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFriend1)).BeginInit();
            this.pnExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnHeader.Controls.Add(this.lbActiveNow);
            this.pnHeader.Controls.Add(this.lbNameFriend);
            this.pnHeader.Controls.Add(this.picFriend1);
            this.pnHeader.Controls.Add(this.pnExit);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(807, 69);
            this.pnHeader.TabIndex = 0;
            // 
            // lbActiveNow
            // 
            this.lbActiveNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActiveNow.Location = new System.Drawing.Point(113, 43);
            this.lbActiveNow.Name = "lbActiveNow";
            this.lbActiveNow.Size = new System.Drawing.Size(100, 23);
            this.lbActiveNow.TabIndex = 3;
            this.lbActiveNow.Text = "Active now";
            // 
            // lbNameFriend
            // 
            this.lbNameFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameFriend.Location = new System.Drawing.Point(111, 12);
            this.lbNameFriend.Name = "lbNameFriend";
            this.lbNameFriend.Size = new System.Drawing.Size(413, 23);
            this.lbNameFriend.TabIndex = 3;
            this.lbNameFriend.Text = "label1";
            // 
            // picFriend1
            // 
            this.picFriend1.Location = new System.Drawing.Point(4, 4);
            this.picFriend1.Name = "picFriend1";
            this.picFriend1.Size = new System.Drawing.Size(100, 62);
            this.picFriend1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFriend1.TabIndex = 2;
            this.picFriend1.TabStop = false;
            // 
            // pnExit
            // 
            this.pnExit.Controls.Add(this.btnExit);
            this.pnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnExit.Location = new System.Drawing.Point(768, 0);
            this.pnExit.Name = "pnExit";
            this.pnExit.Size = new System.Drawing.Size(39, 69);
            this.pnExit.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // flpnChat
            // 
            this.flpnChat.AutoScroll = true;
            this.flpnChat.BackColor = System.Drawing.Color.Gainsboro;
            this.flpnChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpnChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnChat.Location = new System.Drawing.Point(4, 72);
            this.flpnChat.Name = "flpnChat";
            this.flpnChat.Size = new System.Drawing.Size(800, 653);
            this.flpnChat.TabIndex = 1;
            this.flpnChat.WrapContents = false;
            // 
            // txtChat
            // 
            this.txtChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChat.Location = new System.Drawing.Point(4, 731);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(724, 30);
            this.txtChat.TabIndex = 2;
            this.txtChat.TextChanged += new System.EventHandler(this.txtChat_TextChanged);
            this.txtChat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChat_KeyPress);
            // 
            // btnChat
            // 
            this.btnChat.BackColor = System.Drawing.Color.Blue;
            this.btnChat.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChat.Location = new System.Drawing.Point(729, 730);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(75, 31);
            this.btnChat.TabIndex = 3;
            this.btnChat.Text = "Send";
            this.btnChat.UseVisualStyleBackColor = false;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // frmChat
            // 
            this.AcceptButton = this.btnChat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 765);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.flpnChat);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChat";
            this.Load += new System.EventHandler(this.frmChat_Load);
            this.pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFriend1)).EndInit();
            this.pnExit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbNameFriend;
        private System.Windows.Forms.PictureBox picFriend1;
        private System.Windows.Forms.FlowLayoutPanel flpnChat;
        private System.Windows.Forms.Label lbActiveNow;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Button btnChat;
    }
}