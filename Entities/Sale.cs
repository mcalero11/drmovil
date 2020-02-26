using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Sale : IEntity
    {
        public int Correlative { get; set; }
        public string Comments { get; set; }
        public DateTime Date { get; set; } // in current time zone
        public string Customer { get; set; }
        public int UserId { get; set; }
        public int StoreId { get; set; }
    }
}
