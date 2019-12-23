using System;
using System.Collections.Generic;
using System.Text;

namespace Sportif.Models
{
    public class Salon
    {
        public int ID { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public virtual ICollection<SalonImages> SalonImages { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
        public virtual ICollection<SalonComment> SalonComments { get; set; }
    }
}
