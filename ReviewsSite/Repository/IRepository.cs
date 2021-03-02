using ReviewsSite.Extensions;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repository
{
    public interface IRepository<T> : ISelectList where T : class
    {
        void Create(T obj);

        void Update(T obj);

        IEnumerable<T> GetAll();

        T GetByID(int id);

        void Delete(T obj);


    }
}
