using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sportif.Data;
using Sportif.Models;

namespace Sportif.Pages.Admin.Salon
{
    [Authorize(Roles = "Admin")]
    public class EditModel : PageModel
    {
        private readonly Sportif.Data.ApplicationDbContext _context;

        public EditModel(Sportif.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Salon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalonExists(Salon.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SalonExists(int id)
        {
            return _context.Salons.Any(e => e.ID == id);
        }
    }
}
