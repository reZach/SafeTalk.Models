using System.Collections.Generic;

namespace SafeTalk.Models
{
    public class RedisCache
    {
        public List<Chatroom> Chatrooms { get; set; }
        public List<User> Users { get; set; }

        public RedisCache()
        {
            Chatrooms = new List<Chatroom>();
            Users = new List<User>();
        }
    }
}