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
        public string Description { get; set; }

        public string Image { get; set; }
        //{
        //    get
        //    {
        //        if (Image == null)
        //        {
        //            Image = "DefaultTheatre.jpg";
        //            return Image;
        //        }
        //        else
        //        {
        //            return Image;
        //        }
        //    }
        //    set
        //    {
        //        Image = value;
        //    }
        //}

        public virtual ICollection<Review> Reviews { get; set; }

        public Musical()
        {

        }
        public Musical(int id, string title, string genre, string description)
        {
            Id = id;
            Title = title;
            Genre = genre;
            Description = description;
        }
    }
   
}
