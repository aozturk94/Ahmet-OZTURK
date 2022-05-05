using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLessonApp.Models.Abstract
{
    interface IRepository<T> where T:class, new()
    {
        void Add(T entity);
        T GetSingle(int id);
        List<T> GetAll();
        void Update(T entity);
        void Delete(T entity);
    }
}
