using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Service : IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Store Store { get; set; }
        public int StoreId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; } // Created by
    }
}
