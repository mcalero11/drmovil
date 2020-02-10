using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Product : IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public bool IsInventoryTracking { get; set; }
        public int InventoryQuantity { get; set; }

        
    }
}
