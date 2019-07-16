using BasicXamarinApp.Model;
using BasicXamarinApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicXamarinApp.Models
{
    public class AppContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        
        public DbSet<Issue> Issues { get; set; }

        public AppContext( DbContextOptions options) : base(options)
        {
        }
    }
}