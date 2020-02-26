using System.Collections.Generic;

namespace drmovil.api.Models
{
    public class Sale : Entities.Sale
    {
        public List<SaleDetail> SaleDetails { get; set; }
        public Store Store { get; set; }
        public User User { get; set; } // seller
    }
}
