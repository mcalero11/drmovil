using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Model : IEntity // model of cellphone
    {
        public string ModelName { get; set; }

        public int MarkId { get; set; }
        public int StoreId { get; set; }
    }
}
