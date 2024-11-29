using CadastroClientes.Models;

namespace CadastroClientes.Repositories
{
    public interface IClienteRepository
    {
        Task AddCliente(ClienteDto cliente);
        Task<bool> ClienteExistePorEmail(string email);
    }
}
