using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.Models
{
    public class Device : Entities.Device
    {
        [PrimaryKey, AutoIncrement]
        public new int Id { get; set; }
    }
}
