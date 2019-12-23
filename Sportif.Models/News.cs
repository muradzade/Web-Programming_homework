using System;
using System.Collections.Generic;
using System.Text;

namespace Sportif.Models
{
    public class News
    {
        public int ID { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
