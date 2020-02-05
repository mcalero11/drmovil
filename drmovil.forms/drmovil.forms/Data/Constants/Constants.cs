using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace drmovil.forms.Data.Constants
{
    public static partial class Constants
    {
        public const string SqliteFilename = "drmovil.db3";
        public const string BaseURL = "https://localhost";

        public const SQLite.SQLiteOpenFlags FlagsSqlite = SQLite.SQLiteOpenFlags.ReadWrite  |
                                                          SQLite.SQLiteOpenFlags.Create     |
                                                          SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, SqliteFilename);
            }
        }

        public enum ActionSyncEnum
        {
            Create,
            Update,
            Delete
        }

        public enum ApiVersion
        {
            V1 = 1,
        }
    }
}
