using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repository
{
    public class MusicalRepository : Repository<Musical>
    {
        //public  Db<T> _db;

        //void Create(T obj)
        //{
        //    _db.Add(obj);
        //}
        //private MusicalContext _db;

        public MusicalRepository(MusicalContext db) : base(db)
        {
            //this._db = db;
        }
        //public void Create(Musical obj)
        //{
        //    _db.Musicals.Add(obj);
        //    _db.SaveChanges();
        //}

        //public void Delete(Musical obj)
        //{
        //    _db.Musicals.Remove(obj);
        //    _db.SaveChanges();
        //}

        //public IEnumerable<Musical> GetAll()
        //{
        //    return _db.Musicals.ToList();
        //}

        //public Musical GetByID(int id)
        //{
        //    return _db.Musicals.Find(id);

        //}

        //public void Update(Musical obj)
        //{
        //    _db.Musicals.Update(obj);
        //    _db.SaveChanges();

        //}
    }
}
