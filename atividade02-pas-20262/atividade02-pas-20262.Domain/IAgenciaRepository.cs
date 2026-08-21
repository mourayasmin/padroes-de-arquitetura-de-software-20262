namespace atividade02_pas_20261.Domain;

public interface IAgenciaRepository
{
    Task<Agencia?> ObterPorIdAsync(int id);
    Task AdicionarAsync(Agencia agencia);
    Task SalvarAsync();
}