using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.MockService
{
    public class TaskPhotosMock : IMockServices<TaskPhotos>
    {
        public List<TaskPhotos> GetList()
        {
            return new List<TaskPhotos>();
        }
    }
}
