using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.MockService
{
    public class ProductMock : IMockServices<Product>
    {
        public List<Product> GetList()
        {
            return new List<Product> { 
                new Product {
                    Name = "Producto 1",
                    Description = "Description 1",
                },
                new Product {
                    Name = "Producto 2",
                    Description = "Description 2",
                },
                new Product {
                    Name = "Producto 3",
                    Description = "Description 3",
                },

            };
        }
    }
}
