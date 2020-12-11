using Microsoft.EntityFrameworkCore;
using net_example.Models;

namespace net_example.Data 
{
    public class ModelsContext : DbContext
    {
        public ModelsContext(DbContextOptions<ModelsContext> options) : base(options)
        {
        }

        public DbSet<ChatModel> ChatModel { get; set; }
        public DbSet<MessageModel> MessageModel { get; set; }
        public DbSet<UserModel> UserModel { get; set; }
    }
}