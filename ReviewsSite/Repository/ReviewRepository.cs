using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repository
{
    public class ReviewRepository : Repository<Review>
    {

        public ReviewRepository(MusicalContext db) : base(db)
        {
        }
    }
}
