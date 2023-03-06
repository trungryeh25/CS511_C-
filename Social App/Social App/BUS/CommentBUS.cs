using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Social_App.DTO;
using Social_App.DAO;
namespace Social_App.BUS
{
    public class CommentBUS
    {
        private static CommentBUS instance;
        public static CommentBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CommentBUS();
                return instance;
            }
        }
        private CommentBUS()
        {

        }

        public bool sendComment(string sql)
        {
            return CommentDao.Instance.sendComment(sql);
        }
        public List<UserComment> findAll(int postid)
        {
            return CommentDao.Instance.findAll(postid);
        }
        public List<Comment> findAllById(int commentId)
        {
            return CommentDao.Instance.findAllById(commentId);
        }
        public List<Comment> findAllCommentInPost(int postId)
        {
            return CommentDao.Instance.findAllCommentInPost(postId);
        }
    }
}
