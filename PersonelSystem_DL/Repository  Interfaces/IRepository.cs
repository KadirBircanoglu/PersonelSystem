using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSystem_DL.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> List();

        void Insert(T p);

        // Silinecek veya güncellenecek veriyi önce bulmak lazım.
        T Get(Expression<Func<T,bool>> filter);
        void Delete(T p);
        void Update(T p);

        // Şartlı listeleme , filtreleme
        // exp:İsmi Kadir olanları getir
        List<T> List(Expression<Func<T,bool>> filter);
    }
}
