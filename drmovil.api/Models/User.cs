using System.Collections.Generic;

namespace drmovil.api.Models
{
    public class User : Entities.User
    {
        public List<Store> Stores { get; set; } // that is owner

        public List<Role> StoreRoles { get; set; } // that is a guest
    }
}
