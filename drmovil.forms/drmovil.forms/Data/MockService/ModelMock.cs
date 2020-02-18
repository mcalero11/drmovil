using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.MockService
{
    public class ModelMock : IMockServices<Model>
    {
        public List<Model> GetList()
        {
            return new List<Model> { 
                new Model{
                     ModelName = "Galaxy S7",
                },
                new Model{
                     ModelName = "Galaxy Note 9",
                },
                new Model{
                     ModelName = "P30 Pro",
                },
                new Model{
                     ModelName = "Y9",
                },
                new Model{
                     ModelName = "6 Plus",
                },

            };
        }
    }
}
