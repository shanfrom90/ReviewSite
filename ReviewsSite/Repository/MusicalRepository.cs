using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repository
{
    public class MusicalRepository : IRepository<Musical>
    {
        //public  Db<T> _db;

        //void Create(T obj)
        //{
        //    _db.Add(obj);
        //}
        public void Create(Musical obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Musical obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Musical> GetAll()
        {
            throw new NotImplementedException();
        }

        public Musical GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Musical obj)
        {
            throw new NotImplementedException();
        }
    }
}
