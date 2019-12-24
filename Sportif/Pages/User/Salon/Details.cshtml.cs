using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sportif.Data;

namespace Sportif.Pages.User.Salon
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public DetailsModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public Sportif.Models.Salon Salon { get; set; }
        public List<Sportif.Models.Trainer> Trainers { get; set; }

        public void OnGet(int id)
        {
            Salon = _db.Salons.FirstOrDefault(s => s.ID == id);
            Trainers = _db.Trainers.Where(t => t.SalonID == id).ToList();
        }
    }
}