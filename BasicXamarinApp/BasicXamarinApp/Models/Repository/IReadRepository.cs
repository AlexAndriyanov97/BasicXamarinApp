using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Android.Graphics;

namespace BasicXamarinApp.Android.Models.Repository
{
    public interface IReadRepository<TEntity>
    {
        Task<IList<TEntity>> GetAllEntriesAsync();

        Task<IList<TEntity>> GetEntitiesByExpressionAsync(Expression<Func<TEntity, bool>> expression);
    }
}