using System.Collections.Generic;

namespace smartcv_webchat_challenge_common.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}
