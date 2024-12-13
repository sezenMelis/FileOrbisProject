using FileOrbisProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FileOrbisProject.Services
{
    public interface IClientService
    {
        Task<bool> AddUpdateClientAsync(Clients clients);
        Task<bool> DeleteClientAsync(int id);
        Task<Clients> GetClientAsync(int id);
        Task<IEnumerable<Clients>> GetClientAsync();
    }
}
