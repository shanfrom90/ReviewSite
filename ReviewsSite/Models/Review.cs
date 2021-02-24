using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public virtual Musical Musical { get; set; }
        public int MusicalId { get; set; }
    }
}
