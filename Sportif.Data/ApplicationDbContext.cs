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

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Salon> Salons { get; set; }
        public DbSet<SalonComment> SalonComments { get; set; }
        public DbSet<SalonImages> SalonImages { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<TrainerComment> TrainerComments { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<SalonFacility> SalonFacilities { get; set; }


    }
}
