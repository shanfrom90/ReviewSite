using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repository
{
    public class ReviewRepository : Repository<Review>
    {
        //private MusicalContext _db;

        public ReviewRepository(MusicalContext db) : base(db)
        {
            //this._db = db;
        }
        //public void Create(Review obj)
        //{
        //    _db.Reviews.Add(obj);
        //    _db.SaveChanges();
        //}

        //public void Delete(Review obj)
        //{
        //    _db.Reviews.Remove(obj);
        //    _db.SaveChanges();
        //}

        //public IEnumerable<Review> GetAll()
        //{
        //    return _db.Reviews.ToList();
        //}

        //public Review GetByID(int id)
        //{
        //    return _db.Reviews.Find(id);
        //}

        //public void Update(Review obj)
        //{
        //    _db.Reviews.Update(obj);
        //    _db.SaveChanges();
        //}
    }
}
