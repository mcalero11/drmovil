using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Role : IEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Store Store { get; set; }
        public int StoreId { get; set; }
        public int RoleType { get; set; } // use enum Roles
    }
}
