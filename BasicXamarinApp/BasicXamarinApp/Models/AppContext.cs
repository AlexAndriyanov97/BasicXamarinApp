using App1.Model;
using App1.Models;
using BasicXamarinApp.Android.Annotations;
using Microsoft.EntityFrameworkCore;

namespace BasicXamarinApp.Models
{
    public class AppContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        
        public DbSet<Issue> Issues { get; set; }

        public AppContext([NotNull] DbContextOptions options) : base(options)
        {
        }
    }
}