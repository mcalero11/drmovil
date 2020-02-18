using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.MockService
{
    public class MarkMock : IMockServices<Mark>
    {
        public List<Mark> GetList()
        {
            return new List<Mark> { 
                new Mark {
                     MarkName = "Samsung",
                },
                new Mark {
                     MarkName = "Huawei",
                },
                new Mark {
                     MarkName = "Iphone",
                },

            };
        }
    }
}
