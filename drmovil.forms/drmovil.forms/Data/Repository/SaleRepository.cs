using Entities;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static drmovil.forms.Data.Constants.Constants;

namespace drmovil.forms.Data.Repository
{
    public class SaleRepository : BaseRepository<Sale>
    {

        public SaleRepository(SQLiteAsyncConnection sqliteConnection) : base(sqliteConnection)
        {
        }

        public override async Task<bool> AddAsync(Sale entity)
        {
            int id = await _sqliteConnection.InsertAsync(entity);
            if (id > 0)
            {
                ActionSync.Add(ActionSyncEnum.Create, entity);
                return true;
            }
            return false;
        }

        public override async Task<bool> DeleteAsync(Sale entity)
        {
            int rows = await _sqliteConnection.DeleteAsync(entity);
            if (rows > 0)
            {
                ActionSync.Add(ActionSyncEnum.Delete, entity);
                return true;
            }
            return false;
        }

        public override async Task<Sale> FindByIdAsync(int id)
        {
            return await _sqliteConnection.Table<Sale>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public override async Task<bool> UpdateAsync(Sale entity)
        {
            int rows = await _sqliteConnection.UpdateAsync(entity);
            if (rows > 0)
            {
                ActionSync.Add(ActionSyncEnum.Update, entity);
                return true;
            }
            return false;
        }
    }
}
