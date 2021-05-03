using AutoMapper;
using NetDesk.App.Models;
using NetDesk.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetDesk.App.Configurations
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<ClientViewModel, Client>()
                .ReverseMap();
        }
    }
}
