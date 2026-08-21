using atividade02_pas_20261.Domain;
using Microsoft.EntityFrameworkCore;

namespace atividade02_pas_20261.Infra;

public class AgenciaRepository  : IAgenciaRepository
{
    private readonly Database _context;
    public AgenciaRepository(Database context) => _context = context;

    public Task<Agencia?> ObterPorIdAsync(int id) =>
        _context.Agencias.FirstOrDefaultAsync(c => c.Id == id);

    public async Task AdicionarAsync(Agencia agencia) =>
        await _context.Agencias.AddAsync(agencia);

    public Task SalvarAsync() => _context.SaveChangesAsync();
}