using CadastroClientes.Models;

namespace CadastroClientes.Services
{
    public interface IClienteRepository
    {
        Task AddCliente(ClienteDto cliente);
        Task<bool> ClienteExistePorEmail(string email);
    }
}
