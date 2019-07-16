using BasicXamarinApp.Android.Models.Repository;
using BasicXamarinApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BasicXamarinApp.Models.Repository
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class, IHaveId<int>
    {
        private DbContext _dbcontex;

        private DbSet<TEntity> _dbSet;

        public EfRepository()
        {
            
        }

        public TEntity DeleteEntity(Expression<Func<TEntity, bool>> expression)
        {
            TEntity entity = null;
            using (var appContext = new AppContext())
            {
                entity = _dbSet.Where(expression).FirstOrDefault();
                if (entity != null)
                {
                    appContext.Users.Remove(entity);
                    appContext.SaveChanges();
                }
            }

            return entity;
        }

        public IList<TEntity> GetAllEntries()
        {
            return _dbSet.ToList();
        }

        public List<TEntity> GetEntitiesByExpression(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void SaveEntity(TEntity newEntry)
        {
            throw new NotImplementedException();
        }
    }
}
