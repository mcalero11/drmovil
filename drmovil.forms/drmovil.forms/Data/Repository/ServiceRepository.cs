using Work = drmovil.forms.Data.Models.Task;
using Task = System.Threading.Tasks.Task;
using System.Collections.Generic;
using drmovil.forms.Data.Models;

namespace drmovil.forms.Data.Repository
{
    public class ServiceRepository<T> : Repository<T> where T : Work, new()
    {
        public IList<Work> GetTasksByStore(Store store)
        {
            var lst = connection.Table<Work>().Where(x => x.StoreId == store.Id).ToList();

            return lst;
        }
    }
}
