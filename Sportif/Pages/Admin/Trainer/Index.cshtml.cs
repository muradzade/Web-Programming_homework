using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sportif.Data;
using Sportif.Models;

namespace Sportif.Pages.Admin.Trainer
{
    public class IndexModel : PageModel
    {
        private readonly Sportif.Data.ApplicationDbContext _context;

        public IndexModel(Sportif.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Sportif.Models.Trainer> Trainer { get;set; }

        public async Task OnGetAsync()
        {
            Trainer = await _context.Trainers
                .Include(t => t.Salon).ToListAsync();
        }
    }
}
