using System;
using System.Linq.Expressions;
using App1.Models;
using BasicXamarinApp.Android.Models.Repository;

namespace BasicXamarinApp.Android.Models.Services
{
    public class UserService : IService<User>
    {
        private IRepository<User> _repository;
        
        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }


        public User EditEntry(Expression<Func<User, bool>> expression, User editedEntity)
        {
            return _repository.EditEntity(expression, editedEntity);
        }

        public void CreateEntity(User createdEntity)
        {
            _repository.CreateEntity(createdEntity);
        }

        public User DeleteEntity(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}