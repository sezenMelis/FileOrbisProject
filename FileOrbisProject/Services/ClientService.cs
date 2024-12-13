using FileOrbisProject.Models;
using MauiApp.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOrbisProject.Services
{
    public class ClientService : IClientService
    {
        public SQLiteAsyncConnection _database;
        public ClientService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Clients>().Wait();
        }


        public async Task<bool> AddUpdateClientAsync(Clients clients)
        {
            if (clients.Id > 0)
            {
                await _database.UpdateAsync(clients);
            }
            else
            {
                await _database.InsertAsync(clients);
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteClientAsync(int id)
        {
            await _database.DeleteAsync<Clients>(id);
            return await Task.FromResult(true);
        }

        public async Task<Clients> GetClientAsync(int id)
        {
            return await _database.Table<Clients>().Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Clients>> GetClientAsync()
        {
            return await Task.FromResult(await _database.Table<Clients>().ToListAsync());
        }
    }
}
