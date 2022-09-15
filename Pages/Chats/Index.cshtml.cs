using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using test_Chat.Models;

namespace test_Chat.Pages.Chats
{
    public class IndexModel : PageModel
    {
        private readonly test_Chat.Data.test_ChatContext _context;

        public IndexModel(test_Chat.Data.test_ChatContext context)
        {
            _context = context;
        }


        public IList<MessageChatSnterface> MessageChatSnterface { get;set; } = default!;


        public async Task<IActionResult> OnGetAsync(string? username)
        {

            if (_context.MessageChatSnterface != null)
            {
                var check = await (Task.Run(() => _context.MessageChatSnterface));
                check.ToList();
                var check2 = await (Task.Run(() => check.ToList()));
                MessageChatSnterface = check2.Where(u => u.User == username).ToList();
            }
            return Page();
        }

        [BindProperty]
        public MessageChatSnterface MessageChatSnterfacePost { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync(string? username)
        {


            MessageChatSnterfacePost.User = username;
            _context.MessageChatSnterface.Add(MessageChatSnterfacePost);
            await _context.SaveChangesAsync();

            return Redirect("/Chats?username=" + username);

        }

    }
}
