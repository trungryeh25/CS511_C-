using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Social_App.DTO;
using Social_App.BUS;
using System.Drawing.Drawing2D;

namespace Social_App
{
    public partial class frmComment : Form
    {
        Post currentPost = null;
        User me = null;
        User poster = null;

        List<UserComment> listCommentInPost = null;
        public frmComment(Post post, User user, User user1)
        {
            InitializeComponent();
            currentPost = post;
            me = user;
            poster = user1;
            getComment();
        }
        public frmComment(Post post, User user)
        {
            InitializeComponent();
            currentPost = post;
            me = user;
            poster = user;
            getComment();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void getComment()
        {
            if (listCommentInPost != null)
            {
                if(listCommentInPost.Count > 0)
                {
                    listCommentInPost.Clear();
                }
            }
            listCommentInPost = CommentBUS.Instance.findAll(currentPost.post_id);
        }
        void loadData()
        {
            getComment();
            try
            {
                picPost.Image = Image.FromFile(currentPost.image_url);
            }
            catch (Exception)
            {
            }

            rtxtCaption.Text = currentPost.message;
            lbName.Text = poster.name;
            lbDate.Text = currentPost.creation_time.ToString();
            try
            {
                picFriend1.Image = Image.FromFile(poster.image);
            }
            catch (Exception)
            {
            }
            try
            {
                picMe1.Image = Image.FromFile(me.image);
            }
            catch (Exception)
            {
            }
            lbMe.Text = me.name;
            lbHeader.Text = "THIS POST OF " + poster.name;
            btnSend.Enabled = false;
            label1.Text = "All comment - " + listCommentInPost.Count + " comments";
        }

        void loadAComment(UserComment item)
        {
            Panel container = new Panel();
            container.Width = 276;
            container.Height = 50;
            container.BorderStyle = BorderStyle.FixedSingle;


            // lable date comment
            Label dateCmt = new Label();
            dateCmt.AutoSize = true;
            container.Controls.Add(dateCmt);
            dateCmt.Text = item.comment_time.ToString();
            dateCmt.Dock = DockStyle.Left;
            dateCmt.Font = new Font(lbDate.Font.FontFamily, 9, FontStyle.Regular);


            // label Name
            Label nameCmt = new Label();
            nameCmt.AutoSize = true;
            container.Controls.Add(nameCmt);
            nameCmt.Text = item.name;
            nameCmt.Dock = DockStyle.Left;
            nameCmt.Font = new Font(lbDate.Font.FontFamily, 9, FontStyle.Regular);

            // rictext box comment
            RichTextBox cmt = new RichTextBox();
            cmt.Height = 25;
            container.Controls.Add(cmt);
            cmt.Dock = DockStyle.Bottom;
            cmt.BorderStyle = BorderStyle.FixedSingle;
            cmt.ReadOnly = true;
            cmt.Text = item.content;

            // avart user comment
            PictureBox f = new PictureBox();
            f.Width = 50;
            f.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                using (GraphicsPath gp = new GraphicsPath())
                {
                    gp.AddEllipse(0, 0, f.Width - 3, f.Height - 3);
                    Region rg = new Region(gp);
                    f.Region = rg;
                }
                f.Image = Image.FromFile(item.image);
            }
            catch (Exception)
            {
            }
            container.Controls.Add(f);
            f.Dock = DockStyle.Left;




            flpnCmt.Controls.Add(container);
        }
        void loadAllComment()
        {
            flpnCmt.Controls.Clear();
            getComment();
            foreach (UserComment item in listCommentInPost)
            {
                loadAComment(item);
            }
        }
        private void frmComment_Load(object sender, EventArgs e)
        {

            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, picFriend1.Width - 3, picFriend1.Height - 3);
                Region rg = new Region(gp);
                picFriend1.Region = rg;
            }
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, picMe1.Width - 3, picMe1.Height - 3);
                Region rg = new Region(gp);
                picMe1.Region = rg;
            }

            loadData();
            loadAllComment();
            this.ActiveControl = rtxtCmt;
        }

        private void rtxtCmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rtxtCmt.Text.Trim().Equals(""))
            {

                btnSend.Enabled = false;
                btnSend.BackColor = Color.DodgerBlue;
            }
            else
            {
                btnSend.Enabled = true;
                btnSend.BackColor = Color.Blue;
            }
        }

        private void rtxtCmt_TextChanged(object sender, EventArgs e)
        {
            if (rtxtCmt.Text.Trim().Equals(""))
            {

                btnSend.Enabled = false;
                btnSend.BackColor = Color.DodgerBlue;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string postid = currentPost.post_id.ToString();
                string userid = me.user_id.ToString();
                string content = rtxtCmt.Text;
                string date = DateTime.Now.ToLocalTime().ToString();
                string sql = "insert into comments(post_id, user_id, content, comment_time) values (" +
                    postid + ", " + userid + ", N'" + content + "', '" + date + "');";
                CommentBUS.Instance.sendComment(sql);
                loadAllComment();
                rtxtCmt.ResetText();
                rtxtCmt.Focus();
            }
            catch (Exception)
            {
            }
        }
    }
}
