using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sportif.Models
{
    public class Trainer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Biography { get; set; }
        public string Contacts { get; set; }

        public int BranchID { get; set; }
        [ForeignKey("BranchID")]
        public virtual Branch Branch { get; set; }

        public int SalonID { get; set; }
        [ForeignKey("SalonID")]
        public virtual Salon Salon { get; set; }

        public virtual ICollection<TrainerComment> TrainerComments { get; set; }
    }
}
