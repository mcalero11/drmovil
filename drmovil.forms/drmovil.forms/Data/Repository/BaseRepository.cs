using drmovil.forms.Data.ApiService;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static drmovil.forms.Data.Constants.Constants;

namespace drmovil.forms.Data.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : Entities.IEntity
    {
        internal SQLiteAsyncConnection _sqliteConnection { get; set; }

        public BaseRepository(SQLiteAsyncConnection sqliteConnection)
        {
            _sqliteConnection = sqliteConnection;
            ActionSync = new Dictionary<ActionSyncEnum, T>();
        }

        internal IDictionary<ActionSyncEnum, T> ActionSync { get; set; }

        public abstract Task<bool> AddAsync(T entity);

        public abstract Task<bool> DeleteAsync(T entity);

        public abstract Task<T> FindByIdAsync(int Id);

        public abstract Task<bool> UpdateAsync(T entity);

        public async Task<bool> SyncGlobally()
        {
            if (ActionSync?.Count == 0) return true;

            BaseApi rest = new BaseApi();
            var obj = await rest.Post<object, object>(null, "Sync");

            return false;
        }
    }
}
