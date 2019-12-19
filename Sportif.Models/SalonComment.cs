using Sportif.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sportif.Models
{
    public class SalonComment : IComment
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public int SalonID { get; set; }
        [ForeignKey("SalonID")]
        public virtual Salon Salon { get; set; }

    }
}
