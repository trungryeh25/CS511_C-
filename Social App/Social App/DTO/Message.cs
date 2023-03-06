using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_App.DTO
{
    public class Message
    {
        public int message_id { get; set; }
        public int sender_id { get; set; }
        public int receiver_id { get; set; }
        public string message_text { get; set; }
        public DateTime message_timestamp { get; set; }

        public Message()
        {
            this.message_id = 0;
            this.sender_id = 0;
            this.receiver_id = 0;
            this.message_text = string.Empty;
            this.message_timestamp = DateTime.Now;
        }

        public Message(int message_id, int sender_id, int receiver_id, string message_text, DateTime message_timestamp)
        {
            this.message_id = message_id;
            this.sender_id = sender_id;
            this.receiver_id = receiver_id;
            this.message_text = message_text;
            this.message_timestamp = message_timestamp;
        }

        public override string ToString()
        {
            return "[message_id = " + message_id.ToString() + ", sender_id = " + sender_id.ToString() + ", receiver_id = " +
                receiver_id.ToString() + ", message_text = " + message_text + ", message_timestamp = " + message_timestamp.ToString() + "]";
        }
    }
}
