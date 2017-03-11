using System.Collections.Generic;

namespace SafeTalk.Models
{
    public class Chatroom
    {
        public string Name { get; set; }
        public List<string> UserGuids { get; set; }

        public Chatroom()
        {
            Name = null;
            UserGuids = new List<string>();
        }
    }
}