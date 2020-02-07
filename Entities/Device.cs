using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Device : IEntity
    {
        public string Name { get; set; }

        public Store Store { get; set; }
        public int StoreId { get; set; }
    }
}
