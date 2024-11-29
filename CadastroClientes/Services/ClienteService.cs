using CadastroClientes.Models;

namespace CadastroClientes.Services
{
    public class ClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task AddCliente(ClienteDto clienteDto)
        {
            // Validação de dados
            if (string.IsNullOrEmpty(clienteDto.Email))
                throw new ArgumentException("O e-mail é obrigatório.");

            if (await _clienteRepository.ClienteExistePorEmail(clienteDto.Email))
                throw new InvalidOperationException("O e-mail já está em uso.");

            // Mapeamento do DTO para a entidade
            var cliente = new ClienteDto
            {
                Nome = clienteDto.Nome,
                Email = clienteDto.Email,
                Logotipo = clienteDto.Logotipo,
                Logradouros = clienteDto.Logradouros?.Select(l => new LogradouroDto
                {
                    Endereco = l.Endereco
                }).ToList()
            };

            // Chamando o repositório para salvar
            await _clienteRepository.AddCliente(cliente);
        }
    }
}
