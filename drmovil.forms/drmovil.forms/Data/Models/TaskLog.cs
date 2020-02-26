using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.Models
{
    public class TaskLog : Entities.TaskLog
    {
        [PrimaryKey, AutoIncrement]
        public new int Id { get; set; }
    }
}
