using App1.Model;
using App1.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace BasicXamarinApp.Android.Models
{
    public class AppContext:DbContext
    {
        
        public DbSet<User> Users { get; set; }

        public DbSet<Issue> Issues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Vs2015WinFormsEfcSqliteCodeFirst20170304Example.sqlite");
        }
    }
    
}