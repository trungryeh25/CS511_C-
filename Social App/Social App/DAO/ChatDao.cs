using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Social_App.DTO;
namespace Social_App.DAO
{
    public class ChatDao
    {
        private static ChatDao instance;
        public static ChatDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChatDao();
                return instance;
            }
        }
        private ChatDao()
        {

        }
        public List<Message> findAll(int sender_id, int receiver_id)
        {
            List<Message> list = new List<Message>();
            string sql = "select * from messages where sender_id = " + sender_id.ToString() + 
                " and receiver_id = " + receiver_id.ToString() + " order by message_timestamp asc";
            DataTable data = DBConnect.Instance.ExecuteQuery_DataTable(sql);
            foreach (DataRow item in data.Rows)
            {
                int message_id = (int)item["message_id"];
                int send_id = (int)item["sender_id"];
                int receive_id = (int)item["receiver_id"];
                string message_text = item["message_text"].ToString();
                DateTime message_timestamp = DateTime.Parse(item["message_timestamp"].ToString());
                Message chat = new Message(message_id, send_id, receive_id, message_text, message_timestamp);
                list.Add(chat);
            }
            return list;
        }

        public bool SendChat(string sql)
        {
            try
            {
                DBConnect.Instance.ExecuteUpdateQuery(sql);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
