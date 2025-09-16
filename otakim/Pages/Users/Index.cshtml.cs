using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using otakim.Data;
using otakim.Models;

namespace otakim.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly otakim.Data.otakimContext _context;

        public IndexModel(otakim.Data.otakimContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async System.Threading.Tasks.Task OnGetAsync()
        {
            User = await _context.Users.ToListAsync();
        }
    }
}
