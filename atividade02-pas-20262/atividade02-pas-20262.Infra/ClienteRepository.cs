using atividade02_pas_20261.Domain;
using Microsoft.EntityFrameworkCore;

namespace atividade02_pas_20261.Infra;

public class ClienteRepository : IClienteRepository
{
    private readonly Database _context;
    public ClienteRepository(Database context) => _context = context;

    public Task<Cliente?> ObterPorIdAsync(int id) =>
        _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);

    public async Task AdicionarAsync(Cliente cliente) =>
        await _context.Clientes.AddAsync(cliente);

    public Task SalvarAsync() => _context.SaveChangesAsync();
}