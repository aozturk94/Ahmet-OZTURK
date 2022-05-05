using Microsoft.EntityFrameworkCore;
using StudentLessonApp.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLessonApp.Models.Concrete
{

    public class BaseRepository<T> : IRepository<T> where T: class, new()
    {
        public void Add(T entity)
        {
            using (var context = new StudentLessonAppDbContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }

        }
        public void Delete(T entity)
        {
            using (var context = new StudentLessonAppDbContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }
        public List<T> GetAll()
        {
            using (var context = new StudentLessonAppDbContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public T GetSingle(int id)
        {
            using (var context = new StudentLessonAppDbContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public void Update(T entity)
        {
            using (var context = new StudentLessonAppDbContext())
            {
                context.Update(entity).State = EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
