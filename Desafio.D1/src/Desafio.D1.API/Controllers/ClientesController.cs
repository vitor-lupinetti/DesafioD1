using Desafio.D1.Application.AppServices.Interfaces;
using Desafio.D1.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Desafio.D1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteAppService _clienteAppService;
        public ClientesController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }
        // GET: api/<ClientesController>
        [HttpGet]
        public async Task<IEnumerable<ClienteViewModel>> Get()
        {
            return await _clienteAppService.ObterTodos();
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public ClienteViewModel Get(Guid id)
        {
            return null;
        }

        // POST api/<ClientesController>
        [HttpPost]
        public async Task Post([FromBody] ClienteViewModel value)
        {
            await _clienteAppService.Adicionar(value);
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] ClienteViewModel value)
        {
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
