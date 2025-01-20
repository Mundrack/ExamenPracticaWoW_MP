using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SQLite;
using PracticaWoW_MP.Models;

namespace PracticaWoW_MP.Services
{
    public class DatabaseService_MP
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService_MP()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "wow_characters.db3");
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Character_MP>().Wait();
        }

        public Task<int> SaveCharacter(Character_MP character)
        {
            return _database.InsertAsync(character);
        }

        public Task<List<Character_MP>> GetSavedCharacters()
        {
            return _database.Table<Character_MP>().ToListAsync();
        }
    }
}