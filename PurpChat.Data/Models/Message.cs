using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PurpChat.Data.Models
{
    [Table("ct.Message")]
    public class Message
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}