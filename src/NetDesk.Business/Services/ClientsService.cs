using NetDesk.Business.Entities;
using NetDesk.Business.Interfaces.Repositories;
using NetDesk.Business.Interfaces.Services;
using NetDesk.Business.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDesk.Business.Services
{
    public class ClientsService : IClientsService
    {
        private readonly IClientsRepository _clientsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ClientsService(IClientsRepository clientsRepository, IUnitOfWork unitOfWork)
        {
            _clientsRepository = clientsRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Client client)
        {
            await _clientsRepository.AddAsync(client);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Client client)
        {
            _clientsRepository.Update(client);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveAsync(Client client)
        {
            _clientsRepository.Remove(client);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<Client> FindAsync(int id)
            => await _clientsRepository.FindAsync(id);

        public async Task<ICollection<Client>> FindPagedAsync(int take, int skip)
            => await _clientsRepository.FindPagedAsync(take, skip);
    }
}
