using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sportif.Data;
using Sportif.Models;

namespace Sportif.Pages.Admin.Trainer
{
    public class CreateModel : PageModel
    {
        private readonly Sportif.Data.ApplicationDbContext _context;

        public CreateModel(Sportif.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["SalonID"] = new SelectList(_context.Salons, "ID", "Header");
            return Page();
        }

        [BindProperty]
        public Sportif.Models.Trainer Trainer { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Trainers.Add(Trainer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
