using System.Collections.Generic;

namespace drmovil.api.Models
{
    public class Task : Entities.Task
    {
        public Store Store { get; set; }

        public User User { get; set; }

        public Service Service { get; set; }

        public Model Model { get; set; }

        public Customer Customer { get; set; }

        public List<TaskLog> TaskLogs { get; set; }
        public List<TaskPhotos> TaskPhotos { get; set; }
    }
}
