using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Musical
    {
        private string _image;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        [Display(Name = "Image url:")]
        public string Image 
        {
            get
            {
                return _image;
            }
            set
            {

                if (String.IsNullOrEmpty(value))
                {
                    _image = "/Images/DefaultTheatre.jpg";
                }
                else
                {
                    //return Image;
                    _image = value;
                }
            }
        }

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
