using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drmovil.api.Models
{
    public class Mark : Entities.Mark
    {
        public Store Store { get; set; }
        public int StoreId { get; set; }
    }
}
