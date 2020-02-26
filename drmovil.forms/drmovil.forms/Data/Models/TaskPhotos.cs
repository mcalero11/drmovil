using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.Models
{
    public class TaskPhotos : Entities.TaskPhotos
    {
        [PrimaryKey, AutoIncrement]
        public new int Id { get; set; }
    }
}
