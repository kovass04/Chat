using Microsoft.AspNetCore.Mvc.RazorPages;
using test_Chat.Models;
using Microsoft.EntityFrameworkCore;

namespace test_Chat.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Data.test_ChatContext _context;
        public IndexModel(ILogger<IndexModel> logger, Data.test_ChatContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<User> User { get; set; } = default!;
      

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}