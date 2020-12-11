using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace net_example.Models
{
    public class MessageModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ChatId { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
    }
}