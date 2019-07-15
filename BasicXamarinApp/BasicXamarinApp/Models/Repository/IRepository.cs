using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Android.Graphics;

namespace BasicXamarinApp.Android.Models.Repository
{
    public interface IRepository<TEntity>
    {
        List<TEntity> GetAllEntries();

        TEntity GetEntryById(int id);

        List<TEntity> GetEntriesByName(string name);

        List<TEntity> GetEntitiesByExpression(Expression<Func<TEntity, bool>> expression);

    }
}