using System.Collections.Generic;
using System.Linq;
using App1.Models;
using Java.IO;

namespace BasicXamarinApp.Android.Models.Repository
{
    public class UserRepository
    {        
        public UserRepository(AppContext appContext)
        {
        }


        public List<User> GetAllUsers()
        {
            var userList = new List<User>();
            using(AppContext appContext= new AppContext())
            {
                userList = appContext.Users.ToList();
            }

            return userList;
        }

        public User GetUserById(int id)
        {
            User user = null;
            using(AppContext appContext= new AppContext())
            {
                user= appContext.Users.FirstOrDefault(x => x.Id == id);
            }

            return user;
        }


        public List<User> GetUsersByName(string name)
        {
            var users = new List<User>();
            using(AppContext appContext= new AppContext())
            {
                users = appContext.Users.Where(x => x.FirstName == name).ToList();
            }

            return users;
        }

        public User GetUserByEmail(string email)
        {
            User user = null;
            using(AppContext appContext= new AppContext())
            {
                user = appContext.Users.FirstOrDefault(x=>x.Email==email);
            }

            return user;
        }
        
        public User GetUserByPhoneNumber(string phoneNumber)
        {
            User user = null;
            using(AppContext appContext= new AppContext())
            {
                user = appContext.Users.FirstOrDefault(x=>x.PhoneNumber==phoneNumber);
            }
            return user;
        }

    }
}