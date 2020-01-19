using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PurpChat.Models
{
    public class Chat
    {
        public Chat()
        {
            Messages = new List<Message>();
            Users = new List<User>();
        }
        public int Id { get; set; }

        public string Name { get; set; }
        public ICollection<Message> Messages { get; set; }
        //Add users
        public ICollection<User> Users { get; set; }
        public ChatType Type { get; set; }
    }
}
