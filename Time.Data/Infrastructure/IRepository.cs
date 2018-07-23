using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Time.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Delete(T entity);

        void Delete(Expression<Func<T, bool>> where);

        T GetById(int id);

        T GetByDayTime(int day, int time);

        IEnumerable<T> GetAll();
    }
}
