using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Customer : IEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
