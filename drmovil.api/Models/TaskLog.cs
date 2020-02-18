using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drmovil.api.Models
{
    public class TaskLog : Entities.TaskLog
    {
        public Task Task { get; set; }
        public int TaskId { get; set; }
    }
}
