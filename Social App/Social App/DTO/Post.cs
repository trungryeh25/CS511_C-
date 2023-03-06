using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_App.DTO
{
    public class Post
    {
        public int post_id { get; set; }
        public int user_id { get; set; }
        public string message { get; set; }
        public string image_url { get; set; }
        public DateTime creation_time { get; set; }
        

        public Post()
        {
            this.post_id = 0;
            this.user_id = 0;
            this.message = string.Empty;
            this.image_url = string.Empty;
            this.creation_time = DateTime.Now;
        }

        public Post(int post_id, int user_id, string message, string image_url, DateTime creation_time)
        {
            this.post_id = post_id;
            this.user_id = user_id;
            this.message = message;
            this.image_url = image_url;
            this.creation_time = creation_time;
        }

        public override string ToString()
        {
            return "[post_id = " + post_id.ToString() + ", user_id = " + user_id.ToString() + ", message = " + message 
                + ", image_url = " + image_url + ", creation_time = " + creation_time.ToString() + "]";
        }
    }
}
