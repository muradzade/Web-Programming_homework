using System;
using System.Collections.Generic;
using System.Text;

namespace Sportif.Models
{
    public class Branch
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual ICollection<SalonBranch> SalonBranch { get; set; }
    }
}
