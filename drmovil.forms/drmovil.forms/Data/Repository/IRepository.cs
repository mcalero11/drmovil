using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace drmovil.forms.Data.Repository
{
    public interface IRepository<T> : IDisposable
    {

        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        T FindById(int Id);
        IList<T> GetFirst(int rows = 0);
    }
}
