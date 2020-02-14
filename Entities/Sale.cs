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

    }
}
