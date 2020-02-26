using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Task : IEntity // aka work in progress
    {
        public int Correlative { get; set; }
        public string DeviceType { get; set; }
        public string Diagnostic { get; set; }
        public string AdditionalComments { get; set; }
        public bool PublicShare { get; set; } // default true
        public string PublicLink { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Status { get; set; } // use enum TaskStatus


        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public int ModelId { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }

    }
}
