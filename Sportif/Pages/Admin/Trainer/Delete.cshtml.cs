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

namespace Sportif.Pages.Admin.Trainer
{
    [Authorize(Roles = "Admin")]
    public class DeleteModel : PageModel
    {
        private readonly Sportif.Data.ApplicationDbContext _context;

        public DeleteModel(Sportif.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trainer = await _context.Trainers.FindAsync(id);

            if (Trainer != null)
            {
                _context.Trainers.Remove(Trainer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
