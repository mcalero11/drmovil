using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.Models
{
    public class Store : Entities.Store
    {
        public int UserId { get; set; } // owner
    }
}
