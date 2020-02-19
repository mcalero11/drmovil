using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Store : IEntity
    {
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string TimeZone { get; set; }
        public string Country { get; set; }
        public string Department { get; set; }

    }
}
