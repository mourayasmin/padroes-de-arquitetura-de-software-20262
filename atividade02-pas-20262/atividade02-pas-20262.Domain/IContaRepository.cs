namespace atividade02_pas_20261.Domain;

public interface IContaRepository
{
    Task<Conta?> ObterPorIdAsync(int id);
    Task AdicionarAsync(Conta conta);
    Task SalvarAsync();
}
