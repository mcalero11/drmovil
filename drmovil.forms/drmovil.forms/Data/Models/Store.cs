using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.Models
{
    public class Store : Entities.Store
    {
        [PrimaryKey, AutoIncrement]
        public new int Id { get; set; }

        [Ignore]
        public string GetLocation {
            get
            {
                return $"{this.Department}, {this.Country}";
            }
        }
        
        [Ignore]
        public decimal TodaySales
        {
            get
            {

                return decimal.Parse(new Random().Next(-100, 1).ToString());
            }
        }

        [Ignore]
        public decimal WeekSales
        {
            get
            {

                return decimal.Parse(new Random().Next(100, 700).ToString());
            }
        }
        
        [Ignore]
        public decimal MonthSales
        {
            get
            {

                return decimal.Parse(new Random().Next(800, 2000).ToString());
            }
        }
        
        


    }
}
