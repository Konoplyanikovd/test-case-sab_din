using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace net_example.Models
{
    public class ChatModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        
    }
}