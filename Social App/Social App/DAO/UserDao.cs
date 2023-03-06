using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Social_App.DTO;
using System.Data;

namespace Social_App.DAO
{
    public class UserDao
    {
        private static UserDao instance;
        public static UserDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserDao();
                return instance;
            }
        }
        private UserDao()
        {

        }


        public List<User> findAll()
        {
            List<User> list = new List<User>();
            string sql = "select * from users;";
            DataTable data = DBConnect.Instance.ExecuteQuery_DataTable(sql);
            foreach (DataRow item in data.Rows)
            {
                int id = (int)item["user_id"];
                string username = item["username"].ToString();
                string password = item["password"].ToString();
                string email = item["email"].ToString();
                string name = item["name"].ToString();
                int age = (int)item["age"];
                string image = item["image"].ToString();
                User user = new User(id, username, password, email, name, age, image);
                list.Add(user);
            }
            return list;
        }
        public List<User> findAllNotById(int id)
        {
            List<User> list = new List<User>();
            string sql = "select * from users where user_id != " + id.ToString() + ";";
            DataTable data = DBConnect.Instance.ExecuteQuery_DataTable(sql);
            foreach (DataRow item in data.Rows)
            {
                int user_id = (int)item["user_id"];
                string username = item["username"].ToString();
                string password = item["password"].ToString();
                string email = item["email"].ToString();
                string name = item["name"].ToString();
                int age = (int)item["age"];
                string image = item["image"].ToString();
                User user = new User(user_id, username, password, email, name, age, image);
                list.Add(user);
            }
            return list;
        }

        public User getItem(int id)
        {
            User user = null;
            string sql = "select * from users where user_id = " + id.ToString();
            DBConnect.Instance.openConnection();
            using (SqlCommand cmd = new SqlCommand(sql, DBConnect.Instance.con))
            {
                cmd.CommandType = CommandType.Text;
                SqlDataReader item = cmd.ExecuteReader();
                if (item.Read())
                {
                    int userid = (int)item["user_id"];
                    string username = item["username"].ToString();
                    string password = item["password"].ToString();
                    string email = item["email"].ToString();
                    string name = item["name"].ToString();
                    int age = (int)item["age"];
                    string image = item["image"].ToString();
                    user = new User(userid, username, password, email, name, age, image);
                }
            }
            DBConnect.Instance.closeConnection();
            return user;
        }
        public User getItem(string userName)
        {
            User user = null;
            string sql = "select * from users where username = '" + userName + "';";
            DBConnect.Instance.openConnection();
            using (SqlCommand cmd = new SqlCommand(sql, DBConnect.Instance.con))
            {
                cmd.CommandType = CommandType.Text;
                SqlDataReader item = cmd.ExecuteReader();
                if (item.Read())
                {
                    int userid = (int)item["user_id"];
                    string username = item["username"].ToString();
                    string password = item["password"].ToString();
                    string email = item["email"].ToString();
                    string name = item["name"].ToString();
                    int age = (int)item["age"];
                    string image = item["image"].ToString();
                    user = new User(userid, username, password, email, name, age, image);
                }
            }
            DBConnect.Instance.closeConnection();
            return user;
        }
        public bool actionData(string sql)
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


        public bool checkExistUsername(string username)
        {
            List<User> list = findAll();
            foreach (User item in list)
            {
                if (item.username.Equals(username))
                {
                    return true;
                }
            }

            return false;
        }

        public bool checklogin(string username, string password)
        {
            List<User> list = findAll();
            foreach (User item in list)
            {
                if (item.username.Equals(username) && item.password.Equals(password))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
