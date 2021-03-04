using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repository
{
    public class MusicalRepository : Repository<Musical>
    {

        public MusicalRepository(MusicalContext db) : base(db)
        {
        }
    }
}
