using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.MockService
{
    public class StoreMock : IMockServices<Store>
    {
        public List<Store> GetList()
        {
            return new List<Store> { 
                new Store {
                     Name = "DrMovil San Miguel",
                     UserId = 1,
                     Country = "El Salvador",
                     Department = "San Miguel",
                },
                new Store {
                     Name = "DrMovil Chinameca",
                     UserId = 1,
                     Country = "El Salvador",
                     Department = "Chinameca",
                },

            };
        }
    }
}
