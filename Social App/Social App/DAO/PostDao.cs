using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Social_App.DTO;

namespace Social_App.DAO
{
    public class PostDao
    {
        private static PostDao instance;
        public static PostDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new PostDao();
                return instance;
            }
        }
        private PostDao()
        {

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
        public List<Post> findAll()
        {
            List<Post> list = new List<Post>();
            string sql = "select * from posts";
            DataTable data = DBConnect.Instance.ExecuteQuery_DataTable(sql);
            foreach (DataRow item in data.Rows)
            {
                int post_id = (int)item["post_id"];
                int user_id = (int)item["user_id"];
                string message = item["message"].ToString();
                string image_url = item["image_url"].ToString();
                DateTime creation_time = DateTime.Parse(item["creation_time"].ToString());
                Post post = new Post(post_id, user_id, message, image_url, creation_time);
                list.Add(post);
            }
            return list;
        }
        public List<Post> findAllPostNotId(int id)
        {
            List<Post> list = new List<Post>();
            string sql = "select * from posts where user_id != " + id.ToString();
            DataTable data = DBConnect.Instance.ExecuteQuery_DataTable(sql);
            foreach (DataRow item in data.Rows)
            {
                int post_id = (int)item["post_id"];
                int user_id = (int)item["user_id"];
                string message = item["message"].ToString();
                string image_url = item["image_url"].ToString();
                DateTime creation_time = DateTime.Parse(item["creation_time"].ToString());
                Post post = new Post(post_id, user_id, message, image_url, creation_time);
                list.Add(post);
            }
            return list;
        }
        public List<Post> findAllById(int id)
        {
            List<Post> list = new List<Post>();
            string sql = "select * from posts where user_id = " + id.ToString();
            DataTable data = DBConnect.Instance.ExecuteQuery_DataTable(sql);
            foreach (DataRow item in data.Rows)
            {
                int post_id = (int)item["post_id"];
                int user_id = (int)item["user_id"];
                string message = item["message"].ToString();
                string image_url = item["image_url"].ToString();
                DateTime creation_time = DateTime.Parse(item["creation_time"].ToString());
                Post post = new Post(post_id, user_id, message, image_url, creation_time);
                list.Add(post);
            }
            return list;
        }
    }
}
