using CadastroClientes.Models;
using CadastroClientes.Services;
using Microsoft.AspNetCore.Mvc;

namespace CadastroClientes.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteService;

        public ClienteController(IClienteRepository clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCliente([FromBody] ClienteDto clienteDto)
        {
            if (!ModelState.IsValid)
                return BadRequest("Dados inválidos.");
          
            await _clienteService.AddCliente(clienteDto);
            return Ok("Cliente cadastrado com sucesso!");
        }
    }
}
