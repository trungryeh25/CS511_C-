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
    public partial class EditPost : Form
    {
        User currentUser = null;
        Post currentPost = null;
        public EditPost(User user, Post item)
        {
            InitializeComponent();
            currentUser = user;
            currentPost = item;
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
            try
            {
                picPost.Image = Image.FromFile(currentPost.image_url);
            }
            catch (Exception)
            {

                picPost.Image = picUser1.ErrorImage;
            }
            
        }
        void loadLabel()
        {
            lbName.Text = currentUser.name;
        }
        void allData()
        {
            rtxtContentPost.Text = currentPost.message;
        }
        private void EditPost_Load(object sender, EventArgs e)
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
            allData();
            this.ActiveControl = rtxtContentPost;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            try
            {
                int post_id = currentPost.post_id;
                string message = rtxtContentPost.Text;
                string image_url = picPost.Tag == null ? string.Empty : picPost.Tag.ToString();
                string creation_time = DateTime.Now.ToLocalTime().ToString();

                string sql = "UPDATE posts SET message = N'" + message + "', image_url = N'" + image_url +
                    "', creation_time = '" + creation_time + "' WHERE post_id = " + post_id.ToString();
                PostBUS.Instance.actionData(sql);
                MessageBox.Show("Cập nhật thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    btnPost.Enabled = true;
                    btnPost.BackColor = Color.Blue;
                    //currentUser.image = open.FileName;
                    // image file path  
                    //MessageBox.Show(open.FileName);
                }
            }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void btnPost_MouseMove(object sender, MouseEventArgs e)
        {
            btnPost.FlatAppearance.MouseDownBackColor = (btnPost.Enabled == true) ? Color.DodgerBlue : Color.LightGray;
            btnPost.FlatAppearance.MouseOverBackColor = (btnPost.Enabled == true) ? Color.DodgerBlue : Color.LightGray;
        }

        private void rtxtContentPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(rtxtContentPost.Text.CompareTo(currentPost.message) != 0)
            {
                btnPost.Enabled = true;
                btnPost.BackColor = Color.Blue;
            }else
            {
                btnPost.Enabled = false;
                btnPost.BackColor = Color.LightGray;
            }
        }
    }
}
