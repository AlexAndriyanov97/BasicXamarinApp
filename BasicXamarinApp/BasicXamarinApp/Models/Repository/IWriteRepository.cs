using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BasicXamarinApp.Android.Models.Repository
{
    public interface IWriteRepository<TEntity>
    {
        Task<TEntity>  DeleteEntityAsync(Expression<Func<TEntity, bool>> expression);

        void SaveEntityAsync(TEntity newEntry);

        void DeleteEntitiesAsync(Expression<Func<TEntity, bool>> expression);

    }
}