using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.MockService
{
    public class TaskLogMock : IMockServices<TaskLog>
    {
        public List<TaskLog> GetList()
        {
            return new List<TaskLog>();
        }
    }
}
