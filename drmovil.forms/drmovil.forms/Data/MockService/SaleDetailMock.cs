using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.MockService
{
    public class SaleDetailMock : IMockServices<SaleDetail>
    {
        public List<SaleDetail> GetList()
        {
            return new List<SaleDetail> { 
                new SaleDetail{
                     SaleId = 1,
                     ProductName = "Cargador Samsung",
                     Quantity = 1,
                     Price = 5.00M,
                },
                new SaleDetail{
                     SaleId = 1,
                     ProductName = "Audifonos Ezra",
                     Quantity = 1,
                     Price = 5.50M,
                },
                new SaleDetail{
                     SaleId = 1,
                     ProductName = "Protector S9",
                     Quantity = 3,
                     Price = 3.00M,
                },
                new SaleDetail{
                     SaleId = 2,
                     ProductName = "Bocina",
                     Quantity = 1,
                     Price = 10.00M,
                },
                new SaleDetail{
                     SaleId = 3,
                     ProductName = "Vidrio templado",
                     Quantity = 5,
                     Price = 1.00M,
                },

            };
        }
    }
}
