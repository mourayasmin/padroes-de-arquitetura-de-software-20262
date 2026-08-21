using atividade02_pas_20261.Domain;
using Microsoft.EntityFrameworkCore;

namespace atividade02_pas_20261.Infra;

public class ContaRepository : IContaRepository
{
    private readonly Database _context;
    public ContaRepository(Database context) => _context = context;

    public Task<Conta?> ObterPorIdAsync(int id) =>
        _context.Contas.FirstOrDefaultAsync(c => c.Id == id);

    public async Task AdicionarAsync(Conta conta) =>
        await _context.Contas.AddAsync(conta);

    public Task SalvarAsync() => _context.SaveChangesAsync();
}