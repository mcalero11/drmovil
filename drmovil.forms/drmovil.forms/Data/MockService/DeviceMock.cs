using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.MockService
{
    public class DeviceMock : IMockServices<Device>
    {
        public List<Device> GetList()
        {
            return new List<Device> { 
                new Device {
                    Name = "Android",
                },
                new Device {
                    Name = "Iphone",
                },
                new Device {
                    Name = "Tablet",
                },
                new Device {
                    Name = "Ipad",
                },

            };
        }
    }
}
