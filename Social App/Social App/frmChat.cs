using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Social_App.DTO;
using System.Drawing.Drawing2D;
using Social_App.BUS;
namespace Social_App
{

    public partial class frmChat : Form
    {
        User me = null;
        User friend = null;
        List<DTO.Message> listChat1 = null;     // sender is me
        List<DTO.Message> listChat2 = null;     // sender is friend
        List<DTO.Message> listChat = null;      // combine of list 1 and list 2
        public frmChat(User a, User b)
        {
            InitializeComponent();
            me = a;
            friend = b;
            loadChat();
            listChat = new List<DTO.Message>();
        }
        void loadChat()
        {
            listChat1 = ChatBUS.Instance.findAll(me.user_id, friend.user_id);
            listChat2 = ChatBUS.Instance.findAll(friend.user_id, me.user_id);
            if(listChat != null)
            {
                listChat.Clear();
            }
        }
        private void frmChat_Load(object sender, EventArgs e)
        {
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, picFriend1.Width - 3, picFriend1.Height - 3);
                Region rg = new Region(gp);
                picFriend1.Region = rg;
            }
            loadUser();
            loadMessage();
            btnChat.Enabled = false;
            btnChat.BackColor = (btnChat.Enabled == false) ? Color.DodgerBlue : Color.Blue;
        }
        void combineListChat()
        {
            loadChat();
            foreach (DTO.Message item in listChat1)
            {
                listChat.Add(item);
            }
            foreach (DTO.Message item in listChat2)
            {
                listChat.Add(item);
            }
            SortDate s = new SortDate();
            listChat.Sort(s);
        }
        void loadMessage()
        {
            combineListChat();
            foreach (DTO.Message item in listChat)
            {
                loadAMessage(item);
            }
        }
        void loadAMessage(DTO.Message item)
        {
            Panel container = new Panel();
            container.Height = 50;
            container.Width = 565;
            container.Margin = new Padding(16, 8, 16, 8);
            container.Padding = new Padding(10, 0, 10, 0);
            container.BackColor = Color.Aqua;

            // Label chat and time
            Label time = new Label();
            container.Controls.Add(time);
            time.Dock = DockStyle.Bottom;
            time.Text = item.message_timestamp.ToString();
            time.Font = new Font(lbNameFriend.Font.FontFamily, 9, FontStyle.Regular);
            time.Height = 15;
            time.ForeColor = Color.Black;

            Label lbChat = new Label();
            container.Controls.Add(lbChat);
            lbChat.Dock = DockStyle.Top;
            lbChat.Text = item.message_text;
            lbChat.Font = new Font(lbNameFriend.Font.FontFamily, 12, FontStyle.Regular);
            lbChat.Height = 25;
            lbChat.ForeColor = Color.Black;


            if (item.sender_id == me.user_id)
            {
                time.TextAlign = ContentAlignment.MiddleRight;
                lbChat.TextAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                time.TextAlign = ContentAlignment.MiddleLeft;
                lbChat.TextAlign = ContentAlignment.MiddleLeft;
            }

            flpnChat.Controls.Add(container);
        }
        void loadUser()
        {
            lbNameFriend.Text = friend.name;

            try
            {
                picFriend1.Image = Image.FromFile(friend.image);
            }
            catch (Exception)
            {
                picFriend1.Image = picFriend1.ErrorImage;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txtChat.Text;
                string sender_id = me.user_id.ToString();
                string receiver_id = friend.user_id.ToString();
                string datetime = DateTime.Now.ToLocalTime().ToString();
                string sql = "INSERT INTO messages(sender_id, receiver_id, message_text, message_timestamp)" +
                    "VALUES(" + sender_id + "," + receiver_id + ", N'" + message + "', '" + datetime + "');";
                ChatBUS.Instance.SendChat(sql);
                flpnChat.Controls.Clear();
                txtChat.ResetText();
                loadMessage();
                btnChat.Enabled = false;
                btnChat.BackColor = (btnChat.Enabled == false) ? Color.DodgerBlue : Color.Blue;
            }
            catch (Exception)
            {

            }
        }

        private void txtChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 0)
            {
                btnChat.Enabled = txtChat.Text.Trim().Equals("") ? false : true;
                btnChat.BackColor = (btnChat.Enabled == false) ? Color.DodgerBlue : Color.Blue;
            }
            
        }
    }
}
