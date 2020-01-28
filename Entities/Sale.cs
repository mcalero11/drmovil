using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ReferenceNumber { get; set; }
        public DateTime DateTime { get; set; }
        public int Quantity { get; set; }
    }
}
