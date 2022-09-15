
using Microsoft.EntityFrameworkCore;
using test_Chat.Models;

namespace test_Chat.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new test_ChatContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<test_ChatContext>>()))
            {

                if (context.User.Any()) { return; }

                context.User.AddRange(
                    new User { Name = "Oleh", },
                    new User { Name = "Vlad", },
                    new User { Name = "Ben", }
                    );
                context.SaveChanges();

                if (context.MessageChatSnterface.Any()) { return; }

                context.MessageChatSnterface.AddRange(
                    new MessageChatSnterface { User = "Oleh",Chat = "All", TypeChat = "Group" },
                    new MessageChatSnterface { User = "Oleh", Chat = "Ben", TypeChat = "Private" },
                    new MessageChatSnterface { User = "Vlad", Chat = "All", TypeChat = "Group" },
                    new MessageChatSnterface { User = "Vlad", Chat = "Ben", TypeChat = "Private" },
                    new MessageChatSnterface { User = "Ben", Chat = "All", TypeChat = "Group" },
                    new MessageChatSnterface { User = "Ben", Chat = "Vlad", TypeChat = "Private" },
                    new MessageChatSnterface { User = "Ben", Chat = "Oleh", TypeChat = "Private" }

                    );
                context.SaveChanges();

                if (context.AllChats.Any()) { return; }

                context.AllChats.AddRange(
                    new AllChats { Message = "Hi, Ben", UserName = "Oleh", Chat = "Private", UserGet = "Ben", Date = DateTime.Now, MessegeVisable = "Visable"},
                    new AllChats { Message = "Hi, Oleh", UserName = "Ben", Chat = "Private", UserGet = "Oleh", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Hi, everyone!", UserName = "Oleh", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Hi, Oleh", UserName = "Vlad", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "You cooooool man", UserName = "Ben", Chat = "Private", UserGet = "Vlad", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Ok, but I don`t know you", UserName = "Vlad", Chat = "Private", UserGet = "Ben", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "How are you?", UserName = "Vlad", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "I`m fine thank you, and how are you?", UserName = "Oleh", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "I`m bad", UserName = "Vlad", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "UnVisable" },
                    new AllChats { Message = "Oh no, I wanted say, I feel bad. But I deleted the message from myself", UserName = "Vlad", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "It happens", UserName = "Oleh", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Hi everyone hat happened", UserName = "Ben", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 1", UserName = "Oleh", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 2", UserName = "Oleh", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 3", UserName = "Vlad", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 4", UserName = "Vlad", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 5", UserName = "Ben", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 6", UserName = "Vlad", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 7", UserName = "Vlad", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 8", UserName = "Ben", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 9", UserName = "Vlad", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 10", UserName = "Vlad", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 11", UserName = "Ben", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 12", UserName = "Vlad", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 13", UserName = "Vlad", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 14", UserName = "Ben", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 15", UserName = "Oleh", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 16", UserName = "Oleh", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 17", UserName = "Vlad", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 18", UserName = "Oleh", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 19", UserName = "Vlad", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" },
                    new AllChats { Message = "Test 20", UserName = "Vlad", Chat = "Group", UserGet = "All", Date = DateTime.Now, MessegeVisable = "Visable" }
                    
                    );
                context.SaveChanges();
            }
        }
    }
}
