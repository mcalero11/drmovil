using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class TaskPhotos : IEntity
    {
        public string PhotoName { get; set; }

        public int TaskId { get; set; }
    }
}
