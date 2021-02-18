using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Musical
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public Musical()
        {

        }
        public Musical(int id, string title, string genre)
        {
            Id = id;
            Title = title;
            Genre = genre;
        }
    }
   
}
