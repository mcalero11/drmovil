using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drmovil.api.Models
{
    public class Customer : Entities.Customer
    {
        public Store Store { get; set; }
    }
}
