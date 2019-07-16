using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using App1.Model;
using BasicXamarinApp.Models.Repository;
using Microsoft.EntityFrameworkCore;
using AppContext = BasicXamarinApp.Models.AppContext;

namespace BasicXamarinApp.Android.Models.Repository
{
    public class IssueReadRepository : EfReadRepository<Issue>
    {
        public IssueReadRepository(AppContext dbContext, DbSet<Issue> dbSet) : base(dbContext, dbSet)
        {
        }
    }
}