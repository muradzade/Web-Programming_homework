using Microsoft.AspNetCore.Identity;
using Sportif.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sportif.Data
{
    public class CreateUserRoles : ICreateUserRoles
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public CreateUserRoles(ApplicationDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }


        public void AddUserRole()
        {

            if (_db.Roles.Any(r => r.Name == "Admin")) return;

            _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Musteri")).GetAwaiter().GetResult();



            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "AdminM@mail.ru",
                Email = "AdminM@mail.ru",
                EmailConfirmed = true,
                Name = "Murad",
                Surname = "Zade"
            }, "Murad123_").GetAwaiter().GetResult();

            ApplicationUser user = _db.ApplicationUsers.Where
                (u => u.Email == "AdminM@mail.ru").FirstOrDefault();

            _userManager.AddToRoleAsync(user, "Admin").GetAwaiter().GetResult();
        }
    }
}
