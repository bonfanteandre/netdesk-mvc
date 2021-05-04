using NetDesk.Business.Interfaces.UnitOfWork;
using NetDesk.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDesk.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NetDeskContext _context;

        public UnitOfWork(NetDeskContext context)
            => _context = context;

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
