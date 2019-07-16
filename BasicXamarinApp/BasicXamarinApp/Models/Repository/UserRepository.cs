using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Android.Graphics;
using App1.Models;
using BasicXamarinApp.Models.Repository;
using Microsoft.EntityFrameworkCore;
using AppContext = BasicXamarinApp.Models.AppContext;

namespace BasicXamarinApp.Android.Models.Repository
{
    public class UserReadRepository : EfReadRepository<User>
    {
        public UserReadRepository(AppContext dbContext, DbSet<User> dbSet) : base(dbContext, dbSet)
        {
        }
    }
}