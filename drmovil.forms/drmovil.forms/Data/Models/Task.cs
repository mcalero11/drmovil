using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.Models
{
    public class Task : Entities.Task
    {
        [PrimaryKey, AutoIncrement]
        public new int Id { get; set; }

        public string GetModelAndMark
        {
            get
            {
                return "Samsung Galaxy S10 +";
            }
        }
    }
}
