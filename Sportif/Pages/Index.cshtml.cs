using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Sportif.Data;
using Sportif.Models;

namespace Sportif.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _db;
        
        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }


        public List<Event> Events { get; set; }
        public List<News> News { get; set; }
        public List<Salon> Salons { get; set; }
        public void OnGet()
        {
            Events = _db.Events
                .OrderByDescending(d=>d.Date)
                .Take(3)
                .ToList();
            News = _db.News.Take(3)
                .OrderByDescending(d => d.Date)
                .Take(3)
                .ToList();
            Salons = _db.Salons.Where(s => s.IsSlider == true)
                .ToList();
        }
    }
}
