using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Android.Graphics;
using App1.Models;

namespace BasicXamarinApp.Android.Models.Repository
{
    public class UserRepository:IRepository<User>
    {        
        public UserRepository(AppContext appContext)
        {
        }


        public List<User> GetAllEntries()
        {
            var userList = new List<User>();
            using(var appContext= new AppContext())
            {
                userList = appContext.Users.ToList();
            }

            return userList;
        }

        public User GetEntryById(int id)
        {
            Expression<Func<User, bool>> expression = user => user.Id == id;
            var foundedUser = GetEntitiesByExpression(expression).FirstOrDefault();
            return foundedUser;
        }


        public List<User> GetEntriesByName(string name)
        {
            
            Expression<Func<User, bool>> expression = user => user.FirstName == name;
            var foundedUsers = GetEntitiesByExpression(expression);
            return foundedUsers;

        }

        public List<User> GetEntitiesByExpression(Expression<Func<User, bool>> expression)
        {
            var users = new List<User>();
            using(var appContext= new AppContext())
            {
                users = appContext.Users.Where(expression).ToList();
            }

            return users;
        }

    }
}