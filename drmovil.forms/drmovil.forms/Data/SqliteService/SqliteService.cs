using drmovil.forms.Data.Extensions;
using SQLite;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace drmovil.forms.Data.SqliteService
{
    public class SqliteService 
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.Constants.DatabasePath, Constants.Constants.FlagsSqlite);
        });
        
        private static SQLiteAsyncConnection Database => lazyInitializer.Value;
        
        static bool initialized = false;

        public SqliteService()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == nameof(Data.Models.Sale)))
                {
                    // configure tables
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Models.Sale)).ConfigureAwait(false);


                    initialized = true;
                }
            }
        }

    }
}
