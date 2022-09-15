using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test_Chat.Models;

namespace test_Chat.Data
{
    public class test_ChatContext : DbContext
    {
        public test_ChatContext (DbContextOptions<test_ChatContext> options)
            : base(options)
        {
        }
        public DbSet<test_Chat.Models.MessageChatSnterface> MessageChatSnterface { get; set; }

        public DbSet<test_Chat.Models.AllChats> AllChats { get; set; }

        public DbSet<test_Chat.Models.User> User { get; set; }
    }
}
