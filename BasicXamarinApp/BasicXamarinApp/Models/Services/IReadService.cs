using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BasicXamarinApp.Models.Entity;

namespace BasicXamarinApp.Android.Models.Services
{
    public interface IReadService<TEntity>
    {
        Task<IList<TEntity>> LogIn(int id);
    }
}