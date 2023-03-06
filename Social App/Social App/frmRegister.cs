using System;
using System.Windows.Forms;
using Social_App.BUS;
namespace Social_App
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsername;
        }
        protected bool checkNullInput()
        {
            if (txtUsername.Text.Trim().Equals("")) return false;
            if (txtPassword.Text.Trim().Equals("")) return false;
            if (txtEmail.Text.Trim().Equals("")) return false;
            if (txtName.Text.Trim().Equals("")) return false;
            return true;
        }
        protected bool checkValidEmail()
        {
            if (txtEmail.Text.Contains("@")) return true;
            return false;
        }
        protected void resetAllText()
        {
            txtUsername.ResetText();
            txtPassword.ResetText();
            txtName.ResetText();
            txtEmail.ResetText();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!checkNullInput())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                resetAllText();
                txtUsername.Focus();
            }
            else
            {
                try
                {
                    string username = txtUsername.Text.Trim();
                    string password = txtPassword.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string name = txtName.Text.Trim();
                    string age = nmrAge.Value.ToString();
                    string image = "../../imgaes/user1.jpg";    // default
                    string sql = "INSERT INTO users(username, password, email, name, age, image) " +
                        "VALUES ('" + username + "', '" + password + "', '" + email +
                        "', N'" + name + "'," + age + ", '" + image + "')";
                    if (UserBUS.Instance.actionData(sql))
                    {
                        MessageBox.Show("Đăng ký tài khoản thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại. Vui lòng thử lại sau!");
                        MessageBox.Show(sql);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!checkValidEmail())
            {
                MessageBox.Show("Email không đúng, vui lòng nhập lại");
                txtEmail.Focus();
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            bool check = UserBUS.Instance.checkExistUser(txtUsername.Text.Trim());
            if (check)
            {
                MessageBox.Show("Username đã tồn tại.");
                txtUsername.ResetText();
                txtUsername.Focus();
            }
        }
    }
}
