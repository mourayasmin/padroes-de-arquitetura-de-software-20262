namespace atividade02_pas_20261.Domain;

public interface IClienteRepository
{
    Task<Cliente?> ObterPorIdAsync(int id);
    Task AdicionarAsync(Cliente cliente);
    Task SalvarAsync();
}