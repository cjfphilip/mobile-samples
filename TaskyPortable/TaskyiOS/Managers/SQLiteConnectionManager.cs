using System;
using SQLite;
using TaskyPortableLibrary.Contracts;
using System.IO;

namespace Tasky.Managers
{
    class SQLiteConnectionManager: ISQLiteConnectionManager
    {
        SQLiteConnection connection;

        public SQLiteConnection GetSqLiteConnection()
        {
            if (connection == null)
            {
                // Create the database file
                var sqliteFilename = "TodoItemDB.db3";
                // we need to put in /Library/ on iOS5.1 to meet Apple's iCloud terms
                // (they don't want non-user-generated data in Documents)
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
                string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
                var path = Path.Combine(libraryPath, sqliteFilename);
                connection = new SQLiteConnection(path);
            }
            return connection;
        }
    }
}