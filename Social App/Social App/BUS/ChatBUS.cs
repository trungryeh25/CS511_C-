using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Social_App.DTO;
using Social_App.DAO;
namespace Social_App.BUS
{
    public class ChatBUS
    {
        private static ChatBUS instance;
        public static ChatBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChatBUS();
                return instance;
            }
        }
        private ChatBUS()
        {

        }
        public List<Message> findAll(int sent, int recive)
        {
            return ChatDao.Instance.findAll(sent, recive);
        }
        public bool SendChat(string sql)
        {
            return ChatDao.Instance.SendChat(sql);
        }
    }
}
