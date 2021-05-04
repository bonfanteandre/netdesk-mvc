using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NetDesk.App.Models;
using NetDesk.Business.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetDesk.App.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientsService _clientsService;
        private readonly IMapper _mapper;

        public ClientsController(IClientsService clientsService, IMapper mapper)
        {
            _clientsService = clientsService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index([FromQuery] int take, [FromQuery] int skip)
        {
            var clients = await _clientsService.FindPagedAsync(take, skip);
            return View(_mapper.Map<ICollection<ClientViewModel>>(clients));
        }
    }
}
