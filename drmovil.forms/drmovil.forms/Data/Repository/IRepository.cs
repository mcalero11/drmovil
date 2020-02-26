using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace drmovil.forms.Data.Repository
{
    public interface IRepository<T> : IDisposable
    {
        #region Async Methods
        Task<bool> AddAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<T> FindByIdAsync(int Id);
        Task<IList<T>> GetFirstAsync(int rows);
        #endregion

        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        T FindById(int Id);
        IList<T> GetFirst(int rows);
    }
}
