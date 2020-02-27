using drmovil.forms.Data.MockService;
using drmovil.forms.Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Task = System.Threading.Tasks.Task;
using Work = drmovil.forms.Data.Models.Task;

namespace drmovil.forms.Data.SqliteService
{
    public class SqliteService
    {

        public SqliteService()
        {

        }

        public SQLiteConnection GetConnection()
        {
            SQLiteConnection connection = new SQLiteConnection(Constants.Constants.DatabasePath, Constants.Constants.FlagsSqlite);
            
            return connection;
        }

        public SQLiteAsyncConnection GetAsyncConnection()
        {
            SQLiteAsyncConnection connection = new SQLiteAsyncConnection(Constants.Constants.DatabasePath, Constants.Constants.FlagsSqlite);

            return connection;
        }

        public void CreateTables()
        {
            var connection = GetConnection();

            SQLite.TableMapping map = new TableMapping(typeof(SqliteService));
            object[] args = new object[0];

            int count = connection.Query(map, "SELECT * FROM sqlite_master WHERE type = 'table'", args).Count;

            if (count == 0)
            {
                connection.EnableWriteAheadLogging();
            }
            connection.CreateTable<Device>();
            connection.CreateTable<Product>();
            connection.CreateTable<Role>();
            connection.CreateTable<Sale>();
            connection.CreateTable<SaleDetail>();
            connection.CreateTable<Service>();
            connection.CreateTable<Store>();
            connection.CreateTable<Work>();
            connection.CreateTable<User>();
            connection.CreateTable<Mark>();
            connection.CreateTable<Model>();
            connection.CreateTable<TaskLog>();
            connection.CreateTable<TaskPhotos>();
            connection.CreateTable<Customer>();

            if (count == 0)
            {
                InitializeData(connection);
            }

            connection.Dispose();
        }

        public async Task CreateTablesAsync()
        {
            var connection = GetAsyncConnection();

            SQLite.TableMapping map = new TableMapping(typeof(SqliteService));
            object[] args = new object[0];

            var result = await connection.QueryAsync(map, "SELECT * FROM sqlite_master WHERE type = 'table'", args);

            var count = result.Count;

            if (count == 0)
            {
                await connection.EnableWriteAheadLoggingAsync();
            }
            await connection.CreateTableAsync<Device>();
            await connection.CreateTableAsync<Product>();
            await connection.CreateTableAsync<Role>();
            await connection.CreateTableAsync<Sale>();
            await connection.CreateTableAsync<SaleDetail>();
            await connection.CreateTableAsync<Service>();
            await connection.CreateTableAsync<Store>();
            await connection.CreateTableAsync<Work>();
            await connection.CreateTableAsync<User>();
            await connection.CreateTableAsync<Mark>();
            await connection.CreateTableAsync<Model>();
            await connection.CreateTableAsync<TaskLog>();
            await connection.CreateTableAsync<TaskPhotos>();
            await connection.CreateTableAsync<Customer>();

            if (count == 0)
            {
                await InitializeDataAsync(connection);
            }
        }

        private void InitializeData(SQLiteConnection connection)
        {
            connection.InsertAll(new DeviceMock().GetList());
            connection.InsertAll(new ProductMock().GetList());
            connection.InsertAll(new RoleMock().GetList());
            connection.InsertAll(new SaleMock().GetList());
            connection.InsertAll(new SaleDetailMock().GetList());
            connection.InsertAll(new ServiceMock().GetList());
            connection.InsertAll(new StoreMock().GetList());
            connection.InsertAll(new TaskMock().GetList());
            connection.InsertAll(new UserMock().GetList());
            connection.InsertAll(new MarkMock().GetList());
            connection.InsertAll(new ModelMock().GetList());
            connection.InsertAll(new TaskLogMock().GetList());
            connection.InsertAll(new TaskPhotosMock().GetList());
            connection.InsertAll(new CustomerMock().GetList());

        }

        private async Task InitializeDataAsync(SQLiteAsyncConnection connection)
        {
            await connection.InsertAllAsync(new DeviceMock().GetList());
            await connection.InsertAllAsync(new ProductMock().GetList());
            await connection.InsertAllAsync(new RoleMock().GetList());
            await connection.InsertAllAsync(new SaleMock().GetList());
            await connection.InsertAllAsync(new SaleDetailMock().GetList());
            await connection.InsertAllAsync(new ServiceMock().GetList());
            await connection.InsertAllAsync(new StoreMock().GetList());
            await connection.InsertAllAsync(new TaskMock().GetList());
            await connection.InsertAllAsync(new UserMock().GetList());
            await connection.InsertAllAsync(new MarkMock().GetList());
            await connection.InsertAllAsync(new ModelMock().GetList());
            await connection.InsertAllAsync(new TaskLogMock().GetList());
            await connection.InsertAllAsync(new TaskPhotosMock().GetList());
            await connection.InsertAllAsync(new CustomerMock().GetList());
        }
    }
}
