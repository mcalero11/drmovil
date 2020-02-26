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
    }
}
