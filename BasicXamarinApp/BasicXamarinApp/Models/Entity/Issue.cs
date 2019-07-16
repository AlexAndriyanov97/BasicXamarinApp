using System;
using System.Collections.Generic;
using BasicXamarinApp.Models;
using BasicXamarinApp.Models.Entity;

namespace BasicXamarinApp.Model
{
    public class Issue : IHaveId<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Deadline { get; set; }
            
        public int? UserId { get; set; }

        public User User { get; set; }
    }
}