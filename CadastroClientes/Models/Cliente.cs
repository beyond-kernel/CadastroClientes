namespace CadastroClientes.Models
{
    public class ClienteDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public byte[]? Logotipo { get; set; } // Para armazenar a imagem em formato binário
        public List<LogradouroDto>? Logradouros { get; set; } // Relacionamento com logradouros
    }

    public class LogradouroDto
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
    }
}
