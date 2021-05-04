using NetDesk.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDesk.Business.Interfaces.Services
{
    public interface IClientsService
    {
        Task AddAsync(Client client);
        Task UpdateAsync(Client client);
        Task RemoveAsync(Client client);
        Task<Client> FindAsync(int id);
        Task<ICollection<Client>> FindPagedAsync(int take, int skip);
    }
}
