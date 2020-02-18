using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drmovil.api.Models
{
    public class Model : Entities.Model
    {
        public Store Store { get; set; }
        public int StoreId { get; set; }

        public Mark Mark { get; set; }
        public int MarkId { get; set; }
    }
}
