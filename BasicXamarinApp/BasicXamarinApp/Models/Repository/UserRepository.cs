using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Android.Graphics;
using App1.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicXamarinApp.Android.Models.Repository
{
    public class UserRepository : IRepository<User>
    {
        public UserRepository(AppContext appContext)
        {
        }


        public List<User> GetAllEntries()
        {
            var userList = new List<User>();
            using (var appContext = new AppContext())
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
            using (var appContext = new AppContext())
            {
                users = appContext.Users.Where(expression).ToList();
            }

            return users;
        }

        public User EditEntity(Expression<Func<User, bool>> expression, User editedUser)
        {
            User user = null;
            using (var appContext = new AppContext())
            {
                user = appContext.Users.Where(expression).FirstOrDefault();
                if (user != null)
                {
                    user.Email = editedUser.Email;
                    user.Issues = editedUser.Issues;
                    user.FirstName = editedUser.FirstName;
                    user.LastName = editedUser.LastName;
                    user.PhoneNumber = editedUser.PhoneNumber;
                }

                appContext.SaveChanges();
            }

            return user;
        }

        public User DeleteEntity(Expression<Func<User, bool>> expression)
        {
            User user = null;
            using (var appContext = new AppContext())
            {
                user = appContext.Users.Where(expression).FirstOrDefault();
                if (user != null)
                {
                    appContext.Users.Remove(user);
                    appContext.SaveChanges();
                }
            }

            return user;
        }

        public void CreateEntity(User newUser)
        {
            using (var appContext = new AppContext())
            {
                appContext.Users.Add(newUser);
                appContext.SaveChanges();
            }

        }
    }
}