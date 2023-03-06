using System;
using System.Windows.Forms;
using Social_App.BUS;
using Social_App.DTO;
namespace Social_App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát không?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void lbRegister2_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                bool check = UserBUS.Instance.checkLogin(username, password);
                if (check)
                {
                    User user = UserBUS.Instance.getItem(username);
                    frmHome frmHome = new frmHome(user);
                    this.Hide();
                    frmHome.ShowDialog();
                    this.Show();
                    txtUsername.Focus();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                    txtUsername.ResetText();
                    txtPassword.ResetText();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsername;
        }
    }
}
