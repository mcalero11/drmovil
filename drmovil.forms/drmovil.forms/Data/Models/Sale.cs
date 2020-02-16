using SQLite;
using System;

namespace drmovil.forms.Data.Models
{
    public class Sale : Entities.Sale
    {
        [PrimaryKey, AutoIncrement]
        public new int Id { get; set; }
        
        [Ignore]
        public int DetailCount { 
            get
            {
                return new Random().Next(1,10);
            }
        }

        [Ignore]
        public decimal TotalPrice { 
            get
            {
                
                return decimal.Parse(new Random().Next(1,100).ToString());
            }
        }


    }
}
