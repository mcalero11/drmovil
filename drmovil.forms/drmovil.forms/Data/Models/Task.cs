using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.Models
{
    public class Task : Entities.Task
    {
        public int StoreId { get; set; }
        public int UserId { get; set; } // worked on
        public int ServiceId { get; set; }
    }
}
