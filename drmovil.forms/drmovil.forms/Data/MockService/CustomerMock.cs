using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.MockService
{
    public class CustomerMock : IMockServices<Customer>
    {
        public List<Customer> GetList()
        {
            return new List<Customer> { };
        }
    }
}
