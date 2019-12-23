using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sportif.Data;
using Sportif.Models;

namespace Sportif.Pages.Admin.Trainer
{
    public class EditModel : PageModel
    {
        private readonly Sportif.Data.ApplicationDbContext _context;

        public EditModel(Sportif.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sportif.Models.Trainer Trainer { get; set; }
        public List<Sportif.Models.Salon> Salons { get; set; }
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

            Salons=_context.Salons.ToList();

           ViewData["SalonHeader"] = new SelectList(_context.Salons, "Header", "Header");
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

            _context.Attach(Trainer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainerExists(Trainer.ID))
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

        private bool TrainerExists(int id)
        {
            return _context.Trainers.Any(e => e.ID == id);
        }
    }
}
