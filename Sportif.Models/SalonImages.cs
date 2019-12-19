using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sportif.Models
{
    public class SalonImages
    {
        public int ID { get; set; }
        public string Path { get; set; }
        public int SalonID { get; set; }

        public bool OnSlider { get; set; }

        [ForeignKey("SalonID")]
        public virtual Salon salon { get; set; }
    }
}
