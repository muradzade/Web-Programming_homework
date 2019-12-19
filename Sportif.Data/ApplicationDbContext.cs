using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sportif.Models;

namespace Sportif.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Branch> Branch { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Salon> Salon { get; set; }
        public DbSet<SalonBranch> SalonBranch { get; set; }
        public DbSet<SalonComment> SalonComment { get; set; }
        public DbSet<SalonImages> SalonImages { get; set; }
        public DbSet<Trainer> Trainer { get; set; }
        public DbSet<TrainerComment> TrainerComment { get; set; }



    }
}
