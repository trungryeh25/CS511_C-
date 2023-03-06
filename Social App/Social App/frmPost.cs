using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Social_App.BUS;
using Social_App.DTO;
namespace Social_App
{
    public partial class frmPost : Form
    {
        User currentUser = null;
        bool isCheckKeyPress = false;
        public frmPost(User user)
        {
            InitializeComponent();
            lbDate.Text = DateTime.Now.ToLocalTime().ToString();
            currentUser = user;
        }
        public frmPost(User user, Post post)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadButton()
        {
            btnPost.Enabled = false;
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
            picPost.Image = picPost.ErrorImage;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void loadLabel()
        {
            lbDate.Text = DateTime.Now.ToLocalTime().ToString();
            lbName.Text = currentUser.name;
        }

        private void frmPost_Load(object sender, EventArgs e)
        {
            timer1.Start();
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, picUser1.Width - 3, picUser1.Height - 3);
                Region rg = new Region(gp);
                picUser1.Region = rg;
            }
            loadButton();
            loadImage();
            loadLabel();
            this.ActiveControl = rtxtContentPost;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            // open file dialog 
            using (OpenFileDialog open = new OpenFileDialog())
            {
                // image filters  
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    picPost.Image = new Bitmap(open.FileName);
                    picPost.Tag = open.FileName;
                    //currentUser.image = open.FileName;
                    // image file path  
                    //MessageBox.Show(open.FileName);
                }
            }
        }

        bool checkKeypressText(char x)
        {
            bool check = (x >= 32 && x <= 126);
            isCheckKeyPress = true;
            return check;
        }
        private void rtxtContentPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool check = checkKeypressText(e.KeyChar) && rtxtContentPost.Text.Equals("What's on your mind?");
            if (check)
            {
                if (isCheckKeyPress)
                {
                    rtxtContentPost.ResetText();
                }
                btnPost.Enabled = true;
                btnPost.BackColor = Color.Blue;
            }
            else if (e.KeyChar == 8)
            {
                if (rtxtContentPost.Text.Equals(""))
                {
                    isCheckKeyPress = false;
                    rtxtContentPost.Text = "What's on your mind?";
                    rtxtContentPost.Focus();
                    btnPost.Enabled = false;
                    btnPost.BackColor = Color.LightGray;
                }
            }
        }

        private void rtxtContentPost_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPost_Move(object sender, EventArgs e)
        {

        }

        private void btnPost_MouseMove(object sender, MouseEventArgs e)
        {
            btnPost.FlatAppearance.MouseDownBackColor = (btnPost.Enabled == true) ? Color.DodgerBlue : Color.LightGray;
            btnPost.FlatAppearance.MouseOverBackColor = (btnPost.Enabled == true) ? Color.DodgerBlue : Color.LightGray;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            try
            {
                int user_id = currentUser.user_id;
                string message = rtxtContentPost.Text;
                string image_url = picPost.Tag == null ? string.Empty : picPost.Tag.ToString();
                string creation_time = DateTime.Now.ToLocalTime().ToString();

                string sql = "INSERT INTO posts (user_id, message, image_url, creation_time) " +
                    "VALUES (" + user_id + ", N'" + message + "', N'" + image_url + "', '" + creation_time + "')";
                PostBUS.Instance.actionData(sql);
                MessageBox.Show("Đăng bài thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
