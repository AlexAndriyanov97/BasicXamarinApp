using BasicXamarinApp.Android.Models.Repository;
using BasicXamarinApp.Models.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BasicXamarinApp.Model;
using BasicXamarinApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicXamarinApp.Models.Repository
{
    public class EfReadRepository<TEntity> : DbContext, IRepository<TEntity>
        where TEntity : class, IHaveId<int>
    {

        private AppContext _dbContext;
        
        private DbSet<TEntity> _dbSet;

        public EfReadRepository(AppContext dbContext, DbSet<TEntity> dbSet)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _dbSet = dbSet ?? throw new ArgumentException(nameof(dbSet));
        }

        public async Task<TEntity> DeleteEntityAsync(Expression<Func<TEntity, bool>> expression)
        {
            TEntity entity = null;
            entity = await _dbSet.Where(expression).FirstOrDefaultAsync();
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }

            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IList<TEntity>> GetAllEntriesAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IList<TEntity>> GetEntitiesByExpressionAsync(Expression<Func<TEntity, bool>> expression)
        {
            var users = new List<TEntity>();
            users = await _dbSet.Where(expression).ToListAsync();
            return users;
        }

        public async void SaveEntityAsync(TEntity newEntry)
        {
            var haveEntity = await _dbSet.FirstOrDefaultAsync(x => x.Id == newEntry.Id);
            if (haveEntity == null)
            {
                _dbSet.Add(newEntry);
            }
            else
            {
                _dbSet.Remove(haveEntity);
                _dbSet.Add(newEntry);
            }

            await _dbContext.SaveChangesAsync();
        }

        public async void DeleteEntitiesAsync(Expression<Func<TEntity, bool>> expression)
        {
            
            IList<TEntity> entyties = null;
            entyties = await _dbSet.Where(expression).ToListAsync();
            foreach (var entity in entyties)
            {
                if (entity != null)
                {

                    _dbSet.Remove(entity);
                }
            }

            await _dbContext.SaveChangesAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Vs2015WinFormsEfcSqliteCodeFirst20170304Example.sqlite");
        }
    }
}