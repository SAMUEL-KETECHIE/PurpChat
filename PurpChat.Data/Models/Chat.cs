using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PurpChat.Data.Models
{
    [Table("ct.Chat")]
    public class Chat
    {
        public int Id { get; set; }

        public ICollection<Message> Messages { get; set; }
        //Add users
        public ICollection<User> Users { get; set; }
        public ChatType Type { get; set; }
    }
}
