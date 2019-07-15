using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BasicXamarinApp.Android.Models.Services
{
    public interface IService<TEntity>
    {
        TEntity EditEntry(Expression<Func<TEntity, bool>> expression,TEntity editedEntity);

        void CreateEntity(TEntity createdEntity);

        TEntity DeleteEntity(Expression<Func<TEntity, bool>> expression);
    }
}