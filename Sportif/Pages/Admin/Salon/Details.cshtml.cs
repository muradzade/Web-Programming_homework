using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sportif.Data;
using Sportif.Models;

namespace Sportif.Pages.Admin.Salon
{
    public class DetailsModel : PageModel
    {
        private readonly Sportif.Data.ApplicationDbContext _context;

        public DetailsModel(Sportif.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
