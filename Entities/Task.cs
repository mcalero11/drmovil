using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Task : IEntity // aka work in progress
    {
        public int Correlative { get; set; }
        public string DeviceType { get; set; }
        public string Diagnostic { get; set; }
        public string AdditionalComments { get; set; }
        public bool PublicShare { get; set; } // default true

        //public List<string> PhotosName { get; set; }
        public int Status { get; set; } // use enum TaskStatus

        

    }
}
