using System;
using System.Threading.Tasks;
using SQLite;

namespace EPMobileLibrary.Database
{
    public class DatabaseHelper : IDatabaseHelper
    {
        //database path
        private static string _dbPath;
        public DatabaseHelper()
        {
        }

        //Initial database creation.
        public static void CreateDatabase(string dbPath)
        {
            _dbPath = dbPath;
            using (var connection = new SQLiteConnection(dbPath, SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite))
            {
                connection.CreateTable<User>();

            }
        }
        //Add or update user.
        public async Task AddOrUpdateUserAsync(User user)
        {
            var connection = new SQLiteAsyncConnection(_dbPath);
            if (user.Id == 0)
                await connection.InsertAsync(connection);
        }
    }
}
