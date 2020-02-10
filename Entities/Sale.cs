using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Sale : IEntity
    {
        public int Correlative { get; set; }
        public int Quantity { get; set; }
        public string Details { get; set; }

        
    }
}
