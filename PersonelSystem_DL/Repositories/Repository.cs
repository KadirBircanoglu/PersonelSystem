using PersonelSystem_DL.Abstract;
using PersonelSystem_DL.ContextInfo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSystem_DL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {

        MyContext context = new MyContext();
        DbSet<T> _object;

        public Repository()
        {
            _object = context.Set<T>();
        }


        public void Delete(T p)
        {
            _object.Remove(p);
            context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter); // Belirtilen koşulu sağlayan tek değeri döndürür.
                                                    // Belirtilen değeri birden çok öğe sağlıyorsa hata fırlatır.
        }

        public void Insert(T p)
        {
            _object.Add(p);
            context.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var updatedEntity= context.Entry(p);
            if (updatedEntity != null)
            {
                updatedEntity.State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}
