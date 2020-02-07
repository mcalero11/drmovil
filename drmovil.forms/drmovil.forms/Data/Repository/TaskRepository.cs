using SQLite;
using System;
using System.Threading.Tasks;
using Work = drmovil.forms.Data.Models.Task;

namespace drmovil.forms.Data.Repository
{
    public class TaskRepository : BaseRepository<Work>
    {
        public TaskRepository(SQLiteAsyncConnection sqliteConnection) : base(sqliteConnection)
        {
        }

        public override Task<bool> AddAsync(Work entity)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteAsync(Work entity)
        {
            throw new NotImplementedException();
        }

        public override Task<Work> FindByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> UpdateAsync(Work entity)
        {
            throw new NotImplementedException();
        }
    }
}
