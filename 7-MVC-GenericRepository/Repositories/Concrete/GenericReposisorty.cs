using _7_MVC_GenericRepository.AppDbContext;
using _7_MVC_GenericRepository.Entities.Abstract;
using _7_MVC_GenericRepository.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _7_MVC_GenericRepository.Repositories.Concrete
{
    public class GenericReposisorty<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext db;

        public GenericReposisorty(ApplicationDbContext db)
        {
            this.db = db;
        }

        public bool Add(T entity)
        {
            try
            {
                db.Set<T>().Add(entity);
                return db.SaveChanges() > 0;
            }
            catch 
            {

                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                db.Set<T>().Remove(entity);
                return db.SaveChanges() > 0;
            }
            catch 
            {

                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>();
        }

        public T GetById(int id)
        {
            return db.Set<T>().FirstOrDefault(a => a.Id == id);
            // return db.Set<T>().Find(id);
        }

        public IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>().Where(predicate);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>().SingleOrDefault(predicate);
        }

        public bool Update(T entity)
        {
            try
            {
                //Update metodu içine gönderilen entity'de update varsa ilgili id'deki yapıyı update eder, id yok ise add gibi çalışır. Bu sebeple bir AddOrUpdate metodu oluşturulabilir.
                db.Set<T>().Update(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
