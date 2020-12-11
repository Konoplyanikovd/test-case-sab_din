using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace net_example.Models
{
    public class UserModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}