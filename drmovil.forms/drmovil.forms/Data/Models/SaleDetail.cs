﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.Models
{
    public class SaleDetail : Entities.SaleDetail
    {
        [PrimaryKey, AutoIncrement]
        public new int Id { get; set; }
    }
}
