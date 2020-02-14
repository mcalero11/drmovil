using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.MockService
{
    public class SaleMock : IMockServices<Sale>
    {
        public List<Sale> GetList()
        {
            return new List<Sale> {
                new Sale{
                    Comments = "Este es un ejemplo 1",
                    Correlative = 0001,
                    Date = DateTime.Now,
                },
                new Sale{
                    Comments = "Este es un ejemplo 2",
                    Correlative = 0002,
                    Date = DateTime.Now,
                },
                new Sale{
                    Comments = "Este es un ejemplo 3",
                    Correlative = 0003,
                    Date = DateTime.Now,
                },

            };
        }
    }
}
