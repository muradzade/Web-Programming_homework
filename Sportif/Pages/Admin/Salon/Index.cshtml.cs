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

namespace Sportif
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly Sportif.Data.ApplicationDbContext _context;

        public IndexModel(Sportif.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Salon> Salon { get;set; }

        public async Task OnGetAsync()
        {
            Salon = await _context.Salons.ToListAsync();
        }
    }
}
