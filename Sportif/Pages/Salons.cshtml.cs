using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sportif.Data;

namespace Sportif
{
    public class SalonsModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public SalonsModel(ApplicationDbContext db)
        {

            _db = db;
        }
        public List<Sportif.Models.Salon> Salons { get; set; }
        public List<Sportif.Models.Salon> SalonFiltered { get; set; }
        public void OnGet(string adres = null)
        {
            Salons = _db.Salons.ToList();

            if (adres == null)
                SalonFiltered = _db.Salons.ToList();
            else
            {
                SalonFiltered = _db.Salons.Where(s => s.Address == adres).ToList();

            }
        }



    }
}