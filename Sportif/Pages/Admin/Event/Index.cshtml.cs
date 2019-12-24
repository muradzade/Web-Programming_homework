using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sportif.Data;
using Sportif.Models;

namespace Sportif.Pages.Admin.Event
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly Sportif.Data.ApplicationDbContext _context;

        public IndexModel(Sportif.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Sportif.Models.Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Events.ToListAsync();
        }
    }
}
