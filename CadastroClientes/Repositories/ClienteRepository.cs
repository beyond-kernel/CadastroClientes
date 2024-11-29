using CadastroClientes.Models;
using CadastroClientes.Services;
using System.Data;
using System.Data.SqlClient;

namespace CadastroClientes.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SqlConnection _connection;

        public ClienteRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public async Task AddCliente(ClienteDto cliente)
        {
            var command = new SqlCommand("AddCliente", _connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@Email", cliente.Email);
            command.Parameters.AddWithValue("@Logotipo", cliente.Logotipo ?? (object)DBNull.Value);

            await _connection.OpenAsync();
            await command.ExecuteNonQueryAsync();
            await _connection.CloseAsync();
        }

        public async Task<bool> ClienteExistePorEmail(string email)
        {
            var command = new SqlCommand("SELECT COUNT(1) FROM Clientes WHERE Email = @Email", _connection);
            command.Parameters.AddWithValue("@Email", email);

            await _connection.OpenAsync();
            var exists = (int)await command.ExecuteScalarAsync() > 0;
            await _connection.CloseAsync();

            return exists;
        }
    }
}
