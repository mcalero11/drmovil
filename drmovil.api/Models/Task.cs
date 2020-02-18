using System.Collections.Generic;

namespace drmovil.api.Models
{
    public class Task : Entities.Task
    {
        public Store Store { get; set; }
        public int StoreId { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public Service Service { get; set; }
        public int ServiceId { get; set; }

        public Model Model { get; set; }
        public int ModelId { get; set; }

        public List<TaskLog> TaskLogs { get; set; }
        public List<TaskPhotos> TaskPhotos { get; set; }
    }
}
