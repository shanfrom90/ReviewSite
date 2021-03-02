using ReviewsSite.Models;
using System.Collections.Generic;
using System.Linq;

namespace ReviewsSite.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private MusicalContext _db;

        public Repository(MusicalContext db)
        {
            this._db = db;
        }
        public void Create(T obj)
        {
            _db.Set<T>().Add(obj);
            _db.SaveChanges();
        }

        public void Delete(T obj)
        {
            _db.Set<T>().Remove(obj);
            _db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public void Update(T obj)
        {
            _db.Set<T>().Update(obj);
            _db.SaveChanges();

        }

         public List<Musical> PopulateMusicalList()
        {
            return _db.Set<Musical>().ToList();
        }
    }
}
