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

        public List<SaleDetail> SaleDetails { get; set; }
        public Store Store { get; set; }
        public int StoreId { get; set; }
        public User User { get; set; } // seller
        public int UserId { get; set; }
    }
}
