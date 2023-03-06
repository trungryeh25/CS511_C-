using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Social_App.BUS;
using Social_App.DTO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Social_App
{
    public partial class frmHome : Form
    {
        User currentUser = null;
        List<Post> listNewFeed = null;
        List<User> listFriend = null;
        public frmHome(User user)
        {
            InitializeComponent();
            currentUser = user;
            listNewFeed = PostBUS.Instance.findAllPostNotId(currentUser.user_id);
            listFriend = UserBUS.Instance.findAllNotById(currentUser.user_id);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadComponent()
        {
            try
            {
                picUser1.Image = Image.FromFile(currentUser.image);
            }
            catch (Exception)
            {
            }

            try
            {
                btnHome.Image = (Image)(new Bitmap(Image.FromFile("../../imgaes/home.jpg"), new Size(32, 32)));
            }
            catch (Exception)
            {

            }
            try
            {
                btnInfo.Image = (Image)(new Bitmap(Image.FromFile("../../imgaes/userr.jpg"), new Size(32, 32)));
            }
            catch (Exception)
            {

            }

            try
            {
                btnSearch.Image = (Image)(new Bitmap(Image.FromFile("../../imgaes/search.png"), new Size(32, 32)));
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
            try
            {
                btnPost.Image = (Image)(new Bitmap(Image.FromFile("../../imgaes/post.png"), new Size(32, 32)));
            }
            catch (Exception)
            {
            }
        }
        private void frmHome_Load(object sender, EventArgs e)
        {
            //    flpanelPost.AutoScroll = true;
            //    flpanelPost.WrapContents = false;
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, picUser1.Width - 3, picUser1.Height - 3);
                Region rg = new Region(gp);
                picUser1.Region = rg;
            }
            loadComponent();
            loadPost();
            loadFriend();
        }
        void loadAFriend(User item)
        {
            Button btnFriend = new Button();
            flPanelFriend.Controls.Add(btnFriend);
            btnFriend.Margin = new Padding(15, 5, 15, 5);
            btnFriend.Width = 200;
            btnFriend.Height = 30;
            btnFriend.FlatStyle = FlatStyle.Flat;
            btnFriend.FlatAppearance.BorderColor = Color.White;
            btnFriend.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnFriend.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnFriend.Text = item.name;
            btnFriend.Font = new Font(lbPost.Font.FontFamily, 12, FontStyle.Regular);
            btnFriend.TextAlign = ContentAlignment.MiddleLeft;
            try
            {
                btnFriend.Image = (Image)(new Bitmap(Image.FromFile(item.image), new Size(25, 25)));
            }
            catch (Exception)
            {
            }
            
            btnFriend.ImageAlign = ContentAlignment.MiddleLeft;
            btnFriend.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFriend.Tag = item;
            btnFriend.Click += BtnFriend_Click;
        }

        private void BtnFriend_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            User friend = btn.Tag as User;
            if (friend != null)
            {
                frmChat frmChat = new frmChat(currentUser, friend);
                this.Hide();
                frmChat.ShowDialog();
                this.Show();
                btnHome_Click(sender, e);
            }

        }

        void loadFriend()
        {
            foreach (User item in listFriend)
            {
                loadAFriend(item);
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            lbPost.BackColor = Color.SeaShell;
            lbPost.BorderStyle = BorderStyle.FixedSingle;
            lbPost.Font = new Font(lbPost.Font, FontStyle.Underline);
        }
        void loadAPost(Post item)
        {
            // User
            User u1 = UserBUS.Instance.getItem(item.user_id);

            Panel container = new Panel();
            container.Height = 400;
            container.Width = 650;
            container.Margin = new Padding(32, 12, 32, 12);
            container.BackColor = Color.LightGray;
            container.Padding = new Padding(12, 8, 12, 8);
            container.Tag = item;
            container.Click += Container_Click;

            // label comment in post
            Label cmt = new Label();
            cmt.Dock = DockStyle.Bottom;
            cmt.Height = 50;
            cmt.Font = new Font(lbPost.Font.FontFamily, 9, FontStyle.Regular);
            cmt.ForeColor = Color.Black;
            cmt.AutoSize = false;
            cmt.Padding = new Padding(10, 0, 10, 0);
            cmt.TextAlign = ContentAlignment.MiddleRight;
            int countCMT = CommentBUS.Instance.findAllCommentInPost(item.post_id).Count;
            cmt.Text = countCMT.ToString() + " comments";
            container.Controls.Add(cmt);
            cmt.Tag = item;
            cmt.Click += Container_Click;

            // picture box post
            PictureBox picPost = new PictureBox();
            picPost.Height = 200;
            picPost.Tag = item;
            picPost.Click += Container_Click;
            picPost.SizeMode = PictureBoxSizeMode.Zoom;
            picPost.Padding = new Padding(5);
            container.Controls.Add(picPost);
            picPost.Dock = DockStyle.Top;
            try
            {
                //picPost.Image = (Image)(new Bitmap(Image.FromFile(item.image_url), new Size(150, 150)));
                picPost.Image = Image.FromFile(item.image_url);
            }
            catch (Exception)
            {
            }




            // label Caption post;
            Label caption = new Label();
            container.Controls.Add(caption);
            caption.Dock = DockStyle.Top;
            caption.AutoSize = false;
            caption.Font = new Font(lbPost.Font.FontFamily, 12, FontStyle.Regular);
            caption.Text = item.message;
            caption.ForeColor = Color.Black;
            caption.Height = 50;
            caption.Padding = new Padding(10, 4, 10, 4);
            caption.Tag = item;
            caption.Click += Container_Click;

            // header post
            Panel headerPost = new Panel();
            container.Controls.Add(headerPost);
            headerPost.Dock = DockStyle.Top;
            headerPost.Height = 75;
            headerPost.Tag = item;
            headerPost.Click += Container_Click;



            // Label name and date time of post
            Label lbDateTimePost = new Label();
            headerPost.Controls.Add(lbDateTimePost);
            lbDateTimePost.Font = new Font(lbPost.Font.FontFamily, 11, FontStyle.Regular);
            lbDateTimePost.Height = 30;
            lbDateTimePost.Dock = DockStyle.Top;
            lbDateTimePost.ForeColor = Color.Gray;
            lbDateTimePost.Text = item.creation_time.ToString();
            lbDateTimePost.Padding = new Padding(20, 0, 20, 0);

            Label lbNameUser = new Label();
            headerPost.Controls.Add(lbNameUser);
            lbNameUser.Font = new Font(lbPost.Font.FontFamily, 13, FontStyle.Regular);
            lbNameUser.Dock = DockStyle.Top;
            lbNameUser.Height = 40;
            lbNameUser.ForeColor = Color.Black;
            lbNameUser.Text = u1.name;
            lbNameUser.Padding = new Padding(20, 8, 20, 0);

            // picture box avartar user
            PictureBox picAvartar = new PictureBox();
            picAvartar.Width = 70;
            picAvartar.Height = 70;
            headerPost.Controls.Add(picAvartar);
            picAvartar.Dock = DockStyle.Left;
            picAvartar.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                using (GraphicsPath gp = new GraphicsPath())
                {
                    gp.AddEllipse(0, 0, picAvartar.Width - 3, picAvartar.Height - 3);
                    Region rg = new Region(gp);
                    picAvartar.Region = rg;
                }
                picAvartar.Image = Image.FromFile(u1.image);
            }
            catch (Exception)
            {
            }
            flpanelPost.Controls.Add(container);
        }

        private void Container_Click(object sender, EventArgs e)
        {
            string[] component = sender.GetType().ToString().Split('.');
            string tmp = component[component.Length - 1];
            Label lb = null;
            Panel pn = null;
            PictureBox pic = null;
            Post cpost = null;
            if (tmp == "Label")
            {
                lb = sender as Label;
                cpost = lb.Tag as Post;
            }
            else if(tmp == "Panel")
            {
                pn = sender as Panel;
                cpost = pn.Tag as Post;
            }
            else if(tmp == "PictureBox")
            {
                pic = sender as PictureBox;
                cpost = pic.Tag as Post;
            }
            if(cpost != null)
            {
                User poster = UserBUS.Instance.getItem(cpost.user_id);
                frmComment frmComment = new frmComment(cpost, currentUser, poster);
                this.Hide();
                frmComment.ShowDialog();
                this.Show();

                btnHome_Click(sender, e);
            }
            
        }

        private void BtnDeletePost_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.ForeColor = Color.Black;
        }

        private void BtnDeletePost_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.ForeColor = Color.DarkGray;
        }

        void loadPost()
        {
            foreach (Post item in listNewFeed)
            {
                loadAPost(item);
            }
        }
        private void lbPost_MouseHover(object sender, EventArgs e)
        {

        }

        private void lbPost_MouseLeave(object sender, EventArgs e)
        {
            lbPost.BackColor = panelPost.BackColor;
            lbPost.BorderStyle = BorderStyle.None;
            lbPost.Font = new Font(lbPost.Font, FontStyle.Regular);
        }

        private void lbPost_Click(object sender, EventArgs e)
        {
            frmPost frmPost = new frmPost(currentUser);
            this.Hide();
            frmPost.ShowDialog();
            this.Show();
            reLoad();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmInfo frmInfo = new frmInfo(currentUser);
            this.Hide();
            frmInfo.ShowDialog();
            this.Show();
            reLoad();
        }
        public void reLoad()
        {
            currentUser = UserBUS.Instance.getItem(currentUser.user_id);
            try
            {
                picUser1.Image = Image.FromFile(currentUser.image);
            }
            catch (Exception)
            {
                picUser1.Image = picUser1.ErrorImage;
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            frmMyPost frmMyPost = new frmMyPost(currentUser);
            this.Hide();
            frmMyPost.ShowDialog();
            this.Show();
            reLoad();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            flpanelPost.Controls.Clear();
            flPanelFriend.Controls.Clear();
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, picUser1.Width - 3, picUser1.Height - 3);
                Region rg = new Region(gp);
                picUser1.Region = rg;
            }
            loadComponent();
            loadPost();
            loadFriend();
        }
        public string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = convertToUnSign3(txtSearch.Text.Trim().ToLower());
            flPanelFriend.Controls.Clear();
            foreach (User item in listFriend)
            {
                string nameItem = convertToUnSign3(item.name.ToLower());
                if (nameItem.Contains(name))
                {
                    loadAFriend(item);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(56, 182, 255);
        }
    }
}
