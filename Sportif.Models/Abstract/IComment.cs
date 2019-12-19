using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sportif.Models.Abstract
{
    public interface IComment
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

    }
}
