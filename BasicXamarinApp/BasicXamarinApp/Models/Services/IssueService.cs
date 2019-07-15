using System;
using System.Linq.Expressions;
using App1.Model;
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


        public Issue EditEntry(Expression<Func<Issue, bool>> expression,Issue editedIssue)
        {
            return _repository.EditEntity(expression, editedIssue);
        }

        public void CreateEntity(Issue createdIssue)
        {
            _repository.CreateEntity(createdIssue);
        }

        public Issue DeleteEntity(Expression<Func<Issue, bool>> expression)
        {
            return _repository.DeleteEntity(expression);
        }
    }
}