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

namespace Sportif.Pages.Admin.Salon
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
        public Sportif.Models.Salon Salon { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Salon = await _context.Salons.FirstOrDefaultAsync(m => m.ID == id);

            if (Salon == null)
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

            Salon = await _context.Salons.FindAsync(id);

            if (Salon != null)
            {
                _context.Salons.Remove(Salon);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
