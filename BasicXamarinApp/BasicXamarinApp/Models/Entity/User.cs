using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Model;
using BasicXamarinApp.Models.Entity;

namespace App1.Models
{
    public class User : IHaveId<int>
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Email { get; set; }

        public string Password { get; set; }
        
        public string PhoneNumber { get; set; }
        public ICollection<Issue> Issues { get; set; }

        public User()
        {
            Issues = new List<Issue>();
        }
    }
}
