using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Android.Graphics;

namespace BasicXamarinApp.Android.Models.Repository
{
    public interface IRepository<TEntity>
    {
        IList<TEntity> GetAllEntries();

        List<TEntity> GetEntitiesByExpression(Expression<Func<TEntity, bool>> expression);

        TEntity DeleteEntity(Expression<Func<TEntity, bool>> expression);
        
        void SaveEntity(TEntity newEntry);
    }
}