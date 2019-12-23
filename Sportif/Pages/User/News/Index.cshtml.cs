using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sportif.Data;

namespace Sportif.Pages.User.News
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public Sportif.Models.News News { get; set; }
        public void OnGet(int id)
        {
            if (id == 0)
            {
                NotFound();
            }
            News = _db.News.FirstOrDefault(n => n.ID == id);
        }
    }
}