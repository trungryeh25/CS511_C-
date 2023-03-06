using Social_App.DAO;
using Social_App.DTO;
using System;
using System.Collections.Generic;

namespace Social_App.BUS
{
    public class PostBUS
    {
        private static PostBUS instance;
        public static PostBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PostBUS();
                return instance;
            }
        }
        private PostBUS()
        {

        }
        public List<Post> findAll()
        {
            return PostDao.Instance.findAll();
        }
        public List<Post> findAllPostNotId(int id)
        {
            return PostDao.Instance.findAllPostNotId(id);
        }
        public List<Post> findAllById(int id)
        {
            return PostDao.Instance.findAllById(id);
        }
        public bool actionData(string sql)
        {
            return PostDao.Instance.actionData(sql);
        }
    }
}
