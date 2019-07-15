using App1.Model;
using App1.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicXamarinApp.Android.Models
{
    public class AppContext:DbContext
    {
        
        public DbSet<User> Users { get; set; }

        public DbSet<Issue> Issues { get; set; }

        public AppContext():base("DbConnection")
        {
        }
    }
}