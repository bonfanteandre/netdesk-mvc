using Microsoft.EntityFrameworkCore;
using NetDesk.Business.Entities;
using NetDesk.Business.Interfaces.Repositories;
using NetDesk.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDesk.Data.Repositories
{
    public class ClientsRepository : IClientsRepository
    {
        private readonly NetDeskContext _context;

        public ClientsRepository(NetDeskContext context)
            => _context = context;

        public async Task AddAsync(Client client)
            => await _context.Clients.AddAsync(client);

        public void Update(Client client)
            => _context.Clients.Update(client);

        public void Remove(Client client)
            => _context.Clients.Remove(client);

        public async Task<Client> FindAsync(int id)
            => await _context.Clients.FindAsync(id);

        public async Task<ICollection<Client>> FindPagedAsync(int take, int skip)
            => await _context.Clients
                .OrderBy(c => c.Name)
                .Take(take)
                .Skip(skip)
                .ToListAsync();
    }
}
