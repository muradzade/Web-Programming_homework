using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sportif.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public int BranchID { get; set; }

        [ForeignKey("BranchID")]
        public virtual Branch Branch { get; set; }
    }
}
