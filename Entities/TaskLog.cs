using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class TaskLog : IEntity
    {
        public int PreviousStatus { get; set; }
        public int NextStatus { get; set; }
        public DateTime Date { get; set; }
        public string Comments { get; set; }

        public int TaskId { get; set; }
    }
}
