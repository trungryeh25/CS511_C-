using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_App.DTO
{
    public class Comment
    {
        public int comment_id { get; set; }
        public int post_id { get; set; }
        public int user_id { get; set; }
        public string content { get; set; }
        public DateTime? comment_time { get; set; }


        public Comment()
        {
            this.comment_id = 0;
            this.post_id = 0;
            this.user_id = 0;
            this.content = string.Empty;
            this.comment_time = DateTime.Now;
        }

        public Comment(int comment_id, int post_id, int user_id, string content, DateTime? comment_time)
        {
            this.comment_id = comment_id;
            this.post_id = post_id;
            this.user_id = user_id;
            this.content = content;
            this.comment_time = comment_time;
        }

        public override string ToString()
        {
            return "[comment_id = " + comment_id.ToString() + ", post_id = " + post_id.ToString() + ", user_id = " + 
                user_id.ToString() + ", content = " + content + ", comment_time =" + comment_time.ToString()+"]";
        }
    }
}
