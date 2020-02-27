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
                new Store {
                     Name = "Random Store",
                     UserId = 2,
                     Country = "El Salvador",
                     Department = "San Salvador",
                },
                new Store {
                     Name = "Random Store 2",
                     UserId = 2,
                     Country = "El Salvador",
                     Department = "Usulutan",
                },

            };
        }
    }
}
