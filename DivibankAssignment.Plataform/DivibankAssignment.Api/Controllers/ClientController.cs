using DivibankAssignment.Domain.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DivibankAssignment.Domain.Services.Interfaces;

namespace DivibankAssignment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private readonly IClientService _clientService;

        public ClientController(ILogger<ClientController> logger, IClientService clientService)
        {
            _logger = logger;
            _clientService = clientService;
        }

        [HttpGet("{id}")]
        public async Task<ClientDto> Get(Guid id)
        {
            var rng = new Random();

            var client = await new Task<ClientDto>(() => new ClientDto
            {
                Birthdate = new DateTime(1988, 11, 09),
                Id = Guid.NewGuid(),
                Loans = new List<LoanDto>()
            });

            return client;
        }
    }
}