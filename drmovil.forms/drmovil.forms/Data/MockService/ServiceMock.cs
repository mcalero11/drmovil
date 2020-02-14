using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.MockService
{
    public class ServiceMock : IMockServices<Service>
    {
        public List<Service> GetList()
        {
            return new List<Service> { 
                new Service {
                     Name = "Reparación",
                     Description = "Que se repara",
                },
                new Service {
                     Name = "Liberación",
                     Description = "Libera las bandas de red",
                },
                new Service {
                     Name = "Desbloqueo",
                     Description = "Que se desbloquea",
                },
                new Service {
                     Name = "Activación",
                     Description = "Que se activa en el país",
                },

            };
        }
    }
}
