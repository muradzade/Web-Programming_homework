using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sportif.Data;
using Sportif.Models;

namespace Sportif.Pages.User.Home
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Sportif.Models.Event> Events { get; set; }
        public List<Sportif.Models.News> News { get; set; }
        public List<Sportif.Models.Salon> Salons { get; set; }
        public void OnGet()
        {
            Events = _db.Events.ToList();
            News = _db.News.ToList();
            Salons = _db.Salons.Where(s=>s.IsSlider==true)
                .ToList();
        }
    }
}