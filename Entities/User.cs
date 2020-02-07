using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User : IEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<Store> Stores { get; set; } // that her is owner

        public List<Role> StoreRoles { get; set; } // that her is a guest
    }
}
