using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.Models
{
    public class Model : Entities.Model
    {
        [PrimaryKey, AutoIncrement]
        public new int Id { get; set; }
    }
}
