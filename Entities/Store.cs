using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Store : IEntity
    {
        public string Name { get; set; }
        public string ImageName { get; set; }

        public User User { get; set; }
        public int UserId { get; set; } // Owner

        public List<Role> UserRoles { get; set; } // Employees
    }
}
