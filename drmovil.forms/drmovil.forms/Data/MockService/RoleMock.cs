using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.MockService
{
    public class RoleMock : IMockServices<Role>
    {
        public List<Role> GetList()
        {
            return new List<Role> { 
            
            };
        }
    }
}
