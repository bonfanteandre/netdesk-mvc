using NetDesk.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDesk.Business.Interfaces.Repositories
{
    public interface IClientsRepository
    {
        Task AddAsync(Client client);
        void Update(Client client);
        void Remove(Client client);
        Task<Client> FindAsync(int id);
        Task<ICollection<Client>> FindPagedAsync(int take, int skip);
    }
}
