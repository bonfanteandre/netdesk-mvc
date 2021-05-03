using Microsoft.EntityFrameworkCore;
using NetDesk.Business.Entities;
using NetDesk.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDesk.Data.Context
{
    public class NetDeskContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public NetDeskContext(DbContextOptions<NetDeskContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientMap());
        }
    }
}
