using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_App.DTO
{
    public class UserComment
    {
        public int comment_id { get; set; }
        public int post_id { get; set; }
        public int user_id { get; set; }
        public string content { get; set; }
        public DateTime? comment_time { get; set; }
        public string name { get; set; }
        public string image { get; set; }

        
        public UserComment()
        {
            this.comment_id = 0;
            this.post_id = 0;
            this.user_id = 0;
            this.content = string.Empty;
            this.comment_time = DateTime.Now;
            this.name = string.Empty;
            this.image = string.Empty;
        }

        public UserComment(int comment_id, int post_id, int user_id, string content, DateTime? comment_time, string name, string image)
        {
            this.comment_id = comment_id;
            this.post_id = post_id;
            this.user_id = user_id;
            this.content = content;
            this.comment_time = comment_time;
            this.name = name;
            this.image = image;
        }
    }
}
