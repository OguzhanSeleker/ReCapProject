using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : BaseEntity, new()
        where TContext : DbContext, new()
    {
        public bool Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                var result = context.SaveChanges();
                return result > 0 ? true : false;
               
            }
        }

        public bool Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                entity.ModifiedDate = DateTime.Now;
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Modified;
                var result = context.SaveChanges();
                return result > 0 ? true : false;
            }
        }

        public List<TEntity> GetAll()
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Where(t => t.IsDeleted == false).ToList();
            }
        }


        public TEntity GetById(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Where(t => t.IsDeleted == false).SingleOrDefault(filter);
            }
        }

        public bool Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Modified;
                var result = context.SaveChanges();
                return result > 0 ? true : false;
            }
        }
    }
}
