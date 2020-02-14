using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.MockService
{
    public interface IMockServices<T> where T : Entities.IEntity
    {
        List<T> GetList();
    }
}
