using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetDesk.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDesk.Data.Mapping
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");

            builder.Property(c => c.Id)
                .ValueGeneratedNever();

            builder.Property(c => c.CreatedOn)
                .HasColumnType("datetime2");

            builder.Property(c => c.ChangedOn)
                .HasColumnName("datetime2");

            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(c => c.PhoneNumber)
                .HasColumnType("varchar(13)")
                .IsRequired();

            builder.Property(c => c.Email)
                .HasColumnType("varchar(75)")
                .IsRequired();
        }
    }
}
