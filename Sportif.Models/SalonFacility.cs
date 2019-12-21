using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sportif.Models
{
    public class SalonFacility
    {
        public int ID { get; set; }

        public int SalonID { get; set; }
        [ForeignKey("SalonID")]
        public virtual Salon Salon { get; set; }

        public int FacilityID { get; set; }
        [ForeignKey("FacilityID")]
        public virtual Facility Facility { get; set; }
    }
}
