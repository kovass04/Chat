using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using test_Chat.Models;
using PagedList.Mvc;
using PagedList;

namespace test_Chat.Pages.Chats
{
    public class ChatModel : PageModel
    {
        private readonly test_Chat.Data.test_ChatContext _context;
       

        public ChatModel(test_Chat.Data.test_ChatContext context)
        {
            _context = context;
        }

        public IList<MessageChatSnterface> MessageChatSnterface { get; set; } = default!;


        public IList<AllChats> AllChats { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(string? username, string? Chat,string? TypeChat, string? UserGet, int? page)
        {
           

            if (TypeChat == "Private")
            {
                var check = await (Task.Run(() => _context.AllChats));
                check.ToList();
                var check2 = await (Task.Run(() => check.ToList()));
                var check3 = await (Task.Run(() => check.ToList()));
                check2 = check2.Where(u => u.UserName == username && u.Chat == "Private" && u.UserGet == UserGet && u.MessegeVisable == "Visable").ToList();
                check3 = check3.Where(u => u.UserName == UserGet && u.Chat == "Private" && u.UserGet == username).ToList();

                AllChats = check2.Concat(check3).ToList();
                AllChats = AllChats.OrderBy(q => q.Date).ToList();  

            }
            else
            {
                var check = await (Task.Run(() => _context.AllChats));
                check.ToList();
                var check2 = await (Task.Run(() => check.ToList()));


                
                AllChats = check2.Where(u => u.UserGet == UserGet).ToList();
            }
            
            /*int pageSize = 5;
            
            int pageNumber = (page ?? 1);
            AllChats.ToPagedList(pageNumber, pageSize);*/

            return Page();
        }


        //Add
        [BindProperty]
        public AllChats AllChatsPost { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync(string? username, string? UserGet, string? TypeChat)
        {

            AllChatsPost.UserName = username;
            AllChatsPost.Chat = TypeChat;
            AllChatsPost.Date = DateTime.Now;
            AllChatsPost.UserGet = UserGet;
            AllChatsPost.MessegeVisable = "Visable"; 
            _context.AllChats.Add(AllChatsPost);
            await _context.SaveChangesAsync();

            return Redirect("/Chats/Chat?username=" + username + "&UserGet=" + UserGet + "&TypeChat=" + TypeChat );
            
        }

         public async Task<IActionResult> OnPostDeleteAsync(int? id, string? username, string? UserGet, string? TypeChat)
        {
            if (id == null || _context.AllChats == null)
            {
                return NotFound();
            }

            
            var allchats = await _context.AllChats.FindAsync(id);

            if (allchats != null)
            {
                AllChatsPost = allchats;
                _context.AllChats.Remove(AllChatsPost);
                await _context.SaveChangesAsync();
            }

            return Redirect("/Chats/Chat?username=" + username + "&UserGet=" + UserGet + "&TypeChat=" + TypeChat );
        }

        public async Task<IActionResult> OnPostEditAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            AllChatsPost.Date = DateTime.Now;
            _context.Attach(AllChatsPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
            }

            return Redirect("/Chats/Chat?username=" + AllChatsPost.UserName + "&UserGet=" + AllChatsPost.UserGet + "&TypeChat=" + AllChatsPost.Chat );
        }
    }
}
