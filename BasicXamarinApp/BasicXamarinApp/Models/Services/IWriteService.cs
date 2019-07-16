using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BasicXamarinApp.Android.Models.Services
{
    public interface IWriteService<TEntity>
    {
        void LogOut(int id);
    }
}