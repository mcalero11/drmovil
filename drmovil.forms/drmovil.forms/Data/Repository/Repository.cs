﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace drmovil.forms.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : Entities.IEntity, new()
    {
        protected SQLiteConnection connection = null;
        protected SQLiteAsyncConnection connectionAsync = null;

        /// <summary>
        /// Returns an instance of Repository
        /// </summary>
        /// <param name="isAsync">Specify when the connection required is asyc</param>
        public Repository(bool isAsync = false)
        {
            var sqliteService = new SqliteService.SqliteService();
            if (isAsync)
            {
                connectionAsync = sqliteService.GetAsyncConnection();
            }
            else
            {
                connection = sqliteService.GetConnection();
            }


        }


        #region Async Methods
        public Task<bool> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }
        public Task<T> FindByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
        public Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
        public Task<IList<T>> GetFirstAsync(int rows)
        {
            throw new NotImplementedException();
        }

        #endregion
        public bool Add(T entity)
        {
            if (!validateConnection()) return false;

            int rows = connection.Insert(entity);

            return rows > 0;
        }

        

        public bool Delete(T entity)
        {
            if (!validateConnection()) return false;

            int rows = connection.Delete(entity);

            return rows > 0;
        }

        

        public T FindById(int Id) 
        {
            if (!validateConnection()) return null;

            var result = connection.Find<T>(Id);

            return result;
        }

        

        public bool Update(T entity)
        {
            if (!validateConnection()) return false;

            var rows = connection.Update(entity);

            return rows > 0;
        }

        /// <summary>
        /// Returns a list of T, if rows minor than 1 returns all register
        /// </summary>
        /// <param name="rows"></param>
        /// <returns></returns>
        public IList<T> GetFirst(int rows = 0)
        {
            if (!validateConnection()) return null;
            List<T> list = null;
            if (rows<1)
            {
                list = connection.Table<T>().ToList();
            }
            else
            {
                list = connection.Table<T>().Take(rows).ToList();
            }
            
            return list;
        }



        /// <summary>
        /// Returns true when the connection is Successful
        /// </summary>
        /// <returns></returns>
        private bool validateConnection()
        {
            if (connection is null) return false;

            return true;
        }

        /// <summary>
        /// Returns true when the async connection is Successful
        /// </summary>
        /// <returns></returns>
        private bool validateAsyncConnection()
        {
            if (connectionAsync is null) return false;

            return true;
        }


        public void Dispose()
        {
            if (connection != null) this.connection.Dispose();
            if (connectionAsync != null) this.connectionAsync.CloseAsync();
        }
    }
}
