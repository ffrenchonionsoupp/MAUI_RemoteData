
namespace Maui_RemoteData.Models
{
    public static class DatabaseConstants
    {
        public const string DatabaseFileName = "People.db3";
        public const SQLite.SQLiteOpenFlags Flags = 
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite 
            // create the database if it doesn't exist
            | SQLite.SQLiteOpenFlags.Create 
            // enable multi-threading
            | SQLite.SQLiteOpenFlags.SharedCache;
        public static string DatabasePath =>
            Path.Combine(AppContext.BaseDirectory, DatabaseFileName);
    }
}
