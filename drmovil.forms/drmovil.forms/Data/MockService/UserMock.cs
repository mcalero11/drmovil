using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.MockService
{
    public class UserMock : IMockServices<User>
    {
        public List<User> GetList()
        {
            return new List<User> { 
                new User {
                     Username = "MCalero11",
                     Password = "1234",
                     Email = "mjcrequeno@gmail.com",
                     FirstName = "Marvin",
                     LastName = "Calero",
                },
            };
        }
    }
}
