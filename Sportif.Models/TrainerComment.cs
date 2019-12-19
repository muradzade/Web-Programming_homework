using Sportif.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sportif.Models
{
    public class TrainerComment : IComment
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public int TrainerID { get; set; }
        [ForeignKey("TrainerID")]
        public virtual Trainer Trainer { get; set; }
    }
}
