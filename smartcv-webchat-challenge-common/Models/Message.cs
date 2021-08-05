using System;

namespace smartcv_webchat_challenge_common.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
