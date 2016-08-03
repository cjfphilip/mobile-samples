using System;
using SQLite;
using TaskyPortableLibrary.Contracts;
using System.IO;

namespace TaskyAndroid.Managers
{
    class SQLiteConnectionManager: ISQLiteConnectionManager
    {
        SQLiteConnection connection;

        public SQLiteConnection GetSqLiteConnection()
        {
            if (connection == null)
            {
                var sqliteFilename = "TodoItemDB.db3";
                string libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                var path = Path.Combine(libraryPath, sqliteFilename);
                connection = new SQLiteConnection(path);
            }
            return connection;
        }
    }
}