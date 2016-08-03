using SQLite;

namespace TaskyPortableLibrary.Contracts
{
    public interface ISQLiteConnectionManager
    {
        SQLiteConnection GetSqLiteConnection();
    }
}
