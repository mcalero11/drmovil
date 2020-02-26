using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class SaleDetail : IEntity
    {
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public int SaleId { get; set; }
        public int ProductId { get; set; }
    }
}
