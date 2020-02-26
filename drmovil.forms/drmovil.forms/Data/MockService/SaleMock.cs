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
                    UserId = 1,
                    StoreId = 1,
                    Comments = "Este es un ejemplo 1",
                    Correlative = 0001,
                    Date = DateTime.Now,
                    Customer = "Varios",
                },
                new Sale{
                    UserId = 1,
                    StoreId = 1,
                    Comments = "Este es un ejemplo 2",
                    Correlative = 0002,
                    Date = DateTime.Now,
                    Customer = "Juan Pérez",
                },
                new Sale{
                    Id = 20,
                    UserId = 1,
                    StoreId = 2,
                    Comments = "Este es un ejemplo 3",
                    Correlative = 0003,
                    Date = DateTime.Now,
                    Customer = "Sonia Bonilla",
                },

            };
        }
    }
}
