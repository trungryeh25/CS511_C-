using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Social_App.DTO;
using Social_App.BUS;
using System.Data;

namespace Social_App.DAO
{
    public class CommentDao
    {
        private static CommentDao instance;
        public static CommentDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new CommentDao();
                return instance;
            }
        }
        private CommentDao()
        {

        }
        public bool sendComment(string sql)
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

        public List<UserComment> findAll(int  postid)
        {
            List<UserComment> list = new List<UserComment>();
            string sql = "SELECT comment_id, post_id, users.user_id, content, comment_time, name, image " +
                "FROM comments, users WHERE comments.user_id = users.user_id and post_id = " + postid.ToString()
                + " ORDER BY comment_time";
            DataTable data = DBConnect.Instance.ExecuteQuery_DataTable(sql);
            foreach (DataRow item in data.Rows)
            {
                int comment_id = (int)item["comment_id"];
                int post_id = (int)item["post_id"];
                int user_id = (int)item["user_id"];
                string content = item["content"].ToString();
                DateTime? comment_time = item["comment_time"].ToString() == string.Empty ? null : (DateTime?)item["comment_time"];
                string name = item["name"].ToString();
                string image = item["image"].ToString();
                UserComment item1 = new UserComment(comment_id, post_id, user_id, content, comment_time, name, image);
                list.Add(item1);
            }
            return list;
        }

        public List<Comment> findAllById(int id)
        {
            List<Comment> list = new List<Comment>();
            string sql = "SELECT * FROM comments WHERE comment_id = " + id.ToString();
            DataTable data = DBConnect.Instance.ExecuteQuery_DataTable(sql);
            foreach (DataRow item in data.Rows)
            {
                int comment_id = (int)item["comment_id"];
                int post_id = (int)item["post_id"];
                int user_id = (int)item["user_id"];
                string content = item["content"].ToString();
                DateTime? comment_time = item["comment_time"].ToString() == string.Empty ? null : (DateTime?)item["comment_time"];
                Comment cmt = new Comment(comment_id, post_id, user_id, content, comment_time);
                list.Add(cmt);
            }
            return list;
        }
        public List<Comment> findAllCommentInPost(int postid)
        {
            List<Comment> list = new List<Comment>();
            string sql = "SELECT * FROM comments WHERE post_id = " + postid.ToString();
            DataTable data = DBConnect.Instance.ExecuteQuery_DataTable(sql);
            foreach (DataRow item in data.Rows)
            {
                int comment_id = (int)item["comment_id"];
                int post_id = (int)item["post_id"];
                int user_id = (int)item["user_id"];
                string content = item["content"].ToString();
                DateTime? comment_time = item["comment_time"].ToString() == string.Empty ? null : (DateTime?)item["comment_time"];
                Comment cmt = new Comment(comment_id, post_id, user_id, content, comment_time);
                list.Add(cmt);
            }
            return list;
        }
    }
}
