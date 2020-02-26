using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Role : IEntity
    {
        public int RoleType { get; set; } // use enum Roles

        public int UserId { get; set; }
        public int StoreId { get; set; }
    }
}
