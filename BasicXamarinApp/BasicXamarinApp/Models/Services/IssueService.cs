using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BasicXamarinApp.Model;
using BasicXamarinApp.Android.Models.Repository;

namespace BasicXamarinApp.Android.Models.Services
{
    public class IssueService : IService<Issue>
    {
        private IRepository<Issue> _repository;

        public IssueService(IRepository<Issue> repository)
        {
            _repository = repository;
        }

        public async Task<IList<Issue>> LogIn(int id)
        {
            return await _repository.GetEntitiesByExpressionAsync(x => x.UserId == id);
        }

        public void LogOut(int id)
        {
            _repository.DeleteEntitiesAsync(x => x.UserId == id);
        }
    }
}