using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Social_App.DAO;
using Social_App.DTO;
namespace Social_App.BUS
{
    public class UserBUS
    {
        private static UserBUS instance;
        public static UserBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserBUS();
                return instance;
            }
        }
        private UserBUS()
        {

        }
        public List<User> findAll()
        {
            List<User> list = UserDao.Instance.findAll();
            return list;
        }
        public List<User> findAllNotById(int id)
        {
            return UserDao.Instance.findAllNotById(id);
        }
        public bool checkLogin(string username, string password)
        {
            return UserDao.Instance.checklogin(username,password);
        }
        public bool checkExistUser(string username)
        {
            return UserDao.Instance.checkExistUsername(username);
        }
        public bool actionData(string sql)
        {
           return  UserDao.Instance.actionData(sql);
        }
        public User getItem(int id)
        {
            return UserDao.Instance.getItem(id);
        }
        public User getItem(string username)
        {
            return UserDao.Instance.getItem(username);
        }
    }
}
