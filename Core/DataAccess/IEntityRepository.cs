using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : BaseEntity, new()
    {
        T GetById(Expression<Func<T, bool>> filter);
        List<T> GetAll();
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
