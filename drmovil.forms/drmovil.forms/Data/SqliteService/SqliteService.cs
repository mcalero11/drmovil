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
                // configure tables
                if (!Database.TableMappings.Any(m => m.MappedType.Name == nameof(Data.Models.Device)))
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Models.Device)).ConfigureAwait(false);

                if (!Database.TableMappings.Any(m => m.MappedType.Name == nameof(Data.Models.Product)))
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Models.Product)).ConfigureAwait(false);

                if (!Database.TableMappings.Any(m => m.MappedType.Name == nameof(Data.Models.Role)))
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Models.Role)).ConfigureAwait(false);

                if (!Database.TableMappings.Any(m => m.MappedType.Name == nameof(Data.Models.Sale)))
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Models.Sale)).ConfigureAwait(false);

                if (!Database.TableMappings.Any(m => m.MappedType.Name == nameof(Data.Models.SaleDetail)))
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Models.SaleDetail)).ConfigureAwait(false);

                if (!Database.TableMappings.Any(m => m.MappedType.Name == nameof(Data.Models.Service)))
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Models.Service)).ConfigureAwait(false);

                if (!Database.TableMappings.Any(m => m.MappedType.Name == nameof(Data.Models.Store)))
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Models.Store)).ConfigureAwait(false);

                if (!Database.TableMappings.Any(m => m.MappedType.Name == nameof(Data.Models.Task)))
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Models.Task)).ConfigureAwait(false);

                if (!Database.TableMappings.Any(m => m.MappedType.Name == nameof(Data.Models.User)))
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Models.User)).ConfigureAwait(false);


                initialized = true;
            }
        }

    }
}
