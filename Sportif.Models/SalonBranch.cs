using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sportif.Models
{
    public class SalonBranch
    {
        public int ID { get; set; }
        public int SalonID { get; set; }
        [ForeignKey("SalonID")]
        public virtual Salon Salon { get; set; }

        public int BranchID { get; set; }
        [ForeignKey("BranchID")]
        public virtual Branch Branch { get; set; }

    }
}
