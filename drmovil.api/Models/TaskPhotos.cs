using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drmovil.api.Models
{
    public class TaskPhotos : Entities.TaskPhotos
    {
        public Task Task { get; set; }
    }
}
