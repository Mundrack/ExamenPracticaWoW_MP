using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using PracticaWoW_MP.Models;

namespace PracticaWoW_MP.ServicesMP
{
    public class DataBaseService_MP
    {
        private readonly SQLiteAsyncConnection _database;

        public DataBaseService_MP(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Character_MP>().Wait();
        }

        public Task<List<Character_MP>> GetCharactersAsync()
        {
            return _database.Table<Character_MP>().ToListAsync();
        }

        public Task<int> SaveCharacterAsync(Character_MP character)
        {
            return _database.InsertAsync(character);
        }
    }
}