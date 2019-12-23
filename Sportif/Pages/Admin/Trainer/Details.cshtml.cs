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
    public class DetailsModel : PageModel
    {
        private readonly Sportif.Data.ApplicationDbContext _context;

        public DetailsModel(Sportif.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Sportif.Models.Trainer Trainer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trainer = await _context.Trainers
                .Include(t => t.Salon).FirstOrDefaultAsync(m => m.ID == id);

            if (Trainer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
