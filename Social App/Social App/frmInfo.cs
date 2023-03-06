using System;
using System.Windows.Forms;
using Social_App.DTO;
using Social_App.BUS;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace Social_App
{
    public partial class frmInfo : Form
    {
        User currentUser = null;
        bool edit = false;
        public frmInfo(User user)
        {
            InitializeComponent();
            currentUser = user;
            txtUsername.Enabled = false;
        }
        void loadInfo()
        {
            txtUsername.Text = currentUser.username;
            txtPassword.Text = currentUser.password;
            txtEmail.Text = currentUser.email;
            txtName.Text = currentUser.name;
            nmrAge.Value = decimal.Parse(currentUser.age.ToString());
        }
        void disableTextBox()
        {
            txtPassword.Enabled = false;
            txtName.Enabled = false;
            txtEmail.Enabled = false;
        }
        void enableTextbox()
        {
            txtPassword.Enabled = true;
            txtName.Enabled = true;
            txtEmail.Enabled = true;
        }
        void loadComponents()
        {
            try
            {
                picUser1.Image = Image.FromFile(currentUser.image);
                using (GraphicsPath gp = new GraphicsPath())
                {
                    gp.AddEllipse(0, 0, picUser1.Width - 3, picUser1.Height - 3);
                    Region rg = new Region(gp);
                    picUser1.Region = rg;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(e.Message);
                //
                picUser1.Image = picUser1.ErrorImage;
                using (GraphicsPath gp = new GraphicsPath())
                {
                    gp.AddEllipse(0, 0, picUser1.Width - 3, picUser1.Height - 3);
                    Region rg = new Region(gp);
                    picUser1.Region = rg;
                }
            }
            try
            {
                loadInfo();
                disableTextBox();
                btnChooseImage.Enabled = false;
                btnSave.Enabled = false;
                chboxPassword.Checked = false;
            }
            catch (Exception)
            {

            }
        }


        private void frmInfo_Load(object sender, EventArgs e)
        {
            loadComponents();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnChooseImage.Enabled = true;
            btnSave.Enabled = true;
            enableTextbox();
            txtUsername.Focus();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            edit = false;
            btnSave.Enabled = false;
            btnChooseImage.Enabled = false;
            chboxPassword.Checked = false;
            currentUser = UserBUS.Instance.getItem(currentUser.user_id);
            try
            {
                picUser1.Image = Image.FromFile(currentUser.image);
                using (GraphicsPath gp = new GraphicsPath())
                {
                    gp.AddEllipse(0, 0, picUser1.Width - 3, picUser1.Height - 3);
                    Region rg = new Region(gp);
                    picUser1.Region = rg;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(e.Message);
                //
                picUser1.Image = picUser1.ErrorImage;
                using (GraphicsPath gp = new GraphicsPath())
                {
                    gp.AddEllipse(0, 0, picUser1.Width - 3, picUser1.Height - 3);
                    Region rg = new Region(gp);
                    picUser1.Region = rg;
                }
            }
            loadInfo();
            disableTextBox();
            txtPassword.UseSystemPasswordChar = chboxPassword.Checked == false ? true : false;
        }

        private void chboxPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = (chboxPassword.Checked == false) ? true : false;
        }

        bool checkInValidInput()
        {
            if (txtPassword.Text.Trim().Equals("")) return true;
            if (txtEmail.Text.Trim().Equals("")) return true;
            if (txtName.Text.Trim().Equals("")) return true;
            if (nmrAge.Value < 1) return true;
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkInValidInput())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                txtPassword.Focus();
                return;
            }
            
            try
            {
                string password = txtPassword.Text.Trim();
                string email = txtEmail.Text.Trim();
                string name = txtName.Text.Trim();
                string image = currentUser.image;
                string age = nmrAge.Value.ToString();
                string sql = "UPDATE users SET password = '" + password + "', email = '" + email + "', name = N'" +
                    name + "', age = " + age + ", image = '" + image + "' WHERE user_id = " + currentUser.user_id + " and " +
                    "username = '" + currentUser.username + "';";
                bool check = UserBUS.Instance.actionData(sql);
                if (check)
                {
                    MessageBox.Show("Sửa thông tin cá nhân thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại. Vui lòng thử lại sau!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thông tin thất bại. Vui lòng thử lại sau!");
            }


            btnReload_Click(sender, e);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (edit && !txtEmail.Text.Trim().Contains("@"))
            {
                MessageBox.Show("Email không đúng.");
                txtEmail.Focus();
            }
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
                    picUser1.Image = new Bitmap(open.FileName);
                    currentUser.image = open.FileName;
                    // image file path  
                    //MessageBox.Show(open.FileName);
                }
            }
              
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(82, 113, 255);
        }
    }
}
