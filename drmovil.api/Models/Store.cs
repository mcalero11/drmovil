using System.Collections.Generic;

namespace drmovil.api.Models
{
    public class Store : Entities.Store
    {
        public User User { get; set; }
        public int UserId { get; set; } // Owner

        public List<Role> UserRoles { get; set; } // Employees
    }
}
