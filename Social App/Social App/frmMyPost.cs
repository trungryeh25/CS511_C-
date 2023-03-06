using System;
using System.Drawing;
using System.Windows.Forms;
using Social_App.DTO;
using Social_App.BUS;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace Social_App
{
    public partial class frmMyPost : Form
    {
        User currentUser = null;
        List<Post> myListPost = null;
        public frmMyPost(User user)
        {
            InitializeComponent();
            currentUser = user;
            myListPost = new List<Post>();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadListPost()
        {
            if(myListPost != null)
            {
                if(myListPost.Count > 0)
                {
                    myListPost.Clear();
                }
            }

            myListPost = PostBUS.Instance.findAllById(currentUser.user_id);
        }
       
        void loadAComponent(Post item)
        {
            // container
            Panel container = new Panel();
            container.Width = 700;
            container.Height = 400;
            container.BackColor = Color.LightGray;
            container.Margin = new Padding(35, 20, 35, 20);
            container.Tag = item;
            container.Click += Container_Click;



            //Label comment
            Label totalCmt = new Label();
            container.Controls.Add(totalCmt);
            totalCmt.Dock = DockStyle.Top;
            totalCmt.Font = new Font(lbName.Font.FontFamily, 12, FontStyle.Regular);
            totalCmt.AutoSize = false;
            totalCmt.ForeColor = Color.Black;
            int countCMT = CommentBUS.Instance.findAllCommentInPost(item.post_id).Count;
            totalCmt.Text = countCMT.ToString() + " comments";
            totalCmt.Tag = item;
            totalCmt.TextAlign = ContentAlignment.MiddleRight;
            totalCmt.Click += Container_Click;

            Panel containPicture = new Panel();
            containPicture.Height = 200;
            container.Controls.Add(containPicture);
            containPicture.Dock = DockStyle.Top;
            containPicture.Tag = item;
            containPicture.Click += Container_Click;

            // picture box post
            PictureBox picPost = new PictureBox();
            picPost.Width = 400;
            picPost.Tag = item;
            picPost.SizeMode = PictureBoxSizeMode.Zoom;
            picPost.Padding = new Padding(5);
            containPicture.Controls.Add(picPost);
            picPost.Dock = DockStyle.Fill;
            try
            {
                //picPost.Image = (Image)(new Bitmap(Image.FromFile(item.image_url), new Size(150, 150)));
                picPost.Image = Image.FromFile(item.image_url);
            }
            catch (Exception)
            {

                picPost.Image = picLogo1.ErrorImage;
            }
            picPost.Click += Container_Click;



            RichTextBox caption = new RichTextBox();
            container.Controls.Add(caption);
            caption.Dock = DockStyle.Top;
            caption.Height = 100;
            caption.Font = new Font(lbName.Font.FontFamily, 12, FontStyle.Regular);
            caption.Text = item.message;
            caption.ForeColor = Color.Black;
            caption.Padding = new Padding(20, 4, 10, 4);
            caption.Enabled = false;
            caption.BorderStyle = BorderStyle.None;
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
            lbDateTimePost.Font = new Font(lbName.Font.FontFamily, 11, FontStyle.Regular);
            lbDateTimePost.Height = 30;
            lbDateTimePost.Dock = DockStyle.Top;
            lbDateTimePost.ForeColor = Color.Gray;
            lbDateTimePost.Text = item.creation_time.ToString();
            lbDateTimePost.Padding = new Padding(20, 0, 20, 0);

            Label lbNameUser = new Label();
            headerPost.Controls.Add(lbNameUser);
            lbNameUser.Font = new Font(lbName.Font.FontFamily, 13, FontStyle.Regular);
            lbNameUser.Dock = DockStyle.Top;
            lbNameUser.Height = 40;
            lbNameUser.ForeColor = Color.Black;
            lbNameUser.Text = currentUser.name;
            lbNameUser.Padding = new Padding(20, 8, 20, 0);

            // picture box avartar user
            PictureBox picAvartar = new PictureBox();
            picAvartar.Width = 70;
            picAvartar.Height = 70;
            headerPost.Controls.Add(picAvartar);
            picAvartar.Dock = DockStyle.Left;
            picAvartar.SizeMode = PictureBoxSizeMode.StretchImage;


            // button edit post
            Button btnEditPost = new Button();
            headerPost.Controls.Add(btnEditPost);
            btnEditPost.Font = new Font(lbName.Font.FontFamily, 15, FontStyle.Regular);
            btnEditPost.Tag = caption;
            try
            {
                btnEditPost.Image = (Image)(new Bitmap(Image.FromFile("../../imgaes/edit.png"), new Size(20, 20)));
            }
            catch (Exception)
            {

                btnEditPost.Image = picLogo1.ErrorImage;
            }
            btnEditPost.ImageAlign = ContentAlignment.TopCenter;
            btnEditPost.ForeColor = Color.Black;
            btnEditPost.FlatStyle = FlatStyle.Flat;
            btnEditPost.FlatAppearance.BorderColor = Color.LightGray;
            btnEditPost.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnEditPost.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnEditPost.Height = 30;
            btnEditPost.Width = 30;
            btnEditPost.Dock = DockStyle.Right;
            btnEditPost.TextImageRelation = TextImageRelation.TextAboveImage;
            btnEditPost.Padding = new Padding(0);
            btnEditPost.MouseMove += BtnEditPost_MouseMove;
           
            btnEditPost.Click += BtnEditPost_Click;

            // button delete post
            Button btnDeletePost = new Button();
            headerPost.Controls.Add(btnDeletePost);
            btnDeletePost.Font = new Font(lbName.Font.FontFamily, 15, FontStyle.Regular);
            btnDeletePost.Text = "X";
            btnDeletePost.Tag = item.post_id;
            btnDeletePost.ForeColor = Color.Black;
            btnDeletePost.FlatStyle = FlatStyle.Flat;
            btnDeletePost.FlatAppearance.BorderColor = Color.LightGray;
            btnDeletePost.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnDeletePost.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnDeletePost.Height = 35;
            btnDeletePost.Width = 35;
            btnDeletePost.Dock = DockStyle.Right;
            btnDeletePost.TextAlign = ContentAlignment.TopCenter;
            btnDeletePost.MouseMove += BtnDeletePost_MouseMove;
            btnDeletePost.MouseLeave += BtnDeletePost_MouseLeave;
            btnDeletePost.Click += BtnDeletePost_Click;

            try
            {
                using (GraphicsPath gp = new GraphicsPath())
                {
                    gp.AddEllipse(0, 0, picAvartar.Width - 3, picAvartar.Height - 3);
                    Region rg = new Region(gp);
                    picAvartar.Region = rg;
                }
                picAvartar.Image = Image.FromFile(currentUser.image);
            }
            catch (Exception)
            {
                picAvartar.Image = picUser1.ErrorImage;
            }


            flPanelPost.Controls.Add(container);
        }

        private void Container_Click(object sender, EventArgs e)
        {
            string[] component = sender.GetType().ToString().Split('.');
            string tmp = component[component.Length - 1];
            Label lb = null;
            Panel pn = null;
            PictureBox pic = null;
            RichTextBox rtxt = null;
            Post cpost = null;
            if (tmp == "Label")
            {
                lb = sender as Label;
                cpost = lb.Tag as Post;
            }
            else if (tmp == "Panel")
            {
                pn = sender as Panel;
                cpost = pn.Tag as Post;
            }
            else if (tmp == "PictureBox")
            {
                pic = sender as PictureBox;
                cpost = pic.Tag as Post;
            }
            else
            {
                rtxt = sender as RichTextBox;
                cpost = rtxt.Tag as Post;
            }

            if(cpost != null)
            {
                frmComment frmComment = new frmComment(cpost, currentUser);
                this.Hide();
                frmComment.ShowDialog();
                this.Show();
                flPanelPost.Controls.Clear();
                loadListPost();
                loadComponents();
                loadImage();
                loadLabel();
            }
        }

        private void BtnEditPost_MouseMove(object sender, MouseEventArgs e)
        {
            Button btnEdit = sender as Button;
            btnEdit.Cursor = Cursors.Hand;
        }

        private void BtnEditPost_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            RichTextBox rtxtCaption = button.Tag as RichTextBox;

            Post item = rtxtCaption.Tag as Post;

            if(item != null)
            {
                EditPost editPost = new EditPost(currentUser, item);
                this.Hide();
                editPost.ShowDialog();
                this.Show();
                flPanelPost.Controls.Clear();
                loadListPost();
                loadComponents();
                loadImage();
                loadLabel();
            }

        }

        private void BtnDeletePost_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có muốn xóa bài viết này không?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Button button = sender as Button;
                    int id = (int)button.Tag;
                    string sql = "DELETE posts where post_id = " + id.ToString();
                    PostBUS.Instance.actionData(sql);
                    flPanelPost.Controls.Clear();
                    loadListPost();
                    loadComponents();
                    loadImage();
                    loadLabel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        void loadImage()
        {
            try
            {
                picUser1.Image = Image.FromFile(currentUser.image);
            }
            catch (Exception)
            {
                picUser1.Image = picUser1.ErrorImage;
            }
        }
        void loadComponents()
        {

            foreach (Post item in myListPost)
            {
                loadAComponent(item);
            }
        }
        void loadLabel()
        {
            lbName.Text = currentUser.name;
        }
        private void frmMyPost_Load(object sender, EventArgs e)
        {
            flPanelPost.AutoScroll = true;
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, picUser1.Width - 3, picUser1.Height - 3);
                Region rg = new Region(gp);
                picUser1.Region = rg;
            }

            loadListPost();
            loadComponents();
            loadImage();
            loadLabel();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(82, 113, 255);
        }
    }
}
