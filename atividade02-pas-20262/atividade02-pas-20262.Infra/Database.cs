using atividade02_pas_20261.Domain;
using Microsoft.EntityFrameworkCore;

namespace atividade02_pas_20261.Infra;

public class Database : DbContext
{
    public Database(DbContextOptions<Database> options) : base(options) { }

    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Agencia> Agencias => Set<Agencia>();
    public DbSet<Conta> Contas => Set<Conta>();
}