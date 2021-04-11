using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Display (Name = "Review:")]
        public string Content { get; set; }
        [Display (Name = "Number of Stars:")]
        public int Rating { get; set; }
        public virtual Musical Musical { get; set; }
        [Display (Name = "Select Musical")]
        public int MusicalId { get; set; }
    
    
   public Review(string content, int rating)
        {
            Content = content;
            Rating = rating;
        }

    public Review()
        {

        }
    }

    
}
