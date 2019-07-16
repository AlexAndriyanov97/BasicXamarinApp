using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using App1.Models;
using BasicXamarinApp.Android.Models.Repository;

namespace BasicXamarinApp.Android.Models.Services
{
    public class UserService : IService<User>
    {
        private IRepository<User> _repository; 
        
        public UserService(IRepository<User> service)
        {
            _repository = service;
        }

        public async void LogOut(int id)
        {
            await _repository.DeleteEntityAsync(x => true);
        }

        public async Task<IList<User>> LogIn(int id)
        {
            return await _repository.GetEntitiesByExpressionAsync(x => x.Id == id);
        }
    }
}